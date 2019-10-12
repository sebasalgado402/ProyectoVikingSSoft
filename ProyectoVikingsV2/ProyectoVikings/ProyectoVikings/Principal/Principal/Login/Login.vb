Imports MySql.Data.MySqlClient
Public Class Login
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comandos As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Try

            conex.Open()
            MsgBox("Conexión exitosa")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Call mostrarusuario(dtgrecibe)




    End Sub
    Private Sub mostrarusuario(ByVal dgv As DataGridView)
        Try
            sql = "select * from usuario"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

            txtrecibeid.Text = dtgrecibe.Item(3, dtgrecibe.CurrentRow.Index).Value
        Catch ex As Exception

        End Try
        If txtrecibeid.Text = "" Then

        Else
            login2.Show()
            Me.Visible = False



        End If



    End Sub
    
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click



        Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
        Try
            conex.Open()

            comandos = New MySqlCommand("INSERT INTO usuario(nombuser,passwduser)" & Chr(13) &
                                        "Values(@nombuser,@passwduser)", conex)
            comandos.Parameters.AddWithValue("@nombuser", txtcrearusuario.Text)
            comandos.Parameters.AddWithValue("@passwduser", txtcrearcontraseña.Text)

            comandos.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            login2.Show()
            Me.Visible = False




        Catch ex As Exception
            MessageBox.Show("error", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        txtcrearusuario.Text = ""
        txtcrearcontraseña.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class