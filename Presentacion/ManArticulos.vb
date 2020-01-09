Imports Entidad
Imports Logica
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Bitmap
Public Class ManArticulos
    Dim logicaArt As New LogArticulos
    Dim indiceMan As Integer
    Dim con As Integer = 0
    Private Sub ManArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        LimpiarGroupbox(GrpDatos)
        indiceMan = PreConArticulos.ArIndice
        If indiceMan <> 0 Then
            CargarDatos()
        Else
            ImgFoto.Image = ImgFoto.InitialImage
        End If
    End Sub

    Public Sub CargarDatos()
        For Each i In logicaArt.buscar("")
            If (i.Codigo.Equals(indiceMan)) Then
                ImgFoto.Image = i.Imagen
                TxtCodigo.Text = i.Codigo
                TxtDescripcion.Text = i.Descripcion
                CboGrupo.Text = i.Grupo
                TxtPrecio.Text = i.Precio
                TxtStock.Text = i.Stock
                If i.Iva.Equals("14%") Then
                    Op14.Checked = True
                Else
                    Op0.Checked = True
                End If
                ChkEstado.Checked = i.Estado
            End If
        Next
    End Sub
    Public Sub LimpiarGroupbox(ByVal Gbox As GroupBox)
        For Each C In Gbox.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is ComboBox Then C.SelectedIndex = 0
        Next
        TxtCodigo.Text = logicaArt.MaxCodigo()
    End Sub
    Public Function ValidaEntrada(ByVal err As ErrorProvider, ByVal grp As GroupBox) As Boolean
        Dim er As Boolean = True
        For Each C In grp.Controls 'For que se lo utiliza para leer colecciones
            If TypeOf C Is TextBox And C.Text = "" Then 'TypeOf = tipo
                err.SetError(C, "No ha ingresado informacion en: " + C.Name)
                er = False
            End If
            If TypeOf C Is ComboBox And C.Text = "" Then
                err.SetError(C, "No ha Seleccionado ninguna opcion en: " + C.Name)
                er = False
            End If
        Next
        Return er
    End Function

    Private Sub BtnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubir.Click
        logicaArt.Foto(ImgFoto)
    End Sub

    Private Sub TxtPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If Not TxtPrecio.Text.Contains(".") Then
            con = 0
        End If
        If e.KeyChar = "." AndAlso Not TxtPrecio.Text.Contains(".") Then
            e.Handled = False
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso Not TxtPrecio.Text.Contains(".") Then
                e.Handled = True
            Else
                If TxtPrecio.Text.Contains(".") Then
                    If Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso con < 2 Then
                        con += 1
                    Else
                        If e.KeyChar = vbBack Then
                            con -= 1
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TxtStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        ErrDatos.Clear()
        Dim iva As String
        If Op0.Checked = True Then
            iva = "0%"
        Else
            iva = "14%"
        End If

        If MessageBox.Show("Esta Seguro de Grabar el Registro", "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If ValidaEntrada(ErrDatos, GrpDatos) Then
                Dim datos As New EntArticulos(Convert.ToInt32(TxtCodigo.Text), ImgFoto.Image, TxtDescripcion.Text, CboGrupo.Text.ToString, CDec(Replace(TxtPrecio.Text, ".", ",")), Val(TxtStock.Text), iva, ChkEstado.Checked)
                If indiceMan <> 0 Then
                    logicaArt.modificar(datos)
                    MessageBox.Show("Registro Modificado Correctamente")
                Else
                    If indiceMan = 0 Then
                        logicaArt.ingresar(datos)
                        MessageBox.Show("Registro Grabado Correctamente")
                    End If
                End If
                PreConArticulos.TxtBuscar.Clear()
                Me.Dispose()
            Else
                MessageBox.Show("Error. Llene los Campos")
            End If
        Else
            MessageBox.Show("Operacion Cancelada")
        End If
        PreConArticulos.TxtBuscar.Clear()
        PreConArticulos.cargar("")
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        LimpiarGroupbox(GrpDatos)
        Me.Close()
    End Sub
End Class
