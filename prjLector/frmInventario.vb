Imports MySql.Data.MySqlClient

Public Class frmInventario
    Public usuarioIdActual As Integer ' Asignar desde el login

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim con As New MySqlConnection("Server=localhost;Database=webproject;Uid=root;Pwd=root;")
    Dim cmd As MySqlCommand

    Private Sub pnlTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub pnlTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub pnlTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        pnlDatos.Visible = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        txtId.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlDatos.Visible = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtId.Clear()
        txtCategoria.Clear()
        txtSubcategoria.Clear()
        txtCodigo.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtSerie.Clear()
        txtEstado.Clear()
        txtCantidad.Text = "1"
        txtUbicacion.Clear()
        txtObservaciones.Clear()
        txtId.Focus()
    End Sub

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtBuscar.Select()
        ' Agregar columna de botón solo si no existe
        If Not dgvInventario.Columns.Contains("Eliminar") Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.Name = "Eliminar"
            btnCol.HeaderText = "Eliminar"
            btnCol.Text = "Eliminar"
            btnCol.UseColumnTextForButtonValue = True
            dgvInventario.Columns.Add(btnCol)
        End If
        Mostrar()
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim da As New MySqlDataAdapter("SELECT * FROM inventario", con)
            da.Fill(dt)
            dgvInventario.DataSource = dt
            FormatoDgvInventario()
            lblContar.Text = "Numero de Registros :" & dgvInventario.Rows.Count
        Catch ex As Exception
            MsgBox("Error al mostrar inventario: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try
    End Sub

    Sub FormatoDgvInventario()
        If dgvInventario.Columns.Count > 0 Then
            ' Solo aplicar formato si la columna existe
            If dgvInventario.Columns.Contains("categoria") Then dgvInventario.Columns("categoria").Width = 100
            If dgvInventario.Columns.Contains("codigo") Then dgvInventario.Columns("codigo").Width = 100
            If dgvInventario.Columns.Contains("marca") Then dgvInventario.Columns("marca").Width = 100
            If dgvInventario.Columns.Contains("modelo") Then dgvInventario.Columns("modelo").Width = 100
            If dgvInventario.Columns.Contains("estado") Then dgvInventario.Columns("estado").Width = 100
            If dgvInventario.Columns.Contains("cantidad") Then dgvInventario.Columns("cantidad").Width = 60

            dgvInventario.EnableHeadersVisualStyles = False
            Dim estilo As New DataGridViewCellStyle()
            estilo.BackColor = Color.DarkBlue
            estilo.ForeColor = Color.White
            estilo.Font = New Font("Tahoma", 10, FontStyle.Regular Or FontStyle.Bold)
            dgvInventario.ColumnHeadersDefaultCellStyle = estilo

            If dgvInventario.Columns.Contains("id") Then dgvInventario.Columns("id").Visible = False
            If dgvInventario.Columns.Contains("usuario_id") Then dgvInventario.Columns("usuario_id").Visible = False
        End If
    End Sub


    Sub Buscar()
        Dim dt As New DataTable
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim da As New MySqlDataAdapter("SELECT * FROM inventario WHERE categoria LIKE @busqueda OR codigo LIKE @busqueda OR marca LIKE @busqueda", con)
            da.SelectCommand.Parameters.AddWithValue("@busqueda", "%" & txtBuscar.Text & "%")
            da.Fill(dt)
            dgvInventario.DataSource = dt
            FormatoDgvInventario()
            lblContar.Text = "Numero de Registros :" & dgvInventario.Rows.Count
        Catch ex As Exception
            MsgBox("No se puede filtrar")
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCategoria.Text <> "" And txtCodigo.Text <> "" And txtEstado.Text <> "" Then
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                cmd = New MySqlCommand("INSERT INTO inventario (categoria, subcategoria, codigo, marca, modelo, serie, estado, cantidad, ubicacion, observaciones, usuario_id) VALUES (@categoria, @subcategoria, @codigo, @marca, @modelo, @serie, @estado, @cantidad, @ubicacion, @observaciones, @usuario_id)", con)
                cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text)
                cmd.Parameters.AddWithValue("@subcategoria", txtSubcategoria.Text)
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text)
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text)
                cmd.Parameters.AddWithValue("@serie", txtSerie.Text)
                cmd.Parameters.AddWithValue("@estado", txtEstado.Text)
                cmd.Parameters.AddWithValue("@cantidad", Integer.Parse(txtCantidad.Text))
                cmd.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text)
                cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)
                cmd.Parameters.AddWithValue("@usuario_id", usuarioIdActual)
                cmd.ExecuteNonQuery()
                MsgBox("Registro guardado correctamente")
                pnlDatos.Visible = False
                Limpiar()
                Mostrar()
            Catch ex As Exception
                MsgBox("Error al guardar: " & ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try
        Else
            MsgBox("Los campos Categoría, Código y Estado son obligatorios")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtId.Text <> "" Then
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                cmd = New MySqlCommand("UPDATE inventario SET categoria=@categoria, subcategoria=@subcategoria, codigo=@codigo, marca=@marca, modelo=@modelo, serie=@serie, estado=@estado, cantidad=@cantidad, ubicacion=@ubicacion, observaciones=@observaciones WHERE id=@id", con)
                cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text)
                cmd.Parameters.AddWithValue("@subcategoria", txtSubcategoria.Text)
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text)
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text)
                cmd.Parameters.AddWithValue("@serie", txtSerie.Text)
                cmd.Parameters.AddWithValue("@estado", txtEstado.Text)
                cmd.Parameters.AddWithValue("@cantidad", Integer.Parse(txtCantidad.Text))
                cmd.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text)
                cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)
                cmd.Parameters.AddWithValue("@id", Integer.Parse(txtId.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Registro actualizado correctamente")
                pnlDatos.Visible = False
                Limpiar()
                Mostrar()
            Catch ex As Exception
                MsgBox("Error al actualizar: " & ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        Else
            MsgBox("Seleccione un registro para modificar")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtId.Text <> "" Then
            Dim result As DialogResult
            result = MsgBox("El registro sera eliminado permanentemente del sistema y ya no podra recuperarse", vbQuestion + vbOKCancel, "Sistema Inventario")
            If result = DialogResult.OK Then
                Try
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    cmd = New MySqlCommand("DELETE FROM inventario WHERE id=@id", con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(txtId.Text))
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro eliminado correctamente")
                    Limpiar()
                    Mostrar()
                Catch ex As Exception
                    MsgBox("Error al eliminar: " & ex.Message)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            Else
                MsgBox("Eliminacion Cancelada", vbInformation + vbOK, "Mensaje")
            End If
        Else
            MsgBox("Seleccione un registro para eliminar")
        End If
    End Sub

    Private Sub dgvInventario_DoubleClick(sender As Object, e As EventArgs) Handles dgvInventario.DoubleClick
        pnlDatos.Visible = True
        Try
            txtId.Text = dgvInventario.SelectedCells.Item(0).Value
            txtCategoria.Text = dgvInventario.SelectedCells.Item(1).Value
            txtSubcategoria.Text = dgvInventario.SelectedCells.Item(2).Value
            txtCodigo.Text = dgvInventario.SelectedCells.Item(3).Value
            txtMarca.Text = dgvInventario.SelectedCells.Item(4).Value
            txtModelo.Text = dgvInventario.SelectedCells.Item(5).Value
            txtSerie.Text = dgvInventario.SelectedCells.Item(6).Value
            txtEstado.Text = dgvInventario.SelectedCells.Item(7).Value
            txtCantidad.Text = dgvInventario.SelectedCells.Item(8).Value
            txtUbicacion.Text = dgvInventario.SelectedCells.Item(9).Value
            txtObservaciones.Text = dgvInventario.SelectedCells.Item(10).Value
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        Catch ex As Exception
            MsgBox("No hay datos", vbInformation + vbOK, "Mensaje")
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
        pnlDatos.Visible = False
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        pnlDatos.Visible = True
        pnlDatos.BringToFront()
        Limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtObservaciones.TextChanged

    End Sub

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pnlDatos_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatos.Paint

    End Sub

    Private Sub dgvInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellContentClick
        If e.ColumnIndex = dgvInventario.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim idEliminar As Integer = CInt(dgvInventario.Rows(e.RowIndex).Cells("id").Value)
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    cmd = New MySqlCommand("DELETE FROM inventario WHERE id=@id", con)
                    cmd.Parameters.AddWithValue("@id", idEliminar)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro eliminado correctamente")
                    Mostrar()
                Catch ex As Exception
                    MsgBox("Error al eliminar: " & ex.Message)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            End If
        End If
    End Sub
    Private Sub dgvInventario_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvInventario.CellFormatting
        ' Obtener valor de estado
        Dim estadoIndex As Integer = dgvInventario.Columns("estado").Index
        Dim estadoValor As String = dgvInventario.Rows(e.RowIndex).Cells(estadoIndex).Value?.ToString().ToLower()

        If Not String.IsNullOrEmpty(estadoValor) Then
            Select Case estadoValor
                Case "disponible"
                    dgvInventario.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220) ' Verde muy claro
                Case "en uso"
                    dgvInventario.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(235, 245, 255) ' Azul grisáceo claro
                Case "en mantenimiento"
                    dgvInventario.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 205) ' Amarillo suave
                Case "dañado"
                    dgvInventario.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238) ' Rosa pálido
                Case Else
                    dgvInventario.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End Select
        End If

        ' Estilos por columnas
        Dim colName As String = dgvInventario.Columns(e.ColumnIndex).Name

        Select Case colName
            Case "codigo"
                e.CellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                e.CellStyle.ForeColor = Color.DarkSlateBlue

            Case "cantidad"
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                e.CellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                e.CellStyle.ForeColor = Color.DarkGreen

            Case "usuario_id"
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                e.CellStyle.ForeColor = Color.Teal

            Case "modelo", "marca"
                e.CellStyle.ForeColor = Color.DarkOliveGreen

            Case "observaciones"
                e.CellStyle.Font = New Font("Segoe UI", 9, FontStyle.Italic)
                e.CellStyle.ForeColor = Color.Gray

            Case "fecha_registro"
                e.CellStyle.Format = "yyyy-MM-dd HH:mm"
                e.CellStyle.ForeColor = Color.SteelBlue
        End Select
    End Sub


    Private Sub dgvInventario_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvInventario.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim col As DataGridViewColumn = dgvInventario.Columns(e.ColumnIndex)

            If col.Name.ToLower() = "eliminar" Then
                ' Pintar fondo normal
                e.PaintBackground(e.CellBounds, True)

                ' Colores
                Dim bgColor As Color = Color.FromArgb(255, 230, 230) ' Fondo rosado claro
                Dim borderColor As Color = Color.DarkRed
                Dim textColor As Color = Color.Red

                ' Dibujar fondo del botón
                Using bgBrush As New SolidBrush(bgColor)
                    e.Graphics.FillRectangle(bgBrush, e.CellBounds)
                End Using

                ' Dibujar borde simple
                Using pen As New Pen(borderColor)
                    e.Graphics.DrawRectangle(pen, New Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1))
                End Using

                ' Dibujar texto centrado
                Dim texto As String = "Eliminar"
                Using textBrush As New SolidBrush(textColor)
                    Dim textSize As SizeF = e.Graphics.MeasureString(texto, e.CellStyle.Font)
                    Dim textX As Single = e.CellBounds.Left + (e.CellBounds.Width - textSize.Width) / 2
                    Dim textY As Single = e.CellBounds.Top + (e.CellBounds.Height - textSize.Height) / 2

                    e.Graphics.DrawString(texto, e.CellStyle.Font, textBrush, textX, textY)
                End Using

                ' Marcar evento como manejado
                e.Handled = True
            End If
        End If
    End Sub



End Class