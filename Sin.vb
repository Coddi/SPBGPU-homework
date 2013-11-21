Imports System.Math
Module Module1


    Sub Main()
        Dim x, stx, sint As Single
        Dim e, fakt, z, chec1 As Integer
        Console.WriteLine("Введите x")
        x = Console.ReadLine
        chec1 = Sign(x)
        x = x Mod (2 * PI)
        x = Abs(x)
        stx = x
        fakt = 1
        sint = 0
        e = 1
        z = 1
        Do While stx / fakt >= 0.001
            sint = (sint + z * stx) / fakt
            e = e + 2
            stx = stx * x * x
            fakt = fakt * (e - 1) * e
            z = -z
        Loop
        If Sign(sint) <> chec1 Then
            sint = -sint
        End If
        Console.WriteLine(sint)
        Console.ReadLine()

    End Sub
End Module
