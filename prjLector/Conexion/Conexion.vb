Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Module Conexion
    Public conexion As New SqlConnection("Server=DESKTOP-E8AVPG9;Database=BD_LECTOR;User Id=sa;Password=Sistemas$2025*")
    Sub AbrirConexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    Sub CerrarConexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module