Public Class frmInicio
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
            Label1.Text = "Cargando el sistema al " & ProgressBar1.Value & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            'MsgBox("Acceso Completo")
            acceso.Show()
        End If
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
