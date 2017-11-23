Public Class CustomCommandLineForm

    Private Sub CustomCommandLineForm_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        MsgBox("If you messed up something, press [Default] button.")
        e.Cancel = True
    End Sub

    Private Sub CustomCommandLineForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxJoinAudioCommandLine.Text = MainForm.FFmpegCommandLineJoinAudio
        TextBoxSilenceCommandLine.Text = MainForm.FFmpegCommandLineSilence
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        MainForm.FFmpegCommandLineJoinAudio = TextBoxJoinAudioCommandLine.Text
        MainForm.FFmpegCommandLineSilence = TextBoxSilenceCommandLine.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDefault.Click
        If MsgBox("Set to default commandline?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TextBoxJoinAudioCommandLine.Text = MainForm.DefaultFFmpegCommandLineJoinAudio
            TextBoxSilenceCommandLine.Text = MainForm.DefaultFFmpegCommandLineSilence
        End If
    End Sub
End Class