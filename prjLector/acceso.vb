Imports System.Data
Imports MySql.Data.MySqlClient

Public Class acceso

    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtUsuario.Text = "" Then
            MsgBox("Campo Usuario esta vacio")
            txtUsuario.Focus()
            Exit Sub
        End If
        If txtClave.Text = "" Then
            MsgBox("Campo Clave esta vacio")
            txtClave.Focus()
            Exit Sub
        End If

        Try
            con = New MySqlConnection("Server=localhost;Database=webproject;Uid=gleend;Pwd=gleendk;")
            con.Open()
            Dim usuario As String = txtUsuario.Text.Trim()
            Dim clave As String = txtClave.Text.Trim()
            'MsgBox("Usuario: " & usuario & " - Clave: " & clave) ' Depuración
            cmd = New MySqlCommand("SELECT * FROM users WHERE nombre_usuario = @usuario AND contrasena = @clave", con)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@clave", clave)
            rdr = cmd.ExecuteReader()

            If (rdr.Read) Then
                MsgBox("Bienvenido :" & rdr("nombre_usuario").ToString)
                'frmMenu.Show()
                Me.Hide()
            Else
                MsgBox("Usuario no existe")
                txtUsuario.Text = ""
                txtClave.Text = ""
                txtUsuario.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al conectarse: " & ex.Message)
        End Try
    End Sub

    Private Sub acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class