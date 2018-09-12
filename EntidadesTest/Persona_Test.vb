Imports TelefoniaEntidades

Module Persona_Test
    Sub main()

        Dim pers1 As New Persona("Gomez", "José", 34123569)
        Console.WriteLine(pers1.Apellido)
        Console.WriteLine(pers1.Nombre)
        Console.WriteLine(pers1.Documento)
        Console.ReadKey()
    End Sub
End Module
