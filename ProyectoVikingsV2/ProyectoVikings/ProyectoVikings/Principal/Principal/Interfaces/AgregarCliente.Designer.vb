<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtagrecuenta = New System.Windows.Forms.TextBox()
        Me.txtagretel = New System.Windows.Forms.TextBox()
        Me.txtagredire = New System.Windows.Forms.TextBox()
        Me.txtagrenombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnuevocliente = New System.Windows.Forms.Button()
        Me.btnguardarcliente = New System.Windows.Forms.Button()
        Me.btncerrarcliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUEVO CLIENTE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtagrecuenta)
        Me.GroupBox1.Controls.Add(Me.txtagretel)
        Me.GroupBox1.Controls.Add(Me.txtagredire)
        Me.GroupBox1.Controls.Add(Me.txtagrenombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 287)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txtagrecuenta
        '
        Me.txtagrecuenta.Location = New System.Drawing.Point(132, 225)
        Me.txtagrecuenta.Name = "txtagrecuenta"
        Me.txtagrecuenta.Size = New System.Drawing.Size(132, 26)
        Me.txtagrecuenta.TabIndex = 8
        '
        'txtagretel
        '
        Me.txtagretel.Location = New System.Drawing.Point(132, 161)
        Me.txtagretel.MaxLength = 8
        Me.txtagretel.Name = "txtagretel"
        Me.txtagretel.Size = New System.Drawing.Size(132, 26)
        Me.txtagretel.TabIndex = 7
        '
        'txtagredire
        '
        Me.txtagredire.Location = New System.Drawing.Point(132, 90)
        Me.txtagredire.Name = "txtagredire"
        Me.txtagredire.Size = New System.Drawing.Size(132, 26)
        Me.txtagredire.TabIndex = 6
        '
        'txtagrenombre
        '
        Me.txtagrenombre.Location = New System.Drawing.Point(132, 25)
        Me.txtagrenombre.Name = "txtagrenombre"
        Me.txtagrenombre.Size = New System.Drawing.Size(132, 26)
        Me.txtagrenombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label5.Location = New System.Drawing.Point(10, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Estado de Cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label4.Location = New System.Drawing.Point(59, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label3.Location = New System.Drawing.Point(59, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(59, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'btnnuevocliente
        '
        Me.btnnuevocliente.Location = New System.Drawing.Point(12, 335)
        Me.btnnuevocliente.Name = "btnnuevocliente"
        Me.btnnuevocliente.Size = New System.Drawing.Size(97, 45)
        Me.btnnuevocliente.TabIndex = 2
        Me.btnnuevocliente.Text = "Nuevo"
        Me.btnnuevocliente.UseVisualStyleBackColor = True
        '
        'btnguardarcliente
        '
        Me.btnguardarcliente.Location = New System.Drawing.Point(115, 335)
        Me.btnguardarcliente.Name = "btnguardarcliente"
        Me.btnguardarcliente.Size = New System.Drawing.Size(97, 45)
        Me.btnguardarcliente.TabIndex = 3
        Me.btnguardarcliente.Text = "Guardar"
        Me.btnguardarcliente.UseVisualStyleBackColor = True
        '
        'btncerrarcliente
        '
        Me.btncerrarcliente.Location = New System.Drawing.Point(342, 335)
        Me.btncerrarcliente.Name = "btncerrarcliente"
        Me.btncerrarcliente.Size = New System.Drawing.Size(97, 45)
        Me.btncerrarcliente.TabIndex = 4
        Me.btncerrarcliente.Text = "Cerrar"
        Me.btncerrarcliente.UseVisualStyleBackColor = True
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(451, 386)
        Me.Controls.Add(Me.btncerrarcliente)
        Me.Controls.Add(Me.btnguardarcliente)
        Me.Controls.Add(Me.btnnuevocliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarCliente"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtagrecuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtagretel As System.Windows.Forms.TextBox
    Friend WithEvents txtagredire As System.Windows.Forms.TextBox
    Friend WithEvents txtagrenombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnnuevocliente As System.Windows.Forms.Button
    Friend WithEvents btnguardarcliente As System.Windows.Forms.Button
    Friend WithEvents btncerrarcliente As System.Windows.Forms.Button
End Class
