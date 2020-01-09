Imports System.Drawing
Public Class EntArticulos
    Private ArCodigo As Integer
    Private ArImagen As Image
    Private ArDescripcion As String
    Private ArGrupo As String
    Private ArPrecio As Double
    Private ArStock As Integer
    Private ArIva As String
    Private ArEstado As Integer

    Public Property Codigo() As Integer
        Get
            Return ArCodigo
        End Get
        Set(ByVal value As Integer)
            ArCodigo = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return ArDescripcion
        End Get
        Set(ByVal value As String)
            ArDescripcion = value
        End Set
    End Property
    Public Property Grupo() As String
        Get
            Return ArGrupo
        End Get
        Set(ByVal value As String)
            ArGrupo = value
        End Set
    End Property
    Public Property Precio() As Double
        Get
            Return ArPrecio
        End Get
        Set(ByVal value As Double)
            ArPrecio = value
        End Set
    End Property
    Public Property Stock() As Integer
        Get
            Return ArStock
        End Get
        Set(ByVal value As Integer)
            ArStock = value
        End Set
    End Property
    Public Property Iva() As String
        Get
            Return ArIva
        End Get
        Set(ByVal value As String)
            ArIva = value
        End Set
    End Property
    Public Property Estado() As Integer
        Get
            Return ArEstado
        End Get
        Set(ByVal value As Integer)
            ArEstado = value
        End Set
    End Property
    Public Property Imagen() As Image
        Get
            Return ArImagen
        End Get
        Set(ByVal value As Image)
            ArImagen = value
        End Set
    End Property
    Sub New()
        Me.ArCodigo = 0
        Me.ArImagen = Nothing
        Me.ArDescripcion = ""
        Me.ArGrupo = ""
        Me.ArPrecio = 0
        Me.ArStock = 0
        Me.ArIva = ""
        Me.ArEstado = 0

    End Sub
    Sub New(ByVal ArCodigo As Integer, ByVal ArImagen As Image, ByVal ArDescripcion As String, ByVal ArGrupo As String, ByVal ArPrecio As Double, ByVal ArStock As Integer, ByVal ArIva As String, ByVal ArEstado As Integer)
        Me.ArCodigo = ArCodigo
        Me.ArImagen = ArImagen
        Me.ArDescripcion = ArDescripcion
        Me.ArGrupo = ArGrupo
        Me.ArPrecio = ArPrecio
        Me.ArStock = ArStock
        Me.ArIva = ArIva
        Me.ArEstado = ArEstado

    End Sub
End Class
