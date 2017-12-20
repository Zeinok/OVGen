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
        Me.TextBoxTimeScale = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'ButtonColor
        '
        Me.ButtonColor.Location = New System.Drawing.Point(11, 57)
        Me.ButtonColor.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonColor.Name = "ButtonColor"
        Me.ButtonColor.Size = New System.Drawing.Size(253, 26)
        Me.ButtonColor.TabIndex = 3
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
        Me.ComboBoxAlgorithm.TabIndex = 4
        '
        'TextBoxTimeScale
        '
        Me.TextBoxTimeScale.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxTimeScale.Location = New System.Drawing.Point(81, 113)
        Me.TextBoxTimeScale.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTimeScale.Name = "TextBoxTimeScale"
        Me.TextBoxTimeScale.Size = New System.Drawing.Size(33, 25)
        Me.TextBoxTimeScale.TabIndex = 6
        '
        'LabelMS
        '
        Me.LabelMS.AutoSize = True
        Me.LabelMS.Location = New System.Drawing.Point(118, 116)
        Me.LabelMS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMS.Name = "LabelMS"
        Me.LabelMS.Size = New System.Drawing.Size(23, 15)
        Me.LabelMS.TabIndex = 7
        Me.LabelMS.Text = "ms"
        '
        'LabelAmplify
        '
        Me.LabelAmplify.AutoSize = True
        Me.LabelAmplify.Location = New System.Drawing.Point(12, 147)
        Me.LabelAmplify.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAmplify.Name = "LabelAmplify"
        Me.LabelAmplify.Size = New System.Drawing.Size(59, 15)
        Me.LabelAmplify.TabIndex = 8
        Me.LabelAmplify.Text = "Amplify:"
        '
        'TextBoxAmplify
        '
        Me.TextBoxAmplify.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBoxAmplify.Location = New System.Drawing.Point(71, 143)
        Me.TextBoxAmplify.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAmplify.Name = "TextBoxAmplify"
        Me.TextBoxAmplify.Size = New System.Drawing.Size(50, 25)
        Me.TextBoxAmplify.TabIndex = 9
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Location = New System.Drawing.Point(125, 147)
        Me.LabelX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(14, 15)
        Me.LabelX.TabIndex = 10
        Me.LabelX.Text = "x"
        '
        'LabelTimeScale
        '
        Me.LabelTimeScale.AutoSize = True
        Me.LabelTimeScale.Location = New System.Drawing.Point(8, 116)
        Me.LabelTimeScale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTimeScale.Name = "LabelTimeScale"
        Me.LabelTimeScale.Size = New System.Drawing.Size(72, 15)
        Me.LabelTimeScale.TabIndex = 5
        Me.LabelTimeScale.Text = "Time scale:"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(110, 197)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 25)
        Me.ButtonOK.TabIndex = 11
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(189, 197)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 25)
        Me.ButtonCancel.TabIndex = 12
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
        Me.ButtonFontColor.TabIndex = 13
        Me.ButtonFontColor.Text = "Color"
        Me.ButtonFontColor.UseVisualStyleBackColor = True
        '
        'LabelAlgorithm
        '
        Me.LabelAlgorithm.AutoSize = True
        Me.LabelAlgorithm.Location = New System.Drawing.Point(8, 90)
        Me.LabelAlgorithm.Name = "LabelAlgorithm"
        Me.LabelAlgorithm.Size = New System.Drawing.Size(70, 15)
        Me.LabelAlgorithm.TabIndex = 14
        Me.LabelAlgorithm.Text = "Algorithm:"
        '
        'LabelScanTime
        '
        Me.LabelScanTime.AutoSize = True
        Me.LabelScanTime.Location = New System.Drawing.Point(8, 175)
        Me.LabelScanTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelScanTime.Name = "LabelScanTime"
        Me.LabelScanTime.Size = New System.Drawing.Size(102, 15)
        Me.LabelScanTime.TabIndex = 15
        Me.LabelScanTime.Text = "Max Scan Time:"
        '
        'RadioButton1x
        '
        Me.RadioButton1x.AutoSize = True
        Me.RadioButton1x.Location = New System.Drawing.Point(115, 173)
        Me.RadioButton1x.Name = "RadioButton1x"
        Me.RadioButton1x.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton1x.TabIndex = 16
        Me.RadioButton1x.TabStop = True
        Me.RadioButton1x.Text = "1x"
        Me.RadioButton1x.UseVisualStyleBackColor = True
        '
        'RadioButton2x
        '
        Me.RadioButton2x.AutoSize = True
        Me.RadioButton2x.Location = New System.Drawing.Point(163, 173)
        Me.RadioButton2x.Name = "RadioButton2x"
        Me.RadioButton2x.Size = New System.Drawing.Size(42, 19)
        Me.RadioButton2x.TabIndex = 17
        Me.RadioButton2x.TabStop = True
        Me.RadioButton2x.Text = "2x"
        Me.RadioButton2x.UseVisualStyleBackColor = True
        '
        'ChannelConfigForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(272, 232)
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
        Me.Controls.Add(Me.TextBoxTimeScale)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonColor As System.Windows.Forms.Button
    Friend WithEvents ComboBoxAlgorithm As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxTimeScale As System.Windows.Forms.TextBox
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
End Class
