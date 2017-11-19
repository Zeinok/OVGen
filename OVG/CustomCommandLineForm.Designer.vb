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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonDefault = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelWithAudio
        '
        Me.LabelWithAudio.AutoSize = True
        Me.LabelWithAudio.Location = New System.Drawing.Point(12, 9)
        Me.LabelWithAudio.Name = "LabelWithAudio"
        Me.LabelWithAudio.Size = New System.Drawing.Size(78, 15)
        Me.LabelWithAudio.TabIndex = 0
        Me.LabelWithAudio.Text = "With Audio:"
        '
        'TextBoxJoinAudioCommandLine
        '
        Me.TextBoxJoinAudioCommandLine.Location = New System.Drawing.Point(89, 27)
        Me.TextBoxJoinAudioCommandLine.Name = "TextBoxJoinAudioCommandLine"
        Me.TextBoxJoinAudioCommandLine.Size = New System.Drawing.Size(393, 25)
        Me.TextBoxJoinAudioCommandLine.TabIndex = 1
        '
        'LabelWithoutAudio
        '
        Me.LabelWithoutAudio.AutoSize = True
        Me.LabelWithoutAudio.Location = New System.Drawing.Point(12, 55)
        Me.LabelWithoutAudio.Name = "LabelWithoutAudio"
        Me.LabelWithoutAudio.Size = New System.Drawing.Size(96, 15)
        Me.LabelWithoutAudio.TabIndex = 2
        Me.LabelWithoutAudio.Text = "Without Audio:"
        '
        'TextBoxSilenceCommandLine
        '
        Me.TextBoxSilenceCommandLine.Location = New System.Drawing.Point(89, 73)
        Me.TextBoxSilenceCommandLine.Name = "TextBoxSilenceCommandLine"
        Me.TextBoxSilenceCommandLine.Size = New System.Drawing.Size(393, 25)
        Me.TextBoxSilenceCommandLine.TabIndex = 3
        '
        'LabelVariables
        '
        Me.LabelVariables.AutoSize = True
        Me.LabelVariables.Location = New System.Drawing.Point(12, 101)
        Me.LabelVariables.Name = "LabelVariables"
        Me.LabelVariables.Size = New System.Drawing.Size(119, 75)
        Me.LabelVariables.TabIndex = 4
        Me.LabelVariables.Text = "Available variables:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{framerate}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{img}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{audio}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{outfile}"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(288, 147)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(94, 29)
        Me.ButtonOK.TabIndex = 5
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(388, 147)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(94, 29)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'LabelFFmpeg1
        '
        Me.LabelFFmpeg1.AutoSize = True
        Me.LabelFFmpeg1.Location = New System.Drawing.Point(12, 30)
        Me.LabelFFmpeg1.Name = "LabelFFmpeg1"
        Me.LabelFFmpeg1.Size = New System.Drawing.Size(71, 15)
        Me.LabelFFmpeg1.TabIndex = 7
        Me.LabelFFmpeg1.Text = "ffmpeg.exe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ffmpeg.exe"
        '
        'ButtonDefault
        '
        Me.ButtonDefault.Location = New System.Drawing.Point(188, 147)
        Me.ButtonDefault.Name = "ButtonDefault"
        Me.ButtonDefault.Size = New System.Drawing.Size(94, 29)
        Me.ButtonDefault.TabIndex = 9
        Me.ButtonDefault.Text = "Default"
        Me.ButtonDefault.UseVisualStyleBackColor = True
        '
        'CustomCommandLineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 190)
        Me.Controls.Add(Me.ButtonDefault)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelFFmpeg1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelVariables)
        Me.Controls.Add(Me.TextBoxSilenceCommandLine)
        Me.Controls.Add(Me.LabelWithoutAudio)
        Me.Controls.Add(Me.TextBoxJoinAudioCommandLine)
        Me.Controls.Add(Me.LabelWithAudio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonDefault As System.Windows.Forms.Button
End Class
