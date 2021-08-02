<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcCompanias
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
        Me.btnCursosReal = New System.Windows.Forms.Button()
        Me.btnPuntajeEmpleados = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 26
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir4
        '
        Me.btnSalir4.Location = New System.Drawing.Point(323, 12)
        Me.btnSalir4.Name = "btnSalir4"
        Me.btnSalir4.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir4.TabIndex = 25
        Me.btnSalir4.Text = "Salir"
        Me.btnSalir4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCursosReal)
        Me.GroupBox1.Controls.Add(Me.btnPuntajeEmpleados)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 90)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones/Capacitadores"
        '
        'btnCursosReal
        '
        Me.btnCursosReal.Location = New System.Drawing.Point(31, 58)
        Me.btnCursosReal.Name = "btnCursosReal"
        Me.btnCursosReal.Size = New System.Drawing.Size(194, 23)
        Me.btnCursosReal.TabIndex = 15
        Me.btnCursosReal.Text = "Cursos realizados"
        Me.btnCursosReal.UseVisualStyleBackColor = True
        '
        'btnPuntajeEmpleados
        '
        Me.btnPuntajeEmpleados.Location = New System.Drawing.Point(31, 29)
        Me.btnPuntajeEmpleados.Name = "btnPuntajeEmpleados"
        Me.btnPuntajeEmpleados.Size = New System.Drawing.Size(194, 23)
        Me.btnPuntajeEmpleados.TabIndex = 14
        Me.btnPuntajeEmpleados.Text = "Puntaje empleados"
        Me.btnPuntajeEmpleados.UseVisualStyleBackColor = True
        '
        'OpcCompanias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 310)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OpcCompanias"
        Me.Text = "OpcCompanias"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCursosReal As System.Windows.Forms.Button
    Friend WithEvents btnPuntajeEmpleados As System.Windows.Forms.Button
End Class
