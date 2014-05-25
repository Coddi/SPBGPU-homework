Imports System.Security.Cryptography
Imports System.Console
Module Module1

    Structure Elem 'Структура хранящеяся в массиве.
        Public index As Integer 'Начало подстроки в строке
        Public hesh As Double 'Хэш подстроки
    End Structure

    Sub Main()
        Dim test As String = "aghsrtuabcsrh"
        Dim answer As Collection
        Dim Profit() As Integer
        Dim dlinna As Integer
        Dim Flag As Boolean
        Dim str As String

        WriteLine("Посик подстроки в строке")
        WriteLine("Введите строку в которой следует искать")
        test = ReadLine()
        WriteLine("Введите длинну подстроки, которую следует искать. Не длинее {0} символов. В последствии нельзя будет изменить.", test.Length)

        dlinna = ReadLine()


        answer = GetHesh(test, dlinna)
        Do
            WriteLine("Введите искомую строку, длинной {0}", dlinna)
            str = ReadLine()
            If str.Length > dlinna Then
                WriteLine("Искомая строка больше заявленной строки, программа будети закрыта.")
                Exit Do
            End If
            WriteLine("Сколько вхождений подстроки в строку найти?")
            dlinna = ReadLine()
            Profit = Serch(answer, str, test, dlinna)
            For i = 0 To UBound(Profit)
                WriteLine("Строка есть на координатах {0}", Profit(i))
            Next
            WriteLine("Найти другую подстроку? 0 - Нет, 1 - Да")
            Flag = ReadLine()
        Loop While Flag = True






    End Sub


    ''' <summary>
    ''' Поиск подстроки в строке.
    ''' </summary>
    ''' <param name="Hesh">Коллекция с массивами хэша</param>
    ''' <param name="str">Искома подстрока</param>
    ''' <param name="strB">Строка в которой идёт поиск</param>
    ''' <param name="modd">Сколько вхождений находить</param>
    ''' <returns>Индекс первого вхождения</returns>
    ''' <remarks>Определяет в каком массиве искать, и хэш строки которую ищем. Если возвращает индекс первого вхождения, то это старый билд, и новый не успел залить</remarks>
    Function Serch(Hesh As Collection, str As String, strB As String, modd As Integer) As Integer()
        Dim Y As Integer
        Dim Retu() As Integer
        Dim ind, S As Integer
        Y = (-1) ^ Asc(GetChar(str, str.Length))
        Dim Kesh As Double
        For i = 1 To str.Length Step 1
            Kesh += Asc(GetChar(str, i))
        Next
        Kesh /= Math.Abs(Asc(GetChar(str, 1)))

        ReDim Retu(strB.Length)
        Select Case Y
            Case 1
                For i = 1 To modd Step 1
                    Retu(i - 1) = Fuind(Hesh(1), ind, Kesh, str, strB)
                    ind = (Retu(i - 1) + 1)
                Next
                ReDim Retu(ind - 1)
                Return Retu
            Case -1
                For i = 1 To modd Step 1
                    Retu(i - 1) = Fuind(Hesh(2), ind, Kesh, str, strB)
                    ind = (Retu(i - 1) + 1)
                    S = i
                Next
                ReDim Preserve Retu(S - 1)
                Return Retu

        End Select
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="arr">Массив с хэшэм</param>
    ''' <param name="index">Индекс с которого искать</param>
    ''' <param name="hes">Хэш искомой подстроки</param>
    ''' <param name="str">Искомая подстрока, ждля проверки</param>
    ''' <param name="strB">Основная подстрока</param>
    ''' <returns>Номер первого вхождения подстроки</returns>
    ''' <remarks></remarks>
    Function Fuind(arr() As Elem, index As Integer, hes As Double, str As String, strB As String) As Integer
        If index = 0 Then index = index + 1
        For i = index To UBound(arr) Step 1
            If arr(i).hesh = hes Then
                For j = 1 To str.Length Step 1
                    If GetChar(str, j) <> GetChar(strB, (arr(i).index) + j - 1) Then
                        Exit For
                    End If
                    If j = str.Length Then Return arr(i).index
                Next
            End If
        Next
        Return 0

    End Function

















    ''' <summary>
    ''' Получение хэш кодов подстрок, и сортировка их по двум массивам
    ''' </summary>
    ''' <param name="str">Строка которая разбирается на подстроки</param>
    ''' <param name="zize">Размер подстроки</param>
    ''' <returns>Возвращает коллекцию, на позиции 1 лежит массив подстрок, оканчивающихся чётным символом, на позиции 2 нечётным.</returns>
    ''' <remarks>Разбитие сделано для ускорения последующего поиска.</remarks>
    Function GetHesh(str As String, zize As Integer) As Collection
        Dim ans As New Collection
        Dim arrB(str.Length) As Elem
        Dim arrS(str.Length) As Elem
        Dim tempo As Double
        Dim indB, indS As Integer
        ReDim arrB(str.Length)
        ReDim arrS(str.Length)
        indB = 1
        indS = indB
        For i = 1 To (str.Length - zize + 1) Step 1
            tempo = Nothing
            For p = i To (i + zize - 1) Step 1
                tempo += Asc(GetChar(str, p))
            Next
            tempo /= Math.Abs(Asc(GetChar(str, i))) 'Хэш расчитывается как сумма символов, делённая на корень из первого символа.
            If ((-1) ^ Asc(GetChar(str, (i + zize - 1)))) = 1 Then 'В зависимовсти от чётности или нечётности последнего символа, разбиваем на 2 массива. В теории должно повысить скорость поиска.
                arrB(indB).index = i
                arrB(indB).hesh = tempo
                indB += 1
            Else
                arrS(indS).index = i
                arrS(indS).hesh = tempo
                indS += 1
            End If
        Next
        ReDim Preserve arrB(indB - 1)
        ReDim Preserve arrS(indS - 1)
        ans.Add(arrB)
        ans.Add(arrS)
        Return ans
    End Function






End Module
