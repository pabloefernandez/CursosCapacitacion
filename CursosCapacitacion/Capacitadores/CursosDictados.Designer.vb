<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CursosDictados
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnTick = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNomApe = New System.Windows.Forms.TextBox()
        Me.lstCursos = New System.Windows.Forms.ListBox()
        Me.btnSalir4 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(442, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(51, 23)
        Me.btnLimpiar.TabIndex = 0
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnTick
        '
        Me.btnTick.Location = New System.Drawing.Point(408, 48)
        Me.btnTick.Name = "btnTick"
        Me.btnTick.Size = New System.Drawing.Size(28, 23)
        Me.btnTick.TabIndex = 1
        Me.btnTick.Text = "✔"
        Me.btnTick.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(172, 50)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(230, 20)
        Me.txtDni.TabIndex = 2
        '
        'txtNomApe
        '
        Me.txtNomApe.Location = New System.Drawing.Point(178, 85)
        Me.txtNomApe.Name = "txtNomApe"
        Me.txtNomApe.Size = New System.Drawing.Size(219, 20)
        Me.txtNomApe.TabIndex = 3
        '
        'lstCursos
        '
        Me.lstCursos.FormattingEnabled = True
        Me.lstCursos.Location = New System.Drawing.Point(105, 121)
        Me.lstCursos.Name = "lstCursos"
        Me.lstCursos.Size = New System.Drawing.Size(388, 355)
        Me.lstCursos.TabIndex = 4
        '
        'btnSalir4
        '
        Me.btnSalir4.Location = New System.Drawing.Point(494, 12)
        Me.btnSalir4.Name = "btnSalir4"
        Me.btnSalir4.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir4.TabIndex = 23
        Me.btnSalir4.Text = "Salir"
        Me.btnSalir4.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 24
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Ingrese DNI del capacitador"
        '
        'CursosDictados
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
        Me.Name = "CursosDictados"
        Me.Text = "CursosDictados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnTick As System.Windows.Forms.Button
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtNomApe As System.Windows.Forms.TextBox
    Friend WithEvents lstCursos As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir4 As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
