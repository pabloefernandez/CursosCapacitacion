<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleContrato))
        Me.rtbCuerpo = New System.Windows.Forms.RichTextBox()
        Me.txtNCompania = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rtbCuerpo
        '
        Me.rtbCuerpo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCuerpo.Location = New System.Drawing.Point(12, 57)
        Me.rtbCuerpo.Name = "rtbCuerpo"
        Me.rtbCuerpo.ReadOnly = True
        Me.rtbCuerpo.Size = New System.Drawing.Size(795, 561)
        Me.rtbCuerpo.TabIndex = 1
        Me.rtbCuerpo.Text = resources.GetString("rtbCuerpo.Text")
        '
        'txtNCompania
        '
        Me.txtNCompania.Location = New System.Drawing.Point(426, 61)
        Me.txtNCompania.Name = "txtNCompania"
        Me.txtNCompania.Size = New System.Drawing.Size(251, 20)
        Me.txtNCompania.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(12, 85)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(245, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(323, 84)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(136, 20)
        Me.txtCuit.TabIndex = 4
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(528, 84)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(65, 20)
        Me.txtDia.TabIndex = 5
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(657, 84)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(68, 20)
        Me.txtMes.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 7
        '
        'DetalleContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 630)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNCompania)
        Me.Controls.Add(Me.rtbCuerpo)
        Me.Name = "DetalleContrato"
        Me.Text = "DetalleContrato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbCuerpo As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNCompania As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
