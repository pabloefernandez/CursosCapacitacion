<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcCursos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRequisitos = New System.Windows.Forms.Button()
        Me.btnPlaneados = New System.Windows.Forms.Button()
        Me.btnTrimestre = New System.Windows.Forms.Button()
        Me.btnContratados = New System.Windows.Forms.Button()
        Me.btnSalir4 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRequisitos)
        Me.GroupBox1.Controls.Add(Me.btnPlaneados)
        Me.GroupBox1.Controls.Add(Me.btnTrimestre)
        Me.GroupBox1.Controls.Add(Me.btnContratados)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(68, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 145)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION DE LOS CURSOS"
        '
        'btnRequisitos
        '
        Me.btnRequisitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequisitos.Location = New System.Drawing.Point(31, 83)
        Me.btnRequisitos.Name = "btnRequisitos"
        Me.btnRequisitos.Size = New System.Drawing.Size(194, 42)
        Me.btnRequisitos.TabIndex = 15
        Me.btnRequisitos.Text = "Cursos Requisitos"
        Me.btnRequisitos.UseVisualStyleBackColor = True
        '
        'btnPlaneados
        '
        Me.btnPlaneados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaneados.Location = New System.Drawing.Point(31, 35)
        Me.btnPlaneados.Name = "btnPlaneados"
        Me.btnPlaneados.Size = New System.Drawing.Size(194, 42)
        Me.btnPlaneados.TabIndex = 14
        Me.btnPlaneados.Text = "Cursos Planeados"
        Me.btnPlaneados.UseVisualStyleBackColor = True
        '
        'btnTrimestre
        '
        Me.btnTrimestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrimestre.Location = New System.Drawing.Point(231, 83)
        Me.btnTrimestre.Name = "btnTrimestre"
        Me.btnTrimestre.Size = New System.Drawing.Size(194, 42)
        Me.btnTrimestre.TabIndex = 3
        Me.btnTrimestre.Text = "Cursos por Semestre"
        Me.btnTrimestre.UseVisualStyleBackColor = True
        '
        'btnContratados
        '
        Me.btnContratados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContratados.Location = New System.Drawing.Point(231, 35)
        Me.btnContratados.Name = "btnContratados"
        Me.btnContratados.Size = New System.Drawing.Size(194, 42)
        Me.btnContratados.TabIndex = 6
        Me.btnContratados.Text = "Cursos Contratados"
        Me.btnContratados.UseVisualStyleBackColor = True
        '
        'btnSalir4
        '
        Me.btnSalir4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir4.Location = New System.Drawing.Point(487, 12)
        Me.btnSalir4.Name = "btnSalir4"
        Me.btnSalir4.Size = New System.Drawing.Size(98, 42)
        Me.btnSalir4.TabIndex = 16
        Me.btnSalir4.Text = "Salir"
        Me.btnSalir4.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 42)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'OpcCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 254)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OpcCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OpcCursos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlaneados As System.Windows.Forms.Button
    Friend WithEvents btnContratados As System.Windows.Forms.Button
    Friend WithEvents btnTrimestre As System.Windows.Forms.Button
    Friend WithEvents btnSalir4 As System.Windows.Forms.Button
    Friend WithEvents btnRequisitos As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
