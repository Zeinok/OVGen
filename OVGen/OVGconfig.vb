<Serializable()> Public Class OVGconfig
    Public General As GeneralSection
    Public FFmpeg As FFmpegSection
    Sub New()
        General = New GeneralSection
        FFmpeg = New FFmpegSection
    End Sub
    Public Class GeneralSection
        Public SmoothLine As Boolean
        Public DrawMiddleLine As Boolean
        Public Framerate As Integer
        Public LineWidth As Integer
        Public ConvertVideo As Boolean
        Public CRTStyledRender As Boolean
        Public DrawGrid As Boolean
        Public CanvasSize As String
        Public FlowDirection As Integer
    End Class
    Public Class FFmpegSection
        Public BinaryLocation As String
        Public JoinAudioCommandLine As String
        Public SilenceCommandLine As String
    End Class
End Class