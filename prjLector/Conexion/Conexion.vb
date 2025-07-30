Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration
Module Conexion
    Public conexion As New MySqlConnection("Server=localhost;Database=webproject;Uid=gleend;Pwd=gleendk;")
    Sub AbrirConexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    Function EjecutarConsulta(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Try
            AbrirConexion()
            Dim cmd As New MySqlCommand(sql, conexion)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
        Return dt
    End Function

    Sub CerrarConexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module