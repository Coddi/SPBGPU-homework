Module Module1

    Sub Main()
        Dim Data1, Data2, Data3 As Date
        Console.WriteLine("Введите первую дату")
        Data1 = Console.ReadLine
        Console.WriteLine("Введите вторую дату")
        Data2 = Console.ReadLine
        Console.WriteLine("Введите третью дату")
        Data3 = Console.ReadLine
        Console.WriteLine("Максимальная дата")
        Console.WriteLine(maxData(Data1, Data2, Data3))
        Console.WriteLine("Две максимальные даты")
        MaxData2(Data1, Data2, Data3)
        Console.WriteLine(Data1 & " " & Data2)
        Console.ReadLine()
    End Sub

    Function maxData(ByVal d1 As Date, ByVal d2 As Date, ByVal d3 As Date) As Date
        If d1 > d2 And d1 > d3 Then
            Return d1
        End If
        If d2 > d3 And d2 > d1 Then
            Return d2
        Else
            Return d3
        End If
    End Function
    Function MaxData2(ByRef d1 As Date, ByRef d2 As Date, ByVal d3 As Date) As Date
        Dim temp As Date
        If d1 < d2 And d1 < d3 Then
            temp = d1
            d1 = d3
            d3 = temp
        End If
        If d2 < d3 And d2 < d1 Then
            temp = d2
            d2 = d3
            d3 = temp
        End If
    End Function
End Module

