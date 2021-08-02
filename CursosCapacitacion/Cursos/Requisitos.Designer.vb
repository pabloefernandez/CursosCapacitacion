<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requisitos
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
        Me.lstCurso = New System.Windows.Forms.ListBox()
        Me.lstRequisito = New System.Windows.Forms.ListBox()
        Me.lstObligatorio = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir3
        '
        Me.btnSalir3.Location = New System.Drawing.Point(462, 12)
        Me.btnSalir3.Name = "btnSalir3"
        Me.btnSalir3.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir3.TabIndex = 21
        Me.btnSalir3.Text = "Salir"
        Me.btnSalir3.UseVisualStyleBackColor = True
        '
        'lstCurso
        '
        Me.lstCurso.FormattingEnabled = True
        Me.lstCurso.Location = New System.Drawing.Point(11, 84)
        Me.lstCurso.Name = "lstCurso"
        Me.lstCurso.Size = New System.Drawing.Size(238, 511)
        Me.lstCurso.TabIndex = 24
        '
        'lstRequisito
        '
        Me.lstRequisito.FormattingEnabled = True
        Me.lstRequisito.Location = New System.Drawing.Point(251, 84)
        Me.lstRequisito.Name = "lstRequisito"
        Me.lstRequisito.Size = New System.Drawing.Size(238, 511)
        Me.lstRequisito.TabIndex = 25
        '
        'lstObligatorio
        '
        Me.lstObligatorio.FormattingEnabled = True
        Me.lstObligatorio.Location = New System.Drawing.Point(491, 84)
        Me.lstObligatorio.Name = "lstObligatorio"
        Me.lstObligatorio.Size = New System.Drawing.Size(68, 511)
        Me.lstObligatorio.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Curso a realizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Curso requisito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(496, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Oblig."
        '
        'Requisitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 607)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstObligatorio)
        Me.Controls.Add(Me.lstRequisito)
        Me.Controls.Add(Me.lstCurso)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir3)
        Me.Name = "Requisitos"
        Me.Text = "Requisitos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir3 As System.Windows.Forms.Button
    Friend WithEvents lstCurso As System.Windows.Forms.ListBox
    Friend WithEvents lstRequisito As System.Windows.Forms.ListBox
    Friend WithEvents lstObligatorio As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
