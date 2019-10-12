Imports MySql.Data.MySqlClient
Public Class AgregarCliente
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comandos As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtagrecuenta.TextChanged

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnguardarcliente_Click(sender As System.Object, e As System.EventArgs) Handles btnguardarcliente.Click
        Try
            comandos = New MySqlCommand("INSERT INTO clientes (nombcliente,dircliente,telcliente,cuentacliente)" & Chr(13) &
                                        "Values(@nombcliente,@dircliente,@telcliente,@cuentacliente)", conex)
            comandos.Parameters.AddWithValue("@nombcliente", txtagrenombre.Text)
            comandos.Parameters.AddWithValue("@dircliente", txtagredire.Text)
            comandos.Parameters.AddWithValue("@telcliente", txtagretel.Text)
            comandos.Parameters.AddWithValue("@cuentacliente", txtagrecuenta.Text)


            comandos.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtagrecuenta.Text = ""
            txtagredire.Text = ""
            txtagrenombre.Text = ""
            txtagretel.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Es posible que el código ya esté en uso/algún campo obligatorio no está completado", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub AgregarCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            conex.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncerrarcliente_Click(sender As System.Object, e As System.EventArgs) Handles btncerrarcliente.Click
        Me.Close()

    End Sub

    Private Sub btnnuevocliente_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevocliente.Click
        txtagrecuenta.Text = ""
        txtagredire.Text = ""
        txtagrenombre.Text = ""
        txtagretel.Text = ""
    End Sub
End Class