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
        Me.btnContratados = New System.Windows.Forms.Button()
        Me.btnCorrelativos = New System.Windows.Forms.Button()
        Me.btnTrimestre = New System.Windows.Forms.Button()
        Me.btnSalir4 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRequisitos)
        Me.GroupBox1.Controls.Add(Me.btnPlaneados)
        Me.GroupBox1.Controls.Add(Me.btnContratados)
        Me.GroupBox1.Controls.Add(Me.btnCorrelativos)
        Me.GroupBox1.Controls.Add(Me.btnTrimestre)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 226)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones/Cursos"
        '
        'btnRequisitos
        '
        Me.btnRequisitos.Location = New System.Drawing.Point(31, 144)
        Me.btnRequisitos.Name = "btnRequisitos"
        Me.btnRequisitos.Size = New System.Drawing.Size(194, 23)
        Me.btnRequisitos.TabIndex = 15
        Me.btnRequisitos.Text = "Requisitos"
        Me.btnRequisitos.UseVisualStyleBackColor = True
        '
        'btnPlaneados
        '
        Me.btnPlaneados.Location = New System.Drawing.Point(31, 29)
        Me.btnPlaneados.Name = "btnPlaneados"
        Me.btnPlaneados.Size = New System.Drawing.Size(194, 23)
        Me.btnPlaneados.TabIndex = 14
        Me.btnPlaneados.Text = "Planeados"
        Me.btnPlaneados.UseVisualStyleBackColor = True
        '
        'btnContratados
        '
        Me.btnContratados.Location = New System.Drawing.Point(31, 67)
        Me.btnContratados.Name = "btnContratados"
        Me.btnContratados.Size = New System.Drawing.Size(194, 23)
        Me.btnContratados.TabIndex = 6
        Me.btnContratados.Text = "Contratados"
        Me.btnContratados.UseVisualStyleBackColor = True
        '
        'btnCorrelativos
        '
        Me.btnCorrelativos.Location = New System.Drawing.Point(31, 105)
        Me.btnCorrelativos.Name = "btnCorrelativos"
        Me.btnCorrelativos.Size = New System.Drawing.Size(194, 23)
        Me.btnCorrelativos.TabIndex = 5
        Me.btnCorrelativos.Text = "Correlativos"
        Me.btnCorrelativos.UseVisualStyleBackColor = True
        '
        'btnTrimestre
        '
        Me.btnTrimestre.Location = New System.Drawing.Point(31, 182)
        Me.btnTrimestre.Name = "btnTrimestre"
        Me.btnTrimestre.Size = New System.Drawing.Size(194, 23)
        Me.btnTrimestre.TabIndex = 3
        Me.btnTrimestre.Text = "Trimestre"
        Me.btnTrimestre.UseVisualStyleBackColor = True
        '
        'btnSalir4
        '
        Me.btnSalir4.Location = New System.Drawing.Point(323, 12)
        Me.btnSalir4.Name = "btnSalir4"
        Me.btnSalir4.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir4.TabIndex = 16
        Me.btnSalir4.Text = "Salir"
        Me.btnSalir4.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "< Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'OpcCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 336)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OpcCursos"
        Me.Text = "OpcCursos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlaneados As System.Windows.Forms.Button
    Friend WithEvents btnContratados As System.Windows.Forms.Button
    Friend WithEvents btnCorrelativos As System.Windows.Forms.Button
    Friend WithEvents btnTrimestre As System.Windows.Forms.Button
    Friend WithEvents btnSalir4 As System.Windows.Forms.Button
    Friend WithEvents btnRequisitos As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
