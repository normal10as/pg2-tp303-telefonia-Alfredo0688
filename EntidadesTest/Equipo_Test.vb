Imports TelefoniaEntidades

Module Equipo_Test
    Sub main()

        Dim equipo1 As New Equipo(New Marca("Samsung"), New Modelo("S6"), "S")

        equipo1.Vender(Now)
        Console.WriteLine("Marca: {0} Modelo: {1} Serie: {2} Equipo vendido: {3}", equipo1.Marca, equipo1.Modelo, equipo1.Serie, equipo1.FechaVenta)

        Console.ReadKey()


    End Sub
End Module
