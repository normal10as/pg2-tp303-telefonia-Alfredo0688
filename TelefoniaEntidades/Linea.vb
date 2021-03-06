﻿Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As Boolean


    Sub New(codigoArea As UShort, numero As UInteger)
        Me.CodigoArea = codigoArea
        Me.Numero = numero
        _estado = True
    End Sub


    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value >= 100 And value < 10000 Then
                _codigoArea = value
            End If
        End Set
    End Property

    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value >= 100000 And value < 10000000 Then
                _numero = value
            End If

        End Set
    End Property

    Public ReadOnly Property Estado As String
        Get
            Return If(_estado, "Activado", "Suspendida")
        End Get
    End Property

    Public Sub Suspender()
        _estado = False
    End Sub

    Public Sub Reactivar()
        _estado = True
    End Sub

    Public Overrides Function ToString() As String
        Dim EstadoLinea As String = ""
        If Not (_estado) Then
            EstadoLinea = "(" & Estado & ")"
        End If
        Return CodigoArea & " " & Numero & " " & EstadoLinea
    End Function

End Class
