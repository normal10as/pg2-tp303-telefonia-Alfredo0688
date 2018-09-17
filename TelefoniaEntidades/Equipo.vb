Public Class Equipo
    Private _serie As String
    Private _fechaVenta As Date
    Private _marca As Marca
    Private _modelo As Modelo

    Sub New(marca As Marca, modelo As Modelo, serie As String)
        Me.Marca = marca
        Me.Modelo = modelo
        Me.Serie = serie
    End Sub

    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 15 Then
                _serie = value
            End If
        End Set
    End Property

    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    Public Property Marca As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property

    Public Property Modelo As Modelo
        Get
            Return _modelo
        End Get
        Set(value As Modelo)
            _modelo = value
        End Set
    End Property

    Public Sub Vender(fecha_venta As Date)
        _fechaVenta = fecha_venta
    End Sub


    Public Overrides Function ToString() As String
        Return ""
    End Function


End Class
