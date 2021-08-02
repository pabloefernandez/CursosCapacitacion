<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Capacitadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Capacitadores))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCNombre = New System.Windows.Forms.TextBox()
        Me.txtCApellido = New System.Windows.Forms.TextBox()
        Me.txtCDireccion = New System.Windows.Forms.TextBox()
        Me.txtCTelefono = New System.Windows.Forms.TextBox()
        Me.txtCDni = New System.Windows.Forms.TextBox()
        Me.txtCNacionalidad = New System.Windows.Forms.TextBox()
        Me.txtCEmail = New System.Windows.Forms.TextBox()
        Me.rdnFemenino = New System.Windows.Forms.RadioButton()
        Me.rdnMasculino = New System.Windows.Forms.RadioButton()
        Me.btnCSiguiente = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Capacitadores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Altas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(375, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(449, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Apellido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Direccion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Telefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "D.N.I:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(371, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Fecha de Nacimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Nacionalidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Sexo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 459)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Email de contacto:"
        '
        'txtCNombre
        '
        Me.txtCNombre.Location = New System.Drawing.Point(92, 190)
        Me.txtCNombre.Name = "txtCNombre"
        Me.txtCNombre.Size = New System.Drawing.Size(190, 20)
        Me.txtCNombre.TabIndex = 16
        '
        'txtCApellido
        '
        Me.txtCApellido.Location = New System.Drawing.Point(92, 230)
        Me.txtCApellido.Name = "txtCApellido"
        Me.txtCApellido.Size = New System.Drawing.Size(190, 20)
        Me.txtCApellido.TabIndex = 17
        '
        'txtCDireccion
        '
        Me.txtCDireccion.Location = New System.Drawing.Point(102, 269)
        Me.txtCDireccion.Name = "txtCDireccion"
        Me.txtCDireccion.Size = New System.Drawing.Size(190, 20)
        Me.txtCDireccion.TabIndex = 18
        '
        'txtCTelefono
        '
        Me.txtCTelefono.Location = New System.Drawing.Point(98, 310)
        Me.txtCTelefono.MaxLength = 10
        Me.txtCTelefono.Name = "txtCTelefono"
        Me.txtCTelefono.Size = New System.Drawing.Size(190, 20)
        Me.txtCTelefono.TabIndex = 19
        '
        'txtCDni
        '
        Me.txtCDni.Location = New System.Drawing.Point(72, 346)
        Me.txtCDni.MaxLength = 8
        Me.txtCDni.Name = "txtCDni"
        Me.txtCDni.Size = New System.Drawing.Size(150, 20)
        Me.txtCDni.TabIndex = 20
        '
        'txtCNacionalidad
        '
        Me.txtCNacionalidad.Location = New System.Drawing.Point(129, 381)
        Me.txtCNacionalidad.Name = "txtCNacionalidad"
        Me.txtCNacionalidad.Size = New System.Drawing.Size(200, 20)
        Me.txtCNacionalidad.TabIndex = 22
        '
        'txtCEmail
        '
        Me.txtCEmail.Location = New System.Drawing.Point(165, 459)
        Me.txtCEmail.Name = "txtCEmail"
        Me.txtCEmail.Size = New System.Drawing.Size(243, 20)
        Me.txtCEmail.TabIndex = 24
        '
        'rdnFemenino
        '
        Me.rdnFemenino.AutoSize = True
        Me.rdnFemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdnFemenino.Location = New System.Drawing.Point(74, 419)
        Me.rdnFemenino.Name = "rdnFemenino"
        Me.rdnFemenino.Size = New System.Drawing.Size(98, 24)
        Me.rdnFemenino.TabIndex = 26
        Me.rdnFemenino.TabStop = True
        Me.rdnFemenino.Text = "Femenino"
        Me.rdnFemenino.UseVisualStyleBackColor = True
        '
        'rdnMasculino
        '
        Me.rdnMasculino.AutoSize = True
        Me.rdnMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdnMasculino.Location = New System.Drawing.Point(178, 419)
        Me.rdnMasculino.Name = "rdnMasculino"
        Me.rdnMasculino.Size = New System.Drawing.Size(98, 24)
        Me.rdnMasculino.TabIndex = 27
        Me.rdnMasculino.TabStop = True
        Me.rdnMasculino.Text = "Masculino"
        Me.rdnMasculino.UseVisualStyleBackColor = True
        '
        'btnCSiguiente
        '
        Me.btnCSiguiente.Location = New System.Drawing.Point(241, 511)
        Me.btnCSiguiente.Name = "btnCSiguiente"
        Me.btnCSiguiente.Size = New System.Drawing.Size(105, 27)
        Me.btnCSiguiente.TabIndex = 28
        Me.btnCSiguiente.Text = "SIGUIENTE >"
        Me.btnCSiguiente.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(358, 240)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 29
        '
        'A_Capacitadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnCSiguiente)
        Me.Controls.Add(Me.rdnMasculino)
        Me.Controls.Add(Me.rdnFemenino)
        Me.Controls.Add(Me.txtCEmail)
        Me.Controls.Add(Me.txtCNacionalidad)
        Me.Controls.Add(Me.txtCDni)
        Me.Controls.Add(Me.txtCTelefono)
        Me.Controls.Add(Me.txtCDireccion)
        Me.Controls.Add(Me.txtCApellido)
        Me.Controls.Add(Me.txtCNombre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "A_Capacitadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Altas Capacitadores"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCEmail As System.Windows.Forms.TextBox
    Friend WithEvents rdnFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdnMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents btnCSiguiente As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
