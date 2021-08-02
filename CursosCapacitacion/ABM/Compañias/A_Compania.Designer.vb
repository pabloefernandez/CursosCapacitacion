<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Compania
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Compania))
        Me.btnCSiguiente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRepres = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCSiguiente
        '
        Me.btnCSiguiente.Location = New System.Drawing.Point(197, 475)
        Me.btnCSiguiente.Name = "btnCSiguiente"
        Me.btnCSiguiente.Size = New System.Drawing.Size(105, 27)
        Me.btnCSiguiente.TabIndex = 43
        Me.btnCSiguiente.Text = "INGRESARLA >"
        Me.btnCSiguiente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(449, 37)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(350, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 37)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Companias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 37)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Altas"
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.lbl1)
        Me.gbxDatos.Controls.Add(Me.lbl2)
        Me.gbxDatos.Controls.Add(Me.txtDireccion)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Controls.Add(Me.txtRepres)
        Me.gbxDatos.Controls.Add(Me.txtEmail)
        Me.gbxDatos.Controls.Add(Me.txtTel)
        Me.gbxDatos.Controls.Add(Me.lbl3)
        Me.gbxDatos.Controls.Add(Me.lbl7)
        Me.gbxDatos.Controls.Add(Me.lbl5)
        Me.gbxDatos.Controls.Add(Me.txtApe)
        Me.gbxDatos.Controls.Add(Me.lbl4)
        Me.gbxDatos.Controls.Add(Me.txtCuit)
        Me.gbxDatos.Controls.Add(Me.lbl6)
        Me.gbxDatos.Location = New System.Drawing.Point(44, 196)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(410, 260)
        Me.gbxDatos.TabIndex = 38
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "DATOS"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(28, 16)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(180, 20)
        Me.lbl1.TabIndex = 13
        Me.lbl1.Text = "Nombre de la compañia:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(28, 46)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(79, 20)
        Me.lbl2.TabIndex = 17
        Me.lbl2.Text = "Direccion:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(125, 48)
        Me.txtDireccion.MaxLength = 40
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(133, 20)
        Me.txtDireccion.TabIndex = 15
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(214, 18)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 14
        '
        'txtRepres
        '
        Me.txtRepres.Location = New System.Drawing.Point(228, 149)
        Me.txtRepres.MaxLength = 30
        Me.txtRepres.Name = "txtRepres"
        Me.txtRepres.Size = New System.Drawing.Size(138, 20)
        Me.txtRepres.TabIndex = 21
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(86, 219)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(194, 20)
        Me.txtEmail.TabIndex = 24
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(125, 80)
        Me.txtTel.MaxLength = 8
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(133, 20)
        Me.txtTel.TabIndex = 15
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(28, 80)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(75, 20)
        Me.lbl3.TabIndex = 25
        Me.lbl3.Text = "Telefono:"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(28, 219)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(52, 20)
        Me.lbl7.TabIndex = 23
        Me.lbl7.Text = "Email:"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(28, 149)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(198, 20)
        Me.lbl5.TabIndex = 19
        Me.lbl5.Text = "Nombre del representante:"
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(232, 183)
        Me.txtApe.MaxLength = 30
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(138, 20)
        Me.txtApe.TabIndex = 22
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(28, 115)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(62, 20)
        Me.lbl4.TabIndex = 18
        Me.lbl4.Text = "C.U.I.T:"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(125, 115)
        Me.txtCuit.MaxLength = 11
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(100, 20)
        Me.txtCuit.TabIndex = 16
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(28, 183)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(198, 20)
        Me.lbl6.TabIndex = 20
        Me.lbl6.Text = "Apellido del representante:"
        '
        'A_Compania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 523)
        Me.Controls.Add(Me.btnCSiguiente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxDatos)
        Me.Name = "A_Compania"
        Me.Text = "A_Compania"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCSiguiente As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtRepres As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
End Class
