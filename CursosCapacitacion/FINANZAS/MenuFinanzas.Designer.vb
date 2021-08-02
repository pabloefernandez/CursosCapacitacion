<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuFinanzas
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnPagoC = New System.Windows.Forms.Button()
        Me.btnCapacPag = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(354, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 50)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.Location = New System.Drawing.Point(12, 12)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(114, 50)
        Me.btnCerrarSesion.TabIndex = 18
        Me.btnCerrarSesion.Text = "CERRAR SESION"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnPagoC
        '
        Me.btnPagoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagoC.Location = New System.Drawing.Point(80, 95)
        Me.btnPagoC.Name = "btnPagoC"
        Me.btnPagoC.Size = New System.Drawing.Size(138, 55)
        Me.btnPagoC.TabIndex = 20
        Me.btnPagoC.Text = "Pagar a los Capacitadores"
        Me.btnPagoC.UseVisualStyleBackColor = True
        '
        'btnCapacPag
        '
        Me.btnCapacPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapacPag.Location = New System.Drawing.Point(279, 95)
        Me.btnCapacPag.Name = "btnCapacPag"
        Me.btnCapacPag.Size = New System.Drawing.Size(138, 55)
        Me.btnCapacPag.TabIndex = 21
        Me.btnCapacPag.Text = "Capacitadores Pagados"
        Me.btnCapacPag.UseVisualStyleBackColor = True
        '
        'MenuFinanzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 181)
        Me.Controls.Add(Me.btnCapacPag)
        Me.Controls.Add(Me.btnPagoC)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Name = "MenuFinanzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuFinanzas"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents btnPagoC As System.Windows.Forms.Button
    Friend WithEvents btnCapacPag As System.Windows.Forms.Button
End Class
