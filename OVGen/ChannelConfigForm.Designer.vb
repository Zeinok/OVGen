<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChannelConfigForm
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
        Me.ButtonColor = New System.Windows.Forms.Button()
        Me.ComboBoxAlgorithm = New System.Windows.Forms.ComboBox()
        Me.TextBoxHorizontalTime = New System.Windows.Forms.TextBox()
        Me.LabelMS = New System.Windows.Forms.Label()
        Me.LabelAmplify = New System.Windows.Forms.Label()
        Me.TextBoxAmplify = New System.Windows.Forms.TextBox()
        Me.LabelX = New System.Windows.Forms.Label()
        Me.LabelTimeScale = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextBoxLabel = New System.Windows.Forms.TextBox()
        Me.ButtonFont = New System.Windows.Forms.Button()
        Me.LabelChannelLabel = New System.Windows.Forms.Label()
        Me.ButtonFontColor = New System.Windows.Forms.Button()
        Me.LabelAlgorithm = New System.Windows.Forms.Label()
        Me.LabelScanTime = New System.Windows.Forms.Label()
        Me.RadioButton1x = New System.Windows.Forms.RadioButton()
        Me.RadioButton2x = New System.Windows.Forms.RadioButton()
        Me.CheckBoxMixAudioChannel = New System.Windows.Forms.CheckBox()
        Me.LabelAudioChannel = New System.Windows.Forms.Label()
        Me.NumericUpDownAudioChannel = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton1dot5x = New System.Windows.Forms.RadioButton()
        Me.LabelTriggerLevel = New System.Windows.Forms.Label()
        Me.NumericUpDownTriggerLevel = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxExternalTrigger = New System.Windows.Forms.CheckBox()
        Me.ButtonExternalTrigger = New System.Windows.Forms.Button()
        Me.CheckBoxPulseWidthModulatedColor = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAutoTriggerLevel = New System.Windows.Forms.CheckBox()
        Me.ButtonAutoAmplify = New System.Windows.Forms.Button()
        Me.LabelScanPhase = New System.Windows.Forms.Label()
        Me.ComboBoxScanPhase = New System.Windows.Forms.ComboBox()
        Me.CheckBoxXYmode = New System.Windows.Forms.CheckBox()
        Me.CheckBoxXYaspectRatio = New System.Windows.Forms.CheckBox()
        CType(Me.NumericUpDownAudioChannel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTriggerLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonColor
        '
        Me.ButtonColor.Location = New System.Drawing.Point(11, 57)
        Me.ButtonColor.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonColor.Name = "ButtonColor"
        Me.ButtonColor.Size = New System.Drawing.Size(253, 26)
        Me.ButtonColor.TabIndex = 4
        Me.ButtonColor.Text = "Set Wave Color"
        Me.ButtonColor.UseVisualStyleBackColor = True
        '
        'ComboBoxAlgorithm
        '
        Me.ComboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAlgorithm.FormattingEnabled = True
        Me.ComboBoxAlgorithm.Location = New System.Drawing.Point(81, 112)
        Me.ComboBoxAlgorithm.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxAlgorithm.Name = "ComboBoxAlgorithm"
        Me.ComboBoxAlgorithm.Size = New System.Drawing.Size(183, 23)
        Me.ComboBoxAlgorithm.TabIndex = 7
        '
        'TextBoxHorizontalTime
        '
        Me.TextBoxHorizontalTime.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxHorizontalTime.Location = New System.Drawing.Point(109, 168)
        Me.TextBoxHorizontalTime.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHorizontalTime.Name = "TextBoxHorizontalTime"
        Me.TextBoxHorizontalTime.Size = New System.Drawing.Size(33, 25)
        Me.TextBoxHorizontalTime.TabIndex = 11
        '
        'LabelMS
        '
        Me.LabelMS.AutoSize = True
        Me.LabelMS.Location = New System.Drawing.Point(146, 171)
        Me.LabelMS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMS.Name = "LabelMS"
        Me.LabelMS.Size = New System.Drawing.Size(23, 15)
        Me.LabelMS.TabIndex = 12
        Me.LabelMS.Text = "ms"
        '
        'LabelAmplify
        '
        Me.LabelAmplify.AutoSize = True
        Me.LabelAmplify.Location = New System.Drawing.Point(6, 264)
        Me.LabelAmplify.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAmplify.Name = "LabelAmplify"
        Me.LabelAmplify.Size = New System.Drawing.Size(59, 15)
        Me.LabelAmplify.TabIndex = 18
        Me.LabelAmplify.Text = "Amplify:"
        '
        'TextBoxAmplify
        '
        Me.TextBoxAmplify.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxAmplify.Location = New System.Drawing.Point(68, 260)
        Me.TextBoxAmplify.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAmplify.Name = "TextBoxAmplify"
        Me.TextBoxAmplify.Size = New System.Drawing.Size(50, 25)
        Me.TextBoxAmplify.TabIndex = 19
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Location = New System.Drawing.Point(122, 264)
        Me.LabelX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(14, 15)
        Me.LabelX.TabIndex = 20
        Me.LabelX.Text = "x"
        '
        'LabelTimeScale
        '
        Me.LabelTimeScale.AutoSize = True
        Me.LabelTimeScale.Location = New System.Drawing.Point(5, 171)
        Me.LabelTimeScale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTimeScale.Name = "LabelTimeScale"
        Me.LabelTimeScale.Size = New System.Drawing.Size(100, 15)
        Me.LabelTimeScale.TabIndex = 10
        Me.LabelTimeScale.Text = "Horizontal time:"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(110, 373)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 25)
        Me.ButtonOK.TabIndex = 29
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(189, 373)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 25)
        Me.ButtonCancel.TabIndex = 30
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'TextBoxLabel
        '
        Me.TextBoxLabel.Location = New System.Drawing.Point(12, 27)
        Me.TextBoxLabel.Name = "TextBoxLabel"
        Me.TextBoxLabel.Size = New System.Drawing.Size(140, 25)
        Me.TextBoxLabel.TabIndex = 1
        '
        'ButtonFont
        '
        Me.ButtonFont.Location = New System.Drawing.Point(158, 24)
        Me.ButtonFont.Name = "ButtonFont"
        Me.ButtonFont.Size = New System.Drawing.Size(50, 25)
        Me.ButtonFont.TabIndex = 2
        Me.ButtonFont.Text = "Font"
        Me.ButtonFont.UseVisualStyleBackColor = True
        '
        'LabelChannelLabel
        '
        Me.LabelChannelLabel.AutoSize = True
        Me.LabelChannelLabel.Location = New System.Drawing.Point(12, 9)
        Me.LabelChannelLabel.Name = "LabelChannelLabel"
        Me.LabelChannelLabel.Size = New System.Drawing.Size(93, 15)
        Me.LabelChannelLabel.TabIndex = 0
        Me.LabelChannelLabel.Text = "Channel Label:"
        '
        'ButtonFontColor
        '
        Me.ButtonFontColor.Location = New System.Drawing.Point(214, 24)
        Me.ButtonFontColor.Name = "ButtonFontColor"
        Me.ButtonFontColor.Size = New System.Drawing.Size(50, 25)
        Me.ButtonFontColor.TabIndex = 3
        Me.ButtonFontColor.Text = "Color"
        Me.ButtonFontColor.UseVisualStyleBackColor = True
        '
        'LabelAlgorithm
        '
        Me.LabelAlgorithm.AutoSize = True
        Me.LabelAlgorithm.Location = New System.Drawing.Point(5, 115)
        Me.LabelAlgorithm.Name = "LabelAlgorithm"
        Me.LabelAlgorithm.Size = New System.Drawing.Size(70, 15)
        Me.LabelAlgorithm.TabIndex = 6
        Me.LabelAlgorithm.Text = "Algorithm:"
        '
        'LabelScanTime
        '
        Me.LabelScanTime.AutoSize = True
        Me.LabelScanTime.Location = New System.Drawing.Point(5, 292)
        Me.LabelScanTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelScanTime.Name = "LabelScanTime"
        Me.LabelScanTime.Size = New System.Drawing.Size(102, 15)
        Me.LabelScanTime.TabIndex = 22
        Me.LabelScanTime.Text = "Max Scan Time:"
        '
        'RadioButton1x
        '
        Me.RadioButton1x.AutoSize = True
        Me.RadioButton1x.Location = New System.Drawing.Point(112, 290)
        Me.RadioButton1x.Name = "RadioButton1x"
        Me.RadioButton1x.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton1x.TabIndex = 23
        Me.RadioButton1x.TabStop = True
        Me.RadioButton1x.Text = "1x"
        Me.RadioButton1x.UseVisualStyleBackColor = True
        '
        'RadioButton2x
        '
        Me.RadioButton2x.AutoSize = True
        Me.RadioButton2x.Location = New System.Drawing.Point(219, 290)
        Me.RadioButton2x.Name = "RadioButton2x"
        Me.RadioButton2x.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton2x.TabIndex = 25
        Me.RadioButton2x.TabStop = True
        Me.RadioButton2x.Text = "2x"
        Me.RadioButton2x.UseVisualStyleBackColor = True
        '
        'CheckBoxMixAudioChannel
        '
        Me.CheckBoxMixAudioChannel.AutoSize = True
        Me.CheckBoxMixAudioChannel.Location = New System.Drawing.Point(171, 317)
        Me.CheckBoxMixAudioChannel.Name = "CheckBoxMixAudioChannel"
        Me.CheckBoxMixAudioChannel.Size = New System.Drawing.Size(90, 19)
        Me.CheckBoxMixAudioChannel.TabIndex = 28
        Me.CheckBoxMixAudioChannel.Text = "Mix stereo"
        Me.CheckBoxMixAudioChannel.UseVisualStyleBackColor = True
        '
        'LabelAudioChannel
        '
        Me.LabelAudioChannel.AutoSize = True
        Me.LabelAudioChannel.Location = New System.Drawing.Point(5, 318)
        Me.LabelAudioChannel.Name = "LabelAudioChannel"
        Me.LabelAudioChannel.Size = New System.Drawing.Size(93, 15)
        Me.LabelAudioChannel.TabIndex = 26
        Me.LabelAudioChannel.Text = "Audio channel:"
        '
        'NumericUpDownAudioChannel
        '
        Me.NumericUpDownAudioChannel.Location = New System.Drawing.Point(104, 316)
        Me.NumericUpDownAudioChannel.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownAudioChannel.Name = "NumericUpDownAudioChannel"
        Me.NumericUpDownAudioChannel.Size = New System.Drawing.Size(61, 25)
        Me.NumericUpDownAudioChannel.TabIndex = 27
        '
        'RadioButton1dot5x
        '
        Me.RadioButton1dot5x.AutoSize = True
        Me.RadioButton1dot5x.Location = New System.Drawing.Point(160, 290)
        Me.RadioButton1dot5x.Name = "RadioButton1dot5x"
        Me.RadioButton1dot5x.Size = New System.Drawing.Size(53, 19)
        Me.RadioButton1dot5x.TabIndex = 24
        Me.RadioButton1dot5x.TabStop = True
        Me.RadioButton1dot5x.Text = "1.5x"
        Me.RadioButton1dot5x.UseVisualStyleBackColor = True
        '
        'LabelTriggerLevel
        '
        Me.LabelTriggerLevel.AutoSize = True
        Me.LabelTriggerLevel.Location = New System.Drawing.Point(5, 201)
        Me.LabelTriggerLevel.Name = "LabelTriggerLevel"
        Me.LabelTriggerLevel.Size = New System.Drawing.Size(85, 15)
        Me.LabelTriggerLevel.TabIndex = 13
        Me.LabelTriggerLevel.Text = "Trigger level:"
        '
        'NumericUpDownTriggerLevel
        '
        Me.NumericUpDownTriggerLevel.Location = New System.Drawing.Point(96, 198)
        Me.NumericUpDownTriggerLevel.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.NumericUpDownTriggerLevel.Minimum = New Decimal(New Integer() {128, 0, 0, -2147483648})
        Me.NumericUpDownTriggerLevel.Name = "NumericUpDownTriggerLevel"
        Me.NumericUpDownTriggerLevel.Size = New System.Drawing.Size(60, 25)
        Me.NumericUpDownTriggerLevel.TabIndex = 14
        '
        'CheckBoxExternalTrigger
        '
        Me.CheckBoxExternalTrigger.AutoSize = True
        Me.CheckBoxExternalTrigger.Location = New System.Drawing.Point(9, 232)
        Me.CheckBoxExternalTrigger.Name = "CheckBoxExternalTrigger"
        Me.CheckBoxExternalTrigger.Size = New System.Drawing.Size(90, 19)
        Me.CheckBoxExternalTrigger.TabIndex = 16
        Me.CheckBoxExternalTrigger.Text = "Ext. Trig.:"
        Me.CheckBoxExternalTrigger.UseVisualStyleBackColor = True
        '
        'ButtonExternalTrigger
        '
        Me.ButtonExternalTrigger.Location = New System.Drawing.Point(101, 230)
        Me.ButtonExternalTrigger.Name = "ButtonExternalTrigger"
        Me.ButtonExternalTrigger.Size = New System.Drawing.Size(156, 23)
        Me.ButtonExternalTrigger.TabIndex = 17
        Me.ButtonExternalTrigger.Text = "(None)"
        Me.ButtonExternalTrigger.UseVisualStyleBackColor = True
        '
        'CheckBoxPulseWidthModulatedColor
        '
        Me.CheckBoxPulseWidthModulatedColor.AutoSize = True
        Me.CheckBoxPulseWidthModulatedColor.Location = New System.Drawing.Point(11, 88)
        Me.CheckBoxPulseWidthModulatedColor.Name = "CheckBoxPulseWidthModulatedColor"
        Me.CheckBoxPulseWidthModulatedColor.Size = New System.Drawing.Size(191, 19)
        Me.CheckBoxPulseWidthModulatedColor.TabIndex = 5
        Me.CheckBoxPulseWidthModulatedColor.Text = "Pulse width modulated color"
        Me.CheckBoxPulseWidthModulatedColor.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoTriggerLevel
        '
        Me.CheckBoxAutoTriggerLevel.AutoSize = True
        Me.CheckBoxAutoTriggerLevel.Location = New System.Drawing.Point(162, 201)
        Me.CheckBoxAutoTriggerLevel.Name = "CheckBoxAutoTriggerLevel"
        Me.CheckBoxAutoTriggerLevel.Size = New System.Drawing.Size(57, 19)
        Me.CheckBoxAutoTriggerLevel.TabIndex = 15
        Me.CheckBoxAutoTriggerLevel.Text = "Auto"
        Me.CheckBoxAutoTriggerLevel.UseVisualStyleBackColor = True
        '
        'ButtonAutoAmplify
        '
        Me.ButtonAutoAmplify.Location = New System.Drawing.Point(141, 260)
        Me.ButtonAutoAmplify.Name = "ButtonAutoAmplify"
        Me.ButtonAutoAmplify.Size = New System.Drawing.Size(60, 25)
        Me.ButtonAutoAmplify.TabIndex = 21
        Me.ButtonAutoAmplify.Text = "Auto"
        Me.ButtonAutoAmplify.UseVisualStyleBackColor = True
        '
        'LabelScanPhase
        '
        Me.LabelScanPhase.AutoSize = True
        Me.LabelScanPhase.Location = New System.Drawing.Point(5, 143)
        Me.LabelScanPhase.Name = "LabelScanPhase"
        Me.LabelScanPhase.Size = New System.Drawing.Size(74, 15)
        Me.LabelScanPhase.TabIndex = 8
        Me.LabelScanPhase.Text = "Scan Phase:"
        '
        'ComboBoxScanPhase
        '
        Me.ComboBoxScanPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxScanPhase.FormattingEnabled = True
        Me.ComboBoxScanPhase.Items.AddRange(New Object() {"Positive", "Negative", "Both"})
        Me.ComboBoxScanPhase.Location = New System.Drawing.Point(81, 140)
        Me.ComboBoxScanPhase.Name = "ComboBoxScanPhase"
        Me.ComboBoxScanPhase.Size = New System.Drawing.Size(97, 23)
        Me.ComboBoxScanPhase.TabIndex = 9
        '
        'CheckBoxXYmode
        '
        Me.CheckBoxXYmode.AutoSize = True
        Me.CheckBoxXYmode.Location = New System.Drawing.Point(8, 347)
        Me.CheckBoxXYmode.Name = "CheckBoxXYmode"
        Me.CheckBoxXYmode.Size = New System.Drawing.Size(84, 19)
        Me.CheckBoxXYmode.TabIndex = 31
        Me.CheckBoxXYmode.Text = "XY mode"
        Me.CheckBoxXYmode.UseVisualStyleBackColor = True
        '
        'CheckBoxXYaspectRatio
        '
        Me.CheckBoxXYaspectRatio.AutoSize = True
        Me.CheckBoxXYaspectRatio.Checked = True
        Me.CheckBoxXYaspectRatio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxXYaspectRatio.Location = New System.Drawing.Point(98, 347)
        Me.CheckBoxXYaspectRatio.Name = "CheckBoxXYaspectRatio"
        Me.CheckBoxXYaspectRatio.Size = New System.Drawing.Size(174, 19)
        Me.CheckBoxXYaspectRatio.TabIndex = 32
        Me.CheckBoxXYaspectRatio.Text = "XY mode 1:1 aspect ratio"
        Me.CheckBoxXYaspectRatio.UseVisualStyleBackColor = True
        '
        'ChannelConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(272, 409)
        Me.Controls.Add(Me.CheckBoxXYaspectRatio)
        Me.Controls.Add(Me.CheckBoxXYmode)
        Me.Controls.Add(Me.ComboBoxScanPhase)
        Me.Controls.Add(Me.LabelScanPhase)
        Me.Controls.Add(Me.ButtonAutoAmplify)
        Me.Controls.Add(Me.CheckBoxAutoTriggerLevel)
        Me.Controls.Add(Me.CheckBoxPulseWidthModulatedColor)
        Me.Controls.Add(Me.ButtonExternalTrigger)
        Me.Controls.Add(Me.CheckBoxExternalTrigger)
        Me.Controls.Add(Me.NumericUpDownTriggerLevel)
        Me.Controls.Add(Me.LabelTriggerLevel)
        Me.Controls.Add(Me.RadioButton1dot5x)
        Me.Controls.Add(Me.NumericUpDownAudioChannel)
        Me.Controls.Add(Me.LabelAudioChannel)
        Me.Controls.Add(Me.CheckBoxMixAudioChannel)
        Me.Controls.Add(Me.RadioButton2x)
        Me.Controls.Add(Me.RadioButton1x)
        Me.Controls.Add(Me.LabelScanTime)
        Me.Controls.Add(Me.LabelAlgorithm)
        Me.Controls.Add(Me.ButtonFontColor)
        Me.Controls.Add(Me.LabelChannelLabel)
        Me.Controls.Add(Me.ButtonFont)
        Me.Controls.Add(Me.TextBoxLabel)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelTimeScale)
        Me.Controls.Add(Me.LabelX)
        Me.Controls.Add(Me.TextBoxAmplify)
        Me.Controls.Add(Me.LabelAmplify)
        Me.Controls.Add(Me.LabelMS)
        Me.Controls.Add(Me.TextBoxHorizontalTime)
        Me.Controls.Add(Me.ComboBoxAlgorithm)
        Me.Controls.Add(Me.ButtonColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChannelConfigForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Channel config"
        CType(Me.NumericUpDownAudioChannel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTriggerLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonColor As System.Windows.Forms.Button
    Friend WithEvents ComboBoxAlgorithm As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxHorizontalTime As System.Windows.Forms.TextBox
    Friend WithEvents LabelMS As System.Windows.Forms.Label
    Friend WithEvents LabelAmplify As System.Windows.Forms.Label
    Friend WithEvents TextBoxAmplify As System.Windows.Forms.TextBox
    Friend WithEvents LabelX As System.Windows.Forms.Label
    Friend WithEvents LabelTimeScale As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxLabel As TextBox
    Friend WithEvents ButtonFont As Button
    Friend WithEvents LabelChannelLabel As Label
    Friend WithEvents ButtonFontColor As Button
    Friend WithEvents LabelAlgorithm As Label
    Friend WithEvents LabelScanTime As Label
    Friend WithEvents RadioButton1x As RadioButton
    Friend WithEvents RadioButton2x As RadioButton
    Friend WithEvents CheckBoxMixAudioChannel As CheckBox
    Friend WithEvents LabelAudioChannel As Label
    Friend WithEvents NumericUpDownAudioChannel As NumericUpDown
    Friend WithEvents RadioButton1dot5x As RadioButton
    Friend WithEvents LabelTriggerLevel As Label
    Friend WithEvents NumericUpDownTriggerLevel As NumericUpDown
    Friend WithEvents CheckBoxExternalTrigger As CheckBox
    Friend WithEvents ButtonExternalTrigger As Button
    Friend WithEvents CheckBoxPulseWidthModulatedColor As CheckBox
    Friend WithEvents CheckBoxAutoTriggerLevel As CheckBox
    Friend WithEvents ButtonAutoAmplify As Button
    Friend WithEvents LabelScanPhase As Label
    Friend WithEvents ComboBoxScanPhase As ComboBox
    Friend WithEvents CheckBoxXYmode As CheckBox
    Friend WithEvents CheckBoxXYaspectRatio As CheckBox
End Class
