Module Module1

    Sub Main()
        Dim lower As Single = 1
        Dim upper As Single = 9999
        Dim middle As Single
        Dim answer As Integer
        Console.WriteLine("На вопросы следует отвечать да или нет. Введите 1 если да. 2 Если нет.")
        Do While lower < upper
            middle = (upper + lower) / 2
            Console.WriteLine("Меньше или равно" & " " & middle & " ?")
            answer = Console.ReadLine()
            If answer = 1 Then
                upper = middle
            Else
                lower = middle + 1
            End If
            upper = Fix(upper)
        Loop
        Console.WriteLine("Ваше число" & " " & (upper))
        Console.ReadLine()

    End Sub

End Module
