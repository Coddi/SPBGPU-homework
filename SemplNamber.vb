Module Module1

    Sub Main()
        Dim N As Integer
        Console.WriteLine("Введите количество простых чисел, которое желаете получить")
        N = Console.ReadLine
        semplNamber(N)
        Console.ReadLine()


    End Sub
    Friend Sub semplNamber(ByVal n As Integer)
        Dim i, k, z, y, chek As Integer
        Dim Chek1 As Boolean
        Dim tempo As Single
        k = 2
        Console.WriteLine("Первые " & n & " простых чисел.")
        If n = 1 Then
            Console.WriteLine("2")
        Else
            Console.WriteLine("2")
            z = z + 1
            Do While z < n
                Do
                    chek = 0
                    k = k + 1
                    y = k - 1
                    For i = 2 To y Step 1
                        tempo = k / i
                        Chek1 = Fix(tempo) = tempo
                        If Chek1 = True Then
                            chek = chek + 1
                        End If
                    Next
                    If chek = 0 Then
                        Console.WriteLine(k)
                        z = z + 1
                        Exit Do
                    End If
                Loop While chek <> 0
            Loop
        End If

    End Sub

End Module
