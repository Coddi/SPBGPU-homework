

Imports System.Math


Module Module1


    Sub Main()
        Dim A, X1 As Double
        Dim Y2, X2, Z2 As Single
        Dim r1, r2, r3, r4, r5, r6 As Integer
        Dim Tiket As String
q1:
        A = InputBox("Введите значение переменной A, дробную часть вводить через запятую", "Ввод A")
        X1 = Sin(Abs(3 * A))
        X1 = 2 * A + X1
        X1 = X1 / 3.56
        If X1 < 0 Then
            MsgBox("Недопустимое значение A")
            GoTo q1
        Else
            X1 = Sqrt(X1)
            MsgBox("Ответ" & X1)
        End If
q2:
        X2 = InputBox("Введите значение X, дробную часть вводить через запятую", "Ввод X")
        Y2 = InputBox("Введите значение Y, дробную часть вводить через запятую", "Ввод Y")
        X2 = X2 + ((2 + Y2) / X2 ^ 2)
        Y2 = Y2 + (1 / Sqrt((X2 ^ 2) + 10))
        If Y2 = 0 Then
            MsgBox("Недопустимое значение X или Y")
            GoTo q2
        Else
            Z2 = X2 / Y2
            MsgBox("Ответ" & Z2)
        End If
q3:
        Tiket = InputBox("Введите номер билета", "Номер билета")
        If (Len(Tiket)) = 6 Then
            r1 = Tiket \ 100000
            r2 = (Tiket \ 10000) - 10
            r3 = Tiket \ 1000
            Do While r3 > 9
                r3 = r3 - 10
            Loop
            r4 = Tiket \ 100
            Do While r4 > 9
                r4 = r4 - 10
            Loop
            r5 = Tiket \ 10
            Do While r5 > 9
                r5 = r5 - 10
            Loop
            r6 = Tiket
            Do While r6 > 9
                r6 = r6 - 10
            Loop
            If (r1 + r3 + r5) = (r2 + r4 + r6) Then
                MsgBox("Поздравляем, у вас счастливый билет")
            Else
                MsgBox("Билет не счастливый")
            End If
        Else
            MsgBox("Номер не коректнен. В номерене должны быть только 6 цифр, без пробелов и запятых.")
            GoTo q3
        End If
    End Sub

End Module
