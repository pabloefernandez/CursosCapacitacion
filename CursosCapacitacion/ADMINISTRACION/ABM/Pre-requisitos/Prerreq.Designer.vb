<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prerreq
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
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.chkObligatorio = New System.Windows.Forms.CheckBox()
        Me.btnPrerreq = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboCursos
        '
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(114, 12)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(209, 21)
        Me.cboCursos.TabIndex = 0
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(176, 57)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 1
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'chkObligatorio
        '
        Me.chkObligatorio.AutoSize = True
        Me.chkObligatorio.Location = New System.Drawing.Point(330, 14)
        Me.chkObligatorio.Name = "chkObligatorio"
        Me.chkObligatorio.Size = New System.Drawing.Size(76, 17)
        Me.chkObligatorio.TabIndex = 2
        Me.chkObligatorio.Text = "Obligatorio"
        Me.chkObligatorio.UseVisualStyleBackColor = True
        '
        'btnPrerreq
        '
        Me.btnPrerreq.Location = New System.Drawing.Point(320, 57)
        Me.btnPrerreq.Name = "btnPrerreq"
        Me.btnPrerreq.Size = New System.Drawing.Size(106, 23)
        Me.btnPrerreq.TabIndex = 3
        Me.btnPrerreq.Text = "Ver pre-requisitos >"
        Me.btnPrerreq.UseVisualStyleBackColor = True
        '
        'Prerreq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 108)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrerreq)
        Me.Controls.Add(Me.chkObligatorio)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.cboCursos)
        Me.Name = "Prerreq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prerreq"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents chkObligatorio As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrerreq As System.Windows.Forms.Button
End Class
