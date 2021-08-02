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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAsig = New System.Windows.Forms.Button()
        Me.nudHora1 = New System.Windows.Forms.NumericUpDown()
        Me.nudmm1 = New System.Windows.Forms.NumericUpDown()
        Me.nudhora2 = New System.Windows.Forms.NumericUpDown()
        Me.nudmm2 = New System.Windows.Forms.NumericUpDown()
        Me.cboDias = New System.Windows.Forms.ComboBox()
        CType(Me.nudHora1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudmm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudhora2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudmm2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(223, 204)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(101, 43)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 101)
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
        Me.Label3.Location = New System.Drawing.Point(58, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "hh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(219, 78)
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
        'btnAsig
        '
        Me.btnAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsig.Location = New System.Drawing.Point(28, 204)
        Me.btnAsig.Name = "btnAsig"
        Me.btnAsig.Size = New System.Drawing.Size(115, 43)
        Me.btnAsig.TabIndex = 13
        Me.btnAsig.Text = "Asignar Capacitador/es"
        Me.btnAsig.UseVisualStyleBackColor = True
        '
        'nudHora1
        '
        Me.nudHora1.Location = New System.Drawing.Point(107, 104)
        Me.nudHora1.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudHora1.Name = "nudHora1"
        Me.nudHora1.Size = New System.Drawing.Size(61, 20)
        Me.nudHora1.TabIndex = 14
        '
        'nudmm1
        '
        Me.nudmm1.Location = New System.Drawing.Point(207, 104)
        Me.nudmm1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudmm1.Name = "nudmm1"
        Me.nudmm1.Size = New System.Drawing.Size(61, 20)
        Me.nudmm1.TabIndex = 14
        '
        'nudhora2
        '
        Me.nudhora2.Location = New System.Drawing.Point(107, 142)
        Me.nudhora2.Maximum = New Decimal(New Integer() {19, 0, 0, 0})
        Me.nudhora2.Name = "nudhora2"
        Me.nudhora2.Size = New System.Drawing.Size(61, 20)
        Me.nudhora2.TabIndex = 14
        '
        'nudmm2
        '
        Me.nudmm2.Location = New System.Drawing.Point(207, 142)
        Me.nudmm2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudmm2.Name = "nudmm2"
        Me.nudmm2.Size = New System.Drawing.Size(61, 20)
        Me.nudmm2.TabIndex = 14
        '
        'cboDias
        '
        Me.cboDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDias.FormattingEnabled = True
        Me.cboDias.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.cboDias.Location = New System.Drawing.Point(139, 178)
        Me.cboDias.Name = "cboDias"
        Me.cboDias.Size = New System.Drawing.Size(121, 21)
        Me.cboDias.TabIndex = 15
        '
        'A_Ediciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboDias)
        Me.Controls.Add(Me.nudmm1)
        Me.Controls.Add(Me.nudmm2)
        Me.Controls.Add(Me.nudhora2)
        Me.Controls.Add(Me.nudHora1)
        Me.Controls.Add(Me.btnAsig)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Name = "A_Ediciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ediciones de los cursos"
        Me.TopMost = True
        CType(Me.nudHora1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudmm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudhora2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudmm2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAsig As System.Windows.Forms.Button
    Friend WithEvents nudHora1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudmm1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudhora2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudmm2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboDias As System.Windows.Forms.ComboBox
End Class
