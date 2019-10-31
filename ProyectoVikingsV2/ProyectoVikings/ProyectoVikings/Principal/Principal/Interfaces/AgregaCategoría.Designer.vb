<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregaCategoría
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
        Me.txtnombrecat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btbAgregaCat = New System.Windows.Forms.Button()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.recibecat = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnombrecat
        '
        Me.txtnombrecat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrecat.Location = New System.Drawing.Point(204, 44)
        Me.txtnombrecat.Name = "txtnombrecat"
        Me.txtnombrecat.Size = New System.Drawing.Size(148, 24)
        Me.txtnombrecat.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Tomato
        Me.Label2.Font = New System.Drawing.Font("Poppins", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(7, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Descripcion"
        '
        'btbAgregaCat
        '
        Me.btbAgregaCat.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbAgregaCat.Location = New System.Drawing.Point(15, 315)
        Me.btbAgregaCat.Name = "btbAgregaCat"
        Me.btbAgregaCat.Size = New System.Drawing.Size(130, 82)
        Me.btbAgregaCat.TabIndex = 6
        Me.btbAgregaCat.Text = "Agregar"
        Me.btbAgregaCat.UseVisualStyleBackColor = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(6, 137)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(184, 172)
        Me.txtdescripcion.TabIndex = 7
        '
        'recibecat
        '
        Me.recibecat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recibecat.FormattingEnabled = True
        Me.recibecat.ItemHeight = 24
        Me.recibecat.Location = New System.Drawing.Point(196, 137)
        Me.recibecat.Name = "recibecat"
        Me.recibecat.Size = New System.Drawing.Size(183, 172)
        Me.recibecat.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Tomato
        Me.Label3.Font = New System.Drawing.Font("Poppins", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(198, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lista Categorias"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(238, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 82)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Agregar Categoría"
        '
        'AgregaCategoría
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(383, 425)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.recibecat)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.btbAgregaCat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnombrecat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregaCategoría"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnombrecat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btbAgregaCat As System.Windows.Forms.Button
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents recibecat As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
