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
            If txtagrecuenta.Text = "-" Or txtagrenombre.Text = "" Then
                MsgBox("complete los campos faltantes")

            Else
                Dim tel As String
                Dim convertel As Integer
                If checktel.Checked = True Then
                    tel = ""
                    txtagretel.Text = ""
                Else
                    If txtagretel.Text = "" Then
                        tel = ""
                    Else
                        tel = txtagretel.Text
                        convertel = CType(tel, Integer)
                    End If
                End If
                Dim cuentas As String
                Dim cuentai As Integer
                If txtagrecuenta.Text = "-" Or txtagrecuenta.Text = "" Then
                    cuentai = Nothing
                Else
                    cuentas = txtagrecuenta.Text
                    cuentai = CType(cuentas, Integer)

                End If
                Dim direccion As String
                If checkdire.Checked = True Then
                    direccion = "null"
                    txtagredire.Text = "---"
                Else
                    direccion = txtagredire.Text
                End If
                If txtagredire.Text = "" Then
                    direccion = "---"
                Else
                    direccion = txtagredire.Text
                End If






                comandos = New MySqlCommand("INSERT INTO clientes (nombcliente,dircliente,telcliente,cuentacliente)" & Chr(13) &
                                            "Values(@nombcliente,@dircliente,@telcliente,@cuentacliente)", conex)
                comandos.Parameters.AddWithValue("@nombcliente", txtagrenombre.Text)
                comandos.Parameters.AddWithValue("@dircliente", direccion)
                comandos.Parameters.AddWithValue("@telcliente", convertel)
                comandos.Parameters.AddWithValue("@cuentacliente", cuentai)


                comandos.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txtagrecuenta.Text = ""
                txtagredire.Text = ""
                txtagrenombre.Text = ""
                txtagretel.Text = ""
            End If


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

    Private Sub txtagrenombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtagrenombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtagrenombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtagrenombre.TextChanged

    End Sub

    
    Private Sub txtagretel_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtagretel.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtagrecuenta_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtagrecuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub checkdire_Click(sender As System.Object, e As System.EventArgs) Handles checkdire.Click
        If checkdire.Checked = True Then

            txtagredire.Text = ""
            txtagredire.ReadOnly = True
            txtagredire.Enabled = False

        Else
            txtagredire.ReadOnly = False
            txtagredire.Enabled = True

        End If
    End Sub

    Private Sub checktel_Click(sender As System.Object, e As System.EventArgs) Handles checktel.Click
        If checktel.Checked = True Then

            txtagretel.Text = ""
            txtagretel.ReadOnly = True
            txtagretel.Enabled = False

        Else
            txtagretel.ReadOnly = False
            txtagretel.Enabled = True

        End If
    End Sub
End Class