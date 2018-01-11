Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class MainForm

    Dim configFileLocation As String = Environment.CurrentDirectory & "\OVG.ini"
    '== FPS counter
    Dim fpsTimer As Date
    Dim frames As ULong
    Dim realFPS As Double
    Dim averageFPS As Double
    Dim startTime As DateTime
    Dim channelFlowDirection As FlowDirection = FlowDirection.LeftToRight
    '===For Worker
    Public optionsMap As New Dictionary(Of String, channelOptions)
    Dim canvasSize As New Size(1280, 720)
    Dim bgColor As Color = Color.Black
    Public wavePen As New Pen(Color.White, 2)
    Dim totalFrame As ULong
    Dim masterAudioFile As String = ""
    Dim outputLocation As String = ""
    Dim outputDirectory As String = ""
    Dim NoFileWriting As Boolean = False
    Dim allFilesLoaded As Boolean = False
    Dim failedFiles As New Dictionary(Of String, String)
    '===FFmpeg
    Dim convertVideo As Boolean = False
    Dim canceledByUser As Boolean = False
    Dim FFmpegExitCode As Integer = 0
    Public Const DefaultFFmpegCommandLineJoinAudio As String = "-f image2pipe -r {framerate} -c:v png -i {img} -i {audio} -c:a aac -b:a 384k -c:v libx264 -crf 18 -bf 2 -flags +cgop -pix_fmt yuv420p -movflags faststart {outfile}"
    Public Const DefaultFFmpegCommandLineSilence As String = "-f image2pipe -r {framerate} -c:v png -i {img} -c:v libx264 -crf 18 -bf 2 -flags +cgop -pix_fmt yuv420p -movflags faststart {outfile}"
    Public FFmpegCommandLineJoinAudio As String = DefaultFFmpegCommandLineJoinAudio
    Public FFmpegCommandLineSilence As String = DefaultFFmpegCommandLineSilence
    Public FFmpegstderr As IO.StreamReader
    '===For file operation
    Const FileFilter As String = "WAVE File(*.wav)|*.wav"
    Public currentChannelToBeSet As String = ""
    Dim ffmpegPath As String = ""

    '===GUI..etc.
    Dim formStarted As Boolean = False
    Dim originalFormSize As Size
    Dim originalTextBoxLogHeight As Integer

    Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not formStarted Then
            originalFormSize = Me.Size
            Me.MinimumSize = Me.Size
        End If
        formStarted = True
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If OscilloscopeBackgroundWorker.IsBusy Then
            Dim r As DialogResult = MsgBox("Do you want to stop the worker?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If r = Windows.Forms.DialogResult.Yes Then
                ButtonControl_Click(Nothing, Nothing)
            Else
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        writeConfig()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.UserPaint, True)
        loadConfig()
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
        Dim conf As New OVGconfig
        conf.General.SmoothLine = CheckBoxSmooth.Checked
        conf.General.DrawMiddleLine = CheckBoxDrawMiddleLine.Checked
        conf.General.Framerate = NumericUpDownFrameRate.Value
        conf.General.ConvertVideo = CheckBoxVideo.Checked
        conf.General.CRTStyledRender = CheckBoxCRT.Checked
        conf.General.DrawGrid = CheckBoxGrid.Checked
        conf.General.CanvasSize = ComboBoxCanvasSize.Text
        conf.General.FlowDirection = channelFlowDirection
        conf.FFmpeg.BinaryLocation = ffmpegPath.Trim()
        conf.FFmpeg.JoinAudioCommandLine = FFmpegCommandLineJoinAudio.Trim()
        If FFmpegCommandLineJoinAudio = DefaultFFmpegCommandLineJoinAudio Then conf.FFmpeg.JoinAudioCommandLine = ""
        conf.FFmpeg.SilenceCommandLine = FFmpegCommandLineSilence.Trim()
        If FFmpegCommandLineSilence = DefaultFFmpegCommandLineSilence Then conf.FFmpeg.SilenceCommandLine = ""
        Dim xml As New Xml.Serialization.XmlSerializer(conf.GetType())
        Try
            Dim fs As New IO.FileStream("config.xml", IO.FileMode.Create)
            xml.Serialize(fs, conf)
            fs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub loadConfig()
        If My.Computer.FileSystem.FileExists("config.xml") Then
            Dim conf As New OVGconfig
            Dim xml As New Xml.Serialization.XmlSerializer(conf.GetType())
            Try
                Dim fs As New IO.FileStream("config.xml", IO.FileMode.Open)
                conf = xml.Deserialize(fs)
                fs.Close()
            Catch ex As Exception
                TextBoxLog.AppendText("Error occured while loading config:" & ex.Message & vbCrLf)
                Exit Sub
            End Try
            ffmpegPath = conf.FFmpeg.BinaryLocation
            FFmpegCommandLineJoinAudio = conf.FFmpeg.JoinAudioCommandLine
            If FFmpegCommandLineJoinAudio = "" Then FFmpegCommandLineJoinAudio = DefaultFFmpegCommandLineJoinAudio
            FFmpegCommandLineSilence = conf.FFmpeg.SilenceCommandLine
            If FFmpegCommandLineSilence = "" Then FFmpegCommandLineSilence = DefaultFFmpegCommandLineSilence
            CheckBoxSmooth.Checked = conf.General.SmoothLine
            CheckBoxDrawMiddleLine.Checked = conf.General.DrawMiddleLine
            NumericUpDownFrameRate.Value = conf.General.Framerate
            CheckBoxVideo.Checked = conf.General.ConvertVideo
            CheckBoxCRT.Checked = conf.General.CRTStyledRender
            CheckBoxGrid.Checked = conf.General.DrawGrid
            ComboBoxCanvasSize.Text = conf.General.CanvasSize
            channelFlowDirection = conf.General.FlowDirection
            ButtonFlowDirection.Invalidate()
        End If
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
            arg.drawGrid = CheckBoxGrid.Checked
            arg.useAnalogOscilloscopeStyle = CheckBoxCRT.Checked
            If arg.useAnalogOscilloscopeStyle Then
                arg.analogOscilloscopeLineWidth = NumericUpDownLineWidth.Value
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
            arg.FPS = NumericUpDownFrameRate.Value
            arg.smoothLine = CheckBoxSmooth.Checked
            arg.FPS = NumericUpDownFrameRate.Value
            arg.noFileWriting = CheckBoxNoFileWriting.Checked
            arg.convertVideo = CheckBoxVideo.Checked
            arg.drawMiddleLine = CheckBoxDrawMiddleLine.Checked
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
            LabelStatus.Text = "Start."
            OscilloscopeBackgroundWorker.RunWorkerAsync(arg)
            GroupBoxRenderingOptions.Enabled = False
            GroupBoxFiles.Enabled = False
            ButtonControl.Text = "Cancel"
            ButtonControl.Update()
        Else
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
        OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Start."))
        startTime = Now
        canceledByUser = False
        If Not My.Computer.FileSystem.DirectoryExists(outputDirectory) And Not NoFileWriting And Not convertVideo Then
            My.Computer.FileSystem.CreateDirectory(outputDirectory)
            Debug.WriteLine(outputDirectory)
        End If
        Dim args As WorkerArguments = e.Argument
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
            wave(z).mixChannel = extraArg.mixChannel
            wave(z).selectedChannel = extraArg.selectedChannel
            If wave(z).sampleLength > sampleLength Then sampleLength = wave(z).sampleLength
        Next
        If My.Computer.FileSystem.FileExists(masterAudioFile) Then 'use master audio's sample length
            Try
                Dim master As New WAV(masterAudioFile, True)
                sampleLength = master.sampleLength
                OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Using length of master audio."))
            Catch ex As Exception
                OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Failed to parse master audio."))
            End Try
        End If
        If Not allFilesLoaded Then
            wave = Nothing
            OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Failed to load file(s)."))
            Exit Sub
        End If
        OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("All file loaded."))
        Debug.WriteLine("Done loading waves.")
        fpsTimer = Now
        Debug.WriteLine(sampleLength)
        Dim bitDepth As Integer = wave(0).bitDepth
        Debug.WriteLine(bitDepth)
        Dim channels As Byte = args.files.Length
        Dim sampleRate As Integer = wave(0).sampleRate
        Dim samplesPerFrame As Integer = sampleRate / args.FPS
        Dim maxChannelPerColumn As Integer = Math.Ceiling(channels / col)
        Dim channelWidth As Integer = canvasSize.Width / col
        Dim channelHeight As Integer = canvasSize.Height / maxChannelPerColumn
        Dim channelSize As New Size(channelWidth, channelHeight)
        Dim channelOffset(channels - 1) As Point
        For c As Integer = 0 To channels - 1
            Dim x, y, currentColumn, currentRow As Integer
            If channelFlowDirection = FlowDirection.LeftToRight Then
                currentRow = (c - (c Mod col)) / col
                y = channelHeight * currentRow
                x = channelWidth * (c Mod col)
            ElseIf channelFlowDirection = FlowDirection.TopDown Then
                currentColumn = (c - (c Mod maxChannelPerColumn)) / maxChannelPerColumn
                y = channelHeight * (c Mod maxChannelPerColumn)
                x = channelWidth * currentColumn
            End If
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
            ffmpeg.Arguments = "-y " & FFmpegCommandLineJoinAudio _
                                       .Replace("{img}", "-") _
                                       .Replace("{framerate}", args.FPS) _
                                       .Replace("{audio}", SafeFilename(args.audioFile)) _
                                       .Replace("{outfile}", SafeFilename(args.outputFile))
        Else
            'silence
            ffmpeg.Arguments = "-y " & FFmpegCommandLineSilence.Replace("{img}", "-") _
                                       .Replace("{framerate}", args.FPS) _
                                       .Replace("{outfile}", SafeFilename(args.outputFile))
        End If
        Debug.WriteLine(ffmpeg.FileName & " " & ffmpeg.Arguments)
        Dim ffmpegProc As Process = Nothing
        Dim stderr As IO.StreamReader = Nothing
        Dim stdin As IO.Stream = Nothing
        If convertVideo And Not NoFileWriting Then
            OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Starting FFmpeg."))
            OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Run: " & ffmpeg.FileName & " " & ffmpeg.Arguments))
            ffmpegProc = Process.Start(ffmpeg)
            OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Started FFmpeg."))
            stdin = ffmpegProc.StandardInput.BaseStream
            stderr = ffmpegProc.StandardError
            FFmpegstderr = ffmpegProc.StandardError
        End If




        'start work
        OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Begin rendering."))
        Dim overlayBmp As New Bitmap(canvasSize.Width, canvasSize.Height)
        Dim overlayNeeded As Boolean = False
        For c As Byte = 0 To channels - 1
            Dim g As Graphics = Graphics.FromImage(overlayBmp)
            Dim channelArg As channelOptions = wave(c).extraArguments
            If channelArg.label <> "" Then overlayNeeded = True
            g.DrawString(channelArg.label, channelArg.labelFont, New SolidBrush(channelArg.labelColor), New Rectangle(channelOffset(c), channelSize))
        Next
        While i < sampleLength - 1
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
            If args.smoothLine Then g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            If args.drawMiddleLine Then
                For c As Byte = 0 To channels - 1
                    g.DrawLine(Pens.DarkGray, channelOffset(c).X, channelOffset(c).Y + channelHeight \ 2,
                                              channelOffset(c).X + channelWidth, channelOffset(c).Y + channelHeight \ 2)
                Next
            End If
            For c As Byte = 0 To channels - 1 'for each channel
                Dim channelArg As channelOptions = wave(c).extraArguments
                Dim triggerOffset As Long = 0
                'trigger
                Select Case channelArg.algorithm
                    Case TriggeringAlgorithms.UseZeroCrossing
                        triggerOffset = TriggeringAlgorithms.zeroCrossingTrigger(wave(c), i, sampleRate * channelArg.timeScale * channelArg.maxScan)
                    Case TriggeringAlgorithms.UsePeakSpeedScanning
                        triggerOffset = TriggeringAlgorithms.peakSpeedScanning(wave(c), i, sampleRate * channelArg.timeScale * channelArg.maxScan)
                    Case TriggeringAlgorithms.UsePositiveLengthScanning
                        triggerOffset = TriggeringAlgorithms.lengthScanning(wave(c), i, sampleRate * channelArg.timeScale * channelArg.maxScan, True, False)
                    Case TriggeringAlgorithms.UseNegativeLengthScanning
                        triggerOffset = TriggeringAlgorithms.lengthScanning(wave(c), i, sampleRate * channelArg.timeScale * channelArg.maxScan, False, True)
                    Case TriggeringAlgorithms.UseCrossingLengthScanning
                        triggerOffset = TriggeringAlgorithms.lengthScanning(wave(c), i, sampleRate * channelArg.timeScale * channelArg.maxScan, True, True)
                    Case TriggeringAlgorithms.UseMaxVoltageScanning
                        triggerOffset = TriggeringAlgorithms.maxVoltage(wave(c), i, sampleRate * channelArg.timeScale * channelArg.maxScan)
                    Case TriggeringAlgorithms.UseAutoTrigger
                        triggerOffset = TriggeringAlgorithms.autoTrigger(wave(c), i, sampleRate * channelArg.timeScale * channelArg.maxScan)
                End Select

                'draw
                drawWave(g, wavePen, New Rectangle(channelOffset(c), channelSize), wave(c), args, sampleRate, channelArg.timeScale, i, triggerOffset)
                'g.DrawLine(Pens.Red, cavnasSize.Width \ 2, 0, cavnasSize.Width \ 2, cavnasSize.Height)
                'and also read stderr
            Next

            g.Clip = New Region() 'reset region
            If args.drawGrid Then 'draw grid
                For x As Integer = 1 To col - 1
                    g.DrawLine(Pens.Gray, channelWidth * x, 0, channelWidth * x, canvasSize.Height)
                Next
                For y As Integer = 1 To maxChannelPerColumn - 1
                    g.DrawLine(Pens.Gray, 0, channelHeight * y, canvasSize.Width, channelHeight * y)
                Next
            End If
            If overlayNeeded Then
                g.DrawImage(overlayBmp, 0, 0)
            End If
            i += samplesPerFrame
            If Not NoFileWriting And convertVideo Then
                If ffmpegProc.HasExited Then
                    OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("FFmpeg has exited, terminating render..."))
                    OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("FFmpeg exit code:" & ffmpegProc.ExitCode))
                    Exit Sub
                End If
            End If
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
            OscilloscopeBackgroundWorker.ReportProgress(i, prog)
            If OscilloscopeBackgroundWorker.CancellationPending Then
                OscilloscopeBackgroundWorker.ReportProgress(0, New Progress("Stopping!"))
                If convertVideo And Not NoFileWriting Then
                    ffmpegProc.Kill()
                End If
                If BackgroundWorkerStdErrReader.IsBusy Then
                    BackgroundWorkerStdErrReader.CancelAsync()
                End If
                prog = New Progress(Nothing, 0, 0)
                prog.canceled = True
                OscilloscopeBackgroundWorker.ReportProgress(0, prog)
                canceledByUser = True
                Exit While
            End If
        End While
        wavePen.Color = Color.White 'reset color on end
        If convertVideo And Not NoFileWriting And Not OscilloscopeBackgroundWorker.CancellationPending Then
            stdin.Flush()
            stdin.Close()
            Do Until ffmpegProc.HasExited
            Loop
            stderr.Close()
        End If
    End Sub
    Private Sub drawWave(ByRef g As Graphics, ByRef pen As Pen, ByVal rect As Rectangle, ByRef wave As WAV, ByVal workerArg As WorkerArguments, ByVal sampleRate As Long, ByVal timeScale As Double, ByVal offset As Long, ByVal triggerOffset As Long)
        Dim args As channelOptions = wave.extraArguments
        Dim points As New List(Of Point)
        Dim triggerPoint As Long = offset + triggerOffset
        Dim prevX As Integer = -1
        For i As Integer = triggerPoint - sampleRate * args.timeScale / 2 To triggerPoint + sampleRate * args.timeScale / 2 '+ sampleRate * timeScale
            Dim x As Integer = (i - (offset + triggerOffset - sampleRate * args.timeScale / 2)) / sampleRate / args.timeScale * rect.Width + rect.X
            If prevX = x Then
                Continue For
            Else
                prevX = x
            End If
            Dim y As Integer
            y = (256 - wave.getSample(i, False)) / 256 * (rect.Height - 1) + rect.Y
            If workerArg.useAnalogOscilloscopeStyle Then
                points.Add(New Point(x, y - workerArg.analogOscilloscopeLineWidth \ 2 + workerArg.analogOscilloscopeLineWidth - 1))
                points.Add(New Point(x, y - workerArg.analogOscilloscopeLineWidth \ 2 - 1))
                Dim nextX As Integer = (i + 1 - (offset + triggerOffset - sampleRate * args.timeScale / 2)) / sampleRate / args.timeScale * rect.Width + rect.X
                If nextX - x > 1 And x >= 0 Then
                    For dx As ULong = x To nextX
                        points.Add(New Point(dx, y - workerArg.analogOscilloscopeLineWidth \ 2 + workerArg.analogOscilloscopeLineWidth - 1))
                        points.Add(New Point(dx, y - workerArg.analogOscilloscopeLineWidth \ 2 - 1))
                    Next
                End If
            Else
                points.Add(New Point(x, y))
            End If
        Next
        wavePen.Color = args.waveColor
        g.Clip = New Region(rect)
        g.DrawLines(wavePen, points.ToArray())
    End Sub

    Private Sub OscilloscopeBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles OscilloscopeBackgroundWorker.ProgressChanged
        'taskbarProgress.ProgressState = Windows.Shell.TaskbarItemProgressState.Normal
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
        Dim prog As Progress = e.UserState
        If prog.message <> "" Then TextBoxLog.AppendText(prog.message & vbCrLf)
        If prog.Image IsNot Nothing Then

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
            End If
            Dim timeLeftSecond As ULong = 0
            If averageFPS <> 0 Then
                timeLeftSecond = (prog.TotalFrame - prog.CurrentFrame) / averageFPS
            End If
            Dim timeLeft As New TimeSpan(0, 0, timeLeftSecond)
            LabelStatus.Text = String.Format("{0:P1} {1}/{2}, {3:N1} FPS , Time left: {4}", prog.CurrentFrame / prog.TotalFrame, prog.CurrentFrame, prog.TotalFrame, realFPS, timeLeft.ToString())
            frames += 1
            Dim ms As ULong = Math.Abs((Now - fpsTimer).TotalMilliseconds)
            If ms >= 1000 Then
                fpsTimer = Now
                realFPS = frames * 1000 / ms
                averageFPS = (averageFPS + realFPS) / 2
                frames = 0
            End If
            TaskbarManager.Instance.SetProgressValue(prog.CurrentFrame, prog.TotalFrame)
        ElseIf prog.canceled Then 'canceled
            LabelStatus.Text = "Canceled."
            If prog.message <> "" Then
                TextBoxLog.AppendText(prog.message & vbCrLf)
            End If
        End If

    End Sub

    Private Sub OscilloscopeBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles OscilloscopeBackgroundWorker.RunWorkerCompleted
        Dim elapsedTime As TimeSpan = Now - startTime
        TextBoxLog.AppendText("Total time spent: " & elapsedTime.ToString() & vbCrLf)
        CheckBoxNoFileWriting_CheckedChanged(Nothing, Nothing)
        GroupBoxRenderingOptions.Enabled = True
        GroupBoxFiles.Enabled = True
        LabelStatus.Text = "Finished."
        ButtonControl.Text = "Start"
        ButtonControl.Enabled = True
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
        If Not allFilesLoaded Then
            For Each msg In failedFiles
                TextBoxLog.AppendText("Failed to load " & msg.Key & ":" & msg.Value & vbCrLf)
            Next
            Exit Sub
        End If
        If BackgroundWorkerStdErrReader.IsBusy Then
            BackgroundWorkerStdErrReader.CancelAsync()
        End If
        GC.Collect()
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
            previewLayout()
        End If
    End Sub

    Private Sub ButtonSetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetAll.Click
        If ListBoxFiles.Items.Count <> 0 Then
            currentChannelToBeSet = ""
            ChannelConfigForm.ShowDialog()
            previewLayout()
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
            Dim channelOffset(channels - 1) As Point
            If CheckBoxGrid.Checked Then 'draw grid
                For x As Integer = 1 To col - 1
                    g.DrawLine(Pens.Gray, channelWidth * x, 0, channelWidth * x, canvasSize.Height)
                Next
                For y As Integer = 1 To maxChannelPerColumn - 1
                    g.DrawLine(Pens.Gray, 0, channelHeight * y, canvasSize.Width, channelHeight * y)
                Next
            End If
            For c As Integer = 0 To channels - 1
                Dim currentChannel As channelOptions = optionsMap(ListBoxFiles.Items(c))
                Dim x, y, currentColumn, currentRow As Integer
                If channelFlowDirection = FlowDirection.LeftToRight Then
                    currentRow = (c - (c Mod col)) / col
                    y = channelHeight * currentRow
                    x = channelWidth * (c Mod col)
                ElseIf channelFlowDirection = FlowDirection.TopDown Then
                    currentColumn = (c - (c Mod maxChannelPerColumn)) / maxChannelPerColumn
                    y = channelHeight * (c Mod maxChannelPerColumn)
                    x = channelWidth * currentColumn
                End If
                Dim filename As String = IO.Path.GetFileName(ListBoxFiles.Items(c))
                Dim channelColor As Color = optionsMap(ListBoxFiles.Items(c)).waveColor
                If currentChannel.label <> "" Then
                    g.DrawString(currentChannel.label, currentChannel.labelFont, New SolidBrush(currentChannel.labelColor), New Rectangle(x, y, channelWidth, channelHeight))
                Else
                    g.DrawString(filename, New Font(SystemFonts.MenuFont.FontFamily, 24), New SolidBrush(currentChannel.waveColor), New Rectangle(x, y, channelWidth, channelHeight))
                End If
                If CheckBoxDrawMiddleLine.Checked Then
                    g.DrawLine(Pens.DarkGray, x, y + channelHeight \ 2, x + channelWidth, y + channelHeight \ 2)
                End If
            Next
        End If

        PictureBoxOutput.Image = bmpLayout
    End Sub

    Private Sub NumericUpDownColumn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownColumn.ValueChanged
        'If formStarted Then
        previewLayout()
        'End If
    End Sub

    Private Sub ListBoxFiles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFiles.MouseDoubleClick
        If Not ListBoxFiles.SelectedIndex < 0 Then
            currentChannelToBeSet = ListBoxFiles.SelectedItem
            ChannelConfigForm.ShowDialog()
            previewLayout()
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
        If CustomCommandLineForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            writeConfig()
        End If
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

    Private Sub ButtonFlowDirection_Click(sender As Object, e As EventArgs) Handles ButtonFlowDirection.Click
        If channelFlowDirection = FlowDirection.LeftToRight Then
            channelFlowDirection = FlowDirection.TopDown
        Else
            channelFlowDirection = FlowDirection.LeftToRight
        End If
        ButtonFlowDirection.Invalidate()
        previewLayout()
    End Sub

    Private Sub ButtonFlowDirection_Invalidated(sender As Object, e As InvalidateEventArgs) Handles ButtonFlowDirection.Invalidated
        If channelFlowDirection = FlowDirection.LeftToRight Then
            ButtonFlowDirection.Text = "Left to right"
        Else
            ButtonFlowDirection.Text = "Top to down"
        End If
    End Sub

    Private Sub CheckBoxDrawMiddleLine_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDrawMiddleLine.CheckedChanged
        previewLayout()
    End Sub
End Class
