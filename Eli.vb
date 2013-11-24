' Gambas module file
Module Module1
' Код не мой, понять как реализовать данную задачу не успел, или не понял, или просто не знаю как.
' Не отправить нечего не мог, по этой причине отправляю это. По больше части принцип работы понял, но не до конца.
' Весь код взят отсюда http://www.cyberforum.ru/post5371542.html . Правда тут есть ещё и расскраска цветная, но на отключается.
    SUB Main()
        DIM M, N, K AS Integer
        Console.Write("Введите количество строк: ")
        M = Integer.Parse(Console.ReadLine())
        Console.Write("Введите количество столбцов: ")
        N = Integer.Parse(Console.ReadLine())
        Console.Write("Введите количество строк в ёлке: ")
        K = Integer.Parse(Console.ReadLine())
        Console.Clear()
        Console.WriteLine("======= {0} =======", "Программа ЁЛЫ")
        Console.WriteLine("M={0}{3}N={1}{3}K={2}", M, N, K, vbNewLine)
        FOR i AS Integer = 1 TO M
            Console.ForegroundColor = ConsoleColor.DarkGreen
            Console.WriteLine(DrawTrees(N, K))
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine(DrawTrunks(N, K))
            Console.WriteLine()
        NEXT
        Console.ReadLine()
 
    END SUB
 
    ''' <summary>
    ''' Рисование дерева
    ''' </summary>
    ''' <param name="N">Количество деревьев</param>
    ''' <param name="K">Количество "веток" в дереве</param>
    PRIVATE FUNCTION DrawTrees(ByVal N AS Integer, ByVal K AS Integer) AS String
        DIM result AS NEW System.Text.StringBuilder
        DIM row AS String
        FOR i AS Integer = 1 TO K
            row = NEW String("#", 2 * i - 1)
            FOR j AS Integer = 1 TO N
                result.Append(row.PadLeft(K + i - 1).PadRight(2 * K))
            NEXT
            IF i <> K THEN result.AppendLine()
        NEXT
        RETURN result.ToString()
    END FUNCTION
 
    ''' <summary>
    ''' Рисование ствола
    ''' </summary>
    ''' <param name="N">Количество стволов</param>
    ''' <param name="K">Количество "веток" у дерева</param>
    PRIVATE FUNCTION DrawTrunks(ByVal N AS Integer, ByVal K AS Integer) AS String
        DIM result AS NEW System.Text.StringBuilder
        FOR j AS Integer = 1 TO N
            result.Append("#".PadLeft(K).PadRight(2 * K))
        NEXT
        RETURN result.ToString()
    END FUNCTION
END Module

  
