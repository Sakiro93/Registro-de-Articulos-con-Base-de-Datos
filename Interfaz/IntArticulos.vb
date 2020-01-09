Imports Entidad
Imports System.Windows.Forms
Public Interface IntArticulos
    Sub ingresar(ByVal Articulos As EntArticulos)
    Sub modificar(ByVal Articulos As EntArticulos)
    Sub eliminar(ByVal Articulos As Integer)
    Function buscar(ByVal filtro As String) As List(Of EntArticulos)
    Function MaxCodigo() As String
    Sub Foto(ByVal Imagen As PictureBox)
End Interface
