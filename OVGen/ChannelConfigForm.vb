Public Class ChannelConfigForm
    Dim currentOptions As channelOptions
    Dim globalOptions As New channelOptions
    Dim labelFont As Font

    Private Sub ChannelConfigForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxAlgorithm.Items.Clear()
        ComboBoxAlgorithm.Items.AddRange(TriggeringAlgorithms.Algorithms)
        If Not MainForm.currentChannelToBeSet = "" Then
            currentOptions = MainForm.optionsMap.Item(MainForm.currentChannelToBeSet)
        Else
            currentOptions = globalOptions
        End If
        ButtonColor.BackColor = currentOptions.waveColor
        ComboBoxAlgorithm.SelectedIndex = currentOptions.algorithm
        TextBoxHorizontalTime.Text = currentOptions.horizontalTime * 1000
        NumericUpDownTriggerLevel.Value = currentOptions.trigger
        TextBoxAmplify.Text = currentOptions.amplify
        TextBoxLabel.Text = currentOptions.label
        labelFont = currentOptions.labelFont
        ButtonFontColor.BackColor = currentOptions.labelColor
        Select Case currentOptions.maxScan
            Case 1.0F
                RadioButton1x.Checked = True
            Case 1.5F
                RadioButton1dot5x.Checked = True
            Case 2.0F
                RadioButton2x.Checked = True
        End Select
        NumericUpDownAudioChannel.Value = currentOptions.selectedChannel
        CheckBoxMixAudioChannel.Checked = currentOptions.mixChannel
    End Sub

    Private Sub ChannelConfigForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter Then
            ButtonOK_Click(Nothing, Nothing)
        End If
    End Sub

    Sub checkValueValid()
        If IsNumeric(TextBoxHorizontalTime.Text) And IsNumeric(TextBoxAmplify.Text) Then
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

    Private Sub TextBoxTimeScale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxHorizontalTime.TextChanged
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
            currentOptions.horizontalTime = TextBoxHorizontalTime.Text / 1000
            currentOptions.trigger = NumericUpDownTriggerLevel.Value
            currentOptions.amplify = TextBoxAmplify.Text
            currentOptions.label = TextBoxLabel.Text
            currentOptions.labelFont = labelFont
            currentOptions.labelColor = ButtonFontColor.BackColor
            Select Case True
                Case RadioButton1x.Checked
                    currentOptions.maxScan = 1.0F
                Case RadioButton1dot5x.Checked
                    currentOptions.maxScan = 1.5F
                Case RadioButton2x.Checked
                    currentOptions.maxScan = 2.0F
            End Select
            currentOptions.selectedChannel = NumericUpDownAudioChannel.Value
            currentOptions.mixChannel = CheckBoxMixAudioChannel.Checked
        Else

            For Each key In MainForm.optionsMap.Keys
                Dim currentChannel As channelOptions = MainForm.optionsMap.Item(key)
                currentChannel.waveColor = ButtonColor.BackColor
                currentChannel.algorithm = ComboBoxAlgorithm.SelectedIndex
                currentChannel.horizontalTime = TextBoxHorizontalTime.Text / 1000
                currentChannel.trigger = NumericUpDownTriggerLevel.Value
                currentChannel.amplify = TextBoxAmplify.Text
                currentChannel.label = TextBoxLabel.Text
                currentChannel.labelFont = labelFont
                currentChannel.labelColor = ButtonFontColor.BackColor
                Select Case True
                    Case RadioButton1x.Checked
                        currentChannel.maxScan = 1.0F
                    Case RadioButton1dot5x.Checked
                        currentChannel.maxScan = 1.5F
                    Case RadioButton2x.Checked
                        currentChannel.maxScan = 2.0F
                End Select
                currentChannel.selectedChannel = NumericUpDownAudioChannel.Value
                currentChannel.mixChannel = CheckBoxMixAudioChannel.Checked
                globalOptions = currentChannel
            Next
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckBoxStereo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMixAudioChannel.CheckedChanged
        LabelAudioChannel.Enabled = Not CheckBoxMixAudioChannel.Checked
        NumericUpDownAudioChannel.Enabled = Not CheckBoxMixAudioChannel.Checked
    End Sub
End Class