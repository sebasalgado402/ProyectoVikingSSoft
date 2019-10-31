Imports MySql.Data.MySqlClient
Public Class AgregarProveedor



    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comandos As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        Try

            conex.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            comandos = New MySqlCommand("INSERT INTO proveedor (nombprov,rutprov,direccprov,telprov,emailprov,cuentaprov)" & Chr(13) &
                                              "Values(@nombprov,@rutprov,@direccprov,@telprov,@emailprov,@cuentaprov)", conex)

            comandos.Parameters.AddWithValue("@nombprov", txtnombre.Text)
            comandos.Parameters.AddWithValue("@rutprov", txtrut.Text)
            comandos.Parameters.AddWithValue("@direccprov", txtdireccion.Text)
            comandos.Parameters.AddWithValue("@telprov", txttelefono.Text)
            comandos.Parameters.AddWithValue("@emailprov", txtemail.Text)
            comandos.Parameters.AddWithValue("@cuentaprov", txtestadocuenta.Text)


            comandos.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtnombre.Text = ""
            txtrut.Text = ""
            txtdireccion.Text = ""
            txttelefono.Text = ""
            txtemail.Text = ""
            txtestadocuenta.Text = ""


        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Es posible que el código ya esté en uso/algún campo obligatorio no está completado", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)





        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub AgregarProveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txttelefono_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
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

    Private Sub txtestadocuenta_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtestadocuenta.KeyPress
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

    Private Sub txtrut_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtrut.KeyPress
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
End Class