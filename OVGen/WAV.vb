Imports System.Text
Imports System

Public Class WAV
    Public Stream As System.IO.Stream
    'Public rawSample As Byte()
    Private mmf As System.IO.MemoryMappedFiles.MemoryMappedFile
    Public channels As UInt16
    Public sampleRate As UInt32
    Public byteRate As UInt32
    Public blockAlign As UInt16
    Public bitDepth As UInt16
    Public sampleLength As UInt32
    Public totalSamples As UInt32
    Public extraArguments As Object
    Public amplify As Single = 1
    Public limit As UInteger = 0
    Public mixChannel As Boolean = True
    Public selectedChannel As Byte = 0
    Private sampleBegin As UInt32

    Sub New(ByVal filename As String, Optional ByVal checkHeadersOnly As Boolean = False)
        Dim offset As UInt32 = 0
        mmf = System.IO.MemoryMappedFiles.MemoryMappedFile.CreateFromFile(IO.File.Open(filename, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read),
                                                                          Nothing,
                                                                          0,
                                                                          IO.MemoryMappedFiles.MemoryMappedFileAccess.Read,
                                                                          Nothing,
                                                                          IO.HandleInheritability.None,
                                                                          False)
        Try
            Stream = mmf.CreateViewStream(0, 0, IO.MemoryMappedFiles.MemoryMappedFileAccess.Read)
        Catch ex As Exception
            mmf.Dispose()
            Stream = Nothing
            Throw ex
        End Try
        Dim buffer4(3) As Byte
        Dim buffer2(1) As Byte
        offset += Stream.Read(buffer4, 0, 4)
        If Encoding.ASCII.GetString(buffer4) <> "RIFF" Then
            Dim ex As New System.Exception("Bad header at " & Stream.Position & ", expected ""RIFF""")
            Stream.Close()
            mmf.Dispose()
            Throw ex
        End If
        Dim chunkSize As UInt32
        offset += Stream.Read(buffer4, 0, 4)
        chunkSize = BitConverter.ToUInt32(buffer4, 0)
        offset += Stream.Read(buffer4, 0, 4)
        If Encoding.ASCII.GetString(buffer4) <> "WAVE" Then
            Dim ex As New System.Exception("Bad header at " & Stream.Position & ", expected ""WAVE"".")
            Stream.Close()
            mmf.Dispose()
            Throw ex
        End If
        offset += Stream.Read(buffer4, 0, 4)
        If Encoding.ASCII.GetString(buffer4) <> "fmt " Then
            Dim ex As New System.Exception("Bad header at " & Stream.Position & ", expected ""fmt "".")
            Stream.Close()
            mmf.Dispose()
            Throw ex
        End If
        offset += Stream.Read(buffer4, 0, 4)
        If BitConverter.ToUInt32(buffer4, 0) <> 16 Then
            Dim ex As New System.Exception("Bad header at " & Stream.Position & ", expected ""16"".")
            Stream.Close()
            mmf.Dispose()
            Throw ex
        End If
        offset += Stream.Read(buffer2, 0, 2)
        If BitConverter.ToUInt16(buffer2, 0) <> 1 Then
            Dim ex As New System.Exception("Not a PCM encoded audio.")
            Stream.Close()
            mmf.Dispose()
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
            Stream.Close()
            mmf.Dispose()
            Throw ex
        End If
        offset += Stream.Read(buffer4, 0, 4)
        totalSamples = BitConverter.ToUInt32(buffer4, 0)
        sampleLength = totalSamples / channels
        If bitDepth = 16 Then sampleLength /= 2
        sampleBegin = Stream.Position
        If checkHeadersOnly Then
            Stream.Close()
            mmf.Dispose()
            Exit Sub
        End If
        'Stream.Seek(offset, IO.SeekOrigin.Begin)
        'rawSample = New Byte(totalSamples - 1) {}
        'Stream.Read(rawSample, 0, totalSamples)
        'Stream.Seek(sampleBegin, IO.SeekOrigin.Begin)
        'Stream.Close()
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
        If Not mixChannel Then index += selectedChannel
        Select Case bitDepth
            Case 16
                index *= 2
                If index < 0 Or index > totalSamples Then
                    If signed Then
                        Return 0
                    Else
                        Return SByte.MaxValue
                    End If
                End If
                Stream.Position = sampleBegin + index
                Dim buffer(1) As Byte
                Stream.Read(buffer, 0, 2)
                Dim value As Double = BitConverter.ToInt16(buffer, 0) / 258 * amplify
                If mixChannel Then
                    For i As Integer = 2 To (channels - 1) * 2 Step 2
                        Stream.Position += i
                        Stream.Read(buffer, 0, 2)
                        value += BitConverter.ToInt16(buffer, 0) / 258 * amplify
                        value /= 2
                    Next
                End If
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
                If index < 0 Or index > totalSamples Then
                    If signed Then
                        Return 0
                    Else
                        Return SByte.MaxValue + 1
                    End If
                End If
                Stream.Position = sampleBegin + index
                Dim value As Double = (Stream.ReadByte() - 128) * amplify
                If mixChannel Then
                    For i As Integer = 2 To channels
                        value += (Stream.ReadByte() - 128) * amplify
                        value /= 2
                    Next
                End If
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