<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Ediciones
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
        Me.txtHorarioI = New System.Windows.Forms.TextBox()
        Me.txtHorarioF = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtHorarioI2 = New System.Windows.Forms.TextBox()
        Me.txtHorarioF2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalir3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHorarioI
        '
        Me.txtHorarioI.Location = New System.Drawing.Point(104, 101)
        Me.txtHorarioI.Name = "txtHorarioI"
        Me.txtHorarioI.Size = New System.Drawing.Size(61, 20)
        Me.txtHorarioI.TabIndex = 0
        '
        'txtHorarioF
        '
        Me.txtHorarioF.Location = New System.Drawing.Point(211, 101)
        Me.txtHorarioF.Name = "txtHorarioF"
        Me.txtHorarioF.Size = New System.Drawing.Size(61, 20)
        Me.txtHorarioF.TabIndex = 1
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(137, 178)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDia.TabIndex = 2
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(151, 213)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtHorarioI2
        '
        Me.txtHorarioI2.Location = New System.Drawing.Point(104, 142)
        Me.txtHorarioI2.Name = "txtHorarioI2"
        Me.txtHorarioI2.Size = New System.Drawing.Size(61, 20)
        Me.txtHorarioI2.TabIndex = 4
        '
        'txtHorarioF2
        '
        Me.txtHorarioF2.Location = New System.Drawing.Point(211, 142)
        Me.txtHorarioF2.Name = "txtHorarioF2"
        Me.txtHorarioF2.Size = New System.Drawing.Size(61, 20)
        Me.txtHorarioF2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ediciones de los Cursos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(219, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "hh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "mm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dia"
        '
        'btnSalir3
        '
        Me.btnSalir3.Location = New System.Drawing.Point(268, 12)
        Me.btnSalir3.Name = "btnSalir3"
        Me.btnSalir3.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir3.TabIndex = 22
        Me.btnSalir3.Text = "Salir"
        Me.btnSalir3.UseVisualStyleBackColor = True
        '
        'A_Ediciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 252)
        Me.Controls.Add(Me.btnSalir3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHorarioF2)
        Me.Controls.Add(Me.txtHorarioI2)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.txtHorarioF)
        Me.Controls.Add(Me.txtHorarioI)
        Me.Name = "A_Ediciones"
        Me.Text = "Prueba"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHorarioI As System.Windows.Forms.TextBox
    Friend WithEvents txtHorarioF As System.Windows.Forms.TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtHorarioI2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHorarioF2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSalir3 As System.Windows.Forms.Button
End Class
