Imports System.Numerics
Public Class FFT
    Public Shared Sub Separate(ByRef a As Complex(), ByVal n As Integer, ByVal index As Integer)
        Dim b(n / 2 - 1) As Complex
        For i As Integer = 0 To n / 2 - 1
            b(i) = a(i * 2 + 1 + index)
        Next
        For i As Integer = 0 To n / 2 - 1
            a(i + index) = a(i * 2 + index)
        Next
        For i As Integer = 0 To n / 2 - 1
            a(i + n / 2 + index) = b(i)
        Next
    End Sub
    Public Shared Sub FFT(ByRef x As Complex(), ByVal n As Integer, ByVal index As Integer)
        If Not n < 2 Then
            Separate(x, n, index)
            FFT(x, n / 2, 0 + index)
            FFT(x, n / 2, n / 2 + index)
            For k As Integer = 0 To n / 2 - 1
                Dim e As Complex = x(k + index)
                Dim o As Complex = x(k + n / 2 + index)
                Dim w As Complex = Complex.Exp(New Complex(0, -2 * Math.PI * k / n))
                x(k + index) = e + w * o
                x(k + n / 2 + index) = e - w * o
            Next
        End If
    End Sub
    Public Shared Sub HannWindow(ByRef x As Complex())
        Dim L As Integer = x.Length
        For i As Integer = 0 To x.Length - 1
            Dim n As Double = i - x.Length / 2
            x(i) *= 0.5 * (1 - Math.Cos(2 * Math.PI * n / L - 1))
        Next
    End Sub
    ''' <summary>
    ''' Return PointF array For easier drawing.
    ''' </summary>
    ''' <param name="r">Put FFT result</param>
    ''' <param name="sampleRate">Sample Rate</param>
    ''' <param name="sampleCount">Sample Count</param>
    ''' <returns>PointF, values from 0 to 1.0f</returns>
    Public Shared Function PlotHelper(ByVal r As Complex(), ByVal sampleRate As UInt16, ByVal sampleCount As ULong) As PointF()
        Dim points As New List(Of PointF)
        For i As ULong = 0 To sampleCount / 2 - 1
            Dim x As Single = i / sampleCount * 2
            Dim y As Single = r(i).Magnitude
            points.Add(New PointF(x, y))
        Next
        Return points.ToArray()
    End Function
End Class