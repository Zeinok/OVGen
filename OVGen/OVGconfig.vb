<Serializable()> Public Class OVGconfig
    Public General As GeneralSection
    Public FFmpeg As FFmpegSection
    Sub New()
        General = New GeneralSection
        FFmpeg = New FFmpegSection
    End Sub
    Public Class GeneralSection
        Public SmoothLine As Boolean
        Public Framerate As Integer = 60
        Public LineWidth As Integer = 2
        Public ConvertVideo As Boolean
        Public CRTStyledRender As Boolean
        Public DottedXYmode As Boolean
        Public DrawGrid As Boolean
        Public GridColor As New ColorSerializable(Color.LightGray)
        Public GridWidth As Integer = 1
        Public DrawBorder As Boolean
        Public BorderColor As New ColorSerializable(Color.LightGray)
        Public BorderWidth As Integer = 1
        Public BackgroundColor As New ColorSerializable(Color.Black)
        Public DrawMiddleLine As Boolean
        Public MiddleLineColor As New ColorSerializable(Color.Gray)
        Public MiddleLineWidth As Integer = 1
        Public LRmeterColor As New ColorSerializable(Color.Red)
        Public LRmeterHeight As Integer = 4
        Public CanvasSize As String = "1280x720"
        Public FlowDirection As Integer = 0
        Public LabelPosition As Integer = 0
    End Class
    Public Class FFmpegSection
        Public BinaryLocation As String
        Public JoinAudioCommandLine As String
        Public SilenceCommandLine As String
    End Class
End Class
<Serializable()> Public Structure ColorSerializable
    Public R As Byte
    Public G As Byte
    Public B As Byte
    Sub New(R As Byte, G As Byte, B As Byte)
        Me.R = R
        Me.G = G
        Me.B = B
    End Sub
    Sub New(color As Color)
        Me.R = color.R
        Me.G = color.G
        Me.B = color.B
    End Sub
    Function GetColor() As Color
        Return Color.FromArgb(Me.R, Me.G, Me.B)
    End Function
End Structure