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

    Dim nombres As New List(Of String)
    Dim precios As New List(Of Integer)
    Private Sub Facturar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gbcliente.Visible = False
        gbconsumidor.Visible = False
        gbproveedor.Visible = False

        RadioButton1.Checked = True

        rbconsumidor.Checked = False
        rbclie.Checked = False
        rbprov.Checked = False
        If Me.Visible = True Then
            fmrPrincipal.Close()

    
        End If

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



        Call mostrarlosproductos(dtgobtieneventa)


    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove


        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))





    End Sub
    Private Sub brnsalir_Click(sender As System.Object, e As System.EventArgs) Handles brnsalir.Click
        Me.Close()
        fmrPrincipal.Show()

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

    Private Sub btnañadeventa_Click(sender As System.Object, e As System.EventArgs)

       

    End Sub


    Private Sub libprod_Click(sender As Object, e As System.EventArgs)
       

    End Sub
    Private Sub mostrarlosproductos(ByVal dgv As DataGridView)
    Try
            Dim consulta As String
            consulta = "Select * from factura"
            da = New MySqlDataAdapter(consulta, conex)
            dataset = New DataSet
            dataset.Tables.Add("productosfactura")
            da.Fill(dataset, "productosfactura")
            dgv.DataSource = dataset
            dgv.DataMember = "productosfactura"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub libprod_SelectedValueChanged(sender As System.Object, e As System.EventArgs)
        Dim Indice As Integer = libprod.SelectedIndex + 1
        Dim cod As String
        txtpruebacodigoprod.Text = Indice
        Try
            libcodprod.SelectedIndex = Indice - 1
            cod = libcodprod.Text
            txtpruebanombreprod.Text = cod

        Catch ex As Exception

        End Try

    End Sub


    Private Sub txtpruebacod_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub libcodprod_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtcantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        labelfecha.Text = Date.Now.ToShortDateString


        If labelfecha.Text = My.Settings.hora Then

            Me.TopMost = True

        End If
    End Sub
    Public Sub mostrarstock(ByVal dgv As DataGridView)
        Try
            Dim producto As String
            Dim codprod As String
            producto = txtpruebanombreprod.Text
            codprod = txtpruebacodigoprod.Text

            sql = "Select * from productos where codprod='" & codprod & "' and nombprod='" & producto & "'"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            ' MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub btnañadeventa_Click_1(sender As System.Object, e As System.EventArgs) Handles btnañadeventa.Click

        Dim montofinal As Integer
        Dim fecha As Date
        Dim contenido As String
     
        Try
            '''''''''''''''''''
            Call mostrarstock(dtgrecibeprod)
            Dim nombre As String

            nombres.Add(txtpruebanombreprod.Text)

            Dim cantidaddef As Integer

            Dim precioven As Integer
            Dim cantcompra As Integer
            Dim cantidadrecibida As Integer

            cantcompra = txtcantidadcompra.Text

            precios.Add(dtgrecibeprod.Item(3, dtgrecibeprod.CurrentRow.Index).Value)
            txtrecibecantidad.Text = dtgrecibeprod.Item(4, dtgrecibeprod.CurrentRow.Index).Value
        
            cantidadrecibida = txtrecibecantidad.Text


            If cantidadrecibida <= cantidaddef Then
                MsgBox("No hay cantidad de ese producto")
            Else

                fecha = labelfecha.Text

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub libprod_SelectedValueChanged1(sender As Object, e As System.EventArgs) Handles libprod.SelectedValueChanged
        Dim Indice As Integer = libprod.SelectedIndex + 1
        Dim cod As String
        txtpruebanombreprod.Text = Indice
        Try
            libcodprod.SelectedIndex = Indice - 1
            cod = libprod.Text
            txtpruebanombreprod.Text = cod
            txtpruebacodigoprod.Text = libcodprod.Text
        Catch

        End Try
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim monto As Integer = 0
        Dim nombreprod As String = String.Join(",", nombres.ToArray())
        Dim precioprod As String = String.Join(",", precios.ToArray())
        Dim fecha As String = labelfecha.Text
        MsgBox(nombreprod)
        MsgBox(precioprod)
        MsgBox(fecha)
        MsgBox(monto)
        Try
            conex.Open()

        Catch ex As Exception

        End Try
        Try
            ' comando = New MySqlCommand("INSERT INTO factura (factfecha, contenidonombre, contenidoprecio, montofinalfact) VALUES (" & fecha & ", " & nombreprod & "," & precioprod & ", " & monto & ")")
           
            ' comando.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        
       



    End Sub
End Class