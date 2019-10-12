Public Class CrearAdvertencias

   
    Private Sub CrearAdvertencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.errores = 1 Then
            lblErrorContraseña.Visible = False
            lblErrorUsuario.Visible = False
        ElseIf Form1.errores = 2 Then
            lbl2Errores.Visible = False
            lblErrorUsuario.Visible = False
        ElseIf Form1.errores = 3 Then
            lbl2Errores.Visible = False
            lblErrorContraseña.Visible = False
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        Me.Close()

    End Sub
End Class