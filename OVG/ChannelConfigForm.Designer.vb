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
        Me.SuspendLayout()
        '
        'ButtonColor
        '
        Me.ButtonColor.Location = New System.Drawing.Point(9, 10)
        Me.ButtonColor.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonColor.Name = "ButtonColor"
        Me.ButtonColor.Size = New System.Drawing.Size(144, 23)
        Me.ButtonColor.TabIndex = 0
        Me.ButtonColor.Text = "Set Color"
        Me.ButtonColor.UseVisualStyleBackColor = True
        '
        'ComboBoxAlgorithm
        '
        Me.ComboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAlgorithm.FormattingEnabled = True
        Me.ComboBoxAlgorithm.Items.AddRange(New Object() {"Zero-Crossing", "Peak Speed", "Postive Length", "Auto Trigger"})
        Me.ComboBoxAlgorithm.Location = New System.Drawing.Point(9, 37)
        Me.ComboBoxAlgorithm.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxAlgorithm.Name = "ComboBoxAlgorithm"
        Me.ComboBoxAlgorithm.Size = New System.Drawing.Size(144, 23)
        Me.ComboBoxAlgorithm.TabIndex = 1
        '
        'TextBoxTimeScale
        '
        Me.TextBoxTimeScale.Location = New System.Drawing.Point(85, 64)
        Me.TextBoxTimeScale.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTimeScale.Name = "TextBoxTimeScale"
        Me.TextBoxTimeScale.Size = New System.Drawing.Size(33, 25)
        Me.TextBoxTimeScale.TabIndex = 3
        '
        'LabelMS
        '
        Me.LabelMS.AutoSize = True
        Me.LabelMS.Location = New System.Drawing.Point(131, 66)
        Me.LabelMS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMS.Name = "LabelMS"
        Me.LabelMS.Size = New System.Drawing.Size(23, 15)
        Me.LabelMS.TabIndex = 4
        Me.LabelMS.Text = "ms"
        '
        'LabelAmplify
        '
        Me.LabelAmplify.AutoSize = True
        Me.LabelAmplify.Location = New System.Drawing.Point(9, 91)
        Me.LabelAmplify.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAmplify.Name = "LabelAmplify"
        Me.LabelAmplify.Size = New System.Drawing.Size(59, 15)
        Me.LabelAmplify.TabIndex = 5
        Me.LabelAmplify.Text = "Amplify:"
        '
        'TextBoxAmplify
        '
        Me.TextBoxAmplify.Location = New System.Drawing.Point(71, 91)
        Me.TextBoxAmplify.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAmplify.Name = "TextBoxAmplify"
        Me.TextBoxAmplify.Size = New System.Drawing.Size(50, 25)
        Me.TextBoxAmplify.TabIndex = 6
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Location = New System.Drawing.Point(125, 94)
        Me.LabelX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(14, 15)
        Me.LabelX.TabIndex = 7
        Me.LabelX.Text = "x"
        '
        'LabelTimeScale
        '
        Me.LabelTimeScale.AutoSize = True
        Me.LabelTimeScale.Location = New System.Drawing.Point(9, 66)
        Me.LabelTimeScale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTimeScale.Name = "LabelTimeScale"
        Me.LabelTimeScale.Size = New System.Drawing.Size(72, 15)
        Me.LabelTimeScale.TabIndex = 2
        Me.LabelTimeScale.Text = "Time scale:"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(38, 120)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(56, 25)
        Me.ButtonOK.TabIndex = 9
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(98, 120)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(56, 25)
        Me.ButtonCancel.TabIndex = 10
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ChannelConfigForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(164, 155)
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
End Class
