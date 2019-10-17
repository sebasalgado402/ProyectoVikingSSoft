Imports MySql.Data.MySqlClient
Public Class Facturar
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Facturar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gbcliente.Visible = False
        gbconsumidor.Visible = False
        gbproveedor.Visible = False

        RadioButton1.Checked = True

        rbconsumidor.Checked = False
        rbclie.Checked = False
        rbprov.Checked = False
        conex.Open()
        Try
            Dim consulta As String
            consulta = "Select * from productos"
            da = New MySqlDataAdapter(consulta, conex)
            dataset = New DataSet
            dataset.Tables.Add("productos")
            da.Fill(dataset.Tables("productos"))
            libprod.DataSource = dataset.Tables("productos")
            libprod.DisplayMember = "nombprod"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim consulta As String
            consulta = "Select * from productos"
            da = New MySqlDataAdapter(consulta, conex)
            dataset = New DataSet
            dataset.Tables.Add("productos")
            da.Fill(dataset.Tables("productos"))
            libcodprod.DataSource = dataset.Tables("productos")
            libcodprod.DisplayMember = "codprod"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim consulta As String
            consulta = "Select * from proveedor"
            da = New MySqlDataAdapter(consulta, conex)
            dataset = New DataSet
            dataset.Tables.Add("proveedor")
            da.Fill(dataset.Tables("proveedor"))
            cbprov.DataSource = dataset.Tables("proveedor")
            cbprov.DisplayMember = "nombprov"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

      
       



    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove


        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))





    End Sub
    Private Sub brnsalir_Click(sender As System.Object, e As System.EventArgs) Handles brnsalir.Click
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub rbprov_Click(sender As System.Object, e As System.EventArgs) Handles rbprov.Click
        gbproveedor.Visible = True
        gbcliente.Visible = False
        gbconsumidor.Visible = False
    End Sub

    Private Sub rbclie_Click(sender As System.Object, e As System.EventArgs) Handles rbclie.Click
        gbcliente.Visible = True
        gbproveedor.Visible = False
        gbconsumidor.Visible = False
    End Sub

    Private Sub rbconsumidor_Click(sender As System.Object, e As System.EventArgs) Handles rbconsumidor.Click
        gbconsumidor.Visible = True
        gbcliente.Visible = False
        gbproveedor.Visible = False
    End Sub
    Private Sub RadioButton1_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton1.Click
        gbcliente.Visible = False
        gbconsumidor.Visible = False
        gbproveedor.Visible = False
    End Sub

    Private Sub Facturar_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Facturar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnañadirprov.Click
        AgregarProveedor.Show()

    End Sub


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AgregarCliente.Show()

    End Sub

    Private Sub btnañadeventa_Click(sender As System.Object, e As System.EventArgs) Handles btnañadeventa.Click

        Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
        conex.Open()
        Try
            comando = New MySqlCommand("INSERT INTO productos-factura(codprod,cantidad)" & Chr(13) &
                                                    "Values(@codprod,@cantidad)", conex)
            comando.Parameters.AddWithValue("@codprod", libcodprod.Text)
            'comando.Parameters.AddWithValue("@idventafact", libprod.Text)
            'comando.Parameters.AddWithValue("@numlineas", libprod.Text)
            comando.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
            'comando.Parameters.AddWithValue("@montolinea", libprod.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Operacion realizada", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)




        Catch ex As Exception
            MsgBox(ex.Message)
            ' MessageBox.Show("error", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  
    Private Sub libprod_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles libprod.SelectedValueChanged
        Dim Indice As Integer = libprod.SelectedIndex + 1
        txtpruebaprod.Text = Indice
        Try
            libcodprod.SelectedIndex = Indice - 1

        Catch ex As Exception

        End Try

    End Sub
    Private Sub mostrarlosproductos(ByVal dgv As DataGridView)
    Try
            Dim consulta As String
            consulta = "Select * from productos-factura"
            da = New MySqlDataAdapter(consulta, conex)
            dataset = New DataSet
            dataset.Tables.Add("productos-factura")
            da.Fill(dataset, "productos-factura")
            dgv.DataSource = dataset
            dgv.DataMember = "productos-factura"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class