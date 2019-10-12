Public Class Form1

    Public usuario As String
    Public contraseña As String
    Dim titulo As String = ""

    Private Sub btnCrear2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCrear2.MouseHover
        btnCrear2.Visible = False
    End Sub

    Private Sub btnCrear1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCrear1.MouseLeave
        btnCrear2.Visible = True
    End Sub

    Private Sub CheckBoxCont_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxCont.CheckedChanged
        If CheckBoxCont.Checked = True Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub



    Private Sub btnCrear1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear1.Click
        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text
        Dim creado As Integer

        If usuario & contraseña = "" Then
            MsgBox("Ingrese usuario y contraseña", vbExclamation, titulo)
        ElseIf txtContraseña.Text = "" Then
            MsgBox("Ingrese contraseña", vbExclamation, titulo)
        ElseIf txtUsuario.Text = "" Then
            MsgBox("Ingrese usuario", vbExclamation, titulo)
        Else
            MsgBox("Se ha creado el usuario")
            creado = 1
        End If

        If creado = 1 Then
            ingreso.usuarioIngreso = usuario
            ingreso.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCrear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear2.Click
        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text
        Dim creado As Integer

        If txtUsuario.Text & txtContraseña.Text = "" Then
            MsgBox("Ingrese usuario y contraseña", vbExclamation, titulo)
        ElseIf txtContraseña.Text = "" Then
            MsgBox("Ingrese contraseña", vbExclamation, titulo)
        ElseIf txtUsuario.Text = "" Then
            MsgBox("Ingrese usuario", vbExclamation, titulo)
        Else
            MsgBox("Se ha creado el usuario")
            creado = 1
        End If

        If creado = 1 Then
            ingreso.usuarioIngreso = usuario
            ingreso.Show()
            Me.Hide()
        End If
    End Sub



End Class
