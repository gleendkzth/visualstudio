Imports System.Data
Imports MySql.Data.MySqlClient

Public Class acceso

    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim intentosFallidos As Integer = 0 'Contador de intentos

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtUsuario.Text = "" Then
            MsgBox("Campo Usuario está vacío")
            txtUsuario.Focus()
            Exit Sub
        End If
        If txtClave.Text = "" Then
            MsgBox("Campo Clave está vacío")
            txtClave.Focus()
            Exit Sub
        End If

        Try
            con = New MySqlConnection("Server=localhost;Database=webproject;Uid=root;Pwd=root;")
            con.Open()
            Dim usuario As String = txtUsuario.Text.Trim()
            Dim clave As String = txtClave.Text.Trim()

            cmd = New MySqlCommand("SELECT * FROM users WHERE nombre_usuario = @usuario AND contrasena = @clave", con)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@clave", clave)
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                Dim usuarioIdActual As Integer = rdr("id")
                Dim inventarioForm As New frmInventario()
                inventarioForm.usuarioIdActual = usuarioIdActual
                inventarioForm.Show()
                Me.Hide()
            Else
                intentosFallidos += 1
                MsgBox("Usuario o clave incorrectos. Intento " & intentosFallidos & " de 3")
                txtUsuario.Text = ""
                txtClave.Text = ""
                txtUsuario.Focus()

                If intentosFallidos >= 3 Then
                    MsgBox("Demasiados intentos, cerrando programa")
                    Application.Exit()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al conectarse: " & ex.Message)
        End Try
    End Sub

    Private Sub acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Se puede dejar vacío o usarlo para cargar algo al inicio
    End Sub

End Class
