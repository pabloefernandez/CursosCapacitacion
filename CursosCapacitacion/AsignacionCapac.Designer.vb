<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionCapac
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstCapac = New System.Windows.Forms.ListView()
        Me.IDEDICION = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NOMBRE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.APELLIDO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TELEFONO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDHORA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstCapac)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capacitadores"
        '
        'lstCapac
        '
        Me.lstCapac.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDEDICION, Me.NOMBRE, Me.APELLIDO, Me.TELEFONO, Me.IDHORA})
        Me.lstCapac.Location = New System.Drawing.Point(6, 19)
        Me.lstCapac.Name = "lstCapac"
        Me.lstCapac.Size = New System.Drawing.Size(409, 201)
        Me.lstCapac.TabIndex = 0
        Me.lstCapac.UseCompatibleStateImageBehavior = False
        Me.lstCapac.View = System.Windows.Forms.View.Details
        '
        'IDEDICION
        '
        Me.IDEDICION.Text = "Edicion"
        Me.IDEDICION.Width = 64
        '
        'NOMBRE
        '
        Me.NOMBRE.Text = "Nombre"
        Me.NOMBRE.Width = 72
        '
        'APELLIDO
        '
        Me.APELLIDO.Text = "Apellido"
        Me.APELLIDO.Width = 78
        '
        'TELEFONO
        '
        Me.TELEFONO.Text = "Telefono"
        Me.TELEFONO.Width = 106
        '
        'IDHORA
        '
        Me.IDHORA.Text = "IDhorario"
        Me.IDHORA.Width = 85
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(270, 267)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(143, 33)
        Me.btnAsignar.TabIndex = 1
        Me.btnAsignar.Text = "ASIGNAR"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(13, 31)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(94, 31)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(13, 83)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 31)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'AsignacionCapac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 312)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AsignacionCapac"
        Me.Text = "AsignacionCapac"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstCapac As System.Windows.Forms.ListView
    Friend WithEvents IDEDICION As System.Windows.Forms.ColumnHeader
    Friend WithEvents NOMBRE As System.Windows.Forms.ColumnHeader
    Friend WithEvents APELLIDO As System.Windows.Forms.ColumnHeader
    Friend WithEvents TELEFONO As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents IDHORA As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
