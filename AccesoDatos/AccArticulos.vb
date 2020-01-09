Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports Interfaz
Imports Entidad
Imports System.Windows.Forms

Public Class AccArticulos
    Implements IntArticulos

    Public Function buscar(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntArticulos) Implements Interfaz.IntArticulos.buscar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ar_ArProcesosCortos"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "BUS"
            .Add("@ArCodigo", SqlDbType.Int).Value = 0
            .Add("@ArDescripcion", SqlDbType.VarChar).Value = filtro
        End With
        Dim LstArticulos As New List(Of EntArticulos)
        Dim Articulos As EntArticulos
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        Dim mstream As New MemoryStream()
        For fila = 0 To Tabla.Rows.Count - 1
            Dim imagen() As Byte = CType(Tabla.Rows(fila).Item(1), Byte())
            mstream = New MemoryStream(imagen)
            Articulos = New EntArticulos(Tabla.Rows(fila).Item(0), Image.FromStream(mstream), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7))
            LstArticulos.Add(Articulos)
        Next
        Return LstArticulos
    End Function


    Public Sub ingresar(ByVal Articulos As Entidad.EntArticulos) Implements Interfaz.IntArticulos.ingresar
        grabar("INS", Articulos)
    End Sub
    Public Sub modificar(ByVal Articulos As Entidad.EntArticulos) Implements Interfaz.IntArticulos.modificar
        grabar("MOD", Articulos)
    End Sub

    Public Sub grabar(ByVal opc As String, ByVal Articulos As Entidad.EntArticulos)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ar_ArProcesos"
        Dim im As System.IO.MemoryStream = New MemoryStream()
        Articulos.Imagen.Save(im, ImageFormat.Jpeg)
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = opc
            .Add("@ArCodigo", SqlDbType.Int).Value = Articulos.Codigo
            .Add("@ArImagen", SqlDbType.Image).Value = im.GetBuffer
            .Add("@ArDescripcion", SqlDbType.VarChar).Value = Articulos.Descripcion
            .Add("@ArGrupo", SqlDbType.VarChar).Value = Articulos.Grupo
            .Add("@ArPrecio", SqlDbType.Decimal).Value = Articulos.Precio
            .Add("@ArStock", SqlDbType.Int).Value = Articulos.Stock
            .Add("@ArIva", SqlDbType.VarChar).Value = Articulos.Iva
            .Add("@ArEstado", SqlDbType.Int).Value = Articulos.Estado
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Function MaxCodigo() As String Implements Interfaz.IntArticulos.MaxCodigo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ar_ArProcesosCortos"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "SIG"
            .Add("@ArCodigo", SqlDbType.Int).Value = 0
            .Add("@ArDescripcion", SqlDbType.VarChar).Value = ""
        End With
        Return sql.MaximoCodigo(cmd)
    End Function

    Public Sub eliminar(ByVal Articulos As Integer) Implements Interfaz.IntArticulos.eliminar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Ar_ArProcesosCortos"
        With cmd.Parameters
            .Add("@Opcion", SqlDbType.VarChar).Value = "ELI"
            .Add("@ArCodigo", SqlDbType.Int).Value = Articulos
            .Add("@ArDescripcion", SqlDbType.VarChar).Value = ""
        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Sub Foto(ByVal Imagen As System.Windows.Forms.PictureBox) Implements Interfaz.IntArticulos.Foto
        Try
            Dim fotos As OpenFileDialog
            fotos = New OpenFileDialog() 'abre una ventana de busqueda
            fotos.DefaultExt = "*.jpg" 'defino la extension que quiero buscar
            fotos.Multiselect = False ' solo puedo seleccionar uno
            fotos.Filter = "Tipo (*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp" 'filtrar los tipos de archivos
            fotos.Title = "Seleccione una imagen " 'titulo de la ventana
            If fotos.ShowDialog = Windows.Forms.DialogResult.OK Then 'ventana dialogo si quiero o no mandar la foto al pictureBox
                Imagen.Image = Nothing 'Vacio el pictureBox
                Imagen.Image = New Bitmap(fotos.FileName) 'agrego la foto seleccionada
            End If
        Catch ex As Exception
            MessageBox.Show("Error en ----> " + ex.Message)
        End Try
    End Sub
End Class
