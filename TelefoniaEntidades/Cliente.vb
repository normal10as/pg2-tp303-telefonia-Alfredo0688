﻿Public Class Cliente
    Private _cuenta As UInteger

    Sub New()
        Me.Cuenta = _cuenta
    End Sub

    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property

End Class
