Imports TelefoniaEntidades

Module Linea_Test

    Sub main()


        Dim linea1 As New Linea(3764, 221166)
        linea1.Reactivar()
        Console.WriteLine("Linea ToString: {0}", linea1.ToString)
        Console.ReadKey()
        linea1.Suspender()
        Console.WriteLine("Linea ToString: {0}", linea1.ToString)
        Console.ReadKey()

    End Sub


End Module
