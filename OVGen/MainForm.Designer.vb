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
        Me.ButtonBackgroundColor = New System.Windows.Forms.Button()
        Me.NumericUpDownMiddleLine = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownGrid = New System.Windows.Forms.NumericUpDown()
        Me.ButtonMiddleLineColor = New System.Windows.Forms.Button()
        Me.ButtonGridColor = New System.Windows.Forms.Button()
        Me.CheckBoxDrawMiddleLine = New System.Windows.Forms.CheckBox()
        Me.ButtonFlowDirection = New System.Windows.Forms.Button()
        Me.LabelFlowDirecton = New System.Windows.Forms.Label()
        Me.CheckBoxGrid = New System.Windows.Forms.CheckBox()
        Me.LabelCanvasSize = New System.Windows.Forms.Label()
        Me.ComboBoxCanvasSize = New System.Windows.Forms.ComboBox()
        Me.CheckBoxCRT = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownLineWidth = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxNoFileWriting = New System.Windows.Forms.CheckBox()
        Me.LabelLineWidth = New System.Windows.Forms.Label()
        Me.NumericUpDownColumn = New System.Windows.Forms.NumericUpDown()
        Me.LabelColumn = New System.Windows.Forms.Label()
        Me.CheckBoxSmooth = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownFrameRate = New System.Windows.Forms.NumericUpDown()
        Me.LabelFrameRate = New System.Windows.Forms.Label()
        Me.LinkLabelCustomCommandLine = New System.Windows.Forms.LinkLabel()
        Me.ButtonSelectAll = New System.Windows.Forms.Button()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonMoveDown = New System.Windows.Forms.Button()
        Me.ButtonMoveUp = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonAudio = New System.Windows.Forms.Button()
        Me.CheckBoxVideo = New System.Windows.Forms.CheckBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBoxOutput = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelPadding = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelAbout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelPreviewMode = New System.Windows.Forms.Label()
        Me.TimerLabelFlashing = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorkerStdErrReader = New System.ComponentModel.BackgroundWorker()
        Me.LogBox = New System.Windows.Forms.RichTextBox()
        Me.TabControlRenderingFiles = New System.Windows.Forms.TabControl()
        Me.TabPageRendering = New System.Windows.Forms.TabPage()
        Me.ButtonLRmeterColor = New System.Windows.Forms.Button()
        Me.CheckBoxDottedXYmode = New System.Windows.Forms.CheckBox()
        Me.ComboBoxLabelPos = New System.Windows.Forms.ComboBox()
        Me.LabelChannelLabelPos = New System.Windows.Forms.Label()
        Me.NumericUpDownBorder = New System.Windows.Forms.NumericUpDown()
        Me.ButtonBorderColor = New System.Windows.Forms.Button()
        Me.CheckBoxBorder = New System.Windows.Forms.CheckBox()
        Me.TabPageFiles = New System.Windows.Forms.TabPage()
        Me.ListBoxFiles = New System.Windows.Forms.ListBox()
        Me.TimerStatusUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDownLRmeterHeight = New System.Windows.Forms.NumericUpDown()
        Me.LabelLRmeterHeight = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownMiddleLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFrameRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControlRenderingFiles.SuspendLayout()
        Me.TabPageRendering.SuspendLayout()
        CType(Me.NumericUpDownBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageFiles.SuspendLayout()
        CType(Me.NumericUpDownLRmeterHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OscilloscopeBackgroundWorker
        '
        Me.OscilloscopeBackgroundWorker.WorkerReportsProgress = True
        Me.OscilloscopeBackgroundWorker.WorkerSupportsCancellation = True
        '
        'ButtonSetOutputFolder
        '
        Me.ButtonSetOutputFolder.Location = New System.Drawing.Point(786, 18)
        Me.ButtonSetOutputFolder.Margin = New System.Windows.Forms.Padding(4)
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
        Me.TextBoxOutputLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxOutputLocation.Name = "TextBoxOutputLocation"
        Me.TextBoxOutputLocation.Size = New System.Drawing.Size(673, 25)
        Me.TextBoxOutputLocation.TabIndex = 1
        '
        'ButtonControl
        '
        Me.ButtonControl.Location = New System.Drawing.Point(724, 52)
        Me.ButtonControl.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonControl.Name = "ButtonControl"
        Me.ButtonControl.Size = New System.Drawing.Size(94, 29)
        Me.ButtonControl.TabIndex = 4
        Me.ButtonControl.Text = "Start"
        Me.ToolTips.SetToolTip(Me.ButtonControl, "Start drawing.")
        Me.ButtonControl.UseVisualStyleBackColor = True
        '
        'CheckBoxShowOutput
        '
        Me.CheckBoxShowOutput.AutoSize = True
        Me.CheckBoxShowOutput.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxShowOutput.Checked = True
        Me.CheckBoxShowOutput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxShowOutput.Location = New System.Drawing.Point(718, 89)
        Me.CheckBoxShowOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxShowOutput.Name = "CheckBoxShowOutput"
        Me.CheckBoxShowOutput.Size = New System.Drawing.Size(101, 19)
        Me.CheckBoxShowOutput.TabIndex = 5
        Me.CheckBoxShowOutput.Text = "Show output"
        Me.ToolTips.SetToolTip(Me.CheckBoxShowOutput, "Uncheck this if you are worried about speed dropping.")
        Me.CheckBoxShowOutput.UseVisualStyleBackColor = False
        '
        'ButtonBackgroundColor
        '
        Me.ButtonBackgroundColor.BackColor = System.Drawing.Color.Black
        Me.ButtonBackgroundColor.ForeColor = System.Drawing.Color.White
        Me.ButtonBackgroundColor.Location = New System.Drawing.Point(6, 135)
        Me.ButtonBackgroundColor.Name = "ButtonBackgroundColor"
        Me.ButtonBackgroundColor.Size = New System.Drawing.Size(234, 25)
        Me.ButtonBackgroundColor.TabIndex = 8
        Me.ButtonBackgroundColor.Text = "Background Color"
        Me.ButtonBackgroundColor.UseVisualStyleBackColor = False
        '
        'NumericUpDownMiddleLine
        '
        Me.NumericUpDownMiddleLine.Location = New System.Drawing.Point(185, 316)
        Me.NumericUpDownMiddleLine.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDownMiddleLine.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownMiddleLine.Name = "NumericUpDownMiddleLine"
        Me.NumericUpDownMiddleLine.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownMiddleLine.TabIndex = 22
        Me.NumericUpDownMiddleLine.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDownGrid
        '
        Me.NumericUpDownGrid.Location = New System.Drawing.Point(148, 287)
        Me.NumericUpDownGrid.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDownGrid.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownGrid.Name = "NumericUpDownGrid"
        Me.NumericUpDownGrid.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownGrid.TabIndex = 19
        Me.NumericUpDownGrid.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ButtonMiddleLineColor
        '
        Me.ButtonMiddleLineColor.BackColor = System.Drawing.Color.Gray
        Me.ButtonMiddleLineColor.Location = New System.Drawing.Point(104, 316)
        Me.ButtonMiddleLineColor.Name = "ButtonMiddleLineColor"
        Me.ButtonMiddleLineColor.Size = New System.Drawing.Size(75, 25)
        Me.ButtonMiddleLineColor.TabIndex = 21
        Me.ButtonMiddleLineColor.Text = "Color"
        Me.ButtonMiddleLineColor.UseVisualStyleBackColor = False
        '
        'ButtonGridColor
        '
        Me.ButtonGridColor.BackColor = System.Drawing.Color.LightGray
        Me.ButtonGridColor.Location = New System.Drawing.Point(67, 287)
        Me.ButtonGridColor.Name = "ButtonGridColor"
        Me.ButtonGridColor.Size = New System.Drawing.Size(75, 25)
        Me.ButtonGridColor.TabIndex = 18
        Me.ButtonGridColor.Text = "Color"
        Me.ButtonGridColor.UseVisualStyleBackColor = False
        '
        'CheckBoxDrawMiddleLine
        '
        Me.CheckBoxDrawMiddleLine.AutoSize = True
        Me.CheckBoxDrawMiddleLine.Location = New System.Drawing.Point(5, 320)
        Me.CheckBoxDrawMiddleLine.Name = "CheckBoxDrawMiddleLine"
        Me.CheckBoxDrawMiddleLine.Size = New System.Drawing.Size(100, 19)
        Me.CheckBoxDrawMiddleLine.TabIndex = 20
        Me.CheckBoxDrawMiddleLine.Text = "Middle Line"
        Me.ToolTips.SetToolTip(Me.CheckBoxDrawMiddleLine, "Draws a horizontal line at 0V")
        Me.CheckBoxDrawMiddleLine.UseVisualStyleBackColor = True
        '
        'ButtonFlowDirection
        '
        Me.ButtonFlowDirection.Location = New System.Drawing.Point(110, 377)
        Me.ButtonFlowDirection.Name = "ButtonFlowDirection"
        Me.ButtonFlowDirection.Size = New System.Drawing.Size(129, 26)
        Me.ButtonFlowDirection.TabIndex = 26
        Me.ButtonFlowDirection.Text = "FlowDirection"
        Me.ButtonFlowDirection.UseVisualStyleBackColor = True
        '
        'LabelFlowDirecton
        '
        Me.LabelFlowDirecton.AutoSize = True
        Me.LabelFlowDirecton.Location = New System.Drawing.Point(6, 383)
        Me.LabelFlowDirecton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFlowDirecton.Name = "LabelFlowDirecton"
        Me.LabelFlowDirecton.Size = New System.Drawing.Size(97, 15)
        Me.LabelFlowDirecton.TabIndex = 25
        Me.LabelFlowDirecton.Text = "Flow Direction:"
        '
        'CheckBoxGrid
        '
        Me.CheckBoxGrid.AutoSize = True
        Me.CheckBoxGrid.Location = New System.Drawing.Point(5, 291)
        Me.CheckBoxGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxGrid.Name = "CheckBoxGrid"
        Me.CheckBoxGrid.Size = New System.Drawing.Size(55, 19)
        Me.CheckBoxGrid.TabIndex = 17
        Me.CheckBoxGrid.Text = "Grid"
        Me.CheckBoxGrid.UseVisualStyleBackColor = True
        '
        'LabelCanvasSize
        '
        Me.LabelCanvasSize.AutoSize = True
        Me.LabelCanvasSize.Location = New System.Drawing.Point(6, 351)
        Me.LabelCanvasSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCanvasSize.Name = "LabelCanvasSize"
        Me.LabelCanvasSize.Size = New System.Drawing.Size(79, 15)
        Me.LabelCanvasSize.TabIndex = 23
        Me.LabelCanvasSize.Text = "Canvas Size:"
        '
        'ComboBoxCanvasSize
        '
        Me.ComboBoxCanvasSize.FormattingEnabled = True
        Me.ComboBoxCanvasSize.Items.AddRange(New Object() {"1280x720", "1920x1080"})
        Me.ComboBoxCanvasSize.Location = New System.Drawing.Point(93, 347)
        Me.ComboBoxCanvasSize.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCanvasSize.Name = "ComboBoxCanvasSize"
        Me.ComboBoxCanvasSize.Size = New System.Drawing.Size(145, 23)
        Me.ComboBoxCanvasSize.TabIndex = 24
        Me.ComboBoxCanvasSize.Text = "1280x720"
        '
        'CheckBoxCRT
        '
        Me.CheckBoxCRT.AutoSize = True
        Me.CheckBoxCRT.Location = New System.Drawing.Point(120, 31)
        Me.CheckBoxCRT.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxCRT.Name = "CheckBoxCRT"
        Me.CheckBoxCRT.Size = New System.Drawing.Size(93, 19)
        Me.CheckBoxCRT.TabIndex = 2
        Me.CheckBoxCRT.Text = "CRT  Style"
        Me.CheckBoxCRT.UseVisualStyleBackColor = True
        '
        'NumericUpDownLineWidth
        '
        Me.NumericUpDownLineWidth.Location = New System.Drawing.Point(85, 197)
        Me.NumericUpDownLineWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownLineWidth.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDownLineWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownLineWidth.Name = "NumericUpDownLineWidth"
        Me.NumericUpDownLineWidth.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownLineWidth.TabIndex = 11
        Me.NumericUpDownLineWidth.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'CheckBoxNoFileWriting
        '
        Me.CheckBoxNoFileWriting.AutoSize = True
        Me.CheckBoxNoFileWriting.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBoxNoFileWriting.Checked = True
        Me.CheckBoxNoFileWriting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxNoFileWriting.Location = New System.Drawing.Point(6, 5)
        Me.CheckBoxNoFileWriting.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxNoFileWriting.Name = "CheckBoxNoFileWriting"
        Me.CheckBoxNoFileWriting.Size = New System.Drawing.Size(202, 19)
        Me.CheckBoxNoFileWriting.TabIndex = 0
        Me.CheckBoxNoFileWriting.Text = "No file writing (preview only)"
        Me.ToolTips.SetToolTip(Me.CheckBoxNoFileWriting, "Good for previewing your settings.")
        Me.CheckBoxNoFileWriting.UseVisualStyleBackColor = False
        '
        'LabelLineWidth
        '
        Me.LabelLineWidth.AutoSize = True
        Me.LabelLineWidth.Location = New System.Drawing.Point(5, 201)
        Me.LabelLineWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLineWidth.Name = "LabelLineWidth"
        Me.LabelLineWidth.Size = New System.Drawing.Size(76, 15)
        Me.LabelLineWidth.TabIndex = 10
        Me.LabelLineWidth.Text = "Line Width:"
        '
        'NumericUpDownColumn
        '
        Me.NumericUpDownColumn.Location = New System.Drawing.Point(77, 104)
        Me.NumericUpDownColumn.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownColumn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownColumn.Name = "NumericUpDownColumn"
        Me.NumericUpDownColumn.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownColumn.TabIndex = 7
        Me.ToolTips.SetToolTip(Me.NumericUpDownColumn, "Change column count")
        Me.NumericUpDownColumn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelColumn
        '
        Me.LabelColumn.AutoSize = True
        Me.LabelColumn.Location = New System.Drawing.Point(5, 106)
        Me.LabelColumn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelColumn.Name = "LabelColumn"
        Me.LabelColumn.Size = New System.Drawing.Size(61, 15)
        Me.LabelColumn.TabIndex = 6
        Me.LabelColumn.Text = "Columns:"
        '
        'CheckBoxSmooth
        '
        Me.CheckBoxSmooth.AutoSize = True
        Me.CheckBoxSmooth.Location = New System.Drawing.Point(6, 31)
        Me.CheckBoxSmooth.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxSmooth.Name = "CheckBoxSmooth"
        Me.CheckBoxSmooth.Size = New System.Drawing.Size(103, 19)
        Me.CheckBoxSmooth.TabIndex = 1
        Me.CheckBoxSmooth.Text = "Smooth Line"
        Me.ToolTips.SetToolTip(Me.CheckBoxSmooth, "Anti-alias drawing, slower.")
        Me.CheckBoxSmooth.UseVisualStyleBackColor = True
        '
        'NumericUpDownFrameRate
        '
        Me.NumericUpDownFrameRate.Location = New System.Drawing.Point(80, 75)
        Me.NumericUpDownFrameRate.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownFrameRate.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.NumericUpDownFrameRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownFrameRate.Name = "NumericUpDownFrameRate"
        Me.NumericUpDownFrameRate.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownFrameRate.TabIndex = 5
        Me.NumericUpDownFrameRate.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'LabelFrameRate
        '
        Me.LabelFrameRate.AutoSize = True
        Me.LabelFrameRate.Location = New System.Drawing.Point(5, 77)
        Me.LabelFrameRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFrameRate.Name = "LabelFrameRate"
        Me.LabelFrameRate.Size = New System.Drawing.Size(68, 15)
        Me.LabelFrameRate.TabIndex = 4
        Me.LabelFrameRate.Text = "Framerate:"
        '
        'LinkLabelCustomCommandLine
        '
        Me.LinkLabelCustomCommandLine.AutoSize = True
        Me.LinkLabelCustomCommandLine.Location = New System.Drawing.Point(112, 6)
        Me.LinkLabelCustomCommandLine.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelCustomCommandLine.Name = "LinkLabelCustomCommandLine"
        Me.LinkLabelCustomCommandLine.Size = New System.Drawing.Size(111, 15)
        Me.LinkLabelCustomCommandLine.TabIndex = 1
        Me.LinkLabelCustomCommandLine.TabStop = True
        Me.LinkLabelCustomCommandLine.Text = "Edit commandline"
        '
        'ButtonSelectAll
        '
        Me.ButtonSelectAll.Location = New System.Drawing.Point(173, 463)
        Me.ButtonSelectAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSelectAll.Name = "ButtonSelectAll"
        Me.ButtonSelectAll.Size = New System.Drawing.Size(68, 30)
        Me.ButtonSelectAll.TabIndex = 9
        Me.ButtonSelectAll.Text = "Sel. All"
        Me.ButtonSelectAll.UseVisualStyleBackColor = True
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Image = Global.OVG.My.Resources.Resources.gear_16xLG
        Me.ButtonOptions.Location = New System.Drawing.Point(140, 463)
        Me.ButtonOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(28, 30)
        Me.ButtonOptions.TabIndex = 8
        Me.ToolTips.SetToolTip(Me.ButtonOptions, "Channel config")
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'ButtonMoveDown
        '
        Me.ButtonMoveDown.Image = Global.OVG.My.Resources.Resources.arrow_Down_16xLG
        Me.ButtonMoveDown.Location = New System.Drawing.Point(106, 463)
        Me.ButtonMoveDown.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMoveDown.Name = "ButtonMoveDown"
        Me.ButtonMoveDown.Size = New System.Drawing.Size(28, 30)
        Me.ButtonMoveDown.TabIndex = 7
        Me.ToolTips.SetToolTip(Me.ButtonMoveDown, "Move down")
        Me.ButtonMoveDown.UseVisualStyleBackColor = True
        '
        'ButtonMoveUp
        '
        Me.ButtonMoveUp.Image = Global.OVG.My.Resources.Resources.arrow_Up_16xLG
        Me.ButtonMoveUp.Location = New System.Drawing.Point(72, 463)
        Me.ButtonMoveUp.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMoveUp.Name = "ButtonMoveUp"
        Me.ButtonMoveUp.Size = New System.Drawing.Size(28, 30)
        Me.ButtonMoveUp.TabIndex = 6
        Me.ToolTips.SetToolTip(Me.ButtonMoveUp, "Move up")
        Me.ButtonMoveUp.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Image = Global.OVG.My.Resources.Resources.action_Cancel_16xLG
        Me.ButtonRemove.Location = New System.Drawing.Point(39, 463)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(28, 30)
        Me.ButtonRemove.TabIndex = 5
        Me.ToolTips.SetToolTip(Me.ButtonRemove, "Remove file")
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Image = Global.OVG.My.Resources.Resources.action_add_16xLG
        Me.ButtonAdd.Location = New System.Drawing.Point(5, 463)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(28, 30)
        Me.ButtonAdd.TabIndex = 4
        Me.ToolTips.SetToolTip(Me.ButtonAdd, "Add file")
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonAudio
        '
        Me.ButtonAudio.Enabled = False
        Me.ButtonAudio.Location = New System.Drawing.Point(5, 28)
        Me.ButtonAudio.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAudio.Name = "ButtonAudio"
        Me.ButtonAudio.Size = New System.Drawing.Size(236, 26)
        Me.ButtonAudio.TabIndex = 2
        Me.ButtonAudio.Text = "Master Audio"
        Me.ButtonAudio.UseVisualStyleBackColor = True
        '
        'CheckBoxVideo
        '
        Me.CheckBoxVideo.AutoSize = True
        Me.CheckBoxVideo.Location = New System.Drawing.Point(5, 5)
        Me.CheckBoxVideo.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxVideo.Name = "CheckBoxVideo"
        Me.CheckBoxVideo.Size = New System.Drawing.Size(103, 19)
        Me.CheckBoxVideo.TabIndex = 0
        Me.CheckBoxVideo.Text = "Output video"
        Me.ToolTips.SetToolTip(Me.CheckBoxVideo, "Output as video instead of png frame sequences." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requires FFmpeg.")
        Me.CheckBoxVideo.UseVisualStyleBackColor = True
        '
        'PictureBoxOutput
        '
        Me.PictureBoxOutput.Location = New System.Drawing.Point(18, 89)
        Me.PictureBoxOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxOutput.Name = "PictureBoxOutput"
        Me.PictureBoxOutput.Size = New System.Drawing.Size(800, 450)
        Me.PictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxOutput.TabIndex = 4
        Me.PictureBoxOutput.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelStatus, Me.ToolStripStatusLabelPadding, Me.ToolStripStatusLabelAbout})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 637)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1098, 28)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelStatus
        '
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(89, 23)
        Me.LabelStatus.Text = "LabelStatus"
        '
        'ToolStripStatusLabelPadding
        '
        Me.ToolStripStatusLabelPadding.Name = "ToolStripStatusLabelPadding"
        Me.ToolStripStatusLabelPadding.Size = New System.Drawing.Size(935, 23)
        Me.ToolStripStatusLabelPadding.Spring = True
        '
        'ToolStripStatusLabelAbout
        '
        Me.ToolStripStatusLabelAbout.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelAbout.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ToolStripStatusLabelAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabelAbout.Name = "ToolStripStatusLabelAbout"
        Me.ToolStripStatusLabelAbout.Size = New System.Drawing.Size(55, 23)
        Me.ToolStripStatusLabelAbout.Text = "About"
        Me.ToolStripStatusLabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelPreviewMode
        '
        Me.LabelPreviewMode.AutoSize = True
        Me.LabelPreviewMode.BackColor = System.Drawing.SystemColors.Control
        Me.LabelPreviewMode.ForeColor = System.Drawing.Color.Red
        Me.LabelPreviewMode.Location = New System.Drawing.Point(620, 59)
        Me.LabelPreviewMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPreviewMode.Name = "LabelPreviewMode"
        Me.LabelPreviewMode.Size = New System.Drawing.Size(90, 15)
        Me.LabelPreviewMode.TabIndex = 3
        Me.LabelPreviewMode.Text = "Preview Mode"
        Me.LabelPreviewMode.Visible = False
        '
        'TimerLabelFlashing
        '
        Me.TimerLabelFlashing.Enabled = True
        Me.TimerLabelFlashing.Interval = 1000
        '
        'BackgroundWorkerStdErrReader
        '
        Me.BackgroundWorkerStdErrReader.WorkerReportsProgress = True
        Me.BackgroundWorkerStdErrReader.WorkerSupportsCancellation = True
        '
        'LogBox
        '
        Me.LogBox.Location = New System.Drawing.Point(18, 545)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.LogBox.Size = New System.Drawing.Size(1060, 92)
        Me.LogBox.TabIndex = 7
        Me.LogBox.Text = ""
        '
        'TabControlRenderingFiles
        '
        Me.TabControlRenderingFiles.Controls.Add(Me.TabPageRendering)
        Me.TabControlRenderingFiles.Controls.Add(Me.TabPageFiles)
        Me.TabControlRenderingFiles.Location = New System.Drawing.Point(826, 12)
        Me.TabControlRenderingFiles.Name = "TabControlRenderingFiles"
        Me.TabControlRenderingFiles.SelectedIndex = 0
        Me.TabControlRenderingFiles.Size = New System.Drawing.Size(254, 527)
        Me.TabControlRenderingFiles.TabIndex = 6
        '
        'TabPageRendering
        '
        Me.TabPageRendering.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageRendering.Controls.Add(Me.LabelLRmeterHeight)
        Me.TabPageRendering.Controls.Add(Me.NumericUpDownLRmeterHeight)
        Me.TabPageRendering.Controls.Add(Me.ButtonLRmeterColor)
        Me.TabPageRendering.Controls.Add(Me.CheckBoxDottedXYmode)
        Me.TabPageRendering.Controls.Add(Me.ComboBoxLabelPos)
        Me.TabPageRendering.Controls.Add(Me.LabelChannelLabelPos)
        Me.TabPageRendering.Controls.Add(Me.NumericUpDownBorder)
        Me.TabPageRendering.Controls.Add(Me.ButtonBorderColor)
        Me.TabPageRendering.Controls.Add(Me.CheckBoxBorder)
        Me.TabPageRendering.Controls.Add(Me.ButtonBackgroundColor)
        Me.TabPageRendering.Controls.Add(Me.CheckBoxNoFileWriting)
        Me.TabPageRendering.Controls.Add(Me.NumericUpDownMiddleLine)
        Me.TabPageRendering.Controls.Add(Me.LabelFrameRate)
        Me.TabPageRendering.Controls.Add(Me.NumericUpDownGrid)
        Me.TabPageRendering.Controls.Add(Me.NumericUpDownFrameRate)
        Me.TabPageRendering.Controls.Add(Me.ButtonMiddleLineColor)
        Me.TabPageRendering.Controls.Add(Me.CheckBoxSmooth)
        Me.TabPageRendering.Controls.Add(Me.ButtonGridColor)
        Me.TabPageRendering.Controls.Add(Me.LabelColumn)
        Me.TabPageRendering.Controls.Add(Me.CheckBoxDrawMiddleLine)
        Me.TabPageRendering.Controls.Add(Me.NumericUpDownColumn)
        Me.TabPageRendering.Controls.Add(Me.ButtonFlowDirection)
        Me.TabPageRendering.Controls.Add(Me.LabelLineWidth)
        Me.TabPageRendering.Controls.Add(Me.LabelFlowDirecton)
        Me.TabPageRendering.Controls.Add(Me.NumericUpDownLineWidth)
        Me.TabPageRendering.Controls.Add(Me.CheckBoxGrid)
        Me.TabPageRendering.Controls.Add(Me.CheckBoxCRT)
        Me.TabPageRendering.Controls.Add(Me.LabelCanvasSize)
        Me.TabPageRendering.Controls.Add(Me.ComboBoxCanvasSize)
        Me.TabPageRendering.Location = New System.Drawing.Point(4, 25)
        Me.TabPageRendering.Name = "TabPageRendering"
        Me.TabPageRendering.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRendering.Size = New System.Drawing.Size(246, 498)
        Me.TabPageRendering.TabIndex = 0
        Me.TabPageRendering.Text = "Rendering"
        '
        'ButtonLRmeterColor
        '
        Me.ButtonLRmeterColor.BackColor = System.Drawing.Color.Red
        Me.ButtonLRmeterColor.Location = New System.Drawing.Point(8, 166)
        Me.ButtonLRmeterColor.Name = "ButtonLRmeterColor"
        Me.ButtonLRmeterColor.Size = New System.Drawing.Size(232, 25)
        Me.ButtonLRmeterColor.TabIndex = 9
        Me.ButtonLRmeterColor.Text = "LR meter Color"
        Me.ButtonLRmeterColor.UseVisualStyleBackColor = False
        '
        'CheckBoxDottedXYmode
        '
        Me.CheckBoxDottedXYmode.AutoSize = True
        Me.CheckBoxDottedXYmode.Location = New System.Drawing.Point(6, 55)
        Me.CheckBoxDottedXYmode.Name = "CheckBoxDottedXYmode"
        Me.CheckBoxDottedXYmode.Size = New System.Drawing.Size(126, 19)
        Me.CheckBoxDottedXYmode.TabIndex = 3
        Me.CheckBoxDottedXYmode.Text = "Dotted XY mode"
        Me.CheckBoxDottedXYmode.UseVisualStyleBackColor = True
        '
        'ComboBoxLabelPos
        '
        Me.ComboBoxLabelPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLabelPos.FormattingEnabled = True
        Me.ComboBoxLabelPos.Items.AddRange(New Object() {"Top Left", "Top Right", "Bottom Left", "Bottom Right"})
        Me.ComboBoxLabelPos.Location = New System.Drawing.Point(105, 409)
        Me.ComboBoxLabelPos.Name = "ComboBoxLabelPos"
        Me.ComboBoxLabelPos.Size = New System.Drawing.Size(133, 23)
        Me.ComboBoxLabelPos.TabIndex = 28
        '
        'LabelChannelLabelPos
        '
        Me.LabelChannelLabelPos.AutoSize = True
        Me.LabelChannelLabelPos.Location = New System.Drawing.Point(6, 412)
        Me.LabelChannelLabelPos.Name = "LabelChannelLabelPos"
        Me.LabelChannelLabelPos.Size = New System.Drawing.Size(93, 15)
        Me.LabelChannelLabelPos.TabIndex = 27
        Me.LabelChannelLabelPos.Text = "Label Position:"
        '
        'NumericUpDownBorder
        '
        Me.NumericUpDownBorder.Location = New System.Drawing.Point(160, 258)
        Me.NumericUpDownBorder.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDownBorder.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownBorder.Name = "NumericUpDownBorder"
        Me.NumericUpDownBorder.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownBorder.TabIndex = 16
        Me.NumericUpDownBorder.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ButtonBorderColor
        '
        Me.ButtonBorderColor.BackColor = System.Drawing.Color.LightGray
        Me.ButtonBorderColor.Location = New System.Drawing.Point(79, 258)
        Me.ButtonBorderColor.Name = "ButtonBorderColor"
        Me.ButtonBorderColor.Size = New System.Drawing.Size(75, 25)
        Me.ButtonBorderColor.TabIndex = 15
        Me.ButtonBorderColor.Text = "Color"
        Me.ButtonBorderColor.UseVisualStyleBackColor = False
        '
        'CheckBoxBorder
        '
        Me.CheckBoxBorder.AutoSize = True
        Me.CheckBoxBorder.Location = New System.Drawing.Point(5, 262)
        Me.CheckBoxBorder.Name = "CheckBoxBorder"
        Me.CheckBoxBorder.Size = New System.Drawing.Size(68, 19)
        Me.CheckBoxBorder.TabIndex = 14
        Me.CheckBoxBorder.Text = "Border"
        Me.CheckBoxBorder.UseVisualStyleBackColor = True
        '
        'TabPageFiles
        '
        Me.TabPageFiles.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageFiles.Controls.Add(Me.ListBoxFiles)
        Me.TabPageFiles.Controls.Add(Me.ButtonAudio)
        Me.TabPageFiles.Controls.Add(Me.CheckBoxVideo)
        Me.TabPageFiles.Controls.Add(Me.ButtonOptions)
        Me.TabPageFiles.Controls.Add(Me.LinkLabelCustomCommandLine)
        Me.TabPageFiles.Controls.Add(Me.ButtonMoveDown)
        Me.TabPageFiles.Controls.Add(Me.ButtonMoveUp)
        Me.TabPageFiles.Controls.Add(Me.ButtonAdd)
        Me.TabPageFiles.Controls.Add(Me.ButtonSelectAll)
        Me.TabPageFiles.Controls.Add(Me.ButtonRemove)
        Me.TabPageFiles.Location = New System.Drawing.Point(4, 25)
        Me.TabPageFiles.Name = "TabPageFiles"
        Me.TabPageFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFiles.Size = New System.Drawing.Size(246, 498)
        Me.TabPageFiles.TabIndex = 1
        Me.TabPageFiles.Text = "Files"
        '
        'ListBoxFiles
        '
        Me.ListBoxFiles.FormattingEnabled = True
        Me.ListBoxFiles.HorizontalScrollbar = True
        Me.ListBoxFiles.ItemHeight = 15
        Me.ListBoxFiles.Location = New System.Drawing.Point(5, 59)
        Me.ListBoxFiles.Name = "ListBoxFiles"
        Me.ListBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBoxFiles.Size = New System.Drawing.Size(235, 394)
        Me.ListBoxFiles.TabIndex = 10
        '
        'TimerStatusUpdater
        '
        '
        'NumericUpDownLRmeterHeight
        '
        Me.NumericUpDownLRmeterHeight.Location = New System.Drawing.Point(120, 227)
        Me.NumericUpDownLRmeterHeight.Name = "NumericUpDownLRmeterHeight"
        Me.NumericUpDownLRmeterHeight.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownLRmeterHeight.TabIndex = 13
        Me.NumericUpDownLRmeterHeight.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'LabelLRmeterHeight
        '
        Me.LabelLRmeterHeight.AutoSize = True
        Me.LabelLRmeterHeight.Location = New System.Drawing.Point(5, 229)
        Me.LabelLRmeterHeight.Name = "LabelLRmeterHeight"
        Me.LabelLRmeterHeight.Size = New System.Drawing.Size(109, 15)
        Me.LabelLRmeterHeight.TabIndex = 12
        Me.LabelLRmeterHeight.Text = "LR Meter Height:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 665)
        Me.Controls.Add(Me.TabControlRenderingFiles)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.CheckBoxShowOutput)
        Me.Controls.Add(Me.LabelPreviewMode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBoxOutput)
        Me.Controls.Add(Me.ButtonControl)
        Me.Controls.Add(Me.TextBoxOutputLocation)
        Me.Controls.Add(Me.LabelOutputLocation)
        Me.Controls.Add(Me.ButtonSetOutputFolder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oscilloscope View Generator"
        CType(Me.NumericUpDownMiddleLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFrameRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControlRenderingFiles.ResumeLayout(False)
        Me.TabPageRendering.ResumeLayout(False)
        Me.TabPageRendering.PerformLayout()
        CType(Me.NumericUpDownBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageFiles.ResumeLayout(False)
        Me.TabPageFiles.PerformLayout()
        CType(Me.NumericUpDownLRmeterHeight, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelLineWidth As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownLineWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBoxCRT As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSelectAll As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelPreviewMode As System.Windows.Forms.Label
    Friend WithEvents TimerLabelFlashing As System.Windows.Forms.Timer
    Friend WithEvents LabelCanvasSize As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCanvasSize As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxGrid As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripStatusLabelPadding As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelAbout As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LinkLabelCustomCommandLine As System.Windows.Forms.LinkLabel
    Friend WithEvents BackgroundWorkerStdErrReader As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelFlowDirecton As System.Windows.Forms.Label
    Friend WithEvents ButtonFlowDirection As Button
    Friend WithEvents CheckBoxDrawMiddleLine As CheckBox
    Friend WithEvents NumericUpDownMiddleLine As NumericUpDown
    Friend WithEvents NumericUpDownGrid As NumericUpDown
    Friend WithEvents ButtonMiddleLineColor As Button
    Friend WithEvents ButtonGridColor As Button
    Friend WithEvents ButtonBackgroundColor As Button
    Friend WithEvents LogBox As RichTextBox
    Friend WithEvents TabControlRenderingFiles As TabControl
    Friend WithEvents TabPageRendering As TabPage
    Friend WithEvents TabPageFiles As TabPage
    Friend WithEvents CheckBoxBorder As CheckBox
    Friend WithEvents NumericUpDownBorder As NumericUpDown
    Friend WithEvents ButtonBorderColor As Button
    Friend WithEvents ComboBoxLabelPos As ComboBox
    Friend WithEvents LabelChannelLabelPos As Label
    Friend WithEvents ListBoxFiles As ListBox
    Friend WithEvents CheckBoxDottedXYmode As CheckBox
    Friend WithEvents TimerStatusUpdater As Timer
    Friend WithEvents ButtonLRmeterColor As Button
    Friend WithEvents LabelLRmeterHeight As Label
    Friend WithEvents NumericUpDownLRmeterHeight As NumericUpDown
End Class
