<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblContar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtSubcategoria = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Green
        Me.pnlTitulo.Controls.Add(Me.Label11)
        Me.pnlTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlTitulo.Controls.Add(Me.txtId)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(810, 40)
        Me.pnlTitulo.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label11.Location = New System.Drawing.Point(220, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(366, 31)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Registro de Inventario"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Location = New System.Drawing.Point(751, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(39, 34)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(3, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(60, 20)
        Me.txtId.TabIndex = 0
        Me.txtId.Visible = False
        '
        'lblContar
        '
        Me.lblContar.AutoSize = True
        Me.lblContar.BackColor = System.Drawing.Color.Transparent
        Me.lblContar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContar.ForeColor = System.Drawing.SystemColors.Control
        Me.lblContar.Location = New System.Drawing.Point(17, 55)
        Me.lblContar.Name = "lblContar"
        Me.lblContar.Size = New System.Drawing.Size(174, 16)
        Me.lblContar.TabIndex = 2
        Me.lblContar.Text = "Numero de Registros : 0"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(518, 55)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(180, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'dgvInventario
        '
        Me.dgvInventario.AllowUserToAddRows = False
        Me.dgvInventario.AllowUserToDeleteRows = False
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(20, 90)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.ReadOnly = True
        Me.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventario.Size = New System.Drawing.Size(770, 347)
        Me.dgvInventario.TabIndex = 4
        '
        'pnlDatos
        '
        Me.pnlDatos.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlDatos.BackgroundImage = CType(resources.GetObject("pnlDatos.BackgroundImage"), System.Drawing.Image)
        Me.pnlDatos.Controls.Add(Me.Label10)
        Me.pnlDatos.Controls.Add(Me.Label9)
        Me.pnlDatos.Controls.Add(Me.PictureBox2)
        Me.pnlDatos.Controls.Add(Me.Label8)
        Me.pnlDatos.Controls.Add(Me.Label7)
        Me.pnlDatos.Controls.Add(Me.Label6)
        Me.pnlDatos.Controls.Add(Me.Label5)
        Me.pnlDatos.Controls.Add(Me.Label4)
        Me.pnlDatos.Controls.Add(Me.Label3)
        Me.pnlDatos.Controls.Add(Me.Label2)
        Me.pnlDatos.Controls.Add(Me.Label1)
        Me.pnlDatos.Controls.Add(Me.txtCategoria)
        Me.pnlDatos.Controls.Add(Me.txtSubcategoria)
        Me.pnlDatos.Controls.Add(Me.txtCodigo)
        Me.pnlDatos.Controls.Add(Me.txtMarca)
        Me.pnlDatos.Controls.Add(Me.txtModelo)
        Me.pnlDatos.Controls.Add(Me.txtSerie)
        Me.pnlDatos.Controls.Add(Me.txtEstado)
        Me.pnlDatos.Controls.Add(Me.txtCantidad)
        Me.pnlDatos.Controls.Add(Me.txtUbicacion)
        Me.pnlDatos.Controls.Add(Me.txtObservaciones)
        Me.pnlDatos.Controls.Add(Me.btnGuardar)
        Me.pnlDatos.Controls.Add(Me.btnModificar)
        Me.pnlDatos.Controls.Add(Me.btnEliminar)
        Me.pnlDatos.Controls.Add(Me.btnCancelar)
        Me.pnlDatos.Controls.Add(Me.btnLimpiar)
        Me.pnlDatos.Location = New System.Drawing.Point(0, 38)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(810, 410)
        Me.pnlDatos.TabIndex = 5
        Me.pnlDatos.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(404, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Ubicación :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(247, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cantidad :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox2.Location = New System.Drawing.Point(3, 349)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(49, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Estado :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(404, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Serie :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(232, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Modelo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(52, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Marca :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(404, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Codigo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(232, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Subcategoria :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(52, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Categoria :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(49, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Observaciones :"
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(52, 58)
        Me.txtCategoria.Multiline = True
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(157, 40)
        Me.txtCategoria.TabIndex = 1
        '
        'txtSubcategoria
        '
        Me.txtSubcategoria.Location = New System.Drawing.Point(235, 58)
        Me.txtSubcategoria.Multiline = True
        Me.txtSubcategoria.Name = "txtSubcategoria"
        Me.txtSubcategoria.Size = New System.Drawing.Size(164, 40)
        Me.txtSubcategoria.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(407, 58)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(212, 40)
        Me.txtCodigo.TabIndex = 3
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(52, 135)
        Me.txtMarca.Multiline = True
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(157, 39)
        Me.txtMarca.TabIndex = 4
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(235, 135)
        Me.txtModelo.Multiline = True
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(163, 39)
        Me.txtModelo.TabIndex = 5
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(407, 135)
        Me.txtSerie.Multiline = True
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(212, 39)
        Me.txtSerie.TabIndex = 6
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(52, 206)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(157, 42)
        Me.txtEstado.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(237, 206)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(161, 42)
        Me.txtCantidad.TabIndex = 8
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(407, 206)
        Me.txtUbicacion.Multiline = True
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(212, 42)
        Me.txtUbicacion.TabIndex = 9
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(49, 286)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(570, 81)
        Me.txtObservaciones.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Location = New System.Drawing.Point(674, 43)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(65, 55)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Location = New System.Drawing.Point(674, 104)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(65, 55)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Location = New System.Drawing.Point(673, 169)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(66, 55)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Location = New System.Drawing.Point(674, 243)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(65, 55)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Location = New System.Drawing.Point(674, 304)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(65, 55)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.BackgroundImage = CType(resources.GetObject("btnAnadir.BackgroundImage"), System.Drawing.Image)
        Me.btnAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnadir.Location = New System.Drawing.Point(745, 46)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(45, 41)
        Me.btnAnadir.TabIndex = 16
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(449, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Buscar :"
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(810, 446)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.dgvInventario)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblContar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventario"
        Me.Text = "Inventario de Computación"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblContar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtSubcategoria As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAnadir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
