Public Class SMS
    Inherits Plan

    Sub New(credito As UInteger, precio As Decimal)

        MyBase.New(credito, precio)

    End Sub


    Public Overrides Sub NuevoConsumo(valor As UInteger)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function getDisponible() As UInteger
        Throw New NotImplementedException()
    End Function
End Class
