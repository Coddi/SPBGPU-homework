Module Module1

    Sub Main()
        Dim Y As Single
        Dim grid = {{1, 2}, {3, 4}}
        Y = Sred(grid)

    End Sub

    Function Sred(intArr(,) As Integer) As Single '' Среднее значение нечётных строк, строки - второе измерение массива.
        Dim q As Integer = -1
        Dim w As Integer = -1
        Dim ClonArr(,) As Single
        Dim Tempo As Single  ''Максимальное значение будет в диапазоне Integer, но по скольку оно будет дробным, используем Single.
        Dim Chec As Long '' Вмещает максимально возможное количество нечётных элементов
        ReDim ClonArr((intArr.GetUpperBound(0)), (intArr.GetUpperBound(1)))
        For i = 0 To intArr.GetUpperBound(0) '' Клонируем массив, но только нечётные элементы
            q += 1
            For p = 1 To intArr.GetUpperBound(1) Step 2
                w += 1
                ClonArr(q, w) = intArr(i, p)
            Next
        Next
        Chec = ClonArr.GetUpperBound(0) * ClonArr.GetUpperBound(1)
        For i = 0 To ClonArr.GetUpperBound(0) '' Каждый элемент делим на общее количество, можно уменьшить количество циклов, если не уменьшено, значит не успел залить новую версию.
            For p = 0 To ClonArr.GetUpperBound(1)
                ClonArr(i, p) = ClonArr(i, p) / Chec
            Next
        Next
        For i = 0 To ClonArr.GetUpperBound(0)
            For p = 0 To ClonArr.GetUpperBound(1)
                Tempo += ClonArr(i, p)
            Next
        Next
        Return Tempo
    End Function

    Function TruuFols(logikArr(,) As Boolean) As Integer '' На вход идёт масив, пробегаем по всем элементам, если видим True, то делаем +1 к счётчику.
        Dim tempo As Integer
        For i = 0 To logikArr.GetUpperBound(0)
            For p = 0 To logikArr.GetUpperBound(1)
                If logikArr(i, p) = True Then
                    tempo += 1
                End If
            Next
        Next
        Return tempo
    End Function

    Function SummDiagonal(arrCub(,,) As Integer) As Integer
        Dim xAxis As Integer
        Dim tempo As Long
        xAxis = arrCub.GetUpperBound(0)
        For i = 0 To xAxis Step 1
            tempo += arrCub(i, i, i)
        Next
        For i = 0 To xAxis Step 1
            tempo += arrCub(i, (xAxis - i), i)
        Next
        For i = 0 To xAxis Step 1
            tempo += arrCub(i, i, (xAxis - i))
        Next
        For i = 0 To xAxis Step 1
            tempo += arrCub(i, (xAxis - i), (xAxis - i))
        Next
        Return tempo
    End Function


End Module
