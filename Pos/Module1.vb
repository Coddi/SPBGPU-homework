Module Module1

    Sub Main()

        Dim Item As String = "((1+4)-9)"
        Dim Weight, maxWeight As UShort
        Dim i As Integer
        Dim tempo As String
        Dim Temp1() As SElem
        Dim work As Integer
        Dim sngtemp As Single


        ''Console.WriteLine("Ввод выражения")
        ''Item = Console.ReadLine
        List.ReDi(Item.Length)

        Do While i <= Item.Length - 1
            tempo = Item(i)
            i += 1
            Select Case tempo
                Case "("
                    Weight += 1
                    List.Add(tempo, Weight)
                Case "+", "-", "*", "/", ")"
                    Weight -= 1
                    List.Add(tempo, Weight)
                Case "0" To "9"
                    Do Until Item(i) = "+" Or Item(i) = "-" Or Item(i) = "/" Or Item(i) = "*" Or Item(i) = "(" Or Item(i) = ")"
                        tempo &= Item(i)
                        i += 1
                    Loop
                    Weight += 1
                    List.Add(tempo, Weight)
            End Select
            tempo = ""
        Loop

        Do
            work = List.MaxIndex
            Temp1 = List.GetThree(work)
            Select Case Temp1(1).Value
                Case "+"
                    sngtemp = CSng(Temp1(0).Value) + CSng(Temp1(2).Value)
                Case "-"
                    sngtemp = CSng(Temp1(0).Value) - CSng(Temp1(2).Value)
                Case "*"
                    sngtemp = CSng(Temp1(0).Value) * CSng(Temp1(2).Value)
                Case "/"
                    sngtemp = CSng(Temp1(0).Value) / CSng(Temp1(2).Value)
            End Select
            maxWeight = Temp1(0).Weight - 1
            List.DellReng(work, sngtemp, maxWeight)
        Loop While maxWeight > 1

        Console.WriteLine(List.Elem(0).Value)
        Console.ReadLine()
    End Sub

End Module