<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearAdvertencias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl2Errores = New System.Windows.Forms.Label()
        Me.lblErrorUsuario = New System.Windows.Forms.Label()
        Me.lblErrorContraseña = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl2Errores
        '
        Me.lbl2Errores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl2Errores.AutoSize = True
        Me.lbl2Errores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2Errores.Location = New System.Drawing.Point(56, 43)
        Me.lbl2Errores.Margin = New System.Windows.Forms.Padding(3, 0, 9, 6)
        Me.lbl2Errores.Name = "lbl2Errores"
        Me.lbl2Errores.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl2Errores.Size = New System.Drawing.Size(290, 25)
        Me.lbl2Errores.TabIndex = 0
        Me.lbl2Errores.Text = "Ingrese usuario y contraseña"
        Me.lbl2Errores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrorUsuario
        '
        Me.lblErrorUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblErrorUsuario.AutoSize = True
        Me.lblErrorUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorUsuario.Location = New System.Drawing.Point(125, 43)
        Me.lblErrorUsuario.Margin = New System.Windows.Forms.Padding(3, 0, 9, 6)
        Me.lblErrorUsuario.Name = "lblErrorUsuario"
        Me.lblErrorUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblErrorUsuario.Size = New System.Drawing.Size(160, 25)
        Me.lblErrorUsuario.TabIndex = 1
        Me.lblErrorUsuario.Text = "Ingrese usuario"
        Me.lblErrorUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrorContraseña
        '
        Me.lblErrorContraseña.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblErrorContraseña.AutoSize = True
        Me.lblErrorContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorContraseña.Location = New System.Drawing.Point(100, 43)
        Me.lblErrorContraseña.Margin = New System.Windows.Forms.Padding(3, 0, 9, 6)
        Me.lblErrorContraseña.Name = "lblErrorContraseña"
        Me.lblErrorContraseña.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblErrorContraseña.Size = New System.Drawing.Size(196, 25)
        Me.lblErrorContraseña.TabIndex = 2
        Me.lblErrorContraseña.Text = "Ingrese contraseña"
        Me.lblErrorContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(165, 94)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Ok"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'CrearAdvertencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(398, 129)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblErrorContraseña)
        Me.Controls.Add(Me.lblErrorUsuario)
        Me.Controls.Add(Me.lbl2Errores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CrearAdvertencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl2Errores As System.Windows.Forms.Label
    Friend WithEvents lblErrorUsuario As System.Windows.Forms.Label
    Friend WithEvents lblErrorContraseña As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
