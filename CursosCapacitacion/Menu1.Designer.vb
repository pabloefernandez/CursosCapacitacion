<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
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
        Me.btnABM = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.btnCapacitadores = New System.Windows.Forms.Button()
        Me.btnContratos = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.btnSalir1 = New System.Windows.Forms.Button()
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnABM
        '
        Me.btnABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnABM.Location = New System.Drawing.Point(208, 296)
        Me.btnABM.Name = "btnABM"
        Me.btnABM.Size = New System.Drawing.Size(194, 34)
        Me.btnABM.TabIndex = 0
        Me.btnABM.Text = "ABM DEL SISTEMA"
        Me.btnABM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.btnCursos)
        Me.GroupBox1.Controls.Add(Me.btnCapacitadores)
        Me.GroupBox1.Controls.Add(Me.btnContratos)
        Me.GroupBox1.Controls.Add(Me.btnPagos)
        Me.GroupBox1.Location = New System.Drawing.Point(177, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 229)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones/Menu principal"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(31, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(194, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Companias"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnCursos
        '
        Me.btnCursos.Location = New System.Drawing.Point(31, 29)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(194, 23)
        Me.btnCursos.TabIndex = 14
        Me.btnCursos.Text = "Cursos"
        Me.btnCursos.UseVisualStyleBackColor = True
        '
        'btnCapacitadores
        '
        Me.btnCapacitadores.Location = New System.Drawing.Point(31, 67)
        Me.btnCapacitadores.Name = "btnCapacitadores"
        Me.btnCapacitadores.Size = New System.Drawing.Size(194, 23)
        Me.btnCapacitadores.TabIndex = 6
        Me.btnCapacitadores.Text = "Capacitadores"
        Me.btnCapacitadores.UseVisualStyleBackColor = True
        '
        'btnContratos
        '
        Me.btnContratos.Location = New System.Drawing.Point(31, 144)
        Me.btnContratos.Name = "btnContratos"
        Me.btnContratos.Size = New System.Drawing.Size(194, 23)
        Me.btnContratos.TabIndex = 5
        Me.btnContratos.Text = "Contratos"
        Me.btnContratos.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Location = New System.Drawing.Point(31, 183)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(194, 23)
        Me.btnPagos.TabIndex = 3
        Me.btnPagos.Text = "Pagos"
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'btnSalir1
        '
        Me.btnSalir1.Location = New System.Drawing.Point(503, 12)
        Me.btnSalir1.Name = "btnSalir1"
        Me.btnSalir1.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir1.TabIndex = 15
        Me.btnSalir1.Text = "Salir"
        Me.btnSalir1.UseVisualStyleBackColor = True
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.ForeColor = System.Drawing.Color.Green
        Me.lblConnect.Location = New System.Drawing.Point(502, 333)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(51, 13)
        Me.lblConnect.TabIndex = 16
        Me.lblConnect.Text = "Conexion"
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(609, 355)
        Me.Controls.Add(Me.lblConnect)
        Me.Controls.Add(Me.btnSalir1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnABM)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Menu1"
        Me.Text = "Menu principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnABM As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCursos As System.Windows.Forms.Button
    Friend WithEvents btnCapacitadores As System.Windows.Forms.Button
    Friend WithEvents btnContratos As System.Windows.Forms.Button
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents btnSalir1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblConnect As System.Windows.Forms.Label

End Class
