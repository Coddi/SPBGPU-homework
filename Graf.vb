Imports System.Math
Module Module1

    Sub Main()
        Dim Arg, Tempo As Single
        Dim Check1, Check2 As Boolean
        Console.WriteLine("Ввведите значение X, дробную часть через запятую.")
        Arg = Console.ReadLine
        Arg = Abs(Arg)
        If Arg > 0 And Arg < 1 Then
            Console.WriteLine(Arg)
        End If
        Tempo = Arg
        Tempo = Int(Tempo)
        Check1 = (Tempo \ 2 = Tempo / 2)
        If (Tempo Mod 1) = 0 Then
            Check2 = True
        Else
            Check2 = False
        End If
        Select Case Check2
            Case True
                If Check1 = True Then
                    Console.WriteLine(0)
                Else
                    Console.WriteLine(1)
                End If
            Case False
                If Check1 = True Then
                    Arg = Arg - Tempo
                    Console.WriteLine(Arg)
                Else
                    Arg = 1 - (Arg - Tempo)
                    Console.WriteLine(Arg)
                End If
        End Select
        Console.ReadLine()
    End Sub

End Module
