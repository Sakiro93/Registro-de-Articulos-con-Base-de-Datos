Imports Entidad
Imports Logica
Public Class PreConArticulos
    Dim ObjLogArt As New LogArticulos
    Public indice As Integer = 0
    Private Sub PreConArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        cargar("")
    End Sub
    Public Property ArIndice() As Integer
        Get
            Return indice
        End Get
        Set(ByVal value As Integer)
            indice = value
        End Set
    End Property

    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        For Each ar In ObjLogArt.buscar(Buscar)
            Dg.Rows.Add(ar.Codigo, ar.Imagen, ar.Descripcion, ar.Grupo, ar.Precio, ar.Stock, ar.Iva, ar.Estado)
        Next
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        indice = 0
        ManArticulos.ShowDialog()
    End Sub
    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        TxtBuscar.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtBuscar.Text)
        TxtBuscar.SelectionStart = TxtBuscar.Text.Length
        cargar(TxtBuscar.Text.Trim)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Dg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dg.Click
        Dim ind As Integer = Dg.CurrentRow.Index
        Dim cad As String = Dg.Rows(ind).Cells(2).Value.ToString
        Dim codbuscar As String = Dg.Rows(ind).Cells(0).Value.ToString
        If Dg.CurrentCell.ColumnIndex = 8 Then
            indice = Dg.CurrentRow.Index
            ArIndice = Convert.ToInt32(codbuscar)
            ManArticulos.ShowDialog()
            TxtBuscar.Clear()
            cargar("")
        Else
            If Dg.CurrentCell.ColumnIndex = 9 Then
                If MessageBox.Show("Esta Seguro De Eliminar El Registro" + Chr(13) + Chr(13) + cad, "Sistema Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    ObjLogArt.eliminar(codbuscar)
                    TxtBuscar.Clear()
                    MessageBox.Show("Registro Eliminado Correctamente")
                Else
                    MessageBox.Show("Operacion Cancelada")
                End If
                cargar("")
            End If
        End If
    End Sub


End Class