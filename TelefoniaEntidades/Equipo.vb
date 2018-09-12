Public Class Equipo
    Private _serie As String
    Private _fechaVenta As Date


    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length <= 15 Then

            End If
        End Set
    End Property

    Public ReadOnly Property FechaVenta As Date
        Get
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return ""
    End Function


End Class
