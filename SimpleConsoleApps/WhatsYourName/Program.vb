Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Please enter your name: ")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}!")
        Console.Write("Press any key to continue...")
        Console.ReadKey(True)
    End Sub
End Module
