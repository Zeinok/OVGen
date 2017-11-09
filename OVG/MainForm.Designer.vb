<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.OscilloscopeBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ButtonSetOutputFolder = New System.Windows.Forms.Button()
        Me.LabelOutputLocation = New System.Windows.Forms.Label()
        Me.TextBoxOutputLocation = New System.Windows.Forms.TextBox()
        Me.ButtonControl = New System.Windows.Forms.Button()
        Me.CheckBoxShowOutput = New System.Windows.Forms.CheckBox()
        Me.GroupBoxOptions = New System.Windows.Forms.GroupBox()
        Me.CheckBoxGrid = New System.Windows.Forms.CheckBox()
        Me.LabelCanvasSize = New System.Windows.Forms.Label()
        Me.ComboBoxCanvasSize = New System.Windows.Forms.ComboBox()
        Me.ButtonSetAll = New System.Windows.Forms.Button()
        Me.CheckBoxCRT = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownLineWidth = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxNoFileWriting = New System.Windows.Forms.CheckBox()
        Me.LabelLineWidth = New System.Windows.Forms.Label()
        Me.ListBoxFiles = New System.Windows.Forms.ListBox()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonMoveDown = New System.Windows.Forms.Button()
        Me.ButtonMoveUp = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.NumericUpDownColumn = New System.Windows.Forms.NumericUpDown()
        Me.LabelColumn = New System.Windows.Forms.Label()
        Me.CheckBoxSmooth = New System.Windows.Forms.CheckBox()
        Me.ButtonAudio = New System.Windows.Forms.Button()
        Me.CheckBoxVideo = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownFrameRate = New System.Windows.Forms.NumericUpDown()
        Me.LabelFrameRate = New System.Windows.Forms.Label()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBoxOutput = New System.Windows.Forms.PictureBox()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.FFmpegBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelPadding = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelAbout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelPreviewMode = New System.Windows.Forms.Label()
        Me.TimerLabelFlashing = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBoxFFmpegEncodingPreset = New System.Windows.Forms.ComboBox()
        Me.GroupBoxOptions.SuspendLayout()
        CType(Me.NumericUpDownLineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFrameRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OscilloscopeBackgroundWorker
        '
        Me.OscilloscopeBackgroundWorker.WorkerReportsProgress = True
        Me.OscilloscopeBackgroundWorker.WorkerSupportsCancellation = True
        '
        'ButtonSetOutputFolder
        '
        Me.ButtonSetOutputFolder.Location = New System.Drawing.Point(788, 18)
        Me.ButtonSetOutputFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSetOutputFolder.Name = "ButtonSetOutputFolder"
        Me.ButtonSetOutputFolder.Size = New System.Drawing.Size(31, 29)
        Me.ButtonSetOutputFolder.TabIndex = 2
        Me.ButtonSetOutputFolder.Text = "..."
        Me.ToolTips.SetToolTip(Me.ButtonSetOutputFolder, "Browse...")
        Me.ButtonSetOutputFolder.UseVisualStyleBackColor = True
        '
        'LabelOutputLocation
        '
        Me.LabelOutputLocation.AutoSize = True
        Me.LabelOutputLocation.Location = New System.Drawing.Point(15, 22)
        Me.LabelOutputLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelOutputLocation.Name = "LabelOutputLocation"
        Me.LabelOutputLocation.Size = New System.Drawing.Size(88, 15)
        Me.LabelOutputLocation.TabIndex = 0
        Me.LabelOutputLocation.Text = "Output folder:"
        '
        'TextBoxOutputLocation
        '
        Me.TextBoxOutputLocation.Location = New System.Drawing.Point(105, 18)
        Me.TextBoxOutputLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxOutputLocation.Name = "TextBoxOutputLocation"
        Me.TextBoxOutputLocation.Size = New System.Drawing.Size(674, 25)
        Me.TextBoxOutputLocation.TabIndex = 1
        '
        'ButtonControl
        '
        Me.ButtonControl.Location = New System.Drawing.Point(724, 52)
        Me.ButtonControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonControl.Name = "ButtonControl"
        Me.ButtonControl.Size = New System.Drawing.Size(94, 29)
        Me.ButtonControl.TabIndex = 3
        Me.ButtonControl.Text = "Start"
        Me.ToolTips.SetToolTip(Me.ButtonControl, "Start drawing.")
        Me.ButtonControl.UseVisualStyleBackColor = True
        '
        'CheckBoxShowOutput
        '
        Me.CheckBoxShowOutput.AutoSize = True
        Me.CheckBoxShowOutput.Checked = True
        Me.CheckBoxShowOutput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxShowOutput.Location = New System.Drawing.Point(6, 49)
        Me.CheckBoxShowOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxShowOutput.Name = "CheckBoxShowOutput"
        Me.CheckBoxShowOutput.Size = New System.Drawing.Size(101, 19)
        Me.CheckBoxShowOutput.TabIndex = 1
        Me.CheckBoxShowOutput.Text = "Show output"
        Me.ToolTips.SetToolTip(Me.CheckBoxShowOutput, "Uncheck this if you are worried about speed dropping.")
        Me.CheckBoxShowOutput.UseVisualStyleBackColor = True
        '
        'GroupBoxOptions
        '
        Me.GroupBoxOptions.Controls.Add(Me.ComboBoxFFmpegEncodingPreset)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxGrid)
        Me.GroupBoxOptions.Controls.Add(Me.LabelCanvasSize)
        Me.GroupBoxOptions.Controls.Add(Me.ComboBoxCanvasSize)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonSetAll)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxCRT)
        Me.GroupBoxOptions.Controls.Add(Me.NumericUpDownLineWidth)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxNoFileWriting)
        Me.GroupBoxOptions.Controls.Add(Me.LabelLineWidth)
        Me.GroupBoxOptions.Controls.Add(Me.ListBoxFiles)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonOptions)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonMoveDown)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonMoveUp)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonRemove)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxOptions.Controls.Add(Me.NumericUpDownColumn)
        Me.GroupBoxOptions.Controls.Add(Me.LabelColumn)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxSmooth)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonAudio)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxVideo)
        Me.GroupBoxOptions.Controls.Add(Me.NumericUpDownFrameRate)
        Me.GroupBoxOptions.Controls.Add(Me.LabelFrameRate)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxShowOutput)
        Me.GroupBoxOptions.Location = New System.Drawing.Point(824, 9)
        Me.GroupBoxOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxOptions.Name = "GroupBoxOptions"
        Me.GroupBoxOptions.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxOptions.Size = New System.Drawing.Size(254, 530)
        Me.GroupBoxOptions.TabIndex = 5
        Me.GroupBoxOptions.TabStop = False
        Me.GroupBoxOptions.Text = "Options"
        '
        'CheckBoxGrid
        '
        Me.CheckBoxGrid.AutoSize = True
        Me.CheckBoxGrid.Location = New System.Drawing.Point(172, 219)
        Me.CheckBoxGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxGrid.Name = "CheckBoxGrid"
        Me.CheckBoxGrid.Size = New System.Drawing.Size(55, 19)
        Me.CheckBoxGrid.TabIndex = 12
        Me.CheckBoxGrid.Text = "Grid"
        Me.CheckBoxGrid.UseVisualStyleBackColor = True
        '
        'LabelCanvasSize
        '
        Me.LabelCanvasSize.AutoSize = True
        Me.LabelCanvasSize.Location = New System.Drawing.Point(9, 250)
        Me.LabelCanvasSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCanvasSize.Name = "LabelCanvasSize"
        Me.LabelCanvasSize.Size = New System.Drawing.Size(79, 15)
        Me.LabelCanvasSize.TabIndex = 13
        Me.LabelCanvasSize.Text = "Canvas Size:"
        '
        'ComboBoxCanvasSize
        '
        Me.ComboBoxCanvasSize.FormattingEnabled = True
        Me.ComboBoxCanvasSize.Items.AddRange(New Object() {"1280x720", "1920x1080"})
        Me.ComboBoxCanvasSize.Location = New System.Drawing.Point(96, 246)
        Me.ComboBoxCanvasSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxCanvasSize.Name = "ComboBoxCanvasSize"
        Me.ComboBoxCanvasSize.Size = New System.Drawing.Size(150, 23)
        Me.ComboBoxCanvasSize.TabIndex = 14
        Me.ComboBoxCanvasSize.Text = "1280x720"
        '
        'ButtonSetAll
        '
        Me.ButtonSetAll.Location = New System.Drawing.Point(172, 496)
        Me.ButtonSetAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSetAll.Name = "ButtonSetAll"
        Me.ButtonSetAll.Size = New System.Drawing.Size(78, 30)
        Me.ButtonSetAll.TabIndex = 21
        Me.ButtonSetAll.Text = "Set All"
        Me.ButtonSetAll.UseVisualStyleBackColor = True
        '
        'CheckBoxCRT
        '
        Me.CheckBoxCRT.AutoSize = True
        Me.CheckBoxCRT.Location = New System.Drawing.Point(6, 220)
        Me.CheckBoxCRT.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxCRT.Name = "CheckBoxCRT"
        Me.CheckBoxCRT.Size = New System.Drawing.Size(164, 19)
        Me.CheckBoxCRT.TabIndex = 11
        Me.CheckBoxCRT.Text = "CRT Oscilloscope Style"
        Me.CheckBoxCRT.UseVisualStyleBackColor = True
        '
        'NumericUpDownLineWidth
        '
        Me.NumericUpDownLineWidth.Location = New System.Drawing.Point(80, 188)
        Me.NumericUpDownLineWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownLineWidth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownLineWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownLineWidth.Name = "NumericUpDownLineWidth"
        Me.NumericUpDownLineWidth.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownLineWidth.TabIndex = 10
        Me.NumericUpDownLineWidth.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'CheckBoxNoFileWriting
        '
        Me.CheckBoxNoFileWriting.AutoSize = True
        Me.CheckBoxNoFileWriting.Checked = True
        Me.CheckBoxNoFileWriting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxNoFileWriting.Location = New System.Drawing.Point(6, 22)
        Me.CheckBoxNoFileWriting.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxNoFileWriting.Name = "CheckBoxNoFileWriting"
        Me.CheckBoxNoFileWriting.Size = New System.Drawing.Size(202, 19)
        Me.CheckBoxNoFileWriting.TabIndex = 0
        Me.CheckBoxNoFileWriting.Text = "No file writing (preview only)"
        Me.ToolTips.SetToolTip(Me.CheckBoxNoFileWriting, "Good for previewing your settings.")
        Me.CheckBoxNoFileWriting.UseVisualStyleBackColor = True
        '
        'LabelLineWidth
        '
        Me.LabelLineWidth.AutoSize = True
        Me.LabelLineWidth.Location = New System.Drawing.Point(9, 190)
        Me.LabelLineWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLineWidth.Name = "LabelLineWidth"
        Me.LabelLineWidth.Size = New System.Drawing.Size(76, 15)
        Me.LabelLineWidth.TabIndex = 9
        Me.LabelLineWidth.Text = "Line Width:"
        '
        'ListBoxFiles
        '
        Me.ListBoxFiles.FormattingEnabled = True
        Me.ListBoxFiles.HorizontalScrollbar = True
        Me.ListBoxFiles.ItemHeight = 15
        Me.ListBoxFiles.Location = New System.Drawing.Point(5, 285)
        Me.ListBoxFiles.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxFiles.Name = "ListBoxFiles"
        Me.ListBoxFiles.Size = New System.Drawing.Size(243, 199)
        Me.ListBoxFiles.TabIndex = 15
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Image = Global.OVG.My.Resources.Resources.gear_16xLG
        Me.ButtonOptions.Location = New System.Drawing.Point(139, 496)
        Me.ButtonOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(28, 30)
        Me.ButtonOptions.TabIndex = 20
        Me.ToolTips.SetToolTip(Me.ButtonOptions, "Channel config")
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'ButtonMoveDown
        '
        Me.ButtonMoveDown.Image = Global.OVG.My.Resources.Resources.arrow_Down_16xLG
        Me.ButtonMoveDown.Location = New System.Drawing.Point(105, 496)
        Me.ButtonMoveDown.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMoveDown.Name = "ButtonMoveDown"
        Me.ButtonMoveDown.Size = New System.Drawing.Size(28, 30)
        Me.ButtonMoveDown.TabIndex = 19
        Me.ToolTips.SetToolTip(Me.ButtonMoveDown, "Move down")
        Me.ButtonMoveDown.UseVisualStyleBackColor = True
        '
        'ButtonMoveUp
        '
        Me.ButtonMoveUp.Image = Global.OVG.My.Resources.Resources.arrow_Up_16xLG
        Me.ButtonMoveUp.Location = New System.Drawing.Point(71, 496)
        Me.ButtonMoveUp.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMoveUp.Name = "ButtonMoveUp"
        Me.ButtonMoveUp.Size = New System.Drawing.Size(28, 30)
        Me.ButtonMoveUp.TabIndex = 18
        Me.ToolTips.SetToolTip(Me.ButtonMoveUp, "Move up")
        Me.ButtonMoveUp.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Image = Global.OVG.My.Resources.Resources.action_Cancel_16xLG
        Me.ButtonRemove.Location = New System.Drawing.Point(38, 496)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(28, 30)
        Me.ButtonRemove.TabIndex = 17
        Me.ToolTips.SetToolTip(Me.ButtonRemove, "Remove file")
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Image = Global.OVG.My.Resources.Resources.action_add_16xLG
        Me.ButtonAdd.Location = New System.Drawing.Point(4, 496)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(28, 30)
        Me.ButtonAdd.TabIndex = 16
        Me.ToolTips.SetToolTip(Me.ButtonAdd, "Add file")
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'NumericUpDownColumn
        '
        Me.NumericUpDownColumn.Location = New System.Drawing.Point(71, 158)
        Me.NumericUpDownColumn.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownColumn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownColumn.Name = "NumericUpDownColumn"
        Me.NumericUpDownColumn.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownColumn.TabIndex = 8
        Me.ToolTips.SetToolTip(Me.NumericUpDownColumn, "Change column count")
        Me.NumericUpDownColumn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelColumn
        '
        Me.LabelColumn.AutoSize = True
        Me.LabelColumn.Location = New System.Drawing.Point(9, 160)
        Me.LabelColumn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelColumn.Name = "LabelColumn"
        Me.LabelColumn.Size = New System.Drawing.Size(61, 15)
        Me.LabelColumn.TabIndex = 7
        Me.LabelColumn.Text = "Columns:"
        '
        'CheckBoxSmooth
        '
        Me.CheckBoxSmooth.AutoSize = True
        Me.CheckBoxSmooth.Location = New System.Drawing.Point(116, 49)
        Me.CheckBoxSmooth.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxSmooth.Name = "CheckBoxSmooth"
        Me.CheckBoxSmooth.Size = New System.Drawing.Size(103, 19)
        Me.CheckBoxSmooth.TabIndex = 2
        Me.CheckBoxSmooth.Text = "Smooth Line"
        Me.ToolTips.SetToolTip(Me.CheckBoxSmooth, "Anti-alias drawing, slower.")
        Me.CheckBoxSmooth.UseVisualStyleBackColor = True
        '
        'ButtonAudio
        '
        Me.ButtonAudio.Enabled = False
        Me.ButtonAudio.Location = New System.Drawing.Point(6, 131)
        Me.ButtonAudio.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAudio.Name = "ButtonAudio"
        Me.ButtonAudio.Size = New System.Drawing.Size(242, 22)
        Me.ButtonAudio.TabIndex = 6
        Me.ButtonAudio.Text = "Master Audio"
        Me.ButtonAudio.UseVisualStyleBackColor = True
        '
        'CheckBoxVideo
        '
        Me.CheckBoxVideo.AutoSize = True
        Me.CheckBoxVideo.Location = New System.Drawing.Point(6, 106)
        Me.CheckBoxVideo.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxVideo.Name = "CheckBoxVideo"
        Me.CheckBoxVideo.Size = New System.Drawing.Size(124, 19)
        Me.CheckBoxVideo.TabIndex = 5
        Me.CheckBoxVideo.Text = "Convert to video"
        Me.ToolTips.SetToolTip(Me.CheckBoxVideo, "Auto convert frames to video after finished." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requires FFmpeg.")
        Me.CheckBoxVideo.UseVisualStyleBackColor = True
        '
        'NumericUpDownFrameRate
        '
        Me.NumericUpDownFrameRate.Location = New System.Drawing.Point(71, 78)
        Me.NumericUpDownFrameRate.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownFrameRate.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDownFrameRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownFrameRate.Name = "NumericUpDownFrameRate"
        Me.NumericUpDownFrameRate.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownFrameRate.TabIndex = 4
        Me.NumericUpDownFrameRate.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'LabelFrameRate
        '
        Me.LabelFrameRate.AutoSize = True
        Me.LabelFrameRate.Location = New System.Drawing.Point(4, 80)
        Me.LabelFrameRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFrameRate.Name = "LabelFrameRate"
        Me.LabelFrameRate.Size = New System.Drawing.Size(68, 15)
        Me.LabelFrameRate.TabIndex = 3
        Me.LabelFrameRate.Text = "Framerate:"
        '
        'PictureBoxOutput
        '
        Me.PictureBoxOutput.Location = New System.Drawing.Point(18, 89)
        Me.PictureBoxOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxOutput.Name = "PictureBoxOutput"
        Me.PictureBoxOutput.Size = New System.Drawing.Size(800, 450)
        Me.PictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxOutput.TabIndex = 4
        Me.PictureBoxOutput.TabStop = False
        '
        'TextBoxLog
        '
        Me.TextBoxLog.Location = New System.Drawing.Point(18, 89)
        Me.TextBoxLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.ReadOnly = True
        Me.TextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxLog.Size = New System.Drawing.Size(800, 450)
        Me.TextBoxLog.TabIndex = 4
        Me.TextBoxLog.Visible = False
        '
        'FFmpegBackgroundWorker
        '
        Me.FFmpegBackgroundWorker.WorkerReportsProgress = True
        Me.FFmpegBackgroundWorker.WorkerSupportsCancellation = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelStatus, Me.ToolStripStatusLabelPadding, Me.ToolStripStatusLabelAbout})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 552)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1098, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelStatus
        '
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(89, 19)
        Me.LabelStatus.Text = "LabelStatus"
        '
        'ToolStripStatusLabelPadding
        '
        Me.ToolStripStatusLabelPadding.Name = "ToolStripStatusLabelPadding"
        Me.ToolStripStatusLabelPadding.Size = New System.Drawing.Size(795, 19)
        Me.ToolStripStatusLabelPadding.Spring = True
        '
        'ToolStripStatusLabelAbout
        '
        Me.ToolStripStatusLabelAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabelAbout.IsLink = True
        Me.ToolStripStatusLabelAbout.Name = "ToolStripStatusLabelAbout"
        Me.ToolStripStatusLabelAbout.Size = New System.Drawing.Size(195, 19)
        Me.ToolStripStatusLabelAbout.Text = "https://zeinok.blogspot.tw/"
        Me.ToolStripStatusLabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelPreviewMode
        '
        Me.LabelPreviewMode.AutoSize = True
        Me.LabelPreviewMode.BackColor = System.Drawing.SystemColors.Control
        Me.LabelPreviewMode.ForeColor = System.Drawing.Color.Red
        Me.LabelPreviewMode.Location = New System.Drawing.Point(626, 59)
        Me.LabelPreviewMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPreviewMode.Name = "LabelPreviewMode"
        Me.LabelPreviewMode.Size = New System.Drawing.Size(90, 15)
        Me.LabelPreviewMode.TabIndex = 7
        Me.LabelPreviewMode.Text = "Preview Mode"
        Me.LabelPreviewMode.Visible = False
        '
        'TimerLabelFlashing
        '
        Me.TimerLabelFlashing.Enabled = True
        Me.TimerLabelFlashing.Interval = 1000
        '
        'ComboBoxFFmpegEncodingPreset
        '
        Me.ComboBoxFFmpegEncodingPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFFmpegEncodingPreset.Enabled = False
        Me.ComboBoxFFmpegEncodingPreset.FormattingEnabled = True
        Me.ComboBoxFFmpegEncodingPreset.Items.AddRange(New Object() {"ultrafast", "superfast", "veryfast", "faster", "fast", "medium", "slow", "slower", "veryslow", "placebo"})
        Me.ComboBoxFFmpegEncodingPreset.Location = New System.Drawing.Point(135, 104)
        Me.ComboBoxFFmpegEncodingPreset.Name = "ComboBoxFFmpegEncodingPreset"
        Me.ComboBoxFFmpegEncodingPreset.Size = New System.Drawing.Size(111, 23)
        Me.ComboBoxFFmpegEncodingPreset.TabIndex = 22
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1098, 576)
        Me.Controls.Add(Me.LabelPreviewMode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBoxLog)
        Me.Controls.Add(Me.GroupBoxOptions)
        Me.Controls.Add(Me.PictureBoxOutput)
        Me.Controls.Add(Me.ButtonControl)
        Me.Controls.Add(Me.TextBoxOutputLocation)
        Me.Controls.Add(Me.LabelOutputLocation)
        Me.Controls.Add(Me.ButtonSetOutputFolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oscilloscope View Generator"
        Me.GroupBoxOptions.ResumeLayout(False)
        Me.GroupBoxOptions.PerformLayout()
        CType(Me.NumericUpDownLineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFrameRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OscilloscopeBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonSetOutputFolder As System.Windows.Forms.Button
    Friend WithEvents LabelOutputLocation As System.Windows.Forms.Label
    Friend WithEvents TextBoxOutputLocation As System.Windows.Forms.TextBox
    Friend WithEvents ButtonControl As System.Windows.Forms.Button
    Friend WithEvents PictureBoxOutput As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxShowOutput As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxOptions As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDownFrameRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelFrameRate As System.Windows.Forms.Label
    Friend WithEvents CheckBoxVideo As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonAudio As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSmooth As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownColumn As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelColumn As System.Windows.Forms.Label
    Friend WithEvents CheckBoxNoFileWriting As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveDown As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveUp As System.Windows.Forms.Button
    Friend WithEvents ButtonOptions As System.Windows.Forms.Button
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents ListBoxFiles As System.Windows.Forms.ListBox
    Friend WithEvents LabelLineWidth As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownLineWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBoxCRT As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSetAll As System.Windows.Forms.Button
    Friend WithEvents TextBoxLog As System.Windows.Forms.TextBox
    Friend WithEvents FFmpegBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelPreviewMode As System.Windows.Forms.Label
    Friend WithEvents TimerLabelFlashing As System.Windows.Forms.Timer
    Friend WithEvents LabelCanvasSize As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCanvasSize As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxGrid As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripStatusLabelPadding As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelAbout As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ComboBoxFFmpegEncodingPreset As System.Windows.Forms.ComboBox

End Class
