<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Semestre
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
        Me.lstS1 = New System.Windows.Forms.ListBox()
        Me.lstS2 = New System.Windows.Forms.ListBox()
        Me.btnSalir3 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblT1 = New System.Windows.Forms.Label()
        Me.lblT2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstS1
        '
        Me.lstS1.FormattingEnabled = True
        Me.lstS1.Location = New System.Drawing.Point(12, 102)
        Me.lstS1.Name = "lstS1"
        Me.lstS1.Size = New System.Drawing.Size(285, 238)
        Me.lstS1.TabIndex = 0
        '
        'lstS2
        '
        Me.lstS2.FormattingEnabled = True
        Me.lstS2.Location = New System.Drawing.Point(314, 102)
        Me.lstS2.Name = "lstS2"
        Me.lstS2.Size = New System.Drawing.Size(288, 238)
        Me.lstS2.TabIndex = 4
        '
        'btnSalir3
        '
        Me.btnSalir3.Location = New System.Drawing.Point(504, 12)
        Me.btnSalir3.Name = "btnSalir3"
        Me.btnSalir3.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir3.TabIndex = 22
        Me.btnSalir3.Text = "Salir"
        Me.btnSalir3.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblT1
        '
        Me.lblT1.AutoSize = True
        Me.lblT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT1.Location = New System.Drawing.Point(9, 79)
        Me.lblT1.Name = "lblT1"
        Me.lblT1.Size = New System.Drawing.Size(29, 20)
        Me.lblT1.TabIndex = 23
        Me.lblT1.Text = "S1"
        '
        'lblT2
        '
        Me.lblT2.AutoSize = True
        Me.lblT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT2.Location = New System.Drawing.Point(310, 79)
        Me.lblT2.Name = "lblT2"
        Me.lblT2.Size = New System.Drawing.Size(29, 20)
        Me.lblT2.TabIndex = 26
        Me.lblT2.Text = "S2"
        '
        'Semestre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 348)
        Me.Controls.Add(Me.lblT2)
        Me.Controls.Add(Me.lblT1)
        Me.Controls.Add(Me.btnSalir3)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lstS2)
        Me.Controls.Add(Me.lstS1)
        Me.Name = "Semestre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trimestre"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstS1 As System.Windows.Forms.ListBox
    Friend WithEvents lstS2 As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir3 As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblT1 As System.Windows.Forms.Label
    Friend WithEvents lblT2 As System.Windows.Forms.Label
End Class
