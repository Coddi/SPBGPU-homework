Module Module1
    Public Structure SHuman
        Public FirstName As String ' Имя
        Public SecondName As String ' Отчество
        Public LastName As String ' Фамилия
        Public Age As UShort ' Возраст
    End Structure

    Public Sub Main()
        Dim arrPersons(7) As SHuman

        arrPersons(0).LastName = "Пушкин"
        arrPersons(0).FirstName = "Александр"
        arrPersons(0).SecondName = "Сергеевич"
        arrPersons(0).Age = 1799

        arrPersons(1).LastName = "Ломоносов"
        arrPersons(1).FirstName = "Михаил"
        arrPersons(1).SecondName = "Васильевич"
        arrPersons(1).Age = 1711

        arrPersons(2).LastName = "Тютчев"
        arrPersons(2).FirstName = "Фёдор"
        arrPersons(2).SecondName = "Иванович"
        arrPersons(2).Age = 1803

        arrPersons(3).LastName = "Суворов"
        arrPersons(3).FirstName = "Александр"
        arrPersons(3).SecondName = "Васильевич"
        arrPersons(3).Age = 1729

        arrPersons(4).LastName = "Менделеев"
        arrPersons(4).FirstName = "Дмитрий"
        arrPersons(4).SecondName = "Иванович"
        arrPersons(4).Age = 1834

        arrPersons(5).LastName = "Ахматова"
        arrPersons(5).FirstName = "Анна"
        arrPersons(5).SecondName = "Андреевна"
        arrPersons(5).Age = 1889

        arrPersons(6).LastName = "Володин"
        arrPersons(6).FirstName = "Александр"
        arrPersons(6).SecondName = "Моисеевич"
        arrPersons(6).Age = 1919

        arrPersons(7).LastName = "Мухина"
        arrPersons(7).FirstName = "Вера"
        arrPersons(7).SecondName = "Игнатьевна"
        arrPersons(7).Age = 1889

        Dim major As New Collection
        Dim local As New Collection
        local.Add(arrPersons(0))
        major.Add(local)
        Dim s, u, p, firstGroupNo As Integer
        Dim first As Boolean
        Do
            s = 0
            p += 1
            u = 1
            first = True
            Do
                local = major.Item(u)
                If searc(arrPersons(p), local) = True Then
                    If first Then
                        local.Add(arrPersons(p))
                        first = False
                        firstGroupNo = u
                    Else
                        copy(major.Item(firstGroupNo), local)
                        major.Remove(u)
                        u -= 1
                    End If
                End If
                s = major.Count
                u += 1
            Loop While u <= s
            If first = True Then
                local = New Collection
                local.Add(arrPersons(p))
                major.Add(local)
            End If


        Loop While p < UBound(arrPersons)
        WriteColl(major)
        Console.ReadLine()
    End Sub

    Function compare(one As SHuman, two As SHuman) As Boolean
        If one.FirstName = two.FirstName Then Return True
        If one.SecondName = two.SecondName Then Return True
        If one.LastName = two.LastName Then Return True
        If one.Age = two.Age Then Return True
        Return False
    End Function

    Sub copy(globa1 As Collection, globa2 As Collection)
        For i = 1 To globa2.Count Step 1
            globa1.Add(globa2.Item(i))
        Next
    End Sub

    Function searc(Y As SHuman, x As Collection) As Boolean
        For i = 1 To x.Count Step 1
            If compare(Y, x.Item(i)) = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Sub WriteColl(Coll As Collection)
        Dim T As Collection
        Dim Y As SHuman
        For i = 1 To Coll.Count Step 1
            T = Coll.Item(i)
            Console.WriteLine("Группа №" & i)
            For p = 1 To T.Count Step 1
                Y = T.Item(p)
                Console.WriteLine(p & ". " & Y.FirstName & " " & Y.SecondName & " " & Y.LastName & " " & Y.Age)
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
