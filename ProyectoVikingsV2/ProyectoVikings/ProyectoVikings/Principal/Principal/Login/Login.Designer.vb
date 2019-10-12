<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcrearcontraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcrearusuario = New System.Windows.Forms.TextBox()
        Me.txtrecibeid = New System.Windows.Forms.TextBox()
        Me.dtgrecibe = New System.Windows.Forms.DataGridView()
        Me.iduser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userpasswd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgrecibe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcrearcontraseña)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcrearusuario)
        Me.GroupBox1.Controls.Add(Me.txtrecibeid)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 383)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inicio de Sesión"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(455, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 47)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(172, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 83)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'txtcrearcontraseña
        '
        Me.txtcrearcontraseña.Location = New System.Drawing.Point(239, 171)
        Me.txtcrearcontraseña.Name = "txtcrearcontraseña"
        Me.txtcrearcontraseña.Size = New System.Drawing.Size(206, 38)
        Me.txtcrearcontraseña.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Crear Usuario:"
        '
        'txtcrearusuario
        '
        Me.txtcrearusuario.Location = New System.Drawing.Point(239, 97)
        Me.txtcrearusuario.Name = "txtcrearusuario"
        Me.txtcrearusuario.Size = New System.Drawing.Size(206, 38)
        Me.txtcrearusuario.TabIndex = 0
        '
        'txtrecibeid
        '
        Me.txtrecibeid.Location = New System.Drawing.Point(308, 97)
        Me.txtrecibeid.Name = "txtrecibeid"
        Me.txtrecibeid.Size = New System.Drawing.Size(100, 38)
        Me.txtrecibeid.TabIndex = 6
        '
        'dtgrecibe
        '
        Me.dtgrecibe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrecibe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iduser, Me.userpasswd})
        Me.dtgrecibe.Location = New System.Drawing.Point(26, 224)
        Me.dtgrecibe.Name = "dtgrecibe"
        Me.dtgrecibe.Size = New System.Drawing.Size(240, 150)
        Me.dtgrecibe.TabIndex = 7
        '
        'iduser
        '
        Me.iduser.HeaderText = "iduserr"
        Me.iduser.Name = "iduser"
        '
        'userpasswd
        '
        Me.userpasswd.HeaderText = "passwd"
        Me.userpasswd.Name = "userpasswd"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(566, 407)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgrecibe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgrecibe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcrearcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcrearusuario As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtrecibeid As System.Windows.Forms.TextBox
    Friend WithEvents dtgrecibe As System.Windows.Forms.DataGridView
    Friend WithEvents iduser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userpasswd As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
