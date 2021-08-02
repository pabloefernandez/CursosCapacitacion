<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Capacitadores
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
        Me.btnTick = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtDCapacitador = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.btnTick9 = New System.Windows.Forms.Button()
        Me.btnTick6 = New System.Windows.Forms.Button()
        Me.btnTick5 = New System.Windows.Forms.Button()
        Me.btnTick2 = New System.Windows.Forms.Button()
        Me.btnTick3 = New System.Windows.Forms.Button()
        Me.btnTick4 = New System.Windows.Forms.Button()
        Me.btnTick1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txtFNacimiento = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTick8 = New System.Windows.Forms.Button()
        Me.btnTick7 = New System.Windows.Forms.Button()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTick
        '
        Me.btnTick.Location = New System.Drawing.Point(441, 72)
        Me.btnTick.Name = "btnTick"
        Me.btnTick.Size = New System.Drawing.Size(24, 23)
        Me.btnTick.TabIndex = 55
        Me.btnTick.Text = "✔"
        Me.btnTick.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(432, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 54
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtDCapacitador
        '
        Me.txtDCapacitador.Location = New System.Drawing.Point(85, 74)
        Me.txtDCapacitador.Name = "txtDCapacitador"
        Me.txtDCapacitador.Size = New System.Drawing.Size(350, 20)
        Me.txtDCapacitador.TabIndex = 53
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(217, 435)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(105, 27)
        Me.btnModificar.TabIndex = 52
        Me.btnModificar.Text = "LISTO >"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Ingrese DNI del capacitador que desee modificar"
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.btnTick7)
        Me.gbxDatos.Controls.Add(Me.btnTick8)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtSexo)
        Me.gbxDatos.Controls.Add(Me.txtNacionalidad)
        Me.gbxDatos.Controls.Add(Me.btnTick9)
        Me.gbxDatos.Controls.Add(Me.btnTick6)
        Me.gbxDatos.Controls.Add(Me.btnTick5)
        Me.gbxDatos.Controls.Add(Me.btnTick2)
        Me.gbxDatos.Controls.Add(Me.btnTick3)
        Me.gbxDatos.Controls.Add(Me.btnTick4)
        Me.gbxDatos.Controls.Add(Me.btnTick1)
        Me.gbxDatos.Controls.Add(Me.lbl1)
        Me.gbxDatos.Controls.Add(Me.txtDireccion)
        Me.gbxDatos.Controls.Add(Me.lbl5)
        Me.gbxDatos.Controls.Add(Me.lbl2)
        Me.gbxDatos.Controls.Add(Me.txtApellido)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Controls.Add(Me.txtEmail)
        Me.gbxDatos.Controls.Add(Me.txtTel)
        Me.gbxDatos.Controls.Add(Me.lbl3)
        Me.gbxDatos.Controls.Add(Me.lbl7)
        Me.gbxDatos.Controls.Add(Me.txtFNacimiento)
        Me.gbxDatos.Controls.Add(Me.lbl4)
        Me.gbxDatos.Controls.Add(Me.txtDni)
        Me.gbxDatos.Controls.Add(Me.lbl6)
        Me.gbxDatos.Location = New System.Drawing.Point(24, 97)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(482, 323)
        Me.gbxDatos.TabIndex = 50
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "DATOS"
        '
        'btnTick9
        '
        Me.btnTick9.Location = New System.Drawing.Point(288, 268)
        Me.btnTick9.Name = "btnTick9"
        Me.btnTick9.Size = New System.Drawing.Size(22, 20)
        Me.btnTick9.TabIndex = 56
        Me.btnTick9.Text = "✔"
        Me.btnTick9.UseVisualStyleBackColor = True
        '
        'btnTick6
        '
        Me.btnTick6.Location = New System.Drawing.Point(337, 168)
        Me.btnTick6.Name = "btnTick6"
        Me.btnTick6.Size = New System.Drawing.Size(22, 20)
        Me.btnTick6.TabIndex = 55
        Me.btnTick6.Text = "✔"
        Me.btnTick6.UseVisualStyleBackColor = True
        '
        'btnTick5
        '
        Me.btnTick5.Location = New System.Drawing.Point(230, 138)
        Me.btnTick5.Name = "btnTick5"
        Me.btnTick5.Size = New System.Drawing.Size(22, 20)
        Me.btnTick5.TabIndex = 54
        Me.btnTick5.Text = "✔"
        Me.btnTick5.UseVisualStyleBackColor = True
        '
        'btnTick2
        '
        Me.btnTick2.Location = New System.Drawing.Point(242, 48)
        Me.btnTick2.Name = "btnTick2"
        Me.btnTick2.Size = New System.Drawing.Size(22, 20)
        Me.btnTick2.TabIndex = 53
        Me.btnTick2.Text = "✔"
        Me.btnTick2.UseVisualStyleBackColor = True
        '
        'btnTick3
        '
        Me.btnTick3.Location = New System.Drawing.Point(292, 77)
        Me.btnTick3.Name = "btnTick3"
        Me.btnTick3.Size = New System.Drawing.Size(22, 20)
        Me.btnTick3.TabIndex = 52
        Me.btnTick3.Text = "✔"
        Me.btnTick3.UseVisualStyleBackColor = True
        '
        'btnTick4
        '
        Me.btnTick4.Location = New System.Drawing.Point(264, 108)
        Me.btnTick4.Name = "btnTick4"
        Me.btnTick4.Size = New System.Drawing.Size(22, 20)
        Me.btnTick4.TabIndex = 51
        Me.btnTick4.Text = "✔"
        Me.btnTick4.UseVisualStyleBackColor = True
        '
        'btnTick1
        '
        Me.btnTick1.Location = New System.Drawing.Point(291, 16)
        Me.btnTick1.Name = "btnTick1"
        Me.btnTick1.Size = New System.Drawing.Size(22, 20)
        Me.btnTick1.TabIndex = 50
        Me.btnTick1.Text = "✔"
        Me.btnTick1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(28, 16)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(69, 20)
        Me.lbl1.TabIndex = 13
        Me.lbl1.Text = "Nombre:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(28, 46)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(69, 20)
        Me.lbl2.TabIndex = 17
        Me.lbl2.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(103, 48)
        Me.txtApellido.MaxLength = 40
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(133, 20)
        Me.txtApellido.TabIndex = 15
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 16)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 14
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(113, 77)
        Me.txtDireccion.MaxLength = 30
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(173, 20)
        Me.txtDireccion.TabIndex = 21
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(88, 268)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(194, 20)
        Me.txtEmail.TabIndex = 24
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(124, 108)
        Me.txtTel.MaxLength = 8
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(133, 20)
        Me.txtTel.TabIndex = 15
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(27, 108)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(75, 20)
        Me.lbl3.TabIndex = 25
        Me.lbl3.Text = "Telefono:"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(30, 268)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(52, 20)
        Me.lbl7.TabIndex = 23
        Me.lbl7.Text = "Email:"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(28, 77)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(79, 20)
        Me.lbl5.TabIndex = 19
        Me.lbl5.Text = "Direccion:"
        '
        'txtFNacimiento
        '
        Me.txtFNacimiento.Location = New System.Drawing.Point(193, 168)
        Me.txtFNacimiento.MaxLength = 30
        Me.txtFNacimiento.Name = "txtFNacimiento"
        Me.txtFNacimiento.Size = New System.Drawing.Size(138, 20)
        Me.txtFNacimiento.TabIndex = 22
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(27, 138)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(41, 20)
        Me.lbl4.TabIndex = 18
        Me.lbl4.Text = "DNI:"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(74, 138)
        Me.txtDni.MaxLength = 11
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(150, 20)
        Me.txtDni.TabIndex = 16
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(28, 168)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(163, 20)
        Me.lbl6.TabIndex = 20
        Me.lbl6.Text = "Fecha de Nacimiento:"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(135, 200)
        Me.txtNacionalidad.MaxLength = 40
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(194, 20)
        Me.txtNacionalidad.TabIndex = 57
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(80, 233)
        Me.txtSexo.MaxLength = 40
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(194, 20)
        Me.txtSexo.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Nacionalidad:"
        '
        'btnTick8
        '
        Me.btnTick8.Location = New System.Drawing.Point(280, 233)
        Me.btnTick8.Name = "btnTick8"
        Me.btnTick8.Size = New System.Drawing.Size(22, 20)
        Me.btnTick8.TabIndex = 61
        Me.btnTick8.Text = "✔"
        Me.btnTick8.UseVisualStyleBackColor = True
        '
        'btnTick7
        '
        Me.btnTick7.Location = New System.Drawing.Point(337, 200)
        Me.btnTick7.Name = "btnTick7"
        Me.btnTick7.Size = New System.Drawing.Size(22, 20)
        Me.btnTick7.TabIndex = 62
        Me.btnTick7.Text = "✔"
        Me.btnTick7.UseVisualStyleBackColor = True
        '
        'M_Capacitadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 482)
        Me.Controls.Add(Me.btnTick)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtDCapacitador)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxDatos)
        Me.Name = "M_Capacitadores"
        Me.Text = "M_Capacitadores"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTick As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtDCapacitador As System.Windows.Forms.TextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnTick7 As System.Windows.Forms.Button
    Friend WithEvents btnTick8 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents btnTick9 As System.Windows.Forms.Button
    Friend WithEvents btnTick6 As System.Windows.Forms.Button
    Friend WithEvents btnTick5 As System.Windows.Forms.Button
    Friend WithEvents btnTick2 As System.Windows.Forms.Button
    Friend WithEvents btnTick3 As System.Windows.Forms.Button
    Friend WithEvents btnTick4 As System.Windows.Forms.Button
    Friend WithEvents btnTick1 As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents txtFNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
End Class
