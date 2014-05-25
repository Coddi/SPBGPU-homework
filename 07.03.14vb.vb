Module Module1

    Sub Main()
        Dim x() As Integer
        Dim numbers = New Integer() {1, 2, 4, 8, 4, 13}
        x = Serch(numbers, 4, 0)
        Console.ReadLine()

    End Sub

    Function Serch(testArr() As Integer, intS As Integer, Optional Y As Integer = 1) As Integer()
        '' Функция линейного поиска, teatArr - массив в котором выполняется роиск,
        '' intS - искомое значение,
        '' Y - режим поиска, по умолчанию в результат выдаётся первый найденный элемент, при значение 0 - все найденные значения.
        Dim i, tempo As Integer
        Dim p As Integer = 1
        Dim ret() As Integer
        tempo = UBound(testArr)
        ReDim Preserve testArr(tempo + 1)
        testArr(tempo + 1) = intS
        Select Case Y
            Case 1
                Do While testArr(i) <> intS

                    i += 1
                Loop
                ReDim ret(1)
                ret(0) = i + 1
                Return ret
            Case 0
                Do
                    Do While testArr(i) <> intS

                        i += 1
                    Loop
                    ReDim Preserve ret(p)
                    ret(p - 1) = i + 1
                    i += 2
                    p += 1
                Loop While i <= tempo
                Return ret


        End Select

    End Function

End Module
