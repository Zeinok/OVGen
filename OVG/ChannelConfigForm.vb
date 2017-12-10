Public Class ChannelConfigForm
    Dim currentOptions As channelOptions
    Dim labelFont As Font

    Private Sub ChannelConfigForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not MainForm.currentChannelToBeSet = "" Then
            currentOptions = MainForm.optionsMap.Item(MainForm.currentChannelToBeSet)
        Else
            currentOptions = New channelOptions
        End If
        ButtonColor.BackColor = currentOptions.waveColor
        ComboBoxAlgorithm.SelectedIndex = currentOptions.algorithm
        TextBoxTimeScale.Text = currentOptions.timeScale * 1000
        TextBoxAmplify.Text = currentOptions.amplify
        TextBoxLabel.Text = currentOptions.label
        labelFont = currentOptions.labelFont
        ButtonFontColor.BackColor = currentOptions.labelColor
    End Sub

    Private Sub ChannelConfigForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter Then
            ButtonOK_Click(Nothing, Nothing)
        End If
    End Sub

    Sub checkValueValid()
        If IsNumeric(TextBoxTimeScale.Text) And IsNumeric(TextBoxAmplify.Text) Then
            ButtonOK.Enabled = True
        Else
            ButtonOK.Enabled = False
        End If
    End Sub

    Private Sub ButtonFont_Click(sender As Object, e As EventArgs) Handles ButtonFont.Click
        Dim fd As New FontDialog
        fd.Font = labelFont
        If fd.ShowDialog() = DialogResult.OK Then
            labelFont = fd.Font
        End If
    End Sub

    Private Sub ButtonFontColor_Click(sender As Object, e As EventArgs) Handles ButtonFontColor.Click
        Dim cd As New ColorDialog
        cd.Color = ButtonColor.BackColor
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ButtonFontColor.BackColor = cd.Color
        End If
    End Sub

    Private Sub ButtonColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonColor.Click
        Dim cd As New ColorDialog
        cd.Color = ButtonColor.BackColor
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ButtonColor.BackColor = cd.Color
        End If
    End Sub

    Private Sub TextBoxTimeScale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxTimeScale.TextChanged
        checkValueValid()
    End Sub

    Private Sub TextBoxAmplify_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAmplify.TextChanged
        checkValueValid()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        If TextBoxLabel.Text.Replace(" ", "").Length = 0 Then TextBoxLabel.Text = ""
        If Not MainForm.currentChannelToBeSet = "" Then
            currentOptions.waveColor = ButtonColor.BackColor
            currentOptions.algorithm = ComboBoxAlgorithm.SelectedIndex
            currentOptions.timeScale = TextBoxTimeScale.Text / 1000
            currentOptions.amplify = TextBoxAmplify.Text
            currentOptions.label = TextBoxLabel.Text
            currentOptions.labelFont = labelFont
            currentOptions.labelColor = ButtonFontColor.BackColor
        Else
            For Each key In MainForm.optionsMap.Keys
                Dim currentChannel As channelOptions = MainForm.optionsMap.Item(key)
                currentChannel.waveColor = ButtonColor.BackColor
                currentChannel.algorithm = ComboBoxAlgorithm.SelectedIndex
                currentChannel.timeScale = TextBoxTimeScale.Text / 1000
                currentChannel.amplify = TextBoxAmplify.Text
                currentChannel.label = TextBoxLabel.Text
                currentChannel.labelFont = labelFont
                currentChannel.labelColor = ButtonFontColor.BackColor
            Next
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class