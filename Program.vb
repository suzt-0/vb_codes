Imports System

Public MustInherit Class abc            'the abstract class
    Public MustOverride Function area() As Integer
End Class
Public Class circle : Inherits abc      'the class that inherited the abstract class
    Public length As Decimal
    Public breadth As Decimal
    Public radius As Decimal
    Public Sub New(ByVal r As Decimal)

        radius = r
    End Sub


    Public Overrides Function area() As Integer
        Return 3.14 * radius * radius
        Throw New NotImplementedException()
    End Function
End Class
Public Class rectangle : Inherits abc   'the class that inherited the abstract class
    Public length As Decimal
    Public breadth As Decimal

    Public Sub New(ByVal l As Decimal, ByVal b As Decimal)
        length = l
        breadth = b

    End Sub


    Public Overrides Function area() As Integer
        Return length * breadth
        Throw New NotImplementedException()
    End Function
End Class
Module Program
    Sub Main(args As String())

        Dim C As circle = New circle(5)

        Dim R As rectangle = New rectangle(2, 3)

        Console.WriteLine("the areas of rectangle is  :{0}", R.area())
        Console.WriteLine("the areas of circle is  :{0}", C.area())

    End Sub
End Module

