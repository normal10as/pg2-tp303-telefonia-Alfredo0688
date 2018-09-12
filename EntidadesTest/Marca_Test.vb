Imports TelefoniaEntidades
Module Marca_Test

    Sub Main()
        Dim marca1 As New Marca("Sony Ericsson")
        Console.WriteLine(marca1.Nombre)
        Console.WriteLine(marca1.ToString)
        Console.ReadKey()
    End Sub

End Module
