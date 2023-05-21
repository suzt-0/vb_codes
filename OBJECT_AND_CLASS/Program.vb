Imports System
Imports System.Transactions

Public Class shape
    Public length As Decimal
    Public breadth As Decimal
    Public radius As Decimal
End Class
Public Class Area : Inherits shape

    Public Sub New(ByVal l As Decimal, ByVal b As Decimal, ByVal r As Decimal)
        length = l
        breadth = b
        radius = r


    End Sub

    Public Sub display()
        Dim area_R As Decimal
        Dim area_C As Decimal
        area_C = (radius * radius * 3.14)
        area_R = length * breadth
        Console.WriteLine("the areas of rectangle is  :{0}", area_R)
        Console.WriteLine("the areas of circle is  :{0}", area_C)

    End Sub
End Class
Module Program
    Sub Main(args As String())
        Dim A As Area = New Area(5, 5, 4)
        A.display()
    End Sub
End Module
