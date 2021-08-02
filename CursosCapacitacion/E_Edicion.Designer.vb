<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_Edicion
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
        Me.btnElegir = New System.Windows.Forms.Button()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.dgvHorarios = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnElegir
        '
        Me.btnElegir.Location = New System.Drawing.Point(239, 314)
        Me.btnElegir.Name = "btnElegir"
        Me.btnElegir.Size = New System.Drawing.Size(75, 23)
        Me.btnElegir.TabIndex = 5
        Me.btnElegir.Text = "Elegir"
        Me.btnElegir.UseVisualStyleBackColor = True
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(105, 10)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(346, 20)
        Me.lblDatos.TabIndex = 4
        Me.lblDatos.Text = "Elija un horario correspondiente al curso elegido"
        '
        'dgvHorarios
        '
        Me.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHorarios.Location = New System.Drawing.Point(12, 38)
        Me.dgvHorarios.Name = "dgvHorarios"
        Me.dgvHorarios.Size = New System.Drawing.Size(519, 270)
        Me.dgvHorarios.TabIndex = 3
        '
        'E_Edicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 347)
        Me.Controls.Add(Me.btnElegir)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.dgvHorarios)
        Me.Name = "E_Edicion"
        Me.Text = "E_Edicion"
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnElegir As System.Windows.Forms.Button
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents dgvHorarios As System.Windows.Forms.DataGridView
End Class
