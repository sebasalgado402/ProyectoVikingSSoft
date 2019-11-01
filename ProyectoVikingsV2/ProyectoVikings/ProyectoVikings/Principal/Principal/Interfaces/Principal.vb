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
        Try
            Me.Close()

            Agregarproductos.Show()
        Catch ex As Exception

        End Try

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
        Pmodprod.Visible = True
        Pmodprod.BringToFront()


        Dim idproducto As String
        txtrecibeidprod.Text = dtglistaproducto.Item(0, dtglistaproducto.CurrentRow.Index).Value
        idproducto = txtrecibeidprov.Text

        txtmodprodcod.Text = dtglistaproducto.Item(1, dtglistaproducto.CurrentRow.Index).Value

        txtmodnombproducto.Text = dtglistaproducto.Item(2, dtglistaproducto.CurrentRow.Index).Value

        txtmodprecio.Text = dtglistaproducto.Item(3, dtglistaproducto.CurrentRow.Index).Value

        txtmodexistenciaproducto.Text = dtglistaproducto.Item(4, dtglistaproducto.CurrentRow.Index).Value

        txtmoddesc.Text = dtglistaproducto.Item(5, dtglistaproducto.CurrentRow.Index).Value

      


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

        Call mostrarlosproveedores(dtglistaproveedores)

    End Sub

    Private Sub btnborracliente_Click(sender As System.Object, e As System.EventArgs) Handles btnborracliente.Click
        Call eliminarcliente()
        Call mostrarclientes(dtgclientes)

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

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs)
        pmodificarprov.Visible = False

    End Sub

    Private Sub TextBox13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtmodestadocuentacliente.TextChanged

    End Sub

    Private Sub Label44_Click(sender As System.Object, e As System.EventArgs) Handles Label44.Click

    End Sub

    Private Sub btnmodificaprov_Click(sender As System.Object, e As System.EventArgs) Handles btnmodificaprov.Click
        pmodificarprov.Visible = True
        pmodificarprov.BringToFront()
        Dim idprove As String
        txtrecibeidprov.Text = dtglistaproveedores.Item(0, dtglistaproveedores.CurrentRow.Index).Value
        idprove = txtrecibeidprov.Text

        txtmodnombreprov.Text = dtglistaproveedores.Item(1, dtglistaproveedores.CurrentRow.Index).Value

        txtmodrutprov.Text = dtglistaproveedores.Item(2, dtglistaproveedores.CurrentRow.Index).Value

        txtmoddirecprov.Text = dtglistaproveedores.Item(3, dtglistaproveedores.CurrentRow.Index).Value

        txtmodtelprov.Text = dtglistaproveedores.Item(4, dtglistaproveedores.CurrentRow.Index).Value

        txtmodemailprov.Text = dtglistaproveedores.Item(5, dtglistaproveedores.CurrentRow.Index).Value

        txtmodestadocuentaprov.Text = dtglistaproveedores.Item(6, dtglistaproveedores.CurrentRow.Index).Value

        

    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        pmodificarprov.Visible = False
        Call mostrarlosproveedores(dtglistaproveedores)

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        pmodificarClientes.Visible = False
        Call mostrarclientes(dtgclientes)
    End Sub

    Private Sub btnmodificacliente_Click(sender As System.Object, e As System.EventArgs) Handles btnmodificacliente.Click
        pmodificarClientes.Visible = True
        pmodificarClientes.BringToFront()
        Dim idcliente As String
        txtrecibeidcliente.Text = dtgclientes.Item(0, dtgclientes.CurrentRow.Index).Value
        idcliente = txtrecibeidcliente.Text

        txtmodnombcliente.Text = dtgclientes.Item(1, dtgclientes.CurrentRow.Index).Value
        txtmoddireccliente.Text = dtgclientes.Item(2, dtgclientes.CurrentRow.Index).Value
        txtmodtelefcliente.Text = dtgclientes.Item(3, dtgclientes.CurrentRow.Index).Value
        txtmodestadocuentacliente.Text = dtgclientes.Item(4, dtgclientes.CurrentRow.Index).Value




    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs)
        pmodificarClientes.Visible = False

    End Sub

    Private Sub Button9_Click_1(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Pmodprod.Visible = False
        Call mostrarlosproductos(dtglistaproducto)

    End Sub
    
    Private Sub txtmodtelefcliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmodtelefcliente.KeyPress
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

    Private Sub txtmodestadocuentacliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmodestadocuentacliente.KeyPress
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

    Private Sub txtmodexistenciaproducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmodexistenciaproducto.KeyPress
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

    Private Sub txtmodprecio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmodprecio.KeyPress
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

    Private Sub txtmodimpuesto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtmodtelprov_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmodtelprov.KeyPress
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

    Private Sub txtmodestadocuentaprov_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmodestadocuentaprov.KeyPress
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

    Private Sub txtmodrutprov_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmodrutprov.KeyPress
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

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnmodificarprov.Click
        Try

            conex.Open()
        Catch ex As Exception

        End Try

        Try
            If txtmodnombreprov.Text = Nothing Or txtmodrutprov.Text = Nothing Or txtmoddirecprov.Text = Nothing Or txtmodtelprov.Text = Nothing Or txtmodemailprov.Text = Nothing Or txtmodestadocuentaprov.Text = Nothing Then
                MsgBox("complete el campo")
            Else


                comando = New MySqlCommand("Update proveedor set nombprov='" & txtmodnombreprov.Text & "' ,rutprov='" & txtmodrutprov.Text & "',direccprov='" & txtmoddirecprov.Text & "',telprov='" & txtmodtelprov.Text & "',emailprov='" & txtmodemailprov.Text & "',cuentaprov='" & txtmodestadocuentaprov.Text & "' where id_prov='" & txtrecibeidprov.Text & "'", conex)


                comando.Parameters.AddWithValue("@nombprov", txtmodnombreprov.Text)
                comando.Parameters.AddWithValue("@rutprov", txtmodrutprov.Text)
                comando.Parameters.AddWithValue("@direccprov", txtmoddirecprov.Text)
                comando.Parameters.AddWithValue("@telprov", txtmodtelprov.Text)
                comando.Parameters.AddWithValue("@emailprov", txtmodemailprov.Text)
                comando.Parameters.AddWithValue("@cuentaprov", txtmodestadocuentaprov.Text)
                Try
                    comando.ExecuteNonQuery()
                Catch ex As Exception

                End Try

                MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
               
            End If

        Catch ex As MySqlException





        End Try
    End Sub

    Private Sub btnmodificarproducto_Click_1(sender As System.Object, e As System.EventArgs) Handles btnmodificarproducto.Click
        Try
            conex.Open()
        Catch ex As MySqlException

        End Try

        If txtmodprodcod.Text = Nothing Or txtmodnombproducto.Text = Nothing Or txtmodexistenciaproducto.Text = Nothing Or txtmodprecio.Text = Nothing Then
            MsgBox("Complete los campos")
       
        Else

            
            Try
                comando = New MySqlCommand("Update productos set codprod='" & txtmodprodcod.Text & "' ,nombprod='" & txtmodnombproducto.Text & "',precioprod='" & txtmodprecio.Text & "',stockprod='" & txtmodexistenciaproducto.Text & "' ,descprod='" & txtmoddesc.Text & "' where idprod='" & txtrecibeidprod.Text & "'", conex)


                comando.Parameters.AddWithValue("@codprod", txtmodprodcod.Text)
                comando.Parameters.AddWithValue("@nombprod", txtmodnombproducto.Text)
                comando.Parameters.AddWithValue("@precioprod", txtmodprecio.Text)
                comando.Parameters.AddWithValue("@stockprod", txtmodexistenciaproducto.Text)
                comando.Parameters.AddWithValue("@descprod", txtmoddesc.Text)

                comando.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                conex.Close()

            Catch ex As MySqlException

            End Try


        End If
    End Sub

    Private Sub dtglistaproveedores_Click(sender As System.Object, e As System.EventArgs) Handles dtglistaproveedores.Click

    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles btnmodificarclientes.Click
        Try

            conex.Open()
        Catch ex As Exception

        End Try

        Try
            If txtmodnombcliente.Text = Nothing Or txtmoddireccliente.Text = Nothing Or txtmodtelefcliente.Text = Nothing Or txtmodestadocuentacliente.Text = Nothing Then
                MsgBox("complete el campo faltante")
            Else

                Dim ec As Integer
                ec = CType(txtmodestadocuentacliente.Text, Integer)
                comando = New MySqlCommand("Update clientes set nombcliente='" & txtmodnombcliente.Text & "' ,dircliente='" & txtmoddireccliente.Text & "',telcliente='" & txtmodtelefcliente.Text & "',cuentacliente='" & ec & "' where idcliente='" & txtrecibeidcliente.Text & "'", conex)


                comando.Parameters.AddWithValue("@nombcliente", txtmodnombcliente.Text)
                comando.Parameters.AddWithValue("@dircliente", txtmoddireccliente.Text)
                comando.Parameters.AddWithValue("@telcliente", txtmodtelefcliente.Text)
                comando.Parameters.AddWithValue("@cuentacliente", ec)

                Try
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Datos Guardados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



            End If

        Catch ex As MySqlException


            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub btnprodlista_MouseHover(sender As Object, e As System.EventArgs) Handles btnprodlista.MouseHover
        btnprodlista.BackColor = Color.SeaGreen
    End Sub
   
    Private Sub btnprodlista_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnprodlista.MouseLeave

        btnprodlista.BackColor = Color.LightSeaGreen
    End Sub
  
    Private Sub btnclielista_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnclielista.MouseHover
        btnclielista.BackColor = Color.SeaGreen
    End Sub

    Private Sub btnclielista_MouseLeave(sender As Object, e As System.EventArgs) Handles btnclielista.MouseLeave
        btnclielista.BackColor = Color.LightSeaGreen
    End Sub

    Private Sub btnprovlista_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnprovlista.MouseHover
        btnprovlista.BackColor = Color.SeaGreen
    End Sub

    Private Sub btnprovlista_MouseLeave(sender As Object, e As System.EventArgs) Handles btnprovlista.MouseLeave
        btnprovlista.BackColor = Color.LightSeaGreen
    End Sub

    
    Private Sub btnfacturar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnfacturar.MouseHover
        btnfacturar.BackColor = Color.SeaGreen
    End Sub

    Private Sub btnfacturar_MouseLeave(sender As Object, e As System.EventArgs) Handles btnfacturar.MouseLeave
        btnfacturar.BackColor = Color.LightSeaGreen
    End Sub

    Private Sub dtglistaproducto_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dtglistaproducto.CellFormatting

        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewCell = dtglistaproducto(e.ColumnIndex, e.RowIndex)

            If row.Value <= "5" Then

                row.Style.BackColor = Color.Red

            End If

        End If
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewCell = dtglistaproducto(e.ColumnIndex, e.RowIndex)

            If row.Value >= "6" And row.Value <= "9" Then

                row.Style.BackColor = Color.Orange

            End If

        End If
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewCell = dtglistaproducto(e.ColumnIndex, e.RowIndex)

            If row.Value >= "10" Then

                row.Style.BackColor = Color.Green

            End If

        End If



    End Sub

    Private Sub dtglistaproveedores_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dtglistaproveedores.CellFormatting
        If e.ColumnIndex = 6 Then
            Dim row As DataGridViewCell = dtglistaproveedores(e.ColumnIndex, e.RowIndex)

            If row.Value >= "1" Then

                row.Style.BackColor = Color.Red
            ElseIf row.Value = "0" Then
                row.Style.BackColor = Color.Gray
            End If

        End If
        If e.ColumnIndex = 6 Then
            Dim row As DataGridViewCell = dtglistaproveedores(e.ColumnIndex, e.RowIndex)

            If row.Value < "0" Then

                row.Style.BackColor = Color.Green

            End If

        End If


    End Sub

    Private Sub dtgclientes_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dtgclientes.CellFormatting
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewCell = dtgclientes(e.ColumnIndex, e.RowIndex)

            If row.Value >= "1" Then

                row.Style.BackColor = Color.Red
            ElseIf row.Value = "0" Then
                row.Style.BackColor = Color.Gray
            End If

        End If
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewCell = dtgclientes(e.ColumnIndex, e.RowIndex)

            If row.Value < "0" Then

                row.Style.BackColor = Color.Green

            End If

        End If

    End Sub
    Private Sub mostrarlosproductospornombre(ByVal dgv As DataGridView)
        Try
            sql = "select * from productos order by nombprod ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try




    End Sub
    Private Sub mostrarlosproductosporcodprod(ByVal dgv As DataGridView)
        Try
            sql = "select * from productos order by codprod ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub mostrarlosproductosporprecio(ByVal dgv As DataGridView)
        Try
            sql = "select * from productos order by precioprod ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try




    End Sub
    Private Sub mostrarlosproductosporstock(ByVal dgv As DataGridView)
        Try
            sql = "select * from productos order by stockprod ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try




    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Call mostrarlosproductospornombre(dtglistaproducto)
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Call mostrarlosproductosporcodprod(dtglistaproducto)
    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Call mostrarlosproductosporprecio(dtglistaproducto)
    End Sub

    Private Sub Button6_Click_2(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Call mostrarlosproductosporstock(dtglistaproducto)
    End Sub

    Private Sub Button2_Click_2(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call mostrarlosproveedorespornombre(dtglistaproveedores)
    End Sub
    Private Sub mostrarlosproveedorespornombre(ByVal dgv As DataGridView)
        Try
            sql = "select * from proveedor order by nombprov ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub mostrarlosproveedoresporestadocuenta(ByVal dgv As DataGridView)
        Try
            sql = "select * from proveedor order by cuentaprov ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Call mostrarlosproveedoresporestadocuenta(dtglistaproveedores)
    End Sub


    Private Sub Button12_Click_1(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Call mostrarlosclientespornombre(dtgclientes)
    End Sub

    Private Sub Button3_Click_2(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call mostrarlosclientesporestadocuenta(dtgclientes)
    End Sub
    Private Sub mostrarlosclientesporestadocuenta(ByVal dgv As DataGridView)
        Try
            sql = "select * from clientes order by cuentacliente ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub mostrarlosclientespornombre(ByVal dgv As DataGridView)
        Try
            sql = "select * from clientes order by nombcliente ASC"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
