Imports MySql.Data.MySqlClient
Public Class AgregaCategoría
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comandos As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet
    Private Sub AgregaCategoría_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call llenarcategorias()

    End Sub
    Public Sub llenarcategorias()

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New MySqlDataAdapter("Select * from categoria", conex)
            da.Fill(dt)
            recibecat.DataSource = dt
            recibecat.DisplayMember = "nombcat"
            recibecat.ValueMember = "nombcat"
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btbAgregaCat_Click(sender As System.Object, e As System.EventArgs) Handles btbAgregaCat.Click

        Try

            conex.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If txtnombrecat.Text = Nothing Then
                MsgBox("complete el campo")
            Else
                comandos = New MySqlCommand("INSERT INTO categoria (nombcat,desccat)" & Chr(13) &
                                              "Values(@nombcat,@desccat)", conex)

                comandos.Parameters.AddWithValue("@nombcat", txtnombrecat.Text)
                comandos.Parameters.AddWithValue("@desccat", txtdescripcion.Text)


                comandos.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txtdescripcion.Text = ""
                txtnombrecat.Text = ""
            End If
            Call llenarcategorias()

        Catch ex As Exception
            MsgBox(ex.Message)




        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class