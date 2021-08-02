<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evaluaciones
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
        Me.lstCursos = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.lstAprobados = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAprobados = New System.Windows.Forms.Button()
        Me.btnDesaprobados = New System.Windows.Forms.Button()
        Me.lstDesaprobados = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el curso a cargar resultados"
        '
        'lstCursos
        '
        Me.lstCursos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader12})
        Me.lstCursos.GridLines = True
        Me.lstCursos.Location = New System.Drawing.Point(177, 37)
        Me.lstCursos.Name = "lstCursos"
        Me.lstCursos.Size = New System.Drawing.Size(715, 97)
        Me.lstCursos.TabIndex = 1
        Me.lstCursos.UseCompatibleStateImageBehavior = False
        Me.lstCursos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "id"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Curso"
        Me.ColumnHeader1.Width = 145
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Inicio"
        Me.ColumnHeader2.Width = 139
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Final"
        Me.ColumnHeader3.Width = 128
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Dia"
        Me.ColumnHeader4.Width = 178
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(457, 140)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(131, 39)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'lstAprobados
        '
        Me.lstAprobados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstAprobados.GridLines = True
        Me.lstAprobados.Location = New System.Drawing.Point(12, 230)
        Me.lstAprobados.Name = "lstAprobados"
        Me.lstAprobados.Size = New System.Drawing.Size(426, 336)
        Me.lstAprobados.TabIndex = 3
        Me.lstAprobados.UseCompatibleStateImageBehavior = False
        Me.lstAprobados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nombre"
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Apellido"
        Me.ColumnHeader7.Width = 145
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DNI"
        Me.ColumnHeader8.Width = 146
        '
        'btnAprobados
        '
        Me.btnAprobados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobados.Location = New System.Drawing.Point(459, 287)
        Me.btnAprobados.Name = "btnAprobados"
        Me.btnAprobados.Size = New System.Drawing.Size(131, 39)
        Me.btnAprobados.TabIndex = 5
        Me.btnAprobados.Text = "<  APROBADO"
        Me.btnAprobados.UseVisualStyleBackColor = True
        '
        'btnDesaprobados
        '
        Me.btnDesaprobados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesaprobados.Location = New System.Drawing.Point(456, 475)
        Me.btnDesaprobados.Name = "btnDesaprobados"
        Me.btnDesaprobados.Size = New System.Drawing.Size(135, 39)
        Me.btnDesaprobados.TabIndex = 6
        Me.btnDesaprobados.Text = "DESAPROBADO  >"
        Me.btnDesaprobados.UseVisualStyleBackColor = True
        '
        'lstDesaprobados
        '
        Me.lstDesaprobados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lstDesaprobados.GridLines = True
        Me.lstDesaprobados.Location = New System.Drawing.Point(609, 230)
        Me.lstDesaprobados.Name = "lstDesaprobados"
        Me.lstDesaprobados.Size = New System.Drawing.Size(426, 336)
        Me.lstDesaprobados.TabIndex = 7
        Me.lstDesaprobados.UseCompatibleStateImageBehavior = False
        Me.lstDesaprobados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nombre"
        Me.ColumnHeader9.Width = 130
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Apellido"
        Me.ColumnHeader10.Width = 145
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "DNI"
        Me.ColumnHeader11.Width = 146
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "APROBADOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(758, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DESAPROBADOS"
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(438, 597)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(172, 39)
        Me.btnCargar.TabIndex = 11
        Me.btnCargar.Text = "CARGAR RESULTADOS"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Contrato"
        '
        'Evaluaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstDesaprobados)
        Me.Controls.Add(Me.btnDesaprobados)
        Me.Controls.Add(Me.btnAprobados)
        Me.Controls.Add(Me.lstAprobados)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.lstCursos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Evaluaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluaciones"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCursos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents lstAprobados As System.Windows.Forms.ListView
    Friend WithEvents btnAprobados As System.Windows.Forms.Button
    Friend WithEvents btnDesaprobados As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstDesaprobados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
End Class
