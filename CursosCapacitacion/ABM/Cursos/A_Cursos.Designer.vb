<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Cursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Cursos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtPuntaje = New System.Windows.Forms.TextBox()
        Me.txtCupo = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.cboAreas = New System.Windows.Forms.ComboBox()
        Me.chkGerencial = New System.Windows.Forms.CheckBox()
        Me.btnICurso = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(339, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cursos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(449, 37)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Area:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cupo maximo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Costo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Puntaje:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Duracion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nivel:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(128, 192)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(190, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(101, 230)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(44, 20)
        Me.txtNivel.TabIndex = 12
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(138, 263)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(100, 20)
        Me.txtDuracion.TabIndex = 13
        '
        'txtPuntaje
        '
        Me.txtPuntaje.Location = New System.Drawing.Point(128, 295)
        Me.txtPuntaje.Name = "txtPuntaje"
        Me.txtPuntaje.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntaje.TabIndex = 14
        '
        'txtCupo
        '
        Me.txtCupo.Location = New System.Drawing.Point(170, 364)
        Me.txtCupo.Name = "txtCupo"
        Me.txtCupo.Size = New System.Drawing.Size(68, 20)
        Me.txtCupo.TabIndex = 15
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(116, 329)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 16
        '
        'cboAreas
        '
        Me.cboAreas.FormattingEnabled = True
        Me.cboAreas.Location = New System.Drawing.Point(102, 400)
        Me.cboAreas.Name = "cboAreas"
        Me.cboAreas.Size = New System.Drawing.Size(168, 21)
        Me.cboAreas.TabIndex = 17
        '
        'chkGerencial
        '
        Me.chkGerencial.AutoSize = True
        Me.chkGerencial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGerencial.Location = New System.Drawing.Point(384, 401)
        Me.chkGerencial.Name = "chkGerencial"
        Me.chkGerencial.Size = New System.Drawing.Size(96, 24)
        Me.chkGerencial.TabIndex = 18
        Me.chkGerencial.Text = "Gerencial"
        Me.chkGerencial.UseVisualStyleBackColor = True
        '
        'btnICurso
        '
        Me.btnICurso.Location = New System.Drawing.Point(197, 444)
        Me.btnICurso.Name = "btnICurso"
        Me.btnICurso.Size = New System.Drawing.Size(135, 29)
        Me.btnICurso.TabIndex = 19
        Me.btnICurso.Text = "SIGUIENTE >"
        Me.btnICurso.UseVisualStyleBackColor = True
        '
        'A_Cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 491)
        Me.Controls.Add(Me.btnICurso)
        Me.Controls.Add(Me.chkGerencial)
        Me.Controls.Add(Me.cboAreas)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtCupo)
        Me.Controls.Add(Me.txtPuntaje)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtNivel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "A_Cursos"
        Me.Text = "A_Cursos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNivel As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents txtPuntaje As System.Windows.Forms.TextBox
    Friend WithEvents txtCupo As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents cboAreas As System.Windows.Forms.ComboBox
    Friend WithEvents chkGerencial As System.Windows.Forms.CheckBox
    Friend WithEvents btnICurso As System.Windows.Forms.Button
End Class
