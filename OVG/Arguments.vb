Public Class Channel
    Public filename As String
    Public color As Color
    Public iterations As Byte
End Class
Public Class Progress
    Public Image As System.Drawing.Image
    Public CurrentFrame As ULong
    Public TotalFrame As ULong
    Public message As String
    Public canceled As Boolean = False

    Sub New(ByVal NewImage As System.Drawing.Image, ByVal NewCurrentFrame As ULong, ByVal NewTotalFrame As ULong, Optional ByVal newMessage As String = "")
        Image = NewImage
        CurrentFrame = NewCurrentFrame
        TotalFrame = NewTotalFrame
        message = newMessage
    End Sub
End Class
Public Class WorkerArguments
    Public files As String()
    Public columns As Byte
    Public noFileWriting As Boolean
    Public convertVideo As Boolean
    Public ffmpegBinary As String
    Public FPS As Integer
    Public outputFile As String
    Public outputDirectory As String
    Public joinAudio As Boolean
    Public audioFile As String
    Public canceled As Boolean = False
End Class
Public Class FFmpegWorkerArguments
    Public ffmpegBinary As String
    Public directory As String
    Public FPS As Integer
    Public outputFile As String
    Public joinAudio As Boolean
    Public audioFile As String

End Class
Public Class FFmpegProgress
    Public stderr As String
    Public frame As String
    'Public totalFrame As String
    Public FPS As String

End Class
Public Class channelOptions
    'Public color As Color
    Public pen As Pen = MainForm.wavePen
    Public waveColor As Color = MainForm.wavePen.Color
    Public useAnalogOscilloscopeStyle As Boolean = False
    Public analogOscilloscopeLineWidth As Byte = 4
    Public timeScale As Double = 0.025
    Public amplify As Single = 1
    Public trigger As Integer = 0
    Public algorithm As Byte = TriggeringAlgorithms.UsePeakSpeedScanning

End Class