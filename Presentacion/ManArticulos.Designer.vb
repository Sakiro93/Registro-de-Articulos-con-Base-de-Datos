<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManArticulos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManArticulos))
        Me.CboGrupo = New System.Windows.Forms.ComboBox()
        Me.BtnSubir = New System.Windows.Forms.Button()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.GrpDatos = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Op0 = New System.Windows.Forms.RadioButton()
        Me.Op14 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImgFoto = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDatos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboGrupo
        '
        Me.CboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGrupo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.CboGrupo.FormattingEnabled = True
        Me.CboGrupo.Items.AddRange(New Object() {"ALIMENTOS" & Global.Microsoft.VisualBasic.ChrW(9), "TEXTIL", "HERRAMIENTAS", "BEBIDAS", "LIMPIEZA", "LACTEOS"})
        Me.CboGrupo.Location = New System.Drawing.Point(138, 96)
        Me.CboGrupo.Name = "CboGrupo"
        Me.CboGrupo.Size = New System.Drawing.Size(217, 27)
        Me.CboGrupo.TabIndex = 5
        '
        'BtnSubir
        '
        Me.BtnSubir.BackColor = System.Drawing.Color.GhostWhite
        Me.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrDatos.SetIconAlignment(Me.BtnSubir, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.BtnSubir.Image = CType(resources.GetObject("BtnSubir.Image"), System.Drawing.Image)
        Me.BtnSubir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSubir.Location = New System.Drawing.Point(576, 286)
        Me.BtnSubir.Name = "BtnSubir"
        Me.BtnSubir.Size = New System.Drawing.Size(137, 69)
        Me.BtnSubir.TabIndex = 86
        Me.BtnSubir.Text = "SUBIR FOTO"
        Me.BtnSubir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSubir.UseVisualStyleBackColor = False
        '
        'TxtStock
        '
        Me.TxtStock.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(138, 169)
        Me.TxtStock.MaxLength = 4
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(124, 26)
        Me.TxtStock.TabIndex = 77
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoSize = True
        Me.ChkEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkEstado.Checked = True
        Me.ChkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEstado.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstado.Location = New System.Drawing.Point(138, 280)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(80, 25)
        Me.ChkEstado.TabIndex = 1
        Me.ChkEstado.Text = "Activo"
        Me.ChkEstado.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 21)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "IVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Stock"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(138, 130)
        Me.TxtPrecio.MaxLength = 7
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(124, 26)
        Me.TxtPrecio.TabIndex = 3
        '
        'GrpDatos
        '
        Me.GrpDatos.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GrpDatos.Controls.Add(Me.Panel3)
        Me.GrpDatos.Controls.Add(Me.Panel1)
        Me.GrpDatos.Controls.Add(Me.CboGrupo)
        Me.GrpDatos.Controls.Add(Me.BtnSubir)
        Me.GrpDatos.Controls.Add(Me.TxtStock)
        Me.GrpDatos.Controls.Add(Me.ChkEstado)
        Me.GrpDatos.Controls.Add(Me.Label6)
        Me.GrpDatos.Controls.Add(Me.Label5)
        Me.GrpDatos.Controls.Add(Me.Label4)
        Me.GrpDatos.Controls.Add(Me.TxtPrecio)
        Me.GrpDatos.Controls.Add(Me.Label3)
        Me.GrpDatos.Controls.Add(Me.Label2)
        Me.GrpDatos.Controls.Add(Me.TxtDescripcion)
        Me.GrpDatos.Controls.Add(Me.Label1)
        Me.GrpDatos.Controls.Add(Me.TxtCodigo)
        Me.GrpDatos.Controls.Add(Me.Label8)
        Me.GrpDatos.ForeColor = System.Drawing.Color.Black
        Me.GrpDatos.Location = New System.Drawing.Point(17, 96)
        Me.GrpDatos.Name = "GrpDatos"
        Me.GrpDatos.Size = New System.Drawing.Size(839, 370)
        Me.GrpDatos.TabIndex = 86
        Me.GrpDatos.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel3.Controls.Add(Me.Op0)
        Me.Panel3.Controls.Add(Me.Op14)
        Me.Panel3.Location = New System.Drawing.Point(138, 223)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(146, 29)
        Me.Panel3.TabIndex = 88
        '
        'Op0
        '
        Me.Op0.AutoSize = True
        Me.Op0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Op0.Checked = True
        Me.Op0.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Op0.Location = New System.Drawing.Point(96, 3)
        Me.Op0.Name = "Op0"
        Me.Op0.Size = New System.Drawing.Size(50, 23)
        Me.Op0.TabIndex = 2
        Me.Op0.TabStop = True
        Me.Op0.Text = "0%"
        Me.Op0.UseVisualStyleBackColor = False
        '
        'Op14
        '
        Me.Op14.AutoSize = True
        Me.Op14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Op14.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Op14.Location = New System.Drawing.Point(1, 3)
        Me.Op14.Name = "Op14"
        Me.Op14.Size = New System.Drawing.Size(60, 23)
        Me.Op14.TabIndex = 3
        Me.Op14.Text = "14%"
        Me.Op14.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ImgFoto)
        Me.Panel1.Location = New System.Drawing.Point(465, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 258)
        Me.Panel1.TabIndex = 87
        '
        'ImgFoto
        '
        Me.ImgFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgFoto.Image = CType(resources.GetObject("ImgFoto.Image"), System.Drawing.Image)
        Me.ImgFoto.InitialImage = CType(resources.GetObject("ImgFoto.InitialImage"), System.Drawing.Image)
        Me.ImgFoto.Location = New System.Drawing.Point(15, 17)
        Me.ImgFoto.Name = "ImgFoto"
        Me.ImgFoto.Size = New System.Drawing.Size(318, 227)
        Me.ImgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgFoto.TabIndex = 1
        Me.ImgFoto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Grupo"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(138, 53)
        Me.TxtDescripcion.MaxLength = 19
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(217, 26)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Descripcion"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.LightGray
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Black
        Me.TxtCodigo.Location = New System.Drawing.Point(138, 17)
        Me.TxtCodigo.MaxLength = 10
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(216, 26)
        Me.TxtCodigo.TabIndex = 0
        Me.TxtCodigo.Text = "Codigo Automatico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 21)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Codigo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(17, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(839, 69)
        Me.Panel2.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(4, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(650, 28)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "MANTENIMIENTO DE ARTICULOS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Azure
        Me.Panel4.Controls.Add(Me.BtnSalir)
        Me.Panel4.Controls.Add(Me.BtnGuardar)
        Me.Panel4.Location = New System.Drawing.Point(121, 483)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(609, 73)
        Me.Panel4.TabIndex = 89
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(472, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(132, 67)
        Me.BtnSalir.TabIndex = 94
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Lavender
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(3, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(131, 67)
        Me.BtnGuardar.TabIndex = 93
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(677, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 54)
        Me.Label7.TabIndex = 93
        '
        'ManArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(880, 568)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GrpDatos)
        Me.Name = "ManArticulos"
        Me.Text = "Mantenimiento"
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDatos.ResumeLayout(False)
        Me.GrpDatos.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSubir As System.Windows.Forms.Button
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents GrpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents ChkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImgFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Op0 As System.Windows.Forms.RadioButton
    Friend WithEvents Op14 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
