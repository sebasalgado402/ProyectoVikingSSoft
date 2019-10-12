Imports MySql.Data.MySqlClient
Public Class login2
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comandos As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        End
    End Sub

    Private Sub btniniciar_Click(sender As System.Object, e As System.EventArgs) Handles btniniciar.Click
        Dim consulta As String
        Dim lista As Byte
        If txtusuario.Text <> "" And txtcontraseña.Text <> "" Then
            consulta = "select * from usuario where nombuser='" & txtusuario.Text & "' and passwduser='" & txtcontraseña.Text & "'"
            da = New MySqlDataAdapter(consulta, conex)
            dataset = New DataSet
            da.Fill(dataset, "usuario")
            lista = dataset.Tables("usuario").Rows.Count

        End If
        If lista <> 0 Then
            MsgBox("bienvenido")
            fmrPrincipal.Show()
            Me.Close()



        Else
            MsgBox("Usuario/contraseña incorrectos")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub login2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Visible = True Then
            Login.Visible = False

        End If
    End Sub
End Class