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
        Me.GroupBoxRenderingOptions = New System.Windows.Forms.GroupBox()
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
        Me.ButtonSetAll = New System.Windows.Forms.Button()
        Me.ListBoxFiles = New System.Windows.Forms.ListBox()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonMoveDown = New System.Windows.Forms.Button()
        Me.ButtonMoveUp = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonAudio = New System.Windows.Forms.Button()
        Me.CheckBoxVideo = New System.Windows.Forms.CheckBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBoxOutput = New System.Windows.Forms.PictureBox()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelPadding = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelAbout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelPreviewMode = New System.Windows.Forms.Label()
        Me.TimerLabelFlashing = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorkerStdErrReader = New System.ComponentModel.BackgroundWorker()
        Me.GroupBoxFiles = New System.Windows.Forms.GroupBox()
        Me.GroupBoxRenderingOptions.SuspendLayout()
        CType(Me.NumericUpDownLineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFrameRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBoxFiles.SuspendLayout()
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
        'GroupBoxRenderingOptions
        '
        Me.GroupBoxRenderingOptions.Controls.Add(Me.CheckBoxDrawMiddleLine)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.ButtonFlowDirection)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.LabelFlowDirecton)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.CheckBoxGrid)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.LabelCanvasSize)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.ComboBoxCanvasSize)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.CheckBoxCRT)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.NumericUpDownLineWidth)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.CheckBoxNoFileWriting)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.LabelLineWidth)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.NumericUpDownColumn)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.LabelColumn)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.CheckBoxSmooth)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.NumericUpDownFrameRate)
        Me.GroupBoxRenderingOptions.Controls.Add(Me.LabelFrameRate)
        Me.GroupBoxRenderingOptions.Location = New System.Drawing.Point(824, 9)
        Me.GroupBoxRenderingOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxRenderingOptions.Name = "GroupBoxRenderingOptions"
        Me.GroupBoxRenderingOptions.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxRenderingOptions.Size = New System.Drawing.Size(254, 220)
        Me.GroupBoxRenderingOptions.TabIndex = 6
        Me.GroupBoxRenderingOptions.TabStop = False
        Me.GroupBoxRenderingOptions.Text = "Rendering"
        '
        'CheckBoxDrawMiddleLine
        '
        Me.CheckBoxDrawMiddleLine.AutoSize = True
        Me.CheckBoxDrawMiddleLine.Location = New System.Drawing.Point(107, 131)
        Me.CheckBoxDrawMiddleLine.Name = "CheckBoxDrawMiddleLine"
        Me.CheckBoxDrawMiddleLine.Size = New System.Drawing.Size(135, 19)
        Me.CheckBoxDrawMiddleLine.TabIndex = 2
        Me.CheckBoxDrawMiddleLine.Text = "Draw Middle Line"
        Me.CheckBoxDrawMiddleLine.UseVisualStyleBackColor = True
        '
        'ButtonFlowDirection
        '
        Me.ButtonFlowDirection.Location = New System.Drawing.Point(113, 188)
        Me.ButtonFlowDirection.Name = "ButtonFlowDirection"
        Me.ButtonFlowDirection.Size = New System.Drawing.Size(133, 26)
        Me.ButtonFlowDirection.TabIndex = 14
        Me.ButtonFlowDirection.Text = "FlowDirection"
        Me.ButtonFlowDirection.UseVisualStyleBackColor = True
        '
        'LabelFlowDirecton
        '
        Me.LabelFlowDirecton.AutoSize = True
        Me.LabelFlowDirecton.Location = New System.Drawing.Point(9, 194)
        Me.LabelFlowDirecton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFlowDirecton.Name = "LabelFlowDirecton"
        Me.LabelFlowDirecton.Size = New System.Drawing.Size(97, 15)
        Me.LabelFlowDirecton.TabIndex = 13
        Me.LabelFlowDirecton.Text = "Flow Direction:"
        '
        'CheckBoxGrid
        '
        Me.CheckBoxGrid.AutoSize = True
        Me.CheckBoxGrid.Location = New System.Drawing.Point(12, 131)
        Me.CheckBoxGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxGrid.Name = "CheckBoxGrid"
        Me.CheckBoxGrid.Size = New System.Drawing.Size(90, 19)
        Me.CheckBoxGrid.TabIndex = 10
        Me.CheckBoxGrid.Text = "Draw Grid"
        Me.CheckBoxGrid.UseVisualStyleBackColor = True
        '
        'LabelCanvasSize
        '
        Me.LabelCanvasSize.AutoSize = True
        Me.LabelCanvasSize.Location = New System.Drawing.Point(9, 162)
        Me.LabelCanvasSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCanvasSize.Name = "LabelCanvasSize"
        Me.LabelCanvasSize.Size = New System.Drawing.Size(79, 15)
        Me.LabelCanvasSize.TabIndex = 11
        Me.LabelCanvasSize.Text = "Canvas Size:"
        '
        'ComboBoxCanvasSize
        '
        Me.ComboBoxCanvasSize.FormattingEnabled = True
        Me.ComboBoxCanvasSize.Items.AddRange(New Object() {"1280x720", "1920x1080"})
        Me.ComboBoxCanvasSize.Location = New System.Drawing.Point(96, 158)
        Me.ComboBoxCanvasSize.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCanvasSize.Name = "ComboBoxCanvasSize"
        Me.ComboBoxCanvasSize.Size = New System.Drawing.Size(150, 23)
        Me.ComboBoxCanvasSize.TabIndex = 12
        Me.ComboBoxCanvasSize.Text = "1280x720"
        '
        'CheckBoxCRT
        '
        Me.CheckBoxCRT.AutoSize = True
        Me.CheckBoxCRT.Location = New System.Drawing.Point(141, 105)
        Me.CheckBoxCRT.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxCRT.Name = "CheckBoxCRT"
        Me.CheckBoxCRT.Size = New System.Drawing.Size(93, 19)
        Me.CheckBoxCRT.TabIndex = 9
        Me.CheckBoxCRT.Text = "CRT  Style"
        Me.CheckBoxCRT.UseVisualStyleBackColor = True
        '
        'NumericUpDownLineWidth
        '
        Me.NumericUpDownLineWidth.Location = New System.Drawing.Point(88, 103)
        Me.NumericUpDownLineWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownLineWidth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownLineWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownLineWidth.Name = "NumericUpDownLineWidth"
        Me.NumericUpDownLineWidth.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownLineWidth.TabIndex = 8
        Me.NumericUpDownLineWidth.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'CheckBoxNoFileWriting
        '
        Me.CheckBoxNoFileWriting.AutoSize = True
        Me.CheckBoxNoFileWriting.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBoxNoFileWriting.Checked = True
        Me.CheckBoxNoFileWriting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxNoFileWriting.Location = New System.Drawing.Point(11, 22)
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
        Me.LabelLineWidth.Location = New System.Drawing.Point(8, 105)
        Me.LabelLineWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLineWidth.Name = "LabelLineWidth"
        Me.LabelLineWidth.Size = New System.Drawing.Size(76, 15)
        Me.LabelLineWidth.TabIndex = 7
        Me.LabelLineWidth.Text = "Line Width:"
        '
        'NumericUpDownColumn
        '
        Me.NumericUpDownColumn.Location = New System.Drawing.Point(198, 74)
        Me.NumericUpDownColumn.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownColumn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownColumn.Name = "NumericUpDownColumn"
        Me.NumericUpDownColumn.Size = New System.Drawing.Size(48, 25)
        Me.NumericUpDownColumn.TabIndex = 6
        Me.ToolTips.SetToolTip(Me.NumericUpDownColumn, "Change column count")
        Me.NumericUpDownColumn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelColumn
        '
        Me.LabelColumn.AutoSize = True
        Me.LabelColumn.Location = New System.Drawing.Point(132, 76)
        Me.LabelColumn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelColumn.Name = "LabelColumn"
        Me.LabelColumn.Size = New System.Drawing.Size(61, 15)
        Me.LabelColumn.TabIndex = 5
        Me.LabelColumn.Text = "Columns:"
        '
        'CheckBoxSmooth
        '
        Me.CheckBoxSmooth.AutoSize = True
        Me.CheckBoxSmooth.Location = New System.Drawing.Point(11, 48)
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
        Me.NumericUpDownFrameRate.Location = New System.Drawing.Point(80, 74)
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
        Me.LabelFrameRate.Location = New System.Drawing.Point(8, 76)
        Me.LabelFrameRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFrameRate.Name = "LabelFrameRate"
        Me.LabelFrameRate.Size = New System.Drawing.Size(68, 15)
        Me.LabelFrameRate.TabIndex = 3
        Me.LabelFrameRate.Text = "Framerate:"
        '
        'LinkLabelCustomCommandLine
        '
        Me.LinkLabelCustomCommandLine.AutoSize = True
        Me.LinkLabelCustomCommandLine.Location = New System.Drawing.Point(121, 22)
        Me.LinkLabelCustomCommandLine.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelCustomCommandLine.Name = "LinkLabelCustomCommandLine"
        Me.LinkLabelCustomCommandLine.Size = New System.Drawing.Size(111, 15)
        Me.LinkLabelCustomCommandLine.TabIndex = 1
        Me.LinkLabelCustomCommandLine.TabStop = True
        Me.LinkLabelCustomCommandLine.Text = "Edit commandline"
        '
        'ButtonSetAll
        '
        Me.ButtonSetAll.Location = New System.Drawing.Point(173, 271)
        Me.ButtonSetAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSetAll.Name = "ButtonSetAll"
        Me.ButtonSetAll.Size = New System.Drawing.Size(78, 30)
        Me.ButtonSetAll.TabIndex = 9
        Me.ButtonSetAll.Text = "Set All"
        Me.ButtonSetAll.UseVisualStyleBackColor = True
        '
        'ListBoxFiles
        '
        Me.ListBoxFiles.FormattingEnabled = True
        Me.ListBoxFiles.HorizontalScrollbar = True
        Me.ListBoxFiles.ItemHeight = 15
        Me.ListBoxFiles.Location = New System.Drawing.Point(5, 70)
        Me.ListBoxFiles.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxFiles.Name = "ListBoxFiles"
        Me.ListBoxFiles.Size = New System.Drawing.Size(243, 199)
        Me.ListBoxFiles.TabIndex = 3
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Image = Global.OVG.My.Resources.Resources.gear_16xLG
        Me.ButtonOptions.Location = New System.Drawing.Point(140, 271)
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
        Me.ButtonMoveDown.Location = New System.Drawing.Point(106, 271)
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
        Me.ButtonMoveUp.Location = New System.Drawing.Point(72, 271)
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
        Me.ButtonRemove.Location = New System.Drawing.Point(39, 271)
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
        Me.ButtonAdd.Location = New System.Drawing.Point(5, 271)
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
        Me.ButtonAudio.Location = New System.Drawing.Point(5, 44)
        Me.ButtonAudio.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAudio.Name = "ButtonAudio"
        Me.ButtonAudio.Size = New System.Drawing.Size(242, 22)
        Me.ButtonAudio.TabIndex = 2
        Me.ButtonAudio.Text = "Master Audio"
        Me.ButtonAudio.UseVisualStyleBackColor = True
        '
        'CheckBoxVideo
        '
        Me.CheckBoxVideo.AutoSize = True
        Me.CheckBoxVideo.Location = New System.Drawing.Point(10, 21)
        Me.CheckBoxVideo.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxVideo.Name = "CheckBoxVideo"
        Me.CheckBoxVideo.Size = New System.Drawing.Size(103, 19)
        Me.CheckBoxVideo.TabIndex = 0
        Me.CheckBoxVideo.Text = "Output video"
        Me.ToolTips.SetToolTip(Me.CheckBoxVideo, "Auto convert frames to video after finished." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requires FFmpeg.")
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
        'TextBoxLog
        '
        Me.TextBoxLog.Location = New System.Drawing.Point(18, 541)
        Me.TextBoxLog.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.ReadOnly = True
        Me.TextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxLog.Size = New System.Drawing.Size(1060, 92)
        Me.TextBoxLog.TabIndex = 8
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
        Me.StatusStrip1.TabIndex = 9
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
        'GroupBoxFiles
        '
        Me.GroupBoxFiles.Controls.Add(Me.ButtonAudio)
        Me.GroupBoxFiles.Controls.Add(Me.CheckBoxVideo)
        Me.GroupBoxFiles.Controls.Add(Me.LinkLabelCustomCommandLine)
        Me.GroupBoxFiles.Controls.Add(Me.ListBoxFiles)
        Me.GroupBoxFiles.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxFiles.Controls.Add(Me.ButtonRemove)
        Me.GroupBoxFiles.Controls.Add(Me.ButtonSetAll)
        Me.GroupBoxFiles.Controls.Add(Me.ButtonMoveUp)
        Me.GroupBoxFiles.Controls.Add(Me.ButtonMoveDown)
        Me.GroupBoxFiles.Controls.Add(Me.ButtonOptions)
        Me.GroupBoxFiles.Location = New System.Drawing.Point(825, 234)
        Me.GroupBoxFiles.Name = "GroupBoxFiles"
        Me.GroupBoxFiles.Size = New System.Drawing.Size(253, 305)
        Me.GroupBoxFiles.TabIndex = 7
        Me.GroupBoxFiles.TabStop = False
        Me.GroupBoxFiles.Text = "Files"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1098, 665)
        Me.Controls.Add(Me.GroupBoxFiles)
        Me.Controls.Add(Me.CheckBoxShowOutput)
        Me.Controls.Add(Me.TextBoxLog)
        Me.Controls.Add(Me.LabelPreviewMode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBoxRenderingOptions)
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
        Me.GroupBoxRenderingOptions.ResumeLayout(False)
        Me.GroupBoxRenderingOptions.PerformLayout()
        CType(Me.NumericUpDownLineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFrameRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBoxFiles.ResumeLayout(False)
        Me.GroupBoxFiles.PerformLayout()
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
    Friend WithEvents GroupBoxRenderingOptions As System.Windows.Forms.GroupBox
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
    Friend WithEvents GroupBoxFiles As GroupBox
End Class
