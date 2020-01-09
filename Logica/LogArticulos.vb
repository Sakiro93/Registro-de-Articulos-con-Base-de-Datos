Imports Entidad
Imports Interfaz
Imports AccesoDatos
Imports System.Windows.Forms
Public Class LogArticulos
    Implements IntArticulos
    Dim LogAccArticulos As New AccArticulos()
    Public Function buscar(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntArticulos) Implements Interfaz.IntArticulos.buscar
        Return LogAccArticulos.buscar(filtro)
    End Function

    Public Sub ingresar(ByVal Articulos As Entidad.EntArticulos) Implements Interfaz.IntArticulos.ingresar
        LogAccArticulos.ingresar(Articulos)
    End Sub
    Public Function MaxCodigo() As String Implements Interfaz.IntArticulos.MaxCodigo
        Return LogAccArticulos.MaxCodigo
    End Function
    Public Sub modificar(ByVal Articulos As Entidad.EntArticulos) Implements Interfaz.IntArticulos.modificar
        LogAccArticulos.modificar(Articulos)
    End Sub

    Public Sub eliminar(ByVal Articulos As Integer) Implements Interfaz.IntArticulos.eliminar
        LogAccArticulos.eliminar(Articulos)
    End Sub

    Public Sub Foto(ByVal Imagen As System.Windows.Forms.PictureBox) Implements Interfaz.IntArticulos.Foto
        LogAccArticulos.Foto(Imagen)
    End Sub
End Class
