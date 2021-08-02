<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcCapacitadores
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
        Me.btnSalir4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPuntajes = New System.Windows.Forms.Button()
        Me.btnCursosDictados = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 26)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir4
        '
        Me.btnSalir4.Location = New System.Drawing.Point(323, 26)
        Me.btnSalir4.Name = "btnSalir4"
        Me.btnSalir4.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir4.TabIndex = 22
        Me.btnSalir4.Text = "Salir"
        Me.btnSalir4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPuntajes)
        Me.GroupBox1.Controls.Add(Me.btnCursosDictados)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 226)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones/Capacitadores"
        '
        'btnPuntajes
        '
        Me.btnPuntajes.Location = New System.Drawing.Point(31, 58)
        Me.btnPuntajes.Name = "btnPuntajes"
        Me.btnPuntajes.Size = New System.Drawing.Size(194, 23)
        Me.btnPuntajes.TabIndex = 15
        Me.btnPuntajes.Text = "Puntajes"
        Me.btnPuntajes.UseVisualStyleBackColor = True
        '
        'btnCursosDictados
        '
        Me.btnCursosDictados.Location = New System.Drawing.Point(31, 29)
        Me.btnCursosDictados.Name = "btnCursosDictados"
        Me.btnCursosDictados.Size = New System.Drawing.Size(194, 23)
        Me.btnCursosDictados.TabIndex = 14
        Me.btnCursosDictados.Text = "Cursos dictados"
        Me.btnCursosDictados.UseVisualStyleBackColor = True
        '
        'OpcCapacitadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 336)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OpcCapacitadores"
        Me.Text = "OpcCapacitadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCursosDictados As System.Windows.Forms.Button
    Friend WithEvents btnPuntajes As System.Windows.Forms.Button
End Class
