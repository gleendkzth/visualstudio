Imports System.Data
Imports System.Data.SqlClient

Public Class acceso

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

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
            con = New SqlConnection("Data Source=DESKTOP-E8AVPG9;Initial Catalog=BD_CRUD;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select * from Usuarios where Usuario ='" & txtUsuario.Text & "' and Clave ='" & txtClave.Text & "'")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If (rdr.Read) Then
                MsgBox("Bienvenido :" & rdr("Nombre").ToString)
                'frmMenu.Show()
                Me.Hide()
            Else
                MsgBox("Usuario no existe")
                txtUsuario.Text = ""
                txtClave.Text = ""
                txtUsuario.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al conectarse")
        End Try
    End Sub

End Class