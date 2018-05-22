Imports System.ComponentModel

Public Class AutoAmplifyWorkerForm
    Public Property Filename As String
    Dim _result As Double = 1
    Public Property Result As Double
        Get
            Return _result
        End Get
        Set(value As Double)
            Throw New ReadOnlyException
        End Set
    End Property

    Private Sub AutoAmplifyWorkerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text &= String.Format(" ({0})", New IO.FileInfo(Filename).Name)
        Catch ex As Exception

        End Try
        BackgroundWorkerAutoAmplify.RunWorkerAsync()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        If BackgroundWorkerAutoAmplify.IsBusy Then
            BackgroundWorkerAutoAmplify.CancelAsync()
        End If
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub BackgroundWorkerAutoAmplify_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerAutoAmplify.DoWork
        Dim wav As WAV
        Try
            wav = New WAV(Filename)
        Catch ex As Exception
            Exit Sub
        End Try
        Dim biggestSample As Double = 0
        Dim progress As Integer = 0
        For i As Integer = 0 To wav.sampleLength - 1
            Dim tempProgress As Integer = (i + 1) / wav.sampleLength * 100
            If tempProgress <> progress Then
                progress = tempProgress
                BackgroundWorkerAutoAmplify.ReportProgress(progress)
            End If
            If BackgroundWorkerAutoAmplify.CancellationPending Then
                Exit For
            End If
            If Math.Abs(wav.getSample(i, True)) > biggestSample Then
                biggestSample = Math.Abs(wav.getSample(i, True))
            End If
        Next
        _result = 127 / biggestSample
        If _result < 1 Then _result = 1
    End Sub

    Private Sub BackgroundWorkerAutoAmplify_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerAutoAmplify.RunWorkerCompleted
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub BackgroundWorkerAutoAmplify_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorkerAutoAmplify.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
End Class