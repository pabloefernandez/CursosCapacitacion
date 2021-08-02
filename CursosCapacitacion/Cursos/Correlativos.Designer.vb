<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Correlativos
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
        Me.cboAreas = New System.Windows.Forms.ComboBox()
        Me.lstCorrelativos = New System.Windows.Forms.ListBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboAreas
        '
        Me.cboAreas.FormattingEnabled = True
        Me.cboAreas.Location = New System.Drawing.Point(138, 101)
        Me.cboAreas.Name = "cboAreas"
        Me.cboAreas.Size = New System.Drawing.Size(260, 21)
        Me.cboAreas.TabIndex = 0
        '
        'lstCorrelativos
        '
        Me.lstCorrelativos.FormattingEnabled = True
        Me.lstCorrelativos.Location = New System.Drawing.Point(31, 135)
        Me.lstCorrelativos.Name = "lstCorrelativos"
        Me.lstCorrelativos.Size = New System.Drawing.Size(470, 446)
        Me.lstCorrelativos.TabIndex = 22
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir2
        '
        Me.btnSalir2.Location = New System.Drawing.Point(427, 12)
        Me.btnSalir2.Name = "btnSalir2"
        Me.btnSalir2.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir2.TabIndex = 24
        Me.btnSalir2.Text = "Salir"
        Me.btnSalir2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 40)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Seleccione el area para visualizar los cursos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               correspondientes a " & _
            "la misma"
        '
        'Correlativos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 607)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lstCorrelativos)
        Me.Controls.Add(Me.cboAreas)
        Me.Name = "Correlativos"
        Me.Text = "Correlativos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAreas As System.Windows.Forms.ComboBox
    Friend WithEvents lstCorrelativos As System.Windows.Forms.ListBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
