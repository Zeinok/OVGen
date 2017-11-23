<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomCommandLineForm
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
        Me.LabelWithAudio = New System.Windows.Forms.Label()
        Me.TextBoxJoinAudioCommandLine = New System.Windows.Forms.TextBox()
        Me.LabelWithoutAudio = New System.Windows.Forms.Label()
        Me.TextBoxSilenceCommandLine = New System.Windows.Forms.TextBox()
        Me.LabelVariables = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.LabelFFmpeg1 = New System.Windows.Forms.Label()
        Me.LabelFFmpeg2 = New System.Windows.Forms.Label()
        Me.ButtonDefault = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelWithAudio
        '
        Me.LabelWithAudio.AutoSize = True
        Me.LabelWithAudio.Location = New System.Drawing.Point(11, 9)
        Me.LabelWithAudio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWithAudio.Name = "LabelWithAudio"
        Me.LabelWithAudio.Size = New System.Drawing.Size(63, 12)
        Me.LabelWithAudio.TabIndex = 0
        Me.LabelWithAudio.Text = "With Audio:"
        '
        'TextBoxJoinAudioCommandLine
        '
        Me.TextBoxJoinAudioCommandLine.Location = New System.Drawing.Point(86, 22)
        Me.TextBoxJoinAudioCommandLine.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxJoinAudioCommandLine.Name = "TextBoxJoinAudioCommandLine"
        Me.TextBoxJoinAudioCommandLine.Size = New System.Drawing.Size(497, 22)
        Me.TextBoxJoinAudioCommandLine.TabIndex = 1
        '
        'LabelWithoutAudio
        '
        Me.LabelWithoutAudio.AutoSize = True
        Me.LabelWithoutAudio.Location = New System.Drawing.Point(11, 46)
        Me.LabelWithoutAudio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWithoutAudio.Name = "LabelWithoutAudio"
        Me.LabelWithoutAudio.Size = New System.Drawing.Size(78, 12)
        Me.LabelWithoutAudio.TabIndex = 2
        Me.LabelWithoutAudio.Text = "Without Audio:"
        '
        'TextBoxSilenceCommandLine
        '
        Me.TextBoxSilenceCommandLine.Location = New System.Drawing.Point(86, 60)
        Me.TextBoxSilenceCommandLine.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSilenceCommandLine.Name = "TextBoxSilenceCommandLine"
        Me.TextBoxSilenceCommandLine.Size = New System.Drawing.Size(497, 22)
        Me.TextBoxSilenceCommandLine.TabIndex = 3
        '
        'LabelVariables
        '
        Me.LabelVariables.AutoSize = True
        Me.LabelVariables.Location = New System.Drawing.Point(11, 102)
        Me.LabelVariables.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVariables.Name = "LabelVariables"
        Me.LabelVariables.Size = New System.Drawing.Size(96, 60)
        Me.LabelVariables.TabIndex = 4
        Me.LabelVariables.Text = "Available variables:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{framerate}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{img}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{audio}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{outfile}"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(438, 137)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(70, 23)
        Me.ButtonOK.TabIndex = 5
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(513, 137)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(70, 23)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'LabelFFmpeg1
        '
        Me.LabelFFmpeg1.AutoSize = True
        Me.LabelFFmpeg1.Location = New System.Drawing.Point(11, 25)
        Me.LabelFFmpeg1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFFmpeg1.Name = "LabelFFmpeg1"
        Me.LabelFFmpeg1.Size = New System.Drawing.Size(71, 12)
        Me.LabelFFmpeg1.TabIndex = 7
        Me.LabelFFmpeg1.Text = "ffmpeg.exe -y"
        '
        'LabelFFmpeg2
        '
        Me.LabelFFmpeg2.AutoSize = True
        Me.LabelFFmpeg2.Location = New System.Drawing.Point(11, 63)
        Me.LabelFFmpeg2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFFmpeg2.Name = "LabelFFmpeg2"
        Me.LabelFFmpeg2.Size = New System.Drawing.Size(71, 12)
        Me.LabelFFmpeg2.TabIndex = 8
        Me.LabelFFmpeg2.Text = "ffmpeg.exe -y"
        '
        'ButtonDefault
        '
        Me.ButtonDefault.Location = New System.Drawing.Point(363, 137)
        Me.ButtonDefault.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDefault.Name = "ButtonDefault"
        Me.ButtonDefault.Size = New System.Drawing.Size(70, 23)
        Me.ButtonDefault.TabIndex = 9
        Me.ButtonDefault.Text = "Default"
        Me.ButtonDefault.UseVisualStyleBackColor = True
        '
        'CustomCommandLineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 171)
        Me.Controls.Add(Me.ButtonDefault)
        Me.Controls.Add(Me.LabelFFmpeg2)
        Me.Controls.Add(Me.LabelFFmpeg1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelVariables)
        Me.Controls.Add(Me.TextBoxSilenceCommandLine)
        Me.Controls.Add(Me.LabelWithoutAudio)
        Me.Controls.Add(Me.TextBoxJoinAudioCommandLine)
        Me.Controls.Add(Me.LabelWithAudio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomCommandLineForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom commandline (experts only!)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelWithAudio As System.Windows.Forms.Label
    Friend WithEvents TextBoxJoinAudioCommandLine As System.Windows.Forms.TextBox
    Friend WithEvents LabelWithoutAudio As System.Windows.Forms.Label
    Friend WithEvents TextBoxSilenceCommandLine As System.Windows.Forms.TextBox
    Friend WithEvents LabelVariables As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents LabelFFmpeg1 As System.Windows.Forms.Label
    Friend WithEvents LabelFFmpeg2 As System.Windows.Forms.Label
    Friend WithEvents ButtonDefault As System.Windows.Forms.Button
End Class
