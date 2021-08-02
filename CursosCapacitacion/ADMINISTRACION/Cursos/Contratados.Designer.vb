<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contratados
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir3 = New System.Windows.Forms.Button()
        Me.lstContratados = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir3
        '
        Me.btnSalir3.Location = New System.Drawing.Point(427, 12)
        Me.btnSalir3.Name = "btnSalir3"
        Me.btnSalir3.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir3.TabIndex = 20
        Me.btnSalir3.Text = "Salir"
        Me.btnSalir3.UseVisualStyleBackColor = True
        '
        'lstContratados
        '
        Me.lstContratados.FormattingEnabled = True
        Me.lstContratados.Location = New System.Drawing.Point(31, 62)
        Me.lstContratados.Name = "lstContratados"
        Me.lstContratados.Size = New System.Drawing.Size(470, 446)
        Me.lstContratados.TabIndex = 21
        '
        'Contratados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 528)
        Me.Controls.Add(Me.lstContratados)
        Me.Controls.Add(Me.btnSalir3)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "Contratados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contratados"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir3 As System.Windows.Forms.Button
    Friend WithEvents lstContratados As System.Windows.Forms.ListBox
End Class
