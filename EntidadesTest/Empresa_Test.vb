Imports TelefoniaEntidades

Module Empresa_Test
    Sub main()

        Dim empresa1 As New Empresa("Pollo los hermanos", "20-45645789-7")
        Console.WriteLine(empresa1.RazonSocial)
        Console.WriteLine(empresa1.Cuit)
        Console.ReadKey()
    End Sub

End Module
