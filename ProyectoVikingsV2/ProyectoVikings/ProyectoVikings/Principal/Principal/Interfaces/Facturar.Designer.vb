<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturar
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbconsumidor = New System.Windows.Forms.RadioButton()
        Me.rbclie = New System.Windows.Forms.RadioButton()
        Me.rbprov = New System.Windows.Forms.RadioButton()
        Me.gbconsumidor = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.libcodprod = New System.Windows.Forms.ListBox()
        Me.txtpruebacodigoprod = New System.Windows.Forms.TextBox()
        Me.txtpruebanombreprod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.libprod = New System.Windows.Forms.ListBox()
        Me.btnañadeventa = New System.Windows.Forms.Button()
        Me.txtcantidadcompra = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.dtgobtieneventa = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.labelfecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbcliente = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbproveedor = New System.Windows.Forms.GroupBox()
        Me.btnañadirprov = New System.Windows.Forms.Button()
        Me.cbprov = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.brnsalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtrecibecantidad = New System.Windows.Forms.TextBox()
        Me.txtrecibeprecio = New System.Windows.Forms.TextBox()
        Me.dtgrecibeprod = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.gbconsumidor.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgobtieneventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcliente.SuspendLayout()
        Me.gbproveedor.SuspendLayout()
        CType(Me.dtgrecibeprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbconsumidor)
        Me.GroupBox1.Controls.Add(Me.rbclie)
        Me.GroupBox1.Controls.Add(Me.rbprov)
        Me.GroupBox1.Controls.Add(Me.gbconsumidor)
        Me.GroupBox1.Controls.Add(Me.gbcliente)
        Me.GroupBox1.Controls.Add(Me.gbproveedor)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 572)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(157, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(132, 23)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.Text = "Deseo Facturar A:"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbconsumidor
        '
        Me.rbconsumidor.AutoSize = True
        Me.rbconsumidor.Location = New System.Drawing.Point(474, 20)
        Me.rbconsumidor.Name = "rbconsumidor"
        Me.rbconsumidor.Size = New System.Drawing.Size(133, 23)
        Me.rbconsumidor.TabIndex = 7
        Me.rbconsumidor.Text = "Consumidor Final"
        Me.rbconsumidor.UseVisualStyleBackColor = True
        '
        'rbclie
        '
        Me.rbclie.AutoSize = True
        Me.rbclie.Location = New System.Drawing.Point(391, 20)
        Me.rbclie.Name = "rbclie"
        Me.rbclie.Size = New System.Drawing.Size(68, 23)
        Me.rbclie.TabIndex = 6
        Me.rbclie.Text = "Cliente"
        Me.rbclie.UseVisualStyleBackColor = True
        '
        'rbprov
        '
        Me.rbprov.AutoSize = True
        Me.rbprov.Checked = True
        Me.rbprov.Location = New System.Drawing.Point(293, 20)
        Me.rbprov.Name = "rbprov"
        Me.rbprov.Size = New System.Drawing.Size(87, 23)
        Me.rbprov.TabIndex = 5
        Me.rbprov.TabStop = True
        Me.rbprov.Text = "Proveedor"
        Me.rbprov.UseVisualStyleBackColor = True
        '
        'gbconsumidor
        '
        Me.gbconsumidor.Controls.Add(Me.TabControl1)
        Me.gbconsumidor.Controls.Add(Me.labelfecha)
        Me.gbconsumidor.Controls.Add(Me.Label5)
        Me.gbconsumidor.Font = New System.Drawing.Font("Poppins", 9.9999!)
        Me.gbconsumidor.ForeColor = System.Drawing.Color.White
        Me.gbconsumidor.Location = New System.Drawing.Point(7, 44)
        Me.gbconsumidor.Name = "gbconsumidor"
        Me.gbconsumidor.Size = New System.Drawing.Size(858, 520)
        Me.gbconsumidor.TabIndex = 4
        Me.gbconsumidor.TabStop = False
        Me.gbconsumidor.Text = "Consumidor Final"
        Me.gbconsumidor.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 51)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(842, 460)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dtgrecibeprod)
        Me.TabPage1.Controls.Add(Me.txtrecibeprecio)
        Me.TabPage1.Controls.Add(Me.txtrecibecantidad)
        Me.TabPage1.Controls.Add(Me.libcodprod)
        Me.TabPage1.Controls.Add(Me.txtpruebacodigoprod)
        Me.TabPage1.Controls.Add(Me.txtpruebanombreprod)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.libprod)
        Me.TabPage1.Controls.Add(Me.btnañadeventa)
        Me.TabPage1.Controls.Add(Me.txtcantidadcompra)
        Me.TabPage1.Controls.Add(Me.label)
        Me.TabPage1.Controls.Add(Me.dtgobtieneventa)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(834, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Producto"
        '
        'libcodprod
        '
        Me.libcodprod.FormattingEnabled = True
        Me.libcodprod.ItemHeight = 21
        Me.libcodprod.Location = New System.Drawing.Point(22, 292)
        Me.libcodprod.Name = "libcodprod"
        Me.libcodprod.Size = New System.Drawing.Size(184, 109)
        Me.libcodprod.TabIndex = 9
        '
        'txtpruebacodigoprod
        '
        Me.txtpruebacodigoprod.Location = New System.Drawing.Point(45, 141)
        Me.txtpruebacodigoprod.Name = "txtpruebacodigoprod"
        Me.txtpruebacodigoprod.Size = New System.Drawing.Size(100, 29)
        Me.txtpruebacodigoprod.TabIndex = 10
        '
        'txtpruebanombreprod
        '
        Me.txtpruebanombreprod.Location = New System.Drawing.Point(45, 191)
        Me.txtpruebanombreprod.Name = "txtpruebanombreprod"
        Me.txtpruebanombreprod.Size = New System.Drawing.Size(141, 29)
        Me.txtpruebanombreprod.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(106, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Elija Producto"
        '
        'libprod
        '
        Me.libprod.FormattingEnabled = True
        Me.libprod.ItemHeight = 21
        Me.libprod.Location = New System.Drawing.Point(212, 3)
        Me.libprod.Name = "libprod"
        Me.libprod.Size = New System.Drawing.Size(184, 109)
        Me.libprod.TabIndex = 7
        '
        'btnañadeventa
        '
        Me.btnañadeventa.ForeColor = System.Drawing.Color.Black
        Me.btnañadeventa.Location = New System.Drawing.Point(584, 39)
        Me.btnañadeventa.Name = "btnañadeventa"
        Me.btnañadeventa.Size = New System.Drawing.Size(114, 56)
        Me.btnañadeventa.TabIndex = 5
        Me.btnañadeventa.Text = "Añadir a la Venta"
        Me.btnañadeventa.UseVisualStyleBackColor = True
        '
        'txtcantidadcompra
        '
        Me.txtcantidadcompra.Location = New System.Drawing.Point(483, 53)
        Me.txtcantidadcompra.Name = "txtcantidadcompra"
        Me.txtcantidadcompra.Size = New System.Drawing.Size(85, 29)
        Me.txtcantidadcompra.TabIndex = 6
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label.Location = New System.Drawing.Point(403, 56)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(74, 23)
        Me.label.TabIndex = 3
        Me.label.Text = "Cantidad"
        '
        'dtgobtieneventa
        '
        Me.dtgobtieneventa.AllowUserToAddRows = False
        Me.dtgobtieneventa.AllowUserToDeleteRows = False
        Me.dtgobtieneventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgobtieneventa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dtgobtieneventa.BackgroundColor = System.Drawing.Color.Teal
        Me.dtgobtieneventa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgobtieneventa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Poppins", 9.9999!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgobtieneventa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgobtieneventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgobtieneventa.ColumnHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Poppins", 9.9999!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgobtieneventa.DefaultCellStyle = DataGridViewCellStyle8
        Me.dtgobtieneventa.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtgobtieneventa.Location = New System.Drawing.Point(9, 118)
        Me.dtgobtieneventa.Name = "dtgobtieneventa"
        Me.dtgobtieneventa.ReadOnly = True
        Me.dtgobtieneventa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgobtieneventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgobtieneventa.Size = New System.Drawing.Size(822, 302)
        Me.dtgobtieneventa.TabIndex = 23
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(834, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DetalleFactura"
        '
        'labelfecha
        '
        Me.labelfecha.AutoSize = True
        Me.labelfecha.Location = New System.Drawing.Point(634, 32)
        Me.labelfecha.Name = "labelfecha"
        Me.labelfecha.Size = New System.Drawing.Size(32, 23)
        Me.labelfecha.TabIndex = 6
        Me.labelfecha.Text = "fec"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(581, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha:"
        '
        'gbcliente
        '
        Me.gbcliente.Controls.Add(Me.Button1)
        Me.gbcliente.Controls.Add(Me.ComboBox2)
        Me.gbcliente.Controls.Add(Me.Label4)
        Me.gbcliente.Font = New System.Drawing.Font("Poppins", 9.9999!)
        Me.gbcliente.ForeColor = System.Drawing.Color.White
        Me.gbcliente.Location = New System.Drawing.Point(7, 44)
        Me.gbcliente.Name = "gbcliente"
        Me.gbcliente.Size = New System.Drawing.Size(858, 520)
        Me.gbcliente.TabIndex = 3
        Me.gbcliente.TabStop = False
        Me.gbcliente.Text = "Cliente"
        Me.gbcliente.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(254, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Añada Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(104, 22)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 29)
        Me.ComboBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Elija Cliente:"
        '
        'gbproveedor
        '
        Me.gbproveedor.Controls.Add(Me.btnañadirprov)
        Me.gbproveedor.Controls.Add(Me.cbprov)
        Me.gbproveedor.Controls.Add(Me.Label3)
        Me.gbproveedor.Font = New System.Drawing.Font("Poppins", 9.9999!)
        Me.gbproveedor.ForeColor = System.Drawing.Color.White
        Me.gbproveedor.Location = New System.Drawing.Point(7, 44)
        Me.gbproveedor.Name = "gbproveedor"
        Me.gbproveedor.Size = New System.Drawing.Size(858, 520)
        Me.gbproveedor.TabIndex = 2
        Me.gbproveedor.TabStop = False
        Me.gbproveedor.Text = "Proveedor"
        Me.gbproveedor.Visible = False
        '
        'btnañadirprov
        '
        Me.btnañadirprov.ForeColor = System.Drawing.Color.Black
        Me.btnañadirprov.Location = New System.Drawing.Point(267, 19)
        Me.btnañadirprov.Name = "btnañadirprov"
        Me.btnañadirprov.Size = New System.Drawing.Size(134, 29)
        Me.btnañadirprov.TabIndex = 2
        Me.btnañadirprov.Text = "Añada Poveedor"
        Me.btnañadirprov.UseVisualStyleBackColor = True
        '
        'cbprov
        '
        Me.cbprov.FormattingEnabled = True
        Me.cbprov.Location = New System.Drawing.Point(117, 19)
        Me.cbprov.Name = "cbprov"
        Me.cbprov.Size = New System.Drawing.Size(144, 29)
        Me.cbprov.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Elija Proveedor:"
        '
        'brnsalir
        '
        Me.brnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.brnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.brnsalir.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.brnsalir.ForeColor = System.Drawing.Color.White
        Me.brnsalir.Location = New System.Drawing.Point(793, 12)
        Me.brnsalir.Name = "brnsalir"
        Me.brnsalir.Size = New System.Drawing.Size(75, 23)
        Me.brnsalir.TabIndex = 28
        Me.brnsalir.Text = "salir"
        Me.brnsalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(361, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "FACTURAR"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtrecibecantidad
        '
        Me.txtrecibecantidad.Location = New System.Drawing.Point(240, 141)
        Me.txtrecibecantidad.Name = "txtrecibecantidad"
        Me.txtrecibecantidad.Size = New System.Drawing.Size(85, 29)
        Me.txtrecibecantidad.TabIndex = 25
        '
        'txtrecibeprecio
        '
        Me.txtrecibeprecio.Location = New System.Drawing.Point(240, 191)
        Me.txtrecibeprecio.Name = "txtrecibeprecio"
        Me.txtrecibeprecio.Size = New System.Drawing.Size(85, 29)
        Me.txtrecibeprecio.TabIndex = 26
        '
        'dtgrecibeprod
        '
        Me.dtgrecibeprod.AllowUserToAddRows = False
        Me.dtgrecibeprod.AllowUserToDeleteRows = False
        Me.dtgrecibeprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgrecibeprod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dtgrecibeprod.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtgrecibeprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgrecibeprod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.9999!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgrecibeprod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgrecibeprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Poppins", 9.9999!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgrecibeprod.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgrecibeprod.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtgrecibeprod.Location = New System.Drawing.Point(407, 245)
        Me.dtgrecibeprod.Name = "dtgrecibeprod"
        Me.dtgrecibeprod.ReadOnly = True
        Me.dtgrecibeprod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgrecibeprod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrecibeprod.Size = New System.Drawing.Size(421, 175)
        Me.dtgrecibeprod.TabIndex = 27
        '
        'Facturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 610)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.brnsalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Facturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturar"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbconsumidor.ResumeLayout(False)
        Me.gbconsumidor.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtgobtieneventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcliente.ResumeLayout(False)
        Me.gbcliente.PerformLayout()
        Me.gbproveedor.ResumeLayout(False)
        Me.gbproveedor.PerformLayout()
        CType(Me.dtgrecibeprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents brnsalir As System.Windows.Forms.Button
    Friend WithEvents gbcliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbproveedor As System.Windows.Forms.GroupBox
    Friend WithEvents rbconsumidor As System.Windows.Forms.RadioButton
    Friend WithEvents rbclie As System.Windows.Forms.RadioButton
    Friend WithEvents rbprov As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnañadirprov As System.Windows.Forms.Button
    Friend WithEvents cbprov As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gbconsumidor As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents libcodprod As System.Windows.Forms.ListBox
    Friend WithEvents txtpruebacodigoprod As System.Windows.Forms.TextBox
    Friend WithEvents txtpruebanombreprod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents libprod As System.Windows.Forms.ListBox
    Friend WithEvents btnañadeventa As System.Windows.Forms.Button
    Friend WithEvents txtcantidadcompra As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents labelfecha As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtgobtieneventa As System.Windows.Forms.DataGridView
    Friend WithEvents txtrecibecantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtrecibeprecio As System.Windows.Forms.TextBox
    Friend WithEvents dtgrecibeprod As System.Windows.Forms.DataGridView
End Class
