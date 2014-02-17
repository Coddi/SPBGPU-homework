Imports System.Math
Imports System.Console
Module Module1
    ' Максимальное значение в пределах которого вычисляется координаты выстрела
    Public Const conMaxValue As Short = 15
    ' Задержка при вычислении и отображении изменяющихся координат
    Public Const conSleep As Short = 30
    ' Шаг с которым идут круги на мишени
    Public Const conStep As Short = 1
    ' Количество секций на мишени (остальное "молоко")
    Public Const conMaxScore As Short = 10
    Sub Main()
        Dim sngX, sngY As Single
        Dim shrScore, shrCount As Short
        Randomize()
        'Цикл, выход возможен по желанию пользоваталя, но не арньше первого выстрел.
        Do
            'Меняем цвет шрифта
            ForegroundColor = ConsoleColor.Cyan
            'Увеличиваем счётчик выстрелов на 1
            shrCount += 1
            'Выводим сообщение о номере выстрела
            WriteLine("***************************************")
            WriteLine("Выстрел: " & shrCount)
            WriteLine("***************************************")
            'Возвращаем исходных цвет шрифта
            ForegroundColor = ConsoleColor.White
            'Выводим сообщение о ожидание нажатия клавиши, для выстрела по координате Х
            WriteLine("Определение Х...Нажмите любую клавишу ")
            'Вывод случайных координат в заданном диапозоне, после нажатия любой клавиши записываем их в переменную
            sngX = GetNumber()
            WriteLine("X= " & sngX)
            WriteLine()
            'Выводим сообщение о ожидание нажатия клавиши, для выстрела по координате У
            WriteLine("Определение Y...Нажмите любую клавишу ")
            'Вывод случайных координат в заданном диапозоне, после нажатия любой клавиши записываем их в переменную
            sngY = GetNumber()
            WriteLine("Y= " & sngY)
            'Считаем счёт, к текущему прибавляем результат работы функции, где аргументы, это координаты выстрела
            shrScore += CalcScore(sngX, sngY)
            WriteLine()
            'Меняем цвет шрифта
            ForegroundColor = ConsoleColor.DarkRed
            'Выводим статистику
            WriteLine("***************************************")
            WriteLine("Шаг: " & shrCount & " " & "Счёт:" & shrScore)
            WriteLine("***************************************")
            'Возвращаем исходных цвет шрифта
            ForegroundColor = ConsoleColor.White
            'Предлагаем пользователю выйти
            WriteLine("Выйти?(Y/N)")
        Loop Until ReadLine() = "Y" Or "y"
    End Sub
    'Функция определения координат. Входные значения: максимальная координата, и промежуток между сменой координат. 
    'Выводит рандомные числа до нажатия любой клавиши. Возвращает одно число типа Single.
    Function GetNumber(Optional maxValue As Single = conMaxValue, Optional sleep As Short = conSleep) As Single
        Dim tempo As Single = -maxValue
        Do Until KeyAvailable
            tempo = tempo + Rnd()
            Write(tempo)
            System.Threading.Thread.Sleep(sleep)
            If tempo > maxValue Then
                tempo = -maxValue
            End If
            CursorLeft = 0
        Loop
        ReadKey(True)
        Return tempo
    End Function
    'Функция пдсчёта очков. Входные значения: координата х, у, максимальные очки за выстрел.
    'Возвращает количество очков в формате Integer
    Function CalcScore(sngX2 As Single, sngY2 As Single, Optional maxScore As Short = conMaxScore) As Integer
        Dim tempo As Single
        tempo = Sqrt((sngX2) ^ 2 + (sngY2) ^ 2)
        If tempo > maxScore Then
            Return 0
        Else
            tempo = Fix((maxScore + 1) - tempo)
            Return tempo
        End If
    End Function
End Module
