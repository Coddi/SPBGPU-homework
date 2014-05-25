Module Module1

    Sub Main()
        Dim Test = New Integer() {3, 1, 4, 1}
        Dim Tempo As Integer
        Tempo = Invers(Test)
        Console.WriteLine(Tempo)
        Console.ReadKey()


    End Sub

    Function Invers(ArrX() As Integer) As Integer
        For i = 0 To UBound(ArrX) Step 1
            For p = i To UBound(ArrX) Step 1
                If ArrX(i) > ArrX(p) Then
                    Invers += 1
                End If
            Next
        Next
        Return Invers
    End Function
End Module
