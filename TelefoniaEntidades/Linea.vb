Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String

    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
        End Set
    End Property

    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property

    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property

    Public Sub Suspender()
        _estado = "Suspendido"
    End Sub

    Public Sub Reactivar()
        _estado = "Activado"
    End Sub

    Public Overrides Function ToString() As String
        Return CodigoArea & " " & Numero & " " & _estado
    End Function

End Class
