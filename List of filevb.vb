Imports System.IO
Imports System.Array
Module Module1

    Sub Main()
        Dim Result()() As String
        Dim catalig As String = "E:\Загрузки"
        Result = ShowFile(catalig)
        Console.ReadKey()

    End Sub

    Function ShowFile(ByVal strPath As String)
        Dim filelist(1)() As String
        Dim catalog() As String
        catalog = Directory.GetDirectories(strPath)
        filelist(0) = Directory.GetFiles(strPath)
        If (UBound(catalog)) = -1 Then
            Return Directory.GetFiles(strPath)
        End If
        For i = 0 To (UBound(catalog)) Step 1
            CatalogList(catalog(i), filelist)
        Next
        Return filelist
    End Function

    Sub CatalogList(ByVal catalog As String, ByRef filelist()() As String)
        Dim elementInCatalog As Integer
        Dim localCatalog() As String
        localCatalog = Directory.GetDirectories(catalog)
        elementInCatalog = UBound(localCatalog)
        ReDim Preserve filelist((elementInCatalog + (UBound(filelist)) + 1))
        For i = 0 To elementInCatalog Step 1
            filelist((UBound(filelist)) - i) = Directory.GetFiles(localCatalog(i))
            CatalogList(localCatalog(i), filelist)
        Next
    End Sub

End Module
