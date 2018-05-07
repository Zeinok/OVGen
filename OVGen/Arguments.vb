
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
    Sub New(ByVal message As String)
        Me.message = message
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
    Public smoothLine As Boolean
    Public backgroundColor As Color = Color.Black
    Public drawMiddleLine As Boolean
    Public middleLinePen As Pen
    Public useAnalogOscilloscopeStyle As Boolean = False
    Public analogOscilloscopeLineWidth As Byte = 4
    Public drawGrid As Boolean
    Public gridPen As Pen
    Public drawBorder As Boolean
    Public borderPen As Pen
End Class

Public Class channelOptions
    Implements ICloneable
    Public pen As Pen = MainForm.wavePen
    Public waveColor As Color = MainForm.wavePen.Color
    Public pulseWidthModulatedColor As Boolean = False
    Public horizontalTime As Double = 0.025
    Public amplify As Single = 1
    Public trigger As Integer = 0
    Public autoTriggerLevel As Boolean = True
    Public externalTriggerEnabled As Boolean = False
    Public externalTriggerFile As String = ""
    Public algorithm As Byte = TriggeringAlgorithms.UsePeakSpeedScanning
    Public scanPhase As Byte = 0
    Public label As String
    Public labelFont As Font = New Font(SystemFonts.MenuFont.FontFamily, 24)
    Public labelColor As Color = Color.White
    Public maxScan As Single = 1.0F
    Public mixChannel As Boolean = True
    Public selectedChannel As Byte = 0

    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function
End Class