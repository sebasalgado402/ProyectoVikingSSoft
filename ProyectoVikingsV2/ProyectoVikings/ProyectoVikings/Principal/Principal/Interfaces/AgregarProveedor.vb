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

        End Try

        Try
            If txtnombre.Text = "" Or txtrut.Text = "" Then
                MsgBox("complete los campos")
            Else

                Dim direccion As String
                If checkdire.Checked = True Then
                    direccion = "null"
                    txtdireccion.Text = ""


                Else

                    direccion = txtdireccion.Text
                End If
                If txtdireccion.Text = "" Then
                    direccion = ""
                Else
                    direccion = txtdireccion.Text
                End If
                '''''''''''
                Dim tel As String
                Dim teli As Integer
                If notengotel.Checked = True Then
                    teli = Nothing
                    txttelefono.Text = ""

                Else
                    tel = txttelefono.Text
                    teli = CType(tel, Integer)
                End If
                If txttelefono.Text = "" Then
                    tel = ""
                Else
                    tel = txttelefono.Text
                    teli = CType(tel, Integer)
                End If
                ''''''''''''''
                Dim email As String

                If noemail.Checked = True Then
                    email = ""
                    txtemail.Text = ""

                Else
                    email = txtemail.Text

                End If
                If txtemail.Text = "" Then
                    email = ""
                Else
                    email = txtemail.Text

                End If
                Dim estadocuenta As Integer = 0
                If txtestadocuenta.Text = "" Then

                Else
                    Dim conv As String

                    conv = txtestadocuenta.Text
                    estadocuenta = CType(conv, Integer)

                End If


                comandos = New MySqlCommand("INSERT INTO proveedor (nombprov,rutprov,direccprov,telprov,emailprov,cuentaprov)" & Chr(13) &
                                                  "Values(@nombprov,@rutprov,@direccprov,@telprov,@emailprov,@cuentaprov)", conex)

                comandos.Parameters.AddWithValue("@nombprov", txtnombre.Text)
                comandos.Parameters.AddWithValue("@rutprov", txtrut.Text)
                comandos.Parameters.AddWithValue("@direccprov", direccion)
                comandos.Parameters.AddWithValue("@telprov", teli)
                comandos.Parameters.AddWithValue("@emailprov", email)
                comandos.Parameters.AddWithValue("@cuentaprov", estadocuenta)


                comandos.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txtnombre.Text = ""
                txtrut.Text = ""
                txtdireccion.Text = ""
                txttelefono.Text = ""
                txtemail.Text = ""
                txtestadocuenta.Text = ""

            End If
        Catch ex As Exception
            MsgBox(ex.Message)





        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

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
        ElseIf (e.KeyChar = "-") Then
            e.Handled = False
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtdireccion.Text = ""
        txtemail.Text = ""
        txtnombre.Text = ""
        txtrut.Text = ""
        txttelefono.Text = ""
        txtestadocuenta.Text = ""
    End Sub

    Private Sub checkdire_Click(sender As System.Object, e As System.EventArgs) Handles checkdire.Click
        If checkdire.Checked = True Then

            txtdireccion.Text = ""
            txtdireccion.ReadOnly = True
            txtdireccion.Enabled = False

        Else
            txtdireccion.ReadOnly = False
            txtdireccion.Enabled = True

        End If
    End Sub

    Private Sub notengotel_Click(sender As System.Object, e As System.EventArgs) Handles notengotel.Click
        If notengotel.Checked = True Then

            txttelefono.Text = ""
            txttelefono.ReadOnly = True
            txttelefono.Enabled = False

        Else
            txttelefono.ReadOnly = False
            txttelefono.Enabled = True

        End If
    End Sub

    Private Sub noemail_Click(sender As System.Object, e As System.EventArgs) Handles noemail.Click
        If noemail.Checked = True Then

            txtemail.Text = ""
            txtemail.ReadOnly = True
            txtemail.Enabled = False

        Else
            txtemail.ReadOnly = False
            txtemail.Enabled = True

        End If
    End Sub
End Class