Imports System.Text
Imports System

Public Class WAV
    Public Stream As System.IO.Stream
    Public channels As UInt16
    Public sampleRate As UInt32
    Public byteRate As UInt32
    Public blockAlign As UInt16
    Public bitDepth As UInt16
    Public sampleLength As UInt32
    Public timeScale As Double
    Public extraArguments As Object
    Public amplify As Single = 1
    Public limit As UInteger = 10
    Private sampleBegin As UInt32
    Public flipWave As Boolean = False
    Public rawSample As Byte()

    Sub New(ByVal filename As String)
        Dim offset As UInt32 = 0
        stream = New System.IO.FileStream(filename, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        Dim buffer4(3) As Byte
        Dim buffer2(1) As Byte
        offset += Stream.Read(buffer4, 0, 4)
        If Encoding.ASCII.GetString(buffer4) <> "RIFF" Then
            Dim ex As New System.Exception("Bad header at " & stream.Position & ", expected ""RIFF""")
            Throw ex
        End If
        Dim chunkSize As UInt32
        offset += Stream.Read(buffer4, 0, 4)
        chunkSize = BitConverter.ToUInt32(buffer4, 0)
        offset += Stream.Read(buffer4, 0, 4)
        If Encoding.ASCII.GetString(buffer4) <> "WAVE" Then
            Dim ex As New System.Exception("Bad header at " & stream.Position & ", expected ""WAVE"".")
            Throw ex
        End If
        offset += Stream.Read(buffer4, 0, 4)
        If Encoding.ASCII.GetString(buffer4) <> "fmt " Then
            Dim ex As New System.Exception("Bad header at " & stream.Position & ", expected ""fmt "".")
            Throw ex
        End If
        offset += Stream.Read(buffer4, 0, 4)
        If BitConverter.ToUInt32(buffer4, 0) <> 16 Then
            Dim ex As New System.Exception("Bad header at " & stream.Position & ", expected ""16"".")
            Throw ex
        End If
        offset += Stream.Read(buffer2, 0, 2)
        If BitConverter.ToUInt16(buffer2, 0) <> 1 Then
            Dim ex As New System.Exception("Not a PCM encoded audio.")
            Throw ex
        End If
        offset += Stream.Read(buffer2, 0, 2)
        channels = BitConverter.ToUInt16(buffer2, 0)
        offset += Stream.Read(buffer4, 0, 4)
        sampleRate = BitConverter.ToUInt32(buffer4, 0)
        offset += Stream.Read(buffer4, 0, 4)
        byteRate = BitConverter.ToUInt32(buffer4, 0)
        offset += Stream.Read(buffer2, 0, 2)
        blockAlign = BitConverter.ToUInt16(buffer2, 0)
        offset += Stream.Read(buffer2, 0, 2)
        bitDepth = BitConverter.ToUInt16(buffer2, 0)
        offset += Stream.Read(buffer4, 0, 4)
        If Encoding.ASCII.GetString(buffer4) <> "data" Then
            Dim ex As New System.Exception("Bad header at " & Stream.Position & ", expected ""data"".")
            Throw ex
        End If
        offset += stream.Read(buffer4, 0, 4)
        sampleLength = BitConverter.ToUInt32(buffer4, 0) / channels
        sampleBegin = Stream.Position
        Stream.Seek(offset, IO.SeekOrigin.Begin)
        Dim remainBytes As UInt32 = Stream.Length - offset
        rawSample = New Byte(Stream.Length - offset - 1) {}
        Stream.Read(rawSample, 0, remainBytes)
        Stream.Seek(sampleBegin, IO.SeekOrigin.Begin)
        Stream.Close()
    End Sub
    ''' <summary>
    ''' Returns value between -128 to 128
    ''' If unsigned, 0 to 256
    ''' </summary>
    ''' <param name="index">Sample index</param>
    ''' <param name="signed">Should return signed value.</param>
    ''' <returns>Double</returns>
    ''' <remarks></remarks>
    Function getSample(ByVal index As Long, ByVal signed As Boolean) As Double
        'returns value between -128 to 128
        'if unsigned, 0 to 256
        index *= channels
        Select Case bitDepth
            Case 16
                index *= 2
                If index < 0 Or index >= rawSample.Length Then
                    'Debug.WriteLine("exceed length {0}", index)
                    If signed Then
                        Return 0
                    Else
                        Return SByte.MaxValue + 1
                    End If
                End If
                Dim value As Double = BitConverter.ToInt16({rawSample(index), rawSample(index + 1)}, 0) / 258 * amplify
                If flipWave Then value = -value
                If signed Then
                    Select Case value
                        Case Is < -128 + limit
                            Return -128 + limit
                        Case Is > 127 - limit
                            Return 128 - limit
                        Case Else
                            Return value
                    End Select
                Else
                    Select Case value
                        Case Is < -128 + limit
                            Return 0 + limit
                        Case Is > 127 - limit
                            Return 255 - limit
                        Case Else
                            Return value + 127
                    End Select
                End If
            Case 8
                If index < 0 Or index >= rawSample.Length Then
                    If signed Then
                        Return 0
                    Else
                        Return SByte.MaxValue + 1
                    End If
                End If
                Dim value As Double = (rawSample(index) - 128) * amplify
                If flipWave Then value = -value
                If signed Then
                    Select Case value
                        Case Is < -128
                            Return -128
                        Case Is > 127 - limit
                            Return 128 - limit
                        Case Else
                            Return value
                    End Select
                Else
                    value += 128

                    Select Case value
                        Case Is < 0 + limit
                            Return 0 + limit
                        Case Is > 255 - limit
                            Return 255 - limit
                        Case Else
                            Return value
                    End Select
                End If
            Case Else
                'how
                Return 0
        End Select
    End Function


End Class