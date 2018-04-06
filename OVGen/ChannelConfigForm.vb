Public Class ChannelConfigForm
    Public Property Options As New channelOptions
    Public Property SetAll As Boolean = False
    Dim globalOptions As New channelOptions
    Dim labelFont As Font
    Dim externalTrigger As String

    Private Sub ChannelConfigForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxAlgorithm.Items.Clear()
        ComboBoxAlgorithm.Items.AddRange(TriggeringAlgorithms.Algorithms)
        ButtonColor.BackColor = Options.waveColor
        CheckBoxPulseWidthModulatedColor.Checked = Options.pulseWidthModulatedColor
        ComboBoxAlgorithm.SelectedIndex = Options.algorithm
        ComboBoxScanPhase.SelectedIndex = Options.scanPhase
        TextBoxHorizontalTime.Text = Options.horizontalTime * 1000
        NumericUpDownTriggerLevel.Value = Options.trigger
        CheckBoxAutoTriggerLevel.Checked = Options.autoTriggerLevel
        CheckBoxExternalTrigger.Checked = Options.externalTriggerEnabled
        ButtonExternalTrigger.Enabled = Options.externalTriggerEnabled
        If IO.File.Exists(Options.externalTriggerFile) Then
            ButtonExternalTrigger.Text = New IO.FileInfo(Options.externalTriggerFile).Name
            externalTrigger = Options.externalTriggerFile
        Else
            ButtonExternalTrigger.Text = "(None)"
            externalTrigger = ""
        End If
        TextBoxAmplify.Text = Options.amplify
        TextBoxLabel.Text = Options.label
        labelFont = Options.labelFont
        ButtonFontColor.BackColor = Options.labelColor
        Select Case Options.maxScan
            Case 1.0F
                RadioButton1x.Checked = True
            Case 1.5F
                RadioButton1dot5x.Checked = True
            Case 2.0F
                RadioButton2x.Checked = True
        End Select
        NumericUpDownAudioChannel.Value = Options.selectedChannel
        CheckBoxMixAudioChannel.Checked = Options.mixChannel
    End Sub

    Private Sub ChannelConfigForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter Then
            ButtonOK_Click(Nothing, Nothing)
        End If
    End Sub

    Sub checkValueValid()
        If IsNumeric(TextBoxHorizontalTime.Text) And IsNumeric(TextBoxAmplify.Text) Then
            If TextBoxHorizontalTime.Text >= 1 Then
                ButtonOK.Enabled = True
            Else
                ButtonOK.Enabled = False
            End If
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

    Private Sub ButtonColor_BackColorChanged(sender As Object, e As EventArgs) Handles ButtonColor.BackColorChanged
        ButtonColor.ForeColor = MainForm.getTextColor(ButtonColor.BackColor)
    End Sub

    Private Sub TextBoxTimeScale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxHorizontalTime.TextChanged
        checkValueValid()
    End Sub

    Private Sub TextBoxAmplify_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAmplify.TextChanged
        checkValueValid()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        If CheckBoxExternalTrigger.Checked Then
            CheckBoxExternalTrigger.Checked = IO.File.Exists(externalTrigger)
        End If
        If TextBoxLabel.Text.Replace(" ", "").Length = 0 Then TextBoxLabel.Text = ""
        Options.waveColor = ButtonColor.BackColor
        Options.pulseWidthModulatedColor = CheckBoxPulseWidthModulatedColor.Checked
        Options.algorithm = ComboBoxAlgorithm.SelectedIndex
        Options.horizontalTime = TextBoxHorizontalTime.Text / 1000
        Options.trigger = NumericUpDownTriggerLevel.Value
        Options.scanPhase = ComboBoxScanPhase.SelectedIndex
        Options.autoTriggerLevel = CheckBoxAutoTriggerLevel.Checked
        Options.externalTriggerEnabled = CheckBoxExternalTrigger.Checked
        Options.externalTriggerFile = externalTrigger
        Options.amplify = TextBoxAmplify.Text
        Options.label = TextBoxLabel.Text
        Options.labelFont = labelFont
        Options.labelColor = ButtonFontColor.BackColor
        Select Case True
            Case RadioButton1x.Checked
                Options.maxScan = 1.0
            Case RadioButton1dot5x.Checked
                Options.maxScan = 1.5
            Case RadioButton2x.Checked
                Options.maxScan = 2.0
        End Select
        Options.selectedChannel = NumericUpDownAudioChannel.Value
        Options.mixChannel = CheckBoxMixAudioChannel.Checked
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

    Private Sub ButtonExternalTrigger_Click(sender As Object, e As EventArgs) Handles ButtonExternalTrigger.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog() = DialogResult.OK Then
            ButtonExternalTrigger.Text = ofd.SafeFileName
            externalTrigger = ofd.FileName
        End If
    End Sub

    Private Sub CheckBoxExternalTrigger_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxExternalTrigger.CheckedChanged
        ButtonExternalTrigger.Enabled = CheckBoxExternalTrigger.Checked
    End Sub

    Private Sub CheckBoxAutoTriggerLevel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAutoTriggerLevel.CheckedChanged
        NumericUpDownTriggerLevel.Enabled = Not CheckBoxAutoTriggerLevel.Checked
    End Sub

    Private Sub ButtonAutoAmplify_Click(sender As Object, e As EventArgs) Handles ButtonAutoAmplify.Click
        If Not SetAll Then
            Dim aawf As New AutoAmplifyWorkerForm
            aawf.Filename = MainForm.ListBoxFiles.Items(MainForm.ListBoxFiles.SelectedIndex)
            aawf.ShowDialog()
            TextBoxAmplify.Text = String.Format("{0:G1}", aawf.Result)
            If aawf.Result < 1 Then
                TextBoxAmplify.Text = 1
            End If
        Else
            Dim smallestAmplifyValue As Double = Double.MaxValue
            For Each file In MainForm.ListBoxFiles.Items
                Dim aawf As New AutoAmplifyWorkerForm
                aawf.Filename = file
                If aawf.ShowDialog() = DialogResult.Cancel Then
                    Exit For
                End If
                Dim val As Double = aawf.Result
                If val < 1 Then val = 1
                If val < smallestAmplifyValue Then
                    smallestAmplifyValue = val
                End If
            Next
            If smallestAmplifyValue <> Double.MaxValue Then
                TextBoxAmplify.Text = String.Format("{0:G1}", smallestAmplifyValue)
            End If
        End If
    End Sub

    Private Sub ComboBoxAlgorithm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAlgorithm.SelectedIndexChanged
        LabelScanPhase.Enabled = ComboBoxAlgorithm.SelectedIndex = TriggeringAlgorithms.UseMaxLengthScanning _
                                 Or ComboBoxAlgorithm.SelectedIndex = TriggeringAlgorithms.UseMaxRectifiedAreaScanning
        ComboBoxScanPhase.Enabled = LabelScanPhase.Enabled
    End Sub
End Class