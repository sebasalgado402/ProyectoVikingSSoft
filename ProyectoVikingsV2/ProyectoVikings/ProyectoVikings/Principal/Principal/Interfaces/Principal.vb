Imports MySql.Data.MySqlClient
Imports System.Data

Public Class fmrPrincipal
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet



    Dim ex, ey As Integer

    Dim Arrastre As Boolean



    Private Sub panelmover_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove



        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))





    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LbHora.Text = Date.Now.ToLongTimeString
        lbfecha.Text = Date.Now.ToLongDateString

        If LbHora.Text = My.Settings.hora Then

            Me.TopMost = True

        End If

    End Sub

    Private Sub fmrPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pblogo.SendToBack()
        pblogo.Visible = False
        If Me.Visible = True Then
            Login.Visible = False
            login2.Visible = False


        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprovlista.Click
        groupblistaproveedores.Visible = True
        If groupblistaproveedores.Visible = True Then
            groupbclientelista.Visible = False
            groupbproductoLista.Visible = False
        End If
        Call mostrarlosproveedores(dtglistaproveedores)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregaproducto.Click
        Agregarproductos.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Seguro desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try




            If (opcion = DialogResult.No) Then

            Else
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox("Se ha encontrado un error, solo cierre la ventana")
        End Try
    End Sub

    Private Sub btnprodlista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprodlista.Click

        groupbproductoLista.Visible = True
        If groupbproductoLista.Visible = True Then
            groupbclientelista.Visible = False
            groupblistaproveedores.Visible = False
        End If
        Call mostrarlosproductos(dtglistaproducto)



    End Sub
    Private Sub mostrarlosproductos(ByVal dgv As DataGridView)
        Try
            sql = "select * from productos"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
    Private Sub mostrarlosproveedores(ByVal dgv As DataGridView)
        Try
            sql = "select * from proveedor"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
    Private Sub mostrarclientes(ByVal dgv As DataGridView)
        Try
            sql = "select * from clientes"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub


    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles btnmodificaproducto.Click
        modificarProducto.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnclielista.Click
        groupbclientelista.Visible = True
        If groupbclientelista.Visible = True Then
            groupbproductoLista.Visible = False
            groupblistaproveedores.Visible = False

        End If
        Call mostrarclientes(dtgclientes)

    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles btnagregaprov.Click
        AgregarProveedor.Show()

    End Sub

    Private Sub dtglistaproveedores_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        sql = dtglistaproveedores.Rows(e.RowIndex).Cells(0).Value.ToString

    End Sub

    Private Sub dtglistaproducto_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            sql = dtglistaproducto.Rows(e.RowIndex).Cells(0).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtglistaproducto_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Call mostrarlosproductos(dtglistaproducto)
    End Sub

   
    Private Sub txtcodproducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcodproducto.TextChanged
        Try
            Call consultaporcodProducto(txtcodproducto.Text, dtglistaproducto)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub consultaporcodProducto(ByVal id As String, ByVal dgv As DataGridView)
        Try
            da = New MySqlDataAdapter("select * from productos where codprod like '" & id + "%" & "'", conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub
    Private Sub consultapornombreProducto(ByVal id As String, ByVal dgv As DataGridView)
        Try
            da = New MySqlDataAdapter("select * from productos where nombprod like '" & id + "%" & "'", conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtnombreproducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnombreproducto.TextChanged
        Call consultapornombreProducto(txtnombreproducto.Text, dtglistaproducto)
    End Sub

   
    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Call mostrarlosproveedores(dtglistaproveedores)
    End Sub

   

    Private Sub dtglistaproveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglistaproveedores.CellContentClick

    End Sub
    Private Sub consultapornombreProveedor(ByVal id As String, ByVal dgv As DataGridView)
        Try
            da = New MySqlDataAdapter("select * from proveedor where nombprov like '" & id + "%" & "'", conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub
    Private Sub consultaporrutProveedor(ByVal id As String, ByVal dgv As DataGridView)
        Try
            da = New MySqlDataAdapter("select * from proveedor where rutprov like '" & id + "%" & "'", conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub
    Private Sub consultaporcliente(ByVal id As String, ByVal dgv As DataGridView)
        Try
            da = New MySqlDataAdapter("select * from clientes where nombcliente like '" & id + "%" & "'", conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub
    Private Sub txtbuscarnombreprov_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbuscarnombreprov.TextChanged
        Call consultapornombreProveedor(txtbuscarnombreprov.Text, dtglistaproveedores)

    End Sub

    Private Sub txtbuscarrutprov_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbuscarrutprov.TextChanged
        Call consultaporrutProveedor(txtbuscarrutprov.Text, dtglistaproveedores)
    End Sub

   
    
    Private Sub txtbuscacliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbuscacliente.TextChanged
        Call consultaporcliente(txtbuscacliente.Text, dtgclientes)
    End Sub

    Private Sub btnagregacliente_Click(sender As System.Object, e As System.EventArgs) Handles btnagregacliente.Click
        AgregarCliente.Show()

    End Sub

    Private Sub btnborraproducto_Click(sender As System.Object, e As System.EventArgs) Handles btnborraproducto.Click

        Call eliminarproducto()


    End Sub
    Public Sub eliminarproducto()

        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Seguro desea eliminar?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)





        If (opcion = DialogResult.No) Then



        Else

            Dim idborrar As String
            Try
                Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
                conex.Open()


                txtprueba.Text = dtglistaproducto.Item(0, dtglistaproducto.CurrentRow.Index).Value
                idborrar = txtprueba.Text


                comando = New MySqlCommand("select * from productos where idprod='" & idborrar & "'")
                comando.Parameters.AddWithValue("@idprod", idborrar)
                Dim idborrar2 As Integer
                idborrar2 = idborrar.ToString



                sql = ("delete from productos where idprod='" & idborrar & "'")
                comando = New MySqlCommand(sql, conex)
                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


            Call mostrarlosproductos(dtglistaproducto)



    End Sub
    Private Sub eliminarproveedor()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Seguro desea eliminar?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)





        If (opcion = DialogResult.No) Then

        Else
            Dim idborrar As String
            Try
                Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
                conex.Open()


                txtprueba.Text = dtglistaproveedores.Item(0, dtglistaproveedores.CurrentRow.Index).Value
                idborrar = txtprueba.Text


                comando = New MySqlCommand("select * from proveedor where idprov='" & idborrar & "'")
                comando.Parameters.AddWithValue("@idprod", idborrar)
                Dim idborrar2 As Integer
                idborrar2 = idborrar.ToString



                sql = ("delete from proveedor where id_prov='" & idborrar & "'")
                comando = New MySqlCommand(sql, conex)
                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Call mostrarlosproductos(dtglistaproducto)


    End Sub
    Private Sub eliminarcliente()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Seguro desea eliminar?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)





        If (opcion = DialogResult.No) Then

        Else

            Dim idborrar As String
            Try
                Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
                conex.Open()


                txtprueba.Text = dtgclientes.Item(0, dtgclientes.CurrentRow.Index).Value
                idborrar = txtprueba.Text


                comando = New MySqlCommand("select * from clientes where idcliente='" & idborrar & "'")
                comando.Parameters.AddWithValue("@idcliente", idborrar)
                Dim idborrar2 As Integer
                idborrar2 = idborrar.ToString



                sql = ("delete from clientes where idcliente='" & idborrar & "'")
                comando = New MySqlCommand(sql, conex)
                comando.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Call mostrarclientes(dtgclientes)

    End Sub

    Private Sub txtprueba_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtprueba.TextChanged
      
    End Sub

    Private Sub btnborraprov_Click(sender As System.Object, e As System.EventArgs) Handles btnborraprov.Click
        Call eliminarproveedor()


    End Sub

    Private Sub btnborracliente_Click(sender As System.Object, e As System.EventArgs) Handles btnborracliente.Click
        Call eliminarcliente()

    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Call mostrarclientes(dtgclientes)
    End Sub

 
    Private Sub pbcerrar_Click(sender As System.Object, e As System.EventArgs) Handles pbcerrar.Click
     

        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Seguro desea salir?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try

            If (opcion = DialogResult.No) Then
               
            Else
                Try

                    Me.Close()
                    Login.Close()



                Catch ex As Exception
                    MsgBox(ex.Message)
                    End
                End Try


            End If
        Catch ex As Exception
            MsgBox("Se ha encontrado un error, solo cierre la ventana")
        End Try


    End Sub

    Private Sub Panel4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub btnfacturar_Click(sender As System.Object, e As System.EventArgs) Handles btnfacturar.Click
        Facturar.Show()

    End Sub

    Private Sub pbcerrar_MouseHover(sender As System.Object, e As System.EventArgs) Handles pbcerrar.MouseHover
        If WindowState = FormWindowState.Maximized Then

            pbcerrar.Size = New Size(30, 30)
        ElseIf WindowState = FormWindowState.Normal Then
            panelventana.SendToBack()

            'pbcerrar.Visible = True
            pbcerrar.Location = New Point(116, 25)
            pbcerrar.Size = New Size(30, 30)


        End If
    End Sub

    Private Sub pbcerrar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles pbcerrar.MouseLeave
        If WindowState = FormWindowState.Maximized Then

            pbcerrar.Size = New Size(40, 40)
        ElseIf WindowState = FormWindowState.Normal Then
            pbcerrar.Visible = True
            pbcerrar.Location = New Point(110, 21)
            pbcerrar.Size = New Size(40, 40)


        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles pbminimizar.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles pbmaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        pbmaximizar.Visible = False
        pbrestaurar.Visible = True

    End Sub

    Private Sub pbrestaurar_Click(sender As System.Object, e As System.EventArgs) Handles pbrestaurar.Click
        Me.WindowState = FormWindowState.Normal
        pbmaximizar.Visible = True
        pbrestaurar.Visible = False

    End Sub

    
    Private Sub Panel5_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles panelventana.Paint
        Me.BringToFront()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Notas.Show()

    End Sub

    Private Sub groupbproductoLista_Enter(sender As System.Object, e As System.EventArgs) Handles groupbproductoLista.Enter

    End Sub

    Private Sub dtglistaproducto_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglistaproducto.CellContentClick

    End Sub
End Class
