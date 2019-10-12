Imports MySql.Data.MySqlClient

Public Class Agregarproductos
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password='';database= vikingssoft")
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comandos As MySqlCommand
    Dim dv As DataView
    Dim dataset As DataSet

    Public Sub llenarproveedores()


        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New MySqlDataAdapter("Select * from proveedor", conex)
            da.Fill(dt)
            cbproveedor.DataSource = dt
            cbproveedor.DisplayMember = "nombprov"
            cbproveedor.ValueMember = "id_prov"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Agregarproductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            conex.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call llenarproveedores()


    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagrecerrar.Click
        Me.Close()




    End Sub

    Private Sub btnagreguardar_Click(sender As System.Object, e As System.EventArgs) Handles btnagreguardar.Click
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
            txtagercodigoprod.Text = ""
            txtagredescripcionprod.Text = ""
            txtagreexistmin.Text = ""
            txtagreexistprod.Text = ""
            txtagrenombrprod.Text = ""
            txtagreimpprod.Text = ""
            txtagrenombrprod.Text = ""
            txtagreprecio.Text = ""
            txtagrepreciofinalprod.Text = ""

        Catch ex As Exception
            MessageBox.Show("Es posible que el código ya esté en uso/algún campo obligatorio no está completado", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

  
    
    Private Sub btnagrenuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnagrenuevo.Click
        txtagercodigoprod.Text = ""
        txtagredescripcionprod.Text = ""
        txtagreexistmin.Text = ""
        txtagreexistprod.Text = ""
        txtagrenombrprod.Text = ""
        txtagreimpprod.Text = ""
        txtagrenombrprod.Text = ""
        txtagreprecio.Text = ""
        txtagrepreciofinalprod.Text = ""



    End Sub

 
End Class