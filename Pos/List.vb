Module List
    Public Structure SElem
        Public Value As String
        Public Weight As UShort
    End Structure

    Private Arr() As SElem
    Private temp As SElem
    Private lastFree As Integer

    Public Sub ReDi(ByVal Size As Integer)
        ReDim Arr(Size)
    End Sub

    Public Sub Add(ByVal Value As String, ByVal Weight As UShort)
        Arr(lastFree).Value = Value
        Arr(lastFree).Weight = Weight
        lastFree += 1
    End Sub

    Public Function Elem(ByVal index As Integer) As SElem
        Return Arr(index)
    End Function



    Public Sub DellReng(ByVal index As Integer, ByVal Value As String, ByVal Weight As UShort)
        For i = index To Arr.GetUpperBound(0) - 4 Step 1
            Arr(i) = Arr(i + 4)
        Next
        Arr(index - 1).Value = Value
        Arr(index - 1).Weight = Weight
        lastFree -= 4
    End Sub


    Public Function MaxIndex() As Integer
        Dim max, maxi As Integer
        For i = 0 To Arr.GetUpperBound(0) Step 1
            If Arr(i).Weight > max Then
                max = Arr(i).Weight
                maxi = i
            End If
        Next
        Return maxi
    End Function


    Public Function GetThree(ByVal index As Integer) As SElem()
        Dim temp(2) As SElem
        For i = 0 To 2 Step 1
            temp(i) = Arr(index + i)
        Next
        Return temp
    End Function
End Module