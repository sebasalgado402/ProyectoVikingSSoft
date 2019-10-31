<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregarproductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtagercodigoprod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtagrenombrprod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.recibecat = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.recibeprov = New System.Windows.Forms.ListBox()
        Me.btnagregarcat = New System.Windows.Forms.Button()
        Me.brnagregarprov = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtagredescripcionprod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtagreexistprod = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtpruebacod2 = New System.Windows.Forms.TextBox()
        Me.txtpruebacod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtagrepreciofinalprod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtagreimpprod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtagreprecio = New System.Windows.Forms.TextBox()
        Me.btnagrenuevo = New System.Windows.Forms.Button()
        Me.btnagreguardar = New System.Windows.Forms.Button()
        Me.btnagrecerrar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtagercodigoprod
        '
        Me.txtagercodigoprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagercodigoprod.Location = New System.Drawing.Point(159, 18)
        Me.txtagercodigoprod.Name = "txtagercodigoprod"
        Me.txtagercodigoprod.Size = New System.Drawing.Size(141, 24)
        Me.txtagercodigoprod.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OliveDrab
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(97, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'txtagrenombrprod
        '
        Me.txtagrenombrprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagrenombrprod.Location = New System.Drawing.Point(159, 60)
        Me.txtagrenombrprod.Name = "txtagrenombrprod"
        Me.txtagrenombrprod.Size = New System.Drawing.Size(171, 24)
        Me.txtagrenombrprod.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.OliveDrab
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.OliveDrab
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Proveedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.recibecat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.recibeprov)
        Me.GroupBox1.Controls.Add(Me.btnagregarcat)
        Me.GroupBox1.Controls.Add(Me.brnagregarprov)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtagredescripcionprod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtagrenombrprod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtagercodigoprod)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Básicos"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(219, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 52)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Actualizar Listas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'recibecat
        '
        Me.recibecat.FormattingEnabled = True
        Me.recibecat.ItemHeight = 18
        Me.recibecat.Location = New System.Drawing.Point(313, 103)
        Me.recibecat.Name = "recibecat"
        Me.recibecat.Size = New System.Drawing.Size(147, 94)
        Me.recibecat.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.OliveDrab
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(236, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Categoria"
        '
        'recibeprov
        '
        Me.recibeprov.FormattingEnabled = True
        Me.recibeprov.ItemHeight = 18
        Me.recibeprov.Location = New System.Drawing.Point(83, 103)
        Me.recibeprov.Name = "recibeprov"
        Me.recibeprov.Size = New System.Drawing.Size(147, 94)
        Me.recibeprov.TabIndex = 15
        '
        'btnagregarcat
        '
        Me.btnagregarcat.ForeColor = System.Drawing.Color.Black
        Me.btnagregarcat.Location = New System.Drawing.Point(362, 203)
        Me.btnagregarcat.Name = "btnagregarcat"
        Me.btnagregarcat.Size = New System.Drawing.Size(98, 52)
        Me.btnagregarcat.TabIndex = 14
        Me.btnagregarcat.Text = "Nueva Categoría"
        Me.btnagregarcat.UseVisualStyleBackColor = True
        '
        'brnagregarprov
        '
        Me.brnagregarprov.ForeColor = System.Drawing.Color.Black
        Me.brnagregarprov.Location = New System.Drawing.Point(83, 203)
        Me.brnagregarprov.Name = "brnagregarprov"
        Me.brnagregarprov.Size = New System.Drawing.Size(95, 52)
        Me.brnagregarprov.TabIndex = 13
        Me.brnagregarprov.Text = "Nuevo Proveedor"
        Me.brnagregarprov.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.OliveDrab
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(486, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Descripción(Opcional)"
        '
        'txtagredescripcionprod
        '
        Me.txtagredescripcionprod.Location = New System.Drawing.Point(477, 45)
        Me.txtagredescripcionprod.Multiline = True
        Me.txtagredescripcionprod.Name = "txtagredescripcionprod"
        Me.txtagredescripcionprod.Size = New System.Drawing.Size(195, 173)
        Me.txtagredescripcionprod.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.OliveDrab
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(195, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Stock"
        '
        'txtagreexistprod
        '
        Me.txtagreexistprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagreexistprod.Location = New System.Drawing.Point(248, 39)
        Me.txtagreexistprod.Name = "txtagreexistprod"
        Me.txtagreexistprod.Size = New System.Drawing.Size(111, 24)
        Me.txtagreexistprod.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtagreexistprod)
        Me.GroupBox3.Controls.Add(Me.txtpruebacod2)
        Me.GroupBox3.Controls.Add(Me.txtpruebacod)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtagrepreciofinalprod)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtagreimpprod)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtagreprecio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(689, 198)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Precio y Stock"
        '
        'txtpruebacod2
        '
        Me.txtpruebacod2.Location = New System.Drawing.Point(23, 84)
        Me.txtpruebacod2.Name = "txtpruebacod2"
        Me.txtpruebacod2.Size = New System.Drawing.Size(100, 24)
        Me.txtpruebacod2.TabIndex = 14
        Me.txtpruebacod2.Visible = False
        '
        'txtpruebacod
        '
        Me.txtpruebacod.Location = New System.Drawing.Point(23, 42)
        Me.txtpruebacod.Name = "txtpruebacod"
        Me.txtpruebacod.Size = New System.Drawing.Size(100, 24)
        Me.txtpruebacod.TabIndex = 13
        Me.txtpruebacod.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.OliveDrab
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(314, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "(Opcional)"
        '
        'txtagrepreciofinalprod
        '
        Me.txtagrepreciofinalprod.Enabled = False
        Me.txtagrepreciofinalprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagrepreciofinalprod.Location = New System.Drawing.Point(283, 161)
        Me.txtagrepreciofinalprod.Name = "txtagrepreciofinalprod"
        Me.txtagrepreciofinalprod.Size = New System.Drawing.Size(105, 24)
        Me.txtagrepreciofinalprod.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.OliveDrab
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(124, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Precio Costo con Imp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.OliveDrab
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(156, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Impuesto %"
        '
        'txtagreimpprod
        '
        Me.txtagreimpprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagreimpprod.Location = New System.Drawing.Point(248, 126)
        Me.txtagreimpprod.Name = "txtagreimpprod"
        Me.txtagreimpprod.Size = New System.Drawing.Size(60, 24)
        Me.txtagreimpprod.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.OliveDrab
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(146, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Precio Costo"
        '
        'txtagreprecio
        '
        Me.txtagreprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagreprecio.Location = New System.Drawing.Point(248, 83)
        Me.txtagreprecio.Name = "txtagreprecio"
        Me.txtagreprecio.Size = New System.Drawing.Size(105, 24)
        Me.txtagreprecio.TabIndex = 0
        '
        'btnagrenuevo
        '
        Me.btnagrenuevo.Location = New System.Drawing.Point(12, 497)
        Me.btnagrenuevo.Name = "btnagrenuevo"
        Me.btnagrenuevo.Size = New System.Drawing.Size(96, 48)
        Me.btnagrenuevo.TabIndex = 12
        Me.btnagrenuevo.Text = "Limpiar"
        Me.btnagrenuevo.UseVisualStyleBackColor = True
        '
        'btnagreguardar
        '
        Me.btnagreguardar.Location = New System.Drawing.Point(317, 497)
        Me.btnagreguardar.Name = "btnagreguardar"
        Me.btnagreguardar.Size = New System.Drawing.Size(96, 48)
        Me.btnagreguardar.TabIndex = 13
        Me.btnagreguardar.Text = "Guardar"
        Me.btnagreguardar.UseVisualStyleBackColor = True
        '
        'btnagrecerrar
        '
        Me.btnagrecerrar.Location = New System.Drawing.Point(605, 497)
        Me.btnagrecerrar.Name = "btnagrecerrar"
        Me.btnagrecerrar.Size = New System.Drawing.Size(96, 48)
        Me.btnagrecerrar.TabIndex = 14
        Me.btnagrecerrar.Text = "Cerrar"
        Me.btnagrecerrar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(499, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 24)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Visible = False
        '
        'Agregarproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(713, 551)
        Me.Controls.Add(Me.btnagrecerrar)
        Me.Controls.Add(Me.btnagreguardar)
        Me.Controls.Add(Me.btnagrenuevo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregarproductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "--AGREGAR PRODUCTO--"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtagercodigoprod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtagrenombrprod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtagreexistprod As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtagrepreciofinalprod As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtagreimpprod As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtagreprecio As System.Windows.Forms.TextBox
    Friend WithEvents btnagrenuevo As System.Windows.Forms.Button
    Friend WithEvents btnagreguardar As System.Windows.Forms.Button
    Friend WithEvents btnagrecerrar As System.Windows.Forms.Button
    Friend WithEvents txtagredescripcionprod As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnagregarcat As System.Windows.Forms.Button
    Friend WithEvents brnagregarprov As System.Windows.Forms.Button
    Friend WithEvents txtpruebacod2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpruebacod As System.Windows.Forms.TextBox
    Friend WithEvents recibecat As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents recibeprov As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
