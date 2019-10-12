Public Class ingreso

    Public usuarioIngreso As String

    Private Sub ingreso_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If usuarioIngreso = "" Then
            Me.Hide()
            Form1.Show()
        End If

    End Sub
    Private Sub CheckBoxCont_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBoxCont.Checked = True Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub


    Private Sub btnIngresar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar1.Click
        Dim titulo As String = ""
        If txtUsuario.Text <> usuarioIngreso Then
            MsgBox("Usuario incorrecto", vbCritical, titulo)
        ElseIf txtContraseña.Text <> Form1.contraseña Then
            MsgBox("Contraseña incorrecta", vbCritical, titulo)
        Else

        End If
    End Sub

    Private Sub btnIngresar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar2.Click
        Dim titulo As String = ""
        If txtUsuario.Text <> usuarioIngreso Then
            MsgBox("Usuario incorrecto", vbCritical, titulo)
        ElseIf txtContraseña.Text <> Form1.contraseña Then
            MsgBox("Contraseña incorrecta", vbCritical, titulo)
        Else

        End If
    End Sub

    Private Sub btnIngresar2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIngresar2.MouseHover
        btnIngresar2.Visible = False
    End Sub

    Private Sub btnIngresar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIngresar1.MouseLeave
        btnIngresar2.Visible = True
    End Sub



End Class