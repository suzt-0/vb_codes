Imports System

Module Program
    Sub Main()

        Dim intData As Integer       'declaration of intData as Integer 
        Dim CharData As Char         'declaration of charData as Char  
        Dim strData As String        'declaration of strData as String 
        Dim dblData As Double        'declaration of dblData as Double  
        Dim single_data As Single    'declaration of single_data as Single  
        intData = 10                 'Initialization of intData  

        CharData = "A"                                  'Initialization of CharData 
        strData = " VB.NET is a Programming Language."  'Initialization of strData 
        dblData = 4567.676                              'Initialization of dblData  
        single_data = 23.08                             'Initialization of single_data  

        Console.WriteLine(" Value of intData is: {0}", intData)
        Console.WriteLine(" Value of CharData is: {0}", CharData)
        Console.WriteLine(" Value of strData is: {0}", strData)
        Console.WriteLine(" Value of dblData is: {0}", dblData)
        Console.WriteLine(" Value of single_data is: {0}", single_data)

        Console.WriteLine("press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
