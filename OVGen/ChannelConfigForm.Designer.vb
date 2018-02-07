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
        Me.ComboBoxAlgorithm.Location = New System.Drawing.Point(84, 87)
        Me.ComboBoxAlgorithm.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxAlgorithm.Name = "ComboBoxAlgorithm"
        Me.ComboBoxAlgorithm.Size = New System.Drawing.Size(180, 23)
        Me.ComboBoxAlgorithm.TabIndex = 6
        '
        'TextBoxHorizontalTime
        '
        Me.TextBoxHorizontalTime.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxHorizontalTime.Location = New System.Drawing.Point(112, 113)
        Me.TextBoxHorizontalTime.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHorizontalTime.Name = "TextBoxHorizontalTime"
        Me.TextBoxHorizontalTime.Size = New System.Drawing.Size(33, 25)
        Me.TextBoxHorizontalTime.TabIndex = 8
        '
        'LabelMS
        '
        Me.LabelMS.AutoSize = True
        Me.LabelMS.Location = New System.Drawing.Point(149, 116)
        Me.LabelMS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMS.Name = "LabelMS"
        Me.LabelMS.Size = New System.Drawing.Size(23, 15)
        Me.LabelMS.TabIndex = 9
        Me.LabelMS.Text = "ms"
        '
        'LabelAmplify
        '
        Me.LabelAmplify.AutoSize = True
        Me.LabelAmplify.Location = New System.Drawing.Point(9, 209)
        Me.LabelAmplify.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAmplify.Name = "LabelAmplify"
        Me.LabelAmplify.Size = New System.Drawing.Size(59, 15)
        Me.LabelAmplify.TabIndex = 10
        Me.LabelAmplify.Text = "Amplify:"
        '
        'TextBoxAmplify
        '
        Me.TextBoxAmplify.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxAmplify.Location = New System.Drawing.Point(71, 205)
        Me.TextBoxAmplify.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAmplify.Name = "TextBoxAmplify"
        Me.TextBoxAmplify.Size = New System.Drawing.Size(50, 25)
        Me.TextBoxAmplify.TabIndex = 11
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Location = New System.Drawing.Point(125, 209)
        Me.LabelX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(14, 15)
        Me.LabelX.TabIndex = 12
        Me.LabelX.Text = "x"
        '
        'LabelTimeScale
        '
        Me.LabelTimeScale.AutoSize = True
        Me.LabelTimeScale.Location = New System.Drawing.Point(8, 116)
        Me.LabelTimeScale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTimeScale.Name = "LabelTimeScale"
        Me.LabelTimeScale.Size = New System.Drawing.Size(100, 15)
        Me.LabelTimeScale.TabIndex = 7
        Me.LabelTimeScale.Text = "Horizontal time:"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(106, 290)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 25)
        Me.ButtonOK.TabIndex = 19
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(185, 290)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 25)
        Me.ButtonCancel.TabIndex = 20
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
        Me.LabelAlgorithm.Location = New System.Drawing.Point(8, 90)
        Me.LabelAlgorithm.Name = "LabelAlgorithm"
        Me.LabelAlgorithm.Size = New System.Drawing.Size(70, 15)
        Me.LabelAlgorithm.TabIndex = 5
        Me.LabelAlgorithm.Text = "Algorithm:"
        '
        'LabelScanTime
        '
        Me.LabelScanTime.AutoSize = True
        Me.LabelScanTime.Location = New System.Drawing.Point(8, 237)
        Me.LabelScanTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelScanTime.Name = "LabelScanTime"
        Me.LabelScanTime.Size = New System.Drawing.Size(102, 15)
        Me.LabelScanTime.TabIndex = 13
        Me.LabelScanTime.Text = "Max Scan Time:"
        '
        'RadioButton1x
        '
        Me.RadioButton1x.AutoSize = True
        Me.RadioButton1x.Location = New System.Drawing.Point(115, 235)
        Me.RadioButton1x.Name = "RadioButton1x"
        Me.RadioButton1x.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton1x.TabIndex = 14
        Me.RadioButton1x.TabStop = True
        Me.RadioButton1x.Text = "1x"
        Me.RadioButton1x.UseVisualStyleBackColor = True
        '
        'RadioButton2x
        '
        Me.RadioButton2x.AutoSize = True
        Me.RadioButton2x.Location = New System.Drawing.Point(222, 235)
        Me.RadioButton2x.Name = "RadioButton2x"
        Me.RadioButton2x.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton2x.TabIndex = 15
        Me.RadioButton2x.TabStop = True
        Me.RadioButton2x.Text = "2x"
        Me.RadioButton2x.UseVisualStyleBackColor = True
        '
        'CheckBoxMixAudioChannel
        '
        Me.CheckBoxMixAudioChannel.AutoSize = True
        Me.CheckBoxMixAudioChannel.Location = New System.Drawing.Point(174, 262)
        Me.CheckBoxMixAudioChannel.Name = "CheckBoxMixAudioChannel"
        Me.CheckBoxMixAudioChannel.Size = New System.Drawing.Size(90, 19)
        Me.CheckBoxMixAudioChannel.TabIndex = 18
        Me.CheckBoxMixAudioChannel.Text = "Mix stereo"
        Me.CheckBoxMixAudioChannel.UseVisualStyleBackColor = True
        '
        'LabelAudioChannel
        '
        Me.LabelAudioChannel.AutoSize = True
        Me.LabelAudioChannel.Location = New System.Drawing.Point(8, 263)
        Me.LabelAudioChannel.Name = "LabelAudioChannel"
        Me.LabelAudioChannel.Size = New System.Drawing.Size(93, 15)
        Me.LabelAudioChannel.TabIndex = 16
        Me.LabelAudioChannel.Text = "Audio channel:"
        '
        'NumericUpDownAudioChannel
        '
        Me.NumericUpDownAudioChannel.Location = New System.Drawing.Point(107, 261)
        Me.NumericUpDownAudioChannel.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownAudioChannel.Name = "NumericUpDownAudioChannel"
        Me.NumericUpDownAudioChannel.Size = New System.Drawing.Size(61, 25)
        Me.NumericUpDownAudioChannel.TabIndex = 21
        '
        'RadioButton1dot5x
        '
        Me.RadioButton1dot5x.AutoSize = True
        Me.RadioButton1dot5x.Location = New System.Drawing.Point(163, 235)
        Me.RadioButton1dot5x.Name = "RadioButton1dot5x"
        Me.RadioButton1dot5x.Size = New System.Drawing.Size(53, 19)
        Me.RadioButton1dot5x.TabIndex = 22
        Me.RadioButton1dot5x.TabStop = True
        Me.RadioButton1dot5x.Text = "1.5x"
        Me.RadioButton1dot5x.UseVisualStyleBackColor = True
        '
        'LabelTriggerLevel
        '
        Me.LabelTriggerLevel.AutoSize = True
        Me.LabelTriggerLevel.Location = New System.Drawing.Point(8, 146)
        Me.LabelTriggerLevel.Name = "LabelTriggerLevel"
        Me.LabelTriggerLevel.Size = New System.Drawing.Size(85, 15)
        Me.LabelTriggerLevel.TabIndex = 23
        Me.LabelTriggerLevel.Text = "Trigger level:"
        '
        'NumericUpDownTriggerLevel
        '
        Me.NumericUpDownTriggerLevel.Location = New System.Drawing.Point(99, 143)
        Me.NumericUpDownTriggerLevel.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.NumericUpDownTriggerLevel.Minimum = New Decimal(New Integer() {128, 0, 0, -2147483648})
        Me.NumericUpDownTriggerLevel.Name = "NumericUpDownTriggerLevel"
        Me.NumericUpDownTriggerLevel.Size = New System.Drawing.Size(60, 25)
        Me.NumericUpDownTriggerLevel.TabIndex = 24
        '
        'CheckBoxExternalTrigger
        '
        Me.CheckBoxExternalTrigger.AutoSize = True
        Me.CheckBoxExternalTrigger.Location = New System.Drawing.Point(12, 177)
        Me.CheckBoxExternalTrigger.Name = "CheckBoxExternalTrigger"
        Me.CheckBoxExternalTrigger.Size = New System.Drawing.Size(90, 19)
        Me.CheckBoxExternalTrigger.TabIndex = 26
        Me.CheckBoxExternalTrigger.Text = "Ext. Trig.:"
        Me.CheckBoxExternalTrigger.UseVisualStyleBackColor = True
        '
        'ButtonExternalTrigger
        '
        Me.ButtonExternalTrigger.Location = New System.Drawing.Point(104, 175)
        Me.ButtonExternalTrigger.Name = "ButtonExternalTrigger"
        Me.ButtonExternalTrigger.Size = New System.Drawing.Size(156, 23)
        Me.ButtonExternalTrigger.TabIndex = 27
        Me.ButtonExternalTrigger.Text = "(None)"
        Me.ButtonExternalTrigger.UseVisualStyleBackColor = True
        '
        'ChannelConfigForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(272, 371)
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
End Class
