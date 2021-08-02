<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Planeados
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
        Me.btnSalir3 = New System.Windows.Forms.Button()
        Me.lstEspera = New System.Windows.Forms.ListBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSalir3
        '
        Me.btnSalir3.Location = New System.Drawing.Point(427, 12)
        Me.btnSalir3.Name = "btnSalir3"
        Me.btnSalir3.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir3.TabIndex = 16
        Me.btnSalir3.Text = "Salir"
        Me.btnSalir3.UseVisualStyleBackColor = True
        '
        'lstEspera
        '
        Me.lstEspera.FormattingEnabled = True
        Me.lstEspera.Location = New System.Drawing.Point(37, 71)
        Me.lstEspera.Name = "lstEspera"
        Me.lstEspera.Size = New System.Drawing.Size(470, 446)
        Me.lstEspera.TabIndex = 17
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Planeados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 544)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lstEspera)
        Me.Controls.Add(Me.btnSalir3)
        Me.Name = "Planeados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planeados"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir3 As System.Windows.Forms.Button
    Friend WithEvents lstEspera As System.Windows.Forms.ListBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
