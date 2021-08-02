<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cursos_Realizados
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir4 = New System.Windows.Forms.Button()
        Me.lstCursos = New System.Windows.Forms.ListBox()
        Me.txtNomApe = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.btnTick = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Ingrese nombre de la compañia:"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 24)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 32
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir4
        '
        Me.btnSalir4.Location = New System.Drawing.Point(494, 24)
        Me.btnSalir4.Name = "btnSalir4"
        Me.btnSalir4.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir4.TabIndex = 31
        Me.btnSalir4.Text = "Salir"
        Me.btnSalir4.UseVisualStyleBackColor = True
        '
        'lstCursos
        '
        Me.lstCursos.FormattingEnabled = True
        Me.lstCursos.Location = New System.Drawing.Point(105, 133)
        Me.lstCursos.Name = "lstCursos"
        Me.lstCursos.Size = New System.Drawing.Size(388, 355)
        Me.lstCursos.TabIndex = 30
        '
        'txtNomApe
        '
        Me.txtNomApe.Location = New System.Drawing.Point(178, 97)
        Me.txtNomApe.Name = "txtNomApe"
        Me.txtNomApe.Size = New System.Drawing.Size(219, 20)
        Me.txtNomApe.TabIndex = 29
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(172, 62)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(230, 20)
        Me.txtDni.TabIndex = 28
        '
        'btnTick
        '
        Me.btnTick.Location = New System.Drawing.Point(408, 60)
        Me.btnTick.Name = "btnTick"
        Me.btnTick.Size = New System.Drawing.Size(28, 23)
        Me.btnTick.TabIndex = 27
        Me.btnTick.Text = "✔"
        Me.btnTick.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(442, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(51, 23)
        Me.btnLimpiar.TabIndex = 26
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Cursos_Realizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 513)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir4)
        Me.Controls.Add(Me.lstCursos)
        Me.Controls.Add(Me.txtNomApe)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.btnTick)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Name = "Cursos_Realizados"
        Me.Text = "Cursos_Realizados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir4 As System.Windows.Forms.Button
    Friend WithEvents lstCursos As System.Windows.Forms.ListBox
    Friend WithEvents txtNomApe As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents btnTick As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
