Module TriggeringAlgorithms
    Public ReadOnly Algorithms As String() = {"Rising Edge",
                                              "Peak Speed",
                                              "Max Length",
                                              "Max Rectified Area",
                                              "No Trigger"}

    Public Const UseRisingEdge As Byte = 0
    Public Const UsePeakSpeedScanning As Byte = 1
    Public Const UseMaxLengthScanning As Byte = 2
    Public Const UseMaxRectifiedAreaScanning As Byte = 3
    Function risingEdgeTrigger(ByRef wave As WAV, ByVal triggerValue As Integer, ByVal offset As Long, ByVal maxScanLength As Long) As Long
        Dim args As channelOptions = wave.extraArguments
        risingEdgeTrigger = 0
        While Math.Floor(wave.getSample(offset + risingEdgeTrigger, True)) > triggerValue And risingEdgeTrigger < maxScanLength 'postive
            risingEdgeTrigger += 1
        End While
        While Math.Floor(wave.getSample(offset + risingEdgeTrigger, True)) <= triggerValue And risingEdgeTrigger < maxScanLength 'negative
            risingEdgeTrigger += 1
        End While
    End Function

    Function peakSpeedScanning(ByRef wave As WAV, ByVal triggerValue As Integer, ByVal offset As Long, ByVal maxScanLength As Long) As Long
        'OPNA2608: scans how fast a peak is reached centers there
        Dim args As channelOptions = wave.extraArguments
        Dim REoffset As Integer = risingEdgeTrigger(wave, triggerValue, offset, maxScanLength / 2)
        offset += REoffset
        peakSpeedScanning = 0
        Dim peak As Integer = -127
        Dim distance As ULong = 0
        Dim shortestDistance As ULong = maxScanLength
        Dim dy As ULong = 0
        Dim tempTrigger As ULong = 0

        While dy < maxScanLength
            distance = 0
            tempTrigger = dy
            While Math.Floor(wave.getSample(offset + dy, True)) >= triggerValue And dy < maxScanLength
                Dim currentSample As Integer = Math.Floor(wave.getSample(offset + dy, True))
                If currentSample = peak And distance < shortestDistance Then
                    peakSpeedScanning = tempTrigger
                    shortestDistance = distance
                ElseIf currentSample > peak Then
                    peak = currentSample
                    peakSpeedScanning = tempTrigger
                    shortestDistance = distance
                End If
                distance += 1
                dy += 1
            End While
            While Math.Floor(wave.getSample(offset + dy, True)) < triggerValue And dy < maxScanLength
                dy += 1
            End While
        End While
        peakSpeedScanning += REoffset
        'Debug.WriteLine(peakSpeedScanning & "," & maxScanLength)
    End Function

    Function lengthScanning(ByRef wave As WAV, ByVal triggerValue As Integer, ByVal offset As Long, ByVal maxScanLength As Long, ByVal scanPositive As Boolean, ByVal scanNegative As Boolean) As Long
        Dim args As channelOptions = wave.extraArguments
        lengthScanning = 0
        Dim scanLocation As Long = 0
        Dim maxLength As Long = 0
        Dim tempTrigger As Long = 0
        While scanLocation < maxScanLength
            Dim currentLength As Long = 0
            tempTrigger = scanLocation
            While Math.Floor(wave.getSample(offset + scanLocation, True)) > triggerValue And scanLocation < maxScanLength
                scanLocation += 1
                If scanPositive Then currentLength += 1
            End While
            While Math.Floor(wave.getSample(offset + scanLocation, True)) <= triggerValue And scanLocation < maxScanLength
                scanLocation += 1
                If scanNegative Then currentLength += 1
            End While
            If currentLength > maxLength Then
                maxLength = currentLength
                lengthScanning = tempTrigger
            End If
        End While
    End Function

    Function maxRectifiedArea(ByRef wave As WAV, ByVal triggerValue As Integer, ByVal offset As Long, ByVal maxScanLength As Long, ByVal scanPositive As Boolean, ByVal scanNegative As Boolean) As Long
        Dim args As channelOptions = wave.extraArguments
        maxRectifiedArea = 0
        Dim scanLocation As Long = 0
        Dim totalSample As Long = 0
        Dim tempTrigger As Long = 0
        While scanLocation < maxScanLength
            Dim currentTotalSample As Long = 0
            tempTrigger = scanLocation
            While Math.Floor(wave.getSample(offset + scanLocation, True)) > triggerValue And scanLocation < maxScanLength
                scanLocation += 1
                If scanPositive Then currentTotalSample += wave.getSample(offset + scanLocation, True)
            End While
            While Math.Floor(wave.getSample(offset + scanLocation, True)) <= triggerValue And scanLocation < maxScanLength
                scanLocation += 1
                If scanNegative Then currentTotalSample -= wave.getSample(offset + scanLocation, True)
            End While
            If currentTotalSample > totalSample Then
                totalSample = currentTotalSample
                maxRectifiedArea = tempTrigger
            End If
        End While
    End Function
End Module
