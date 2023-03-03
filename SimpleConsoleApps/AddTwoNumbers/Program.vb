Imports System

Module Program
    Public num1 As Integer
    Public num2 As Integer
    Public answer As Integer
    Sub Main(args As String())
        Console.WriteLine("Type a number and press Enter")
        num1 = Console.ReadLine()
        Console.WriteLine("Type another number to add to it and press Enter")
        num2 = Console.ReadLine()
        answer = num1 + num2
        Console.WriteLine("The answer is " & answer)
        Console.Write("Press any key to continue...")
        Console.ReadKey()
    End Sub
End Module
