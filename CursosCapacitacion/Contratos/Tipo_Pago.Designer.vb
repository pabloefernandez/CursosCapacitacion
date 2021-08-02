<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Pago
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
        Me.btnSiguienteT = New System.Windows.Forms.Button()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.gbxTipo = New System.Windows.Forms.GroupBox()
        Me.gbxTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSiguienteT
        '
        Me.btnSiguienteT.Location = New System.Drawing.Point(119, 128)
        Me.btnSiguienteT.Name = "btnSiguienteT"
        Me.btnSiguienteT.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguienteT.TabIndex = 1
        Me.btnSiguienteT.Text = "Siguiente"
        Me.btnSiguienteT.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(22, 19)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(146, 21)
        Me.cboTipo.TabIndex = 0
        '
        'gbxTipo
        '
        Me.gbxTipo.Controls.Add(Me.btnSiguienteT)
        Me.gbxTipo.Controls.Add(Me.cboTipo)
        Me.gbxTipo.Location = New System.Drawing.Point(12, 12)
        Me.gbxTipo.Name = "gbxTipo"
        Me.gbxTipo.Size = New System.Drawing.Size(200, 157)
        Me.gbxTipo.TabIndex = 2
        Me.gbxTipo.TabStop = False
        Me.gbxTipo.Text = "Tipo de pago"
        '
        'Tipo_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 177)
        Me.Controls.Add(Me.gbxTipo)
        Me.Name = "Tipo_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo_Pago"
        Me.TopMost = True
        Me.gbxTipo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSiguienteT As System.Windows.Forms.Button
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents gbxTipo As System.Windows.Forms.GroupBox
End Class
