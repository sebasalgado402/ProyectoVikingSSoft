Imports MySql.Data.MySqlClient

Public Class Agregarproductos
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim dta As DataTable
    Dim sql As String
    Dim comandos As MySqlCommand
    Dim comandos1 As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet

    Public Sub llenarproveedores()


        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New MySqlDataAdapter("Select * from proveedor", conex)
            da.Fill(dt)
            recibeprov.DataSource = dt
            recibeprov.DisplayMember = "nombprov"
            recibeprov.ValueMember = "nombprov"
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
       




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
    Private Sub Agregarproductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            conex.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call llenarcategorias()
        Call llenarproveedores()


    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagrecerrar.Click
        Me.Close()
        fmrPrincipal.Show()




    End Sub

    Private Sub btnagreguardar_Click(sender As System.Object, e As System.EventArgs) Handles btnagreguardar.Click
        Dim codigo As String
        Dim codigo2 As String
        If txtagercodigoprod.Text = Nothing Or txtagrenombrprod.Text = Nothing Or txtagreexistprod.Text = Nothing Or txtagreprecio.Text = Nothing Then
            MsgBox("Complete los campos")
        ElseIf recibecat.Text = "" Then
            MsgBox("Seleccione una categoría o Cree una para continuar")
        ElseIf recibeprov.Text = "" Then
            MsgBox("Seleccione un proveedor o cree uno")
        Else

            Try
                comandos = New MySqlCommand("INSERT INTO productos (codprod,nombprod,precioprod,stockprod,descprod)" & Chr(13) &
                                            "Values(@codprod,@nombprod,@precioprod,@stockprod,@descprod)", conex)
                comandos.Parameters.AddWithValue("@codprod", txtagercodigoprod.Text)
                comandos.Parameters.AddWithValue("@nombprod", txtagrenombrprod.Text)
                comandos.Parameters.AddWithValue("@precioprod", txtagreprecio.Text)
                comandos.Parameters.AddWithValue("@stockprod", txtagreexistprod.Text)
                comandos.Parameters.AddWithValue("@descprod", txtagredescripcionprod.Text)

                comandos.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Catch ex As MySqlException

            End Try

            Try

                codigo = txtagercodigoprod.Text
                codigo2 = txtagercodigoprod.Text
                comandos = New MySqlCommand("INSERT INTO productosproveedor (codprod,nombprov)" & Chr(13) &
                                            "Values(@codprod,@nombprod)", conex)
                comandos.Parameters.AddWithValue("@codprod", codigo)
                comandos.Parameters.AddWithValue("@nombprod", recibeprov.Text)


                comandos.ExecuteNonQuery()




                comandos1 = New MySqlCommand("INSERT INTO productoscategoria (codprod,nombcat)" & Chr(13) &
                                            "Values(@codprod,@nombcat)", conex)
                comandos1.Parameters.AddWithValue("@codprod", codigo2)
                comandos1.Parameters.AddWithValue("@nombcat", recibecat.Text)


                comandos1.ExecuteNonQuery()

                txtagercodigoprod.Text = ""
                txtagredescripcionprod.Text = ""

                txtagreexistprod.Text = ""
                txtagrenombrprod.Text = ""
                txtagreimpprod.Text = ""
                txtagrenombrprod.Text = ""
                txtagreprecio.Text = ""
                txtagrepreciofinalprod.Text = ""

            


           

            Catch ex As MySqlException
                'MessageBox.Show("Es posible que el código ya esté en uso/algún campo obligatorio no está completado", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox("Codigo ya existente")


            End Try

        End If

    End Sub



    Private Sub btnagrenuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnagrenuevo.Click
        txtagercodigoprod.Text = ""
        txtagredescripcionprod.Text = ""

        txtagreexistprod.Text = ""
        txtagrenombrprod.Text = ""
        txtagreimpprod.Text = ""
        txtagrenombrprod.Text = ""
        txtagreprecio.Text = ""
        txtagrepreciofinalprod.Text = ""



    End Sub


    Private Sub txtagreexistprod_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtagreexistprod.TextChanged

    End Sub
    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles brnagregarprov.Click
        AgregarProveedor.Show()

        If AgregarProveedor.Visible = False Then
            Call llenarproveedores()
            Call llenarcategorias()
        End If


    End Sub




    Private Sub recibeprov_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles recibeprov.SelectedValueChanged
        Dim Indice As Integer = recibeprov.SelectedIndex + 1
        Dim cod As String
        txtpruebacod.Text = Indice
        Try
            recibeprov.SelectedIndex = Indice - 1
            cod = recibeprov.Text
            txtpruebacod.Text = cod
        Catch


        End Try
    End Sub

    Private Sub recibeprov_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles recibeprov.SelectedIndexChanged

    End Sub

    Private Sub btnagregarcat_Click(sender As System.Object, e As System.EventArgs) Handles btnagregarcat.Click
        AgregaCategoría.Show()

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Call llenarcategorias()
        Call llenarproveedores()

    End Sub

    Private Sub recibecat_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles recibecat.SelectedValueChanged
        Dim Indice As Integer = recibecat.SelectedIndex + 1
        Dim cod As String
        txtpruebacod2.Text = Indice
        Try
            recibecat.SelectedIndex = Indice - 1
            cod = recibecat.Text
            txtpruebacod2.Text = cod
        Catch

        End Try
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtagreexistprod_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtagreexistprod.KeyPress
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

    Private Sub txtagreprecio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtagreprecio.KeyPress
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

    Private Sub txtagreimpprod_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtagreimpprod.KeyPress
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