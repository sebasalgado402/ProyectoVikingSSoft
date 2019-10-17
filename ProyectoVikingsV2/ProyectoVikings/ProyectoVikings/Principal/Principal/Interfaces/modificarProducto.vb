Imports MySql.Data.MySqlClient

Public Class modificarProducto
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet

    Private Sub llamarproducto(ByVal dgv As DataGridView)
        Try
            sql = "select * from productos where codprod="
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub modificarProducto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class