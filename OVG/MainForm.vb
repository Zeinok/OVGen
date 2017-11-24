Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class MainForm

    'Public timeScale As Double = 0.025
    Dim fpsTimer As Date
    Dim frames As ULong
    Dim realFPS As ULong
    Dim averageFPS As Double
    '===For Worker
    Public optionsMap As New Dictionary(Of String, channelOptions)
    Dim canvasSize As New Size(1280, 720)
    Dim bgColor As Color = Color.Black
    Public wavePen As New Pen(Color.White, 2)
    Dim useAnalogOscilloscopeStyle As Boolean = False
    Dim analogOscilloscopeLineWidth As Integer = 4
    Dim drawGrid As Boolean = False
    Dim frameRate As UInt16 = 60
    Dim totalFrame As ULong
    Dim smoothLine As Boolean = False
    Dim triggerPos As Integer = 0
    Dim masterAudioFile As String = ""
    Dim outputLocation As String = ""
    Dim outputDirectory As String = ""
    Dim NoFileWriting As Boolean = False
    Dim allFilesLoaded As Boolean = False
    Dim failedFiles As New Dictionary(Of String, String)
    '===FFmpeg Worker
    Dim convertVideo As Boolean = False
    Dim canceledByUser As Boolean = False
    Dim FFmpegExitCode As Integer = 0
    Public Const DefaultFFmpegCommandLineJoinAudio As String = "-f image2pipe -r {framerate} -vcodec png -i {img} -i {audio} -acodec aac -vcodec libx264 -crf 18 -bf 2 -flags +cgop -pix_fmt yuv420p -movflags faststart {outfile}"
    Public Const DefaultFFmpegCommandLineSilence As String = "-f image2pipe -r {framerate} -vcodec png -i {img} -vcodec libx264 -crf 18 -bf 2 -flags +cgop -pix_fmt yuv420p -movflags faststart {outfile}"
    Public FFmpegCommandLineJoinAudio As String = DefaultFFmpegCommandLineJoinAudio
    Public FFmpegCommandLineSilence As String = DefaultFFmpegCommandLineSilence
    Dim FFmpegRegex As New System.Text.RegularExpressions.Regex("frame=\s*(.+?)\s+fps=\s*(.+?)\s+")
    Public FFmpegstderr As IO.StreamReader
        '===For file operation
    Const FileFilter As String = "WAVE File(*.wav)|*.wav"
    Public currentChannelToBeSet As String = ""
    Dim ffmpegPath As String = ""

    '===GUI..etc.
    Dim hidpi As New Windows.Shell.TaskbarItemInfo 'causes hidpi support :/
    Dim formStarted As Boolean = False
    Dim thumbnail As Microsoft.WindowsAPICodePack.Taskbar.TabbedThumbnail
    Dim originalFormSize As Size
    Dim originalTextBoxLogHeight As Integer

    Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not formStarted Then
            originalFormSize = Me.Size
            Me.MinimumSize = Me.Size
        End If
        formStarted = True
        thumbnail = New Microsoft.WindowsAPICodePack.Taskbar.TabbedThumbnail(Me.Handle, PictureBoxOutput)
        thumbnail.Title = Me.Text

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If OscilloscopeBackgroundWorker.IsBusy Or FFmpegBackgroundWorker.IsBusy Then
            If OscilloscopeBackgroundWorker.IsBusy Then
                Dim r As DialogResult = MsgBox("Do you want to stop the worker?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If r = Windows.Forms.DialogResult.Yes Then
                    ButtonControl_Click(Nothing, Nothing)
                Else
                    e.Cancel = True
                End If
            Else
                MsgBox("Please wait while encoding the video.", MsgBoxStyle.Critical)
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.UserPaint, True)
        If My.Computer.FileSystem.FileExists("config.ini") Then
            Dim configReader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("config.ini")
            ffmpegPath = configReader.ReadLine()
            FFmpegCommandLineJoinAudio = configReader.ReadLine()
            FFmpegCommandLineSilence = configReader.ReadLine()
            If FFmpegCommandLineJoinAudio = "" Then FFmpegCommandLineJoinAudio = DefaultFFmpegCommandLineJoinAudio
            If FFmpegCommandLineSilence = "" Then FFmpegCommandLineSilence = DefaultFFmpegCommandLineSilence
            configReader.Close()
        End If
        NumericUpDownFrameRate.Value = frameRate
        outputDirectory = IO.Path.GetTempPath() & "OVG-" & randStr(5)
        If Not CheckBoxVideo.Checked Then
            TextBoxOutputLocation.Text = outputDirectory
        End If
        LabelStatus.Text = ""
        CheckBoxNoFileWriting_CheckedChanged(Nothing, Nothing)
        originalTextBoxLogHeight = TextBoxLog.Height
    End Sub

    Function randStr(ByVal len As ULong) As String
        Dim rand As New Random
        Dim map As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        randStr = ""
        For i As Integer = 1 To len
            randStr &= map.Substring(rand.Next(map.Length - 1), 1)
        Next
    End Function

    Function SafeFilename(ByVal filename As String) As String
        SafeFilename = filename
        If filename.Contains(" ") Then SafeFilename = """" & filename & """"
    End Function
    Private Sub writeConfig()
        Dim configWriter As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("config.ini", False)
        configWriter.WriteLine(ffmpegPath)
        configWriter.WriteLine(FFmpegCommandLineJoinAudio)
        configWriter.WriteLine(FFmpegCommandLineSilence)
        configWriter.Close()
    End Sub
    Private Sub ButtonControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonControl.Click


        If Not OscilloscopeBackgroundWorker.IsBusy Then
            TextBoxLog.Clear()
            Dim arg As New WorkerArguments
            'check cavnas size
            Try

                Dim userInput As String() = ComboBoxCanvasSize.Text.Split({"x", " "}, StringSplitOptions.RemoveEmptyEntries)
                If userInput.Length = 2 Then
                    canvasSize = New Size(userInput(0), userInput(1))
                Else
                    MsgBox("Invalid canvas size!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If canvasSize.Width < 1 Or canvasSize.Height < 1 Then
                    MsgBox("Invalid canvas size!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Invalid canvas size!" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try

            arg.outputFile = outputLocation
            outputLocation = TextBoxOutputLocation.Text
            outputDirectory = ""

            If Not TaskbarManager.Instance.TabbedThumbnail.IsThumbnailPreviewAdded(thumbnail) Then
                TaskbarManager.Instance.TabbedThumbnail.AddThumbnailPreview(thumbnail)
            End If
            drawGrid = CheckBoxGrid.Checked
            useAnalogOscilloscopeStyle = CheckBoxCRT.Checked
            If useAnalogOscilloscopeStyle Then
                analogOscilloscopeLineWidth = NumericUpDownLineWidth.Value
                wavePen.Width = 1
            Else
                wavePen.Width = NumericUpDownLineWidth.Value
            End If
            If ListBoxFiles.Items.Count = 0 Then
                MsgBox("Please add at least one file!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            convertVideo = CheckBoxVideo.Checked
            NoFileWriting = CheckBoxNoFileWriting.Checked
            If convertVideo And Not NoFileWriting Then
                Debug.WriteLine(Strings.Right(outputLocation, 4).ToLower)
                If Strings.Right(outputLocation, 4).ToLower <> ".mp4" Then
                    MsgBox("Please set a proper filename!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                Try
                    Using f = New IO.FileStream(outputLocation, IO.FileMode.OpenOrCreate)
                        f.WriteByte(0)
                        f.Flush()
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on creating empty file.")
                    Exit Sub
                End Try
                arg.outputDirectory = IO.Path.GetTempPath() & "OVG_" & randStr(5) & "\"
                outputDirectory = IO.Path.GetTempPath() & "OVG_" & randStr(5) & "\"
                arg.outputFile = outputLocation
                If Not BackgroundWorkerStdErrReader.IsBusy Then
                    BackgroundWorkerStdErrReader.RunWorkerAsync()
                End If
            Else
                arg.outputDirectory = TextBoxOutputLocation.Text
                outputDirectory = outputLocation
            End If
            If outputDirectory = "" And Not NoFileWriting And Not convertVideo Then
                MsgBox("Please select a directory!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Debug.WriteLine(String.Format("Output directory:{0}", outputDirectory))
            frameRate = NumericUpDownFrameRate.Value
            smoothLine = CheckBoxSmooth.Checked
            arg.FPS = NumericUpDownFrameRate.Value
            arg.noFileWriting = CheckBoxNoFileWriting.Checked
            arg.convertVideo = CheckBoxVideo.Checked

            arg.columns = NumericUpDownColumn.Value
            Dim fileArray(ListBoxFiles.Items.Count - 1) As String
            For i As Integer = 0 To fileArray.Length - 1
                fileArray(i) = ListBoxFiles.Items(i)
            Next
            arg.files = fileArray
            If IO.File.Exists(masterAudioFile) Then
                arg.joinAudio = True
                arg.audioFile = masterAudioFile
            Else
                arg.joinAudio = False
            End If
            arg.ffmpegBinary = ffmpegPath

            OscilloscopeBackgroundWorker.RunWorkerAsync(arg)
            GroupBoxOptions.Enabled = False
            ButtonControl.Text = "Cancel"
            ButtonControl.Update()
        Else
            If TaskbarManager.Instance.TabbedThumbnail.IsThumbnailPreviewAdded(thumbnail) Then
                TaskbarManager.Instance.TabbedThumbnail.RemoveThumbnailPreview(thumbnail)
            End If
            OscilloscopeBackgroundWorker.CancelAsync()
            ButtonControl.Text = "Start"
        End If


    End Sub

    Private Sub CheckBoxVideo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxVideo.CheckedChanged
        If CheckBoxVideo.Checked Then
            If Not My.Computer.FileSystem.FileExists(ffmpegPath) Then
                MsgBox("FFmpeg binary is not exist or location not set!, select one.", MsgBoxStyle.Exclamation)
                Dim ofd As New OpenFileDialog
                ofd.Filter = "FFmpeg binary|ffmpeg.exe|All Files|*.*"
                If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ffmpegPath = ofd.FileName
                    writeConfig()
                Else
                    CheckBoxVideo.Checked = False
                    Exit Sub
                End If
            End If
            ButtonAudio.Enabled = True
            LabelOutputLocation.Text = "Output video:"
        Else
            ButtonAudio.Enabled = False
            LabelOutputLocation.Text = "Output folder:"
            masterAudioFile = ""
            ButtonAudio.Text = "Master Audio"
        End If
    End Sub

    Private Sub ButtonAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAudio.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "WAVE File(*.wav)|*.wav"
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            masterAudioFile = ofd.FileName
            ButtonAudio.Text = ofd.SafeFileName
        End If
    End Sub

    Private Sub ButtonSetOutputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetOutputFolder.Click
        If CheckBoxVideo.Checked Then
            Dim sfd As New SaveFileDialog
            sfd.Filter = "MP4 File(*.mp4)|*.mp4"
            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBoxOutputLocation.Text = sfd.FileName
            End If
        Else
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBoxOutputLocation.Text = fbd.SelectedPath
            End If
        End If
    End Sub

    Private Sub OscilloscopeBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles OscilloscopeBackgroundWorker.DoWork
        'MsgBox("Start work")
        canceledByUser = False
        If Not My.Computer.FileSystem.DirectoryExists(outputDirectory) And Not NoFileWriting Then
            My.Computer.FileSystem.CreateDirectory(outputDirectory)
        End If
        Debug.WriteLine(outputDirectory)
        Dim args As WorkerArguments = e.Argument
        Debug.WriteLine("Start.")
        Dim reader(args.files.Length - 1) As IO.StreamReader
        Dim wave(args.files.Length - 1) As WAV
        Dim data As New List(Of Byte())
        Dim col As Byte = args.columns
        Dim sampleLength As UInteger = 0
        allFilesLoaded = True
        failedFiles.Clear()
        For z As Byte = 0 To args.files.Length - 1
            OscilloscopeBackgroundWorker.ReportProgress(0, New Progress(Nothing, 0, 0, "Loading wav file: " & args.files(z)))
            Try
                wave(z) = New WAV(args.files(z))
            Catch ex As Exception
                allFilesLoaded = False
                failedFiles.Add(args.files(z), ex.Message)
                Continue For
            End Try
            Dim extraArg As channelOptions = optionsMap(args.files(z))
            wave(z).extraArguments = extraArg
            wave(z).amplify = extraArg.amplify
            wave(z).timeScale = extraArg.timeScale
            If wave(z).rawSample.Length / wave(z).channels > sampleLength Then sampleLength = wave(z).rawSample.Length / wave(z).channels
        Next
        If Not allFilesLoaded Then
            OscilloscopeBackgroundWorker.ReportProgress(0, New Progress(Nothing, 0, 0, "Failed to load file(s), see log."))
            Exit Sub
        End If
        If My.Computer.FileSystem.FileExists(masterAudioFile) Then 'use master audio's sample length
            Dim master As New WAV(masterAudioFile)
            sampleLength = master.rawSample.Length / master.channels
        End If
        OscilloscopeBackgroundWorker.ReportProgress(0, New Progress(Nothing, 0, 0, "All file loaded."))
        Debug.WriteLine("Done loading waves.")
        fpsTimer = Now
        Debug.WriteLine(sampleLength)
        Dim bitDepth As Integer = wave(0).bitDepth
        If bitDepth = 16 Then sampleLength /= 2
        Debug.WriteLine(bitDepth)
        Dim channels As Byte = args.files.Length
        Dim sampleRate As Integer = wave(0).sampleRate
        Dim samplesPerFrame As Integer = sampleRate / frameRate
        Dim maxChannelPerColumn As Integer = Math.Ceiling(channels / col)
        Dim channelWidth As Integer = canvasSize.Width / col
        Dim channelHeight As Integer = canvasSize.Height / maxChannelPerColumn


        'If bitDepth = 16 Then samplesPerFrame *= 2
        Dim channelSize As New Size(channelWidth, channelHeight)
        Dim channelOffset(channels - 1) As Point
        Dim currentColumn As Integer = 0
        For c As Integer = 0 To channels - 1
            Dim y As Integer = channelHeight * (c Mod maxChannelPerColumn)
            currentColumn = (c - (c Mod maxChannelPerColumn)) / maxChannelPerColumn
            Dim x As Integer = channelWidth * currentColumn
            channelOffset(c) = New Point(x, y)
            Debug.WriteLine(channelOffset(c).ToString())
        Next

        Dim i As Integer = 0
        Dim sampleStep As Byte = 1
        totalFrame = sampleLength \ samplesPerFrame + 1
        'ffmpeg
        Dim ffmpeg As New ProcessStartInfo
        ffmpeg.FileName = args.ffmpegBinary
        ffmpeg.CreateNoWindow = True
        ffmpeg.RedirectStandardInput = True
        ffmpeg.RedirectStandardError = True
        ffmpeg.UseShellExecute = False
        If args.joinAudio Then
            'join audio
            Dim arguments As String = "-y " & FFmpegCommandLineJoinAudio.Replace("{img}", "-").Replace("{framerate}", args.FPS).Replace("{audio}", SafeFilename(args.audioFile)).Replace("{outfile}", SafeFilename(args.outputFile))
            ffmpeg.Arguments = arguments
        Else
            'silence
            Dim arguments As String = "-y " & FFmpegCommandLineSilence.Replace("{img}", "-").Replace("{framerate}", args.FPS).Replace("{outfile}", SafeFilename(args.outputFile))
            ffmpeg.Arguments = arguments
        End If
        Debug.WriteLine(ffmpeg.FileName & " " & ffmpeg.Arguments)
        Dim ffmpegProc As Process = Nothing
        Dim stderr As IO.StreamReader = Nothing
        Dim stdin As IO.BufferedStream = Nothing
        If convertVideo And Not NoFileWriting Then
            ffmpegProc = Process.Start(ffmpeg)
            stdin = New IO.BufferedStream(ffmpegProc.StandardInput.BaseStream, 16384)
            stderr = ffmpegProc.StandardError
            FFmpegstderr = ffmpegProc.StandardError
        End If




        'start work
        While i < sampleLength - 1

            Dim stderrStrBuild As New System.Text.StringBuilder
            Dim bmp As Bitmap = Nothing
            Dim createdBmp As Boolean = False
            Dim bmpCreateCount As Integer = 0
            Do
                Try
                    bmpCreateCount += 1
                    bmp = New Bitmap(canvasSize.Width, canvasSize.Height)

                    createdBmp = True
                Catch ex As Exception
                    createdBmp = False
                End Try
            Loop Until createdBmp Or bmpCreateCount > 3
            If bmpCreateCount > 3 Then Continue While
            Dim g As Graphics = Graphics.FromImage(bmp)
            g.Clear(bgColor)
            If smoothLine Then g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            If drawGrid Then
                For x As Integer = 1 To col - 1
                    g.DrawLine(Pens.Gray, channelWidth * x, 0, channelWidth * x, canvasSize.Height)
                Next
                For y As Integer = 1 To maxChannelPerColumn - 1
                    g.DrawLine(Pens.Gray, 0, channelHeight * y, canvasSize.Width, channelHeight * y)
                Next
            End If
            For c As Byte = 0 To channels - 1 'for each channel
                Dim channelArg As channelOptions = wave(c).extraArguments
                Dim triggerOffset As Long = 0
                'trigger
                Select Case channelArg.algorithm
                    Case TriggeringAlgorithms.UseZeroCrossing
                        triggerOffset = TriggeringAlgorithms.zeroCrossingTrigger(wave(c), i, sampleRate / 50)
                    Case TriggeringAlgorithms.UsePeakSpeedScanning
                        triggerOffset = TriggeringAlgorithms.peakSpeedScanning(wave(c), i, sampleRate / 25)
                End Select

                'draw
                drawWave(g, wavePen, New Rectangle(channelOffset(c), channelSize), wave(c), sampleRate, channelArg.timeScale, i, triggerOffset)
                'g.DrawLine(Pens.Red, cavnasSize.Width \ 2, 0, cavnasSize.Width \ 2, cavnasSize.Height)

                'and also read stderr
                If convertVideo And Not NoFileWriting Then
                    'stderrStrBuild.AppendLine(stderr.ReadLine())
                End If
            Next


            i += samplesPerFrame
            Dim ok As Boolean = False
            Dim saveRetries As Integer = 0
            Do
                If NoFileWriting Then Exit Do
                Try
                    saveRetries += 1
                    If convertVideo Then
                        bmp.Save(stdin, Imaging.ImageFormat.Png)
                    Else
                        bmp.Clone().Save(outputDirectory & "\" & i \ samplesPerFrame & ".png", Imaging.ImageFormat.Png)
                    End If
                    ok = True
                Catch ex As InvalidOperationException
                    ok = False
                End Try
            Loop Until ok = True Or saveRetries > 10
            Dim prog As New Progress(bmp, i \ samplesPerFrame, totalFrame)
            prog.message = stderrStrBuild.ToString()
            OscilloscopeBackgroundWorker.ReportProgress(i, prog)
            If OscilloscopeBackgroundWorker.CancellationPending Then
                If convertVideo And Not NoFileWriting Then ffmpegProc.Kill()
                prog = New Progress(Nothing, 0, 0)
                prog.canceled = True
                OscilloscopeBackgroundWorker.ReportProgress(0, prog)
                canceledByUser = True
                Exit While
            End If
        End While
        If convertVideo And Not NoFileWriting Then
            stdin.Close()
            Do Until ffmpegProc.HasExited
            Loop
            stderr.Close()
        End If
    End Sub
    Private Sub drawWave(ByRef g As Graphics, ByRef pen As Pen, ByVal rect As Rectangle, ByRef wave As WAV, ByVal sampleRate As Long, ByVal timeScale As Double, ByVal offset As Long, ByVal triggerOffset As Long)
        Dim args As channelOptions = wave.extraArguments
        Dim points As New List(Of Point)
        Dim triggerPoint As Long = offset + triggerOffset
        For i As Integer = triggerPoint - sampleRate * args.timeScale / 2 To triggerPoint + sampleRate * args.timeScale / 2 '+ sampleRate * timeScale
            Dim x As Integer = (i - (offset + triggerOffset - sampleRate * args.timeScale / 2)) / sampleRate / args.timeScale * rect.Width + rect.X
            Dim y As Integer
            y = (258 - wave.getSample(i, False)) / 256 * rect.Height + rect.Y
            points.Add(New Point(x, y))
            If useAnalogOscilloscopeStyle Then
                points.Add(New Point(x, y + analogOscilloscopeLineWidth))
                Dim nextX As Integer = (i + 1 - (offset + triggerOffset - sampleRate * args.timeScale / 2)) / sampleRate / args.timeScale * rect.Width + rect.X
                'Dim nextY As Integer
                'nextY = (258 - wave.getSample(i + 1, False)) / 260 * rect.Height + rect.Y
                'Dim m As Double = (nextY - y) / (nextX - x)
                If nextX - x > 1 And x >= 0 Then
                    For dx As ULong = x To nextX
                        'Dim drawY As Integer = (dx - x) * m + y
                        'drawY = Math.Ceiling(drawY)
                        points.Add(New Point(dx, y + analogOscilloscopeLineWidth))
                        points.Add(New Point(dx, y))
                    Next
                End If
            End If
        Next
        wavePen.Color = args.waveColor
        g.DrawLines(wavePen, points.ToArray())
    End Sub

    Private Sub OscilloscopeBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles OscilloscopeBackgroundWorker.ProgressChanged
        'taskbarProgress.ProgressState = Windows.Shell.TaskbarItemProgressState.Normal
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
        Dim prog As Progress = e.UserState
        If prog.Image IsNot Nothing Then
            If prog.message <> "" Then TextBoxLog.AppendText(prog.message & vbCrLf)
            Dim ok As Boolean = False
            If CheckBoxShowOutput.Checked Then
                Do
                    Try
                        PictureBoxOutput.Image = prog.Image.Clone()
                        ok = True
                    Catch ex As InvalidOperationException
                        ok = False
                    End Try
                Loop Until ok = True
                thumbnail.InvalidatePreview()
            End If
            Dim timeLeftSecond As ULong = 0
            If averageFPS <> 0 Then
                timeLeftSecond = (prog.TotalFrame - prog.CurrentFrame) / averageFPS
            End If
            Dim timeLeft As New TimeSpan(0, 0, timeLeftSecond)
            LabelStatus.Text = String.Format("{0}% {1}/{2}, {3} FPS , Time left: {4}", Math.Ceiling(prog.CurrentFrame / prog.TotalFrame * 100), prog.CurrentFrame, prog.TotalFrame, realFPS, timeLeft.ToString())
            frames += 1
            'realFPS = frames
            'Debug.WriteLine((TimeOfDay - fpsTimer).TotalMilliseconds)
            If Math.Abs((TimeOfDay - fpsTimer).TotalMilliseconds) >= 1000 Then
                fpsTimer = TimeOfDay
                realFPS = frames
                averageFPS = (averageFPS + realFPS) / 2
                frames = 0
            End If
            TaskbarManager.Instance.TabbedThumbnail.InvalidateThumbnails()
            TaskbarManager.Instance.SetProgressValue(prog.CurrentFrame, prog.TotalFrame)
        ElseIf prog.canceled Then 'canceled
            LabelStatus.Text = "Canceled."
            If prog.message <> "" Then
                LabelStatus.Text = prog.message
            End If
        End If

    End Sub

    Private Sub OscilloscopeBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles OscilloscopeBackgroundWorker.RunWorkerCompleted
        CheckBoxNoFileWriting_CheckedChanged(Nothing, Nothing)
        If TaskbarManager.Instance.TabbedThumbnail.IsThumbnailPreviewAdded(thumbnail) Then
            TaskbarManager.Instance.TabbedThumbnail.RemoveThumbnailPreview(thumbnail)
        End If
        GroupBoxOptions.Enabled = True
        LabelStatus.Text = "Finished."
        ButtonControl.Text = "Start"
        ButtonControl.Enabled = True
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
        If Not allFilesLoaded Then
            For Each msg In failedFiles
                TextBoxLog.AppendText("Failed to load " & msg.Key & ":" & msg.Value)
            Next
            Exit Sub
        End If
        'If CheckBoxVideo.Checked And Not canceledByUser And Not NoFileWriting Then
        '    ButtonControl.Enabled = False
        '    TextBoxLog.Visible = True
        '    TextBoxLog.Clear()
        '    Dim ffmpegarg As New FFmpegWorkerArguments
        '    If My.Computer.FileSystem.FileExists(masterAudioFile) Then
        '        ffmpegarg.joinAudio = True
        '        ffmpegarg.audioFile = masterAudioFile
        '    Else
        '        ffmpegarg.joinAudio = False
        '    End If
        '    ffmpegarg.ffmpegBinary = ffmpegPath
        '    ffmpegarg.directory = outputDirectory
        '    ffmpegarg.outputFile = outputLocation
        '    ffmpegarg.FPS = frameRate
        '    FFmpegBackgroundWorker.RunWorkerAsync(ffmpegarg)
        'End If
        'If CheckBoxVideo.Checked And canceledByUser And Not NoFileWriting Then
        '    Dim result As MsgBoxResult = MsgBox("Do you want to delete frames generated by program?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        '    If result = MsgBoxResult.Yes Then
        '        TextBoxLog.Visible = True
        '        TextBoxLog.Clear()
        '        deleteFiles()
        '    End If
        'End If

    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = FileFilter
        ofd.Multiselect = True
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each file In ofd.FileNames
                If ListBoxFiles.Items.Contains(file) Then
                    MsgBox(file & " already exists in the list!", MsgBoxStyle.Exclamation)
                    Continue For
                End If
                ListBoxFiles.Items.Add(file)
                optionsMap.Add(file, New channelOptions)
            Next
        End If
        previewLayout()
    End Sub

    Private Sub ButtonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click
        Dim index As Integer = ListBoxFiles.SelectedIndex
        If Not ListBoxFiles.SelectedIndex < 0 Then
            optionsMap.Remove(ListBoxFiles.SelectedItem)
            ListBoxFiles.Items.RemoveAt(ListBoxFiles.SelectedIndex)
            If index > ListBoxFiles.Items.Count - 1 Then index -= 1
            ListBoxFiles.SelectedIndex = index
        End If
        previewLayout()
    End Sub

    Private Sub ButtonMoveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMoveUp.Click

        If ListBoxFiles.SelectedIndex > 0 Then
            ListBoxFiles.Items.Insert(ListBoxFiles.SelectedIndex - 1, ListBoxFiles.SelectedItem)
            ListBoxFiles.SelectedIndex = ListBoxFiles.SelectedIndex - 2
            ListBoxFiles.Items.RemoveAt(ListBoxFiles.SelectedIndex + 2)
        End If
        previewLayout()
    End Sub

    Private Sub ButtonMoveDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMoveDown.Click
        If ListBoxFiles.SelectedIndex < ListBoxFiles.Items.Count - 1 Then
            ListBoxFiles.Items.Insert(ListBoxFiles.SelectedIndex + 2, ListBoxFiles.SelectedItem)
            ListBoxFiles.SelectedIndex = ListBoxFiles.SelectedIndex + 2
            ListBoxFiles.Items.RemoveAt(ListBoxFiles.SelectedIndex - 2)
        End If
        previewLayout()
    End Sub

    Private Sub ButtonOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOptions.Click
        If Not ListBoxFiles.SelectedIndex < 0 Then
            currentChannelToBeSet = ListBoxFiles.SelectedItem
            ChannelConfigForm.ShowDialog()
        End If
    End Sub

    Private Sub ButtonSetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetAll.Click
        If ListBoxFiles.Items.Count <> 0 Then
            currentChannelToBeSet = ""
            ChannelConfigForm.ShowDialog()
        End If
    End Sub

    Sub previewLayout()

        Dim bmpLayout As New Bitmap(canvasSize.Width, canvasSize.Height)
        Dim g As Graphics = Graphics.FromImage(bmpLayout)
        g.Clear(bgColor)
        If ListBoxFiles.Items.Count <> 0 Then
            Dim col As Byte = NumericUpDownColumn.Value
            Dim channels As UInteger = ListBoxFiles.Items.Count
            Dim maxChannelPerColumn As Integer = Math.Ceiling(channels / col)
            Dim channelWidth As Integer = canvasSize.Width / col
            Dim channelHeight As Integer = canvasSize.Height / maxChannelPerColumn
            'If bitDepth = 16 Then samplesPerFrame *= 2
            Dim channelOffset(channels - 1) As Point
            Dim currentColumn As Integer = 0
            If CheckBoxGrid.Checked Then 'draw grid
                For x As Integer = 1 To col - 1
                    g.DrawLine(Pens.Gray, channelWidth * x, 0, channelWidth * x, canvasSize.Height)
                Next
                For y As Integer = 1 To maxChannelPerColumn - 1
                    g.DrawLine(Pens.Gray, 0, channelHeight * y, canvasSize.Width, channelHeight * y)
                Next
            End If
            For c As Integer = 0 To channels - 1
                Dim y As Integer = channelHeight * (c Mod maxChannelPerColumn)
                currentColumn = (c - (c Mod maxChannelPerColumn)) / maxChannelPerColumn
                Dim x As Integer = channelWidth * currentColumn
                Dim filename As String = IO.Path.GetFileName(ListBoxFiles.Items(c))
                Dim channelColor As Color = optionsMap(ListBoxFiles.Items(c)).waveColor
                g.DrawString(filename, New Font(SystemFonts.MenuFont.FontFamily, 24), New SolidBrush(channelColor), x, y)
            Next
        End If

        PictureBoxOutput.Image = bmpLayout
    End Sub

    Private Sub NumericUpDownColumn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownColumn.ValueChanged
        'If formStarted Then
        previewLayout()
        'End If
    End Sub

    'Private Sub FFmpegBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles FFmpegBackgroundWorker.DoWork
    '    Dim args As FFmpegWorkerArguments = e.Argument
    '    Dim ffmpeg As New ProcessStartInfo
    '    ffmpeg.WorkingDirectory = args.directory
    '    ffmpeg.FileName = args.ffmpegBinary
    '    'ffmpeg.WindowStyle = ProcessWindowStyle.Hidden
    '    ffmpeg.CreateNoWindow = True
    '    'ffmpeg.RedirectStandardOutput = True
    '    ffmpeg.RedirectStandardError = True
    '    ffmpeg.UseShellExecute = False
    '    If args.joinAudio Then
    '        'join audio
    '        Dim arguments As String = "-y " & FFmpegCommandLineJoinAudio.Replace("{img}", "%d.png").Replace("{framerate}", args.FPS).Replace("{audio}", args.audioFile).Replace("{outfile}", args.outputFile)
    '        ffmpeg.Arguments = arguments
    '        'ffmpeg.Arguments = String.Format("-y -framerate {0} -i %d.png -i ""{1}"" -preset {2} ""{3}""", args.FPS, args.audioFile, FFmpegEncodingPreset, args.outputFile)
    '    Else
    '        'silence
    '        Dim arguments As String = "-y " & FFmpegCommandLineSilence.Replace("{img}", "%d.png").Replace("{framerate}", args.FPS).Replace("{outfile}", args.outputFile)
    '        ffmpeg.Arguments = arguments
    '        'ffmpeg.Arguments = String.Format("-y -framerate {0} -i %d.png -preset {1} ""{2}""", args.FPS, FFmpegEncodingPreset, args.outputFile)
    '    End If
    '    Debug.WriteLine(ffmpeg.FileName & " " & ffmpeg.Arguments)
    '    Dim prevprog As New FFmpegProgress
    '    prevprog.stderr = "Run command:" & ffmpeg.FileName & " " & ffmpeg.Arguments
    '    FFmpegBackgroundWorker.ReportProgress(0, prevprog)
    '    Dim ffmpegProc As Process
    '    If Not CheckBoxNoFileWriting.Checked Then
    '        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
    '        Dim regex As New System.Text.RegularExpressions.Regex("frame=\s*(.+?)\s+fps=\s*(.+?)\s+")
    '        ffmpegProc = Process.Start(ffmpeg)
    '        Dim stderr As IO.StreamReader = ffmpegProc.StandardError
    '        Dim lastProg As New FFmpegProgress
    '        While Not ffmpegProc.HasExited
    '            Dim errline As String
    '            If Not stderr.EndOfStream Then
    '                Try
    '                    errline = stderr.ReadLine()
    '                Catch ex As Exception
    '                    Application.DoEvents()
    '                    Continue While
    '                End Try
    '                If regex.IsMatch(errline) Then
    '                    Dim match As System.Text.RegularExpressions.Match = regex.Match(errline)
    '                    Dim prog As New FFmpegProgress
    '                    prog.stderr = errline
    '                    prog.frame = match.Groups(1).Value
    '                    prog.FPS = match.Groups(2).Value
    '                    FFmpegBackgroundWorker.ReportProgress(Val(prog.frame), prog)
    '                    lastProg = prog
    '                Else
    '                    Dim prog As FFmpegProgress = lastProg
    '                    prog.stderr = errline
    '                    FFmpegBackgroundWorker.ReportProgress(Val(prog.frame), prog)
    '                End If
    '            End If
    '        End While
    '        FFmpegExitCode = ffmpegProc.ExitCode
    '    End If
    '    Dim retries As Integer = 0
    '    Dim ok As Boolean = False


    'End Sub

    'Private Sub FFmpegBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles FFmpegBackgroundWorker.ProgressChanged
    '    Dim prog As FFmpegProgress = e.UserState
    '    Dim FPS As ULong = Val(prog.FPS)
    '    Dim frame As ULong = Val(prog.frame)
    '    TaskbarManager.Instance.SetProgressValue(e.ProgressPercentage, totalFrame)
    '    TextBoxLog.AppendText(prog.stderr & vbCrLf)
    '    Dim timeLeft As String = "?"
    '    If FPS <> 0 Then
    '        timeLeft = New TimeSpan(0, 0, (totalFrame - frame) / FPS).ToString()
    '    End If
    '    LabelStatus.Text = String.Format("{0}% {1}/{2}, {3} FPS, Time left: {4}", Math.Round(prog.frame / totalFrame * 100, 1), frame, totalFrame, FPS, timeLeft)
    '    'LabelStatus.Text = Val(prog.frame) & "/" & totalFrame & " fps=" & Val(prog.FPS)
    'End Sub

    'Private Sub FFmpegBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles FFmpegBackgroundWorker.RunWorkerCompleted
    '    If convertVideo Then
    '        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
    '        If FFmpegExitCode <> 0 Then
    '            Dim retryResult As MsgBoxResult = MsgBox(String.Format("FFmpeg returned exit code {0}." & vbCrLf & "Do you wan to retry?", FFmpegExitCode), MsgBoxStyle.RetryCancel)
    '            If retryResult = MsgBoxResult.Retry Then
    '                Dim newLocationResult As MsgBoxResult = MsgBox("Do you want to specify new file location?", MsgBoxStyle.YesNo)
    '                If newLocationResult = MsgBoxResult.Yes Then
    '                    Dim sfd As New SaveFileDialog
    '                    sfd.Filter = "MP4 File(*.mp4)|*.mp4"
    '                    If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                        TextBoxOutputLocation.Text = outputLocation
    '                        outputLocation = sfd.FileName
    '                    End If
    '                End If
    '                FFmpegBackgroundWorker.RunWorkerAsync()
    '                Exit Sub 'don't delete files
    '            End If
    '        End If
    '        deleteFiles()
    '        TextBoxLog.AppendText("Finished.")
    '        LabelStatus.Text = "Finished."
    '        ButtonControl.Text = "Start"
    '        ButtonControl.Enabled = True

    '    End If
    'End Sub
    'Sub deleteFiles()
    '    Dim ok As Boolean = False
    '    Dim retries As Integer = 0
    '    Do
    '        Try
    '            TextBoxLog.AppendText("Deleting temporary files Attempt " & retries & "," & outputDirectory & vbCrLf)
    '            My.Computer.FileSystem.DeleteDirectory(outputDirectory, FileIO.DeleteDirectoryOption.DeleteAllContents)
    '            ok = True
    '        Catch ex As Exception
    '            retries += 1
    '            ok = False
    '        End Try
    '    Loop Until ok Or retries > 5
    'End Sub
    Private Sub ListBoxFiles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFiles.MouseDoubleClick
        If Not ListBoxFiles.SelectedIndex < 0 Then
            currentChannelToBeSet = ListBoxFiles.SelectedItem
            ChannelConfigForm.ShowDialog()
        End If
    End Sub

    Private Sub CheckBoxNoFileWriting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxNoFileWriting.CheckedChanged
        If CheckBoxNoFileWriting.Checked Then
            LabelPreviewMode.Visible = True
        Else
            LabelPreviewMode.Visible = False
        End If
        TimerLabelFlashing.Enabled = CheckBoxNoFileWriting.Checked
    End Sub

    Private Sub TimerLabelFlashing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLabelFlashing.Tick
        If OscilloscopeBackgroundWorker.IsBusy Then
            If CheckBoxNoFileWriting.Checked Then
                LabelPreviewMode.Visible = Not LabelPreviewMode.Visible
            Else
                LabelPreviewMode.Visible = False
            End If
        End If
    End Sub

    Private Sub ToolStripStatusLabelAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabelAbout.Click
        'Process.Start("https://zeinok.blogspot.tw")

    End Sub

    Private Sub ToolStripStatusLabelAbout_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripStatusLabelAbout.MouseDown
        ToolStripStatusLabelAbout.BorderStyle = Border3DStyle.SunkenOuter
    End Sub

    Private Sub ToolStripStatusLabelAbout_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabelAbout.MouseLeave
        ToolStripStatusLabelAbout.BorderStyle = Border3DStyle.RaisedOuter
    End Sub

    Private Sub ToolStripStatusLabelAbout_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripStatusLabelAbout.MouseUp
        ToolStripStatusLabelAbout.BorderStyle = Border3DStyle.RaisedOuter
        AboutForm.ShowDialog()
    End Sub

    Private Sub LinkLabelCustomCommandLine_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelCustomCommandLine.LinkClicked
        CustomCommandLineForm.ShowDialog()
    End Sub

    Private Sub CheckBoxGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxGrid.CheckedChanged
        previewLayout()
    End Sub

    Private Sub BackgroundWorkerStdErrReader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerStdErrReader.DoWork
        While convertVideo And Not NoFileWriting And Not BackgroundWorkerStdErrReader.CancellationPending
            If FFmpegstderr IsNot Nothing Then
                If FFmpegstderr.BaseStream IsNot Nothing Then
                    If FFmpegstderr.BaseStream.CanRead Then
                        BackgroundWorkerStdErrReader.ReportProgress(0, FFmpegstderr.ReadLine())
                    End If
                End If
            End If
        End While
    End Sub

    Private Sub BackgroundWorkerStdErrReader_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorkerStdErrReader.ProgressChanged
        Dim stderr As String = e.UserState
        If stderr <> "" Then
            TextBoxLog.AppendText(stderr & vbCrLf)
        End If
    End Sub

    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If formStarted Then
            Me.Size = New Size(originalFormSize.Width, Me.Height)
            TextBoxLog.Size = New Size(TextBoxLog.Width, Me.Height - originalFormSize.Height + originalTextBoxLogHeight)
        End If

    End Sub

End Class
