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
    Function risingEdgeTrigger(ByRef wave As WAV, ByVal offset As Long, ByVal maxScanLength As Long) As Long
        Dim args As channelOptions = wave.extraArguments
        risingEdgeTrigger = 0
        While Math.Floor(wave.getSample(offset + risingEdgeTrigger, True)) > args.trigger And risingEdgeTrigger < maxScanLength 'postive
            risingEdgeTrigger += 1
        End While
        While Math.Floor(wave.getSample(offset + risingEdgeTrigger, True)) <= args.trigger And risingEdgeTrigger < maxScanLength 'negative
            risingEdgeTrigger += 1
        End While
    End Function

    Function peakSpeedScanning(ByRef wave As WAV, ByVal offset As Long, ByVal maxScanLength As Long) As Long
        'OPNA2608: scans how fast a peak is reached centers there
        Dim args As channelOptions = wave.extraArguments
        peakSpeedScanning = 0
        Dim firstScan As Long = 0
        Dim captureLength As Long = 0
        Dim low As Integer = 128
        Dim max As Integer = -127
        Dim peaks As New List(Of Integer)
        While firstScan < maxScanLength
            If Math.Floor(wave.getSample(offset + firstScan, True)) < low Then
                low = Math.Floor(wave.getSample(offset + firstScan, True))
            End If
            If Math.Floor(wave.getSample(offset + firstScan, True)) = max Then
                peaks.Add(firstScan)
            End If
            If Math.Floor(wave.getSample(offset + firstScan, True)) > max Then
                max = Math.Floor(wave.getSample(offset + firstScan, True))
                peaks.Clear()
                peaks.Add(firstScan)
            End If
            firstScan += 1
        End While
        Dim middleDistance As Long = maxScanLength
        Dim middlePoint As Long = 0
        If args.autoTriggerLevel Then
            args.trigger = (max + low) / 2
        End If
        For Each peakPoint In peaks
            Dim currentPoint As Integer = peakPoint
            While Math.Floor(wave.getSample(offset + currentPoint, True)) > args.trigger And currentPoint >= 0 'find middle point
                currentPoint -= 1
            End While
            Dim distanceToPeak As Long = peakPoint - currentPoint 'distance between middlePoint to peakPoint
            'If currentPoint < 0 Then
            '    distanceToPeak = maxScanLength - 1
            'End If
            If distanceToPeak < middleDistance And distanceToPeak > 0 Then 'if distance is shortest
                middlePoint = currentPoint
                middleDistance = distanceToPeak
            End If
        Next

        If middlePoint = -1 Then
            Dim currentPoint = middlePoint
            While offset + currentPoint >= 0 And Math.Floor(wave.getSample(offset + currentPoint, True)) > args.trigger And currentPoint >= -maxScanLength
                currentPoint -= 1
            End While
            If currentPoint > -maxScanLength Then
                middlePoint = currentPoint
            Else
                middlePoint += 1
            End If
        End If
        'Debug.WriteLine(middlePoint)
        peakSpeedScanning = middlePoint
    End Function

    Function lengthScanning(ByRef wave As WAV, ByVal offset As Long, ByVal maxScanLength As Long, ByVal scanPositive As Boolean, ByVal scanNegative As Boolean) As Long
        Dim args As channelOptions = wave.extraArguments
        lengthScanning = 0
        Dim scanLocation As Long = 0
        Dim maxLength As Long = 0
        While scanLocation < maxScanLength
            Dim currentLength As Long = 0
            While Math.Floor(wave.getSample(offset + scanLocation, True)) > args.trigger And scanLocation < maxScanLength
                scanLocation += 1
                If scanPositive Then currentLength += 1
            End While
            While Math.Floor(wave.getSample(offset + scanLocation, True)) <= args.trigger And scanLocation < maxScanLength
                scanLocation += 1
                If scanNegative Then currentLength += 1
            End While
            If currentLength > maxLength Then
                maxLength = currentLength
                lengthScanning = scanLocation
            End If
        End While
    End Function

    Function maxRectifiedArea(ByRef wave As WAV, ByVal offset As Long, ByVal maxScanLength As Long, ByVal scanPositive As Boolean, ByVal scanNegative As Boolean) As Long
        Dim args As channelOptions = wave.extraArguments
        maxRectifiedArea = 0
        Dim scanLocation As Long = 0
        Dim totalSample As Long = 0
        While scanLocation < maxScanLength
            Dim currentTotalSample As Long = 0
            While Math.Floor(wave.getSample(offset + scanLocation, True)) > args.trigger And scanLocation < maxScanLength
                scanLocation += 1
                If scanPositive Then currentTotalSample += wave.getSample(offset + scanLocation, True)
            End While
            While Math.Floor(wave.getSample(offset + scanLocation, True)) <= args.trigger And scanLocation < maxScanLength
                scanLocation += 1
                If scanNegative Then currentTotalSample -= wave.getSample(offset + scanLocation, True)
            End While
            If currentTotalSample > totalSample Then
                totalSample = currentTotalSample
                maxRectifiedArea = scanLocation
            End If
        End While
    End Function
End Module
