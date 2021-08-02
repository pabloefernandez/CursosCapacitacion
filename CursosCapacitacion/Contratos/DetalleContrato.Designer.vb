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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleContrato))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnPag2 = New System.Windows.Forms.Button()
        Me.lblDomi = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblComp = New System.Windows.Forms.Label()
        Me.lblNCont = New System.Windows.Forms.Label()
        Me.lblNContT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCuitC = New System.Windows.Forms.TextBox()
        Me.txtNombreR = New System.Windows.Forms.TextBox()
        Me.txtDomi = New System.Windows.Forms.TextBox()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHorarioF = New System.Windows.Forms.TextBox()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.txtHoraI = New System.Windows.Forms.TextBox()
        Me.txtCur = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnImprmir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(900, 1011)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(105, 30)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Location = New System.Drawing.Point(391, 1020)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(240, 30)
        Me.btnFinalizar.TabIndex = 15
        Me.btnFinalizar.Text = "--FINALIZAR CONTRATO--"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnPag2
        '
        Me.btnPag2.Location = New System.Drawing.Point(863, 754)
        Me.btnPag2.Name = "btnPag2"
        Me.btnPag2.Size = New System.Drawing.Size(133, 35)
        Me.btnPag2.TabIndex = 38
        Me.btnPag2.Text = "PAGINA 2"
        Me.btnPag2.UseVisualStyleBackColor = True
        '
        'lblDomi
        '
        Me.lblDomi.AutoSize = True
        Me.lblDomi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomi.Location = New System.Drawing.Point(622, 88)
        Me.lblDomi.Name = "lblDomi"
        Me.lblDomi.Size = New System.Drawing.Size(0, 18)
        Me.lblDomi.TabIndex = 36
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(842, 115)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(49, 18)
        Me.lblFecha.TabIndex = 34
        Me.lblFecha.Text = "Fecha"
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.Location = New System.Drawing.Point(764, 65)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(0, 18)
        Me.lblComp.TabIndex = 35
        '
        'lblNCont
        '
        Me.lblNCont.AutoSize = True
        Me.lblNCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNCont.Location = New System.Drawing.Point(438, 116)
        Me.lblNCont.Name = "lblNCont"
        Me.lblNCont.Size = New System.Drawing.Size(77, 18)
        Me.lblNCont.TabIndex = 33
        Me.lblNCont.Text = "NContrato"
        '
        'lblNContT
        '
        Me.lblNContT.AutoSize = True
        Me.lblNContT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNContT.Location = New System.Drawing.Point(302, 115)
        Me.lblNContT.Name = "lblNContT"
        Me.lblNContT.Size = New System.Drawing.Size(130, 20)
        Me.lblNContT.TabIndex = 32
        Me.lblNContT.Text = "Nª de contrato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(777, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(438, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "CLAUSULAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(429, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "CONTRATO DE CAPACITACION EMPRESARIAL"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCuitC)
        Me.GroupBox1.Controls.Add(Me.txtNombreR)
        Me.GroupBox1.Controls.Add(Me.txtDomi)
        Me.GroupBox1.Controls.Add(Me.txtComp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 137)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'txtCuitC
        '
        Me.txtCuitC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuitC.Location = New System.Drawing.Point(543, 51)
        Me.txtCuitC.Name = "txtCuitC"
        Me.txtCuitC.Size = New System.Drawing.Size(122, 20)
        Me.txtCuitC.TabIndex = 1
        '
        'txtNombreR
        '
        Me.txtNombreR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreR.Location = New System.Drawing.Point(679, 33)
        Me.txtNombreR.Name = "txtNombreR"
        Me.txtNombreR.Size = New System.Drawing.Size(278, 20)
        Me.txtNombreR.TabIndex = 1
        '
        'txtDomi
        '
        Me.txtDomi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomi.Location = New System.Drawing.Point(114, 69)
        Me.txtDomi.Name = "txtDomi"
        Me.txtDomi.Size = New System.Drawing.Size(126, 20)
        Me.txtDomi.TabIndex = 1
        '
        'txtComp
        '
        Me.txtComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComp.Location = New System.Drawing.Point(246, 53)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(205, 20)
        Me.txtComp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(947, 108)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHorarioF)
        Me.GroupBox2.Controls.Add(Me.txtTiempo)
        Me.GroupBox2.Controls.Add(Me.txtHoraI)
        Me.GroupBox2.Controls.Add(Me.txtCur)
        Me.GroupBox2.Controls.Add(Me.txtDia)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(975, 421)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'txtHorarioF
        '
        Me.txtHorarioF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorarioF.Location = New System.Drawing.Point(781, 32)
        Me.txtHorarioF.Name = "txtHorarioF"
        Me.txtHorarioF.Size = New System.Drawing.Size(131, 20)
        Me.txtHorarioF.TabIndex = 1
        '
        'txtTiempo
        '
        Me.txtTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempo.Location = New System.Drawing.Point(472, 71)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(74, 20)
        Me.txtTiempo.TabIndex = 1
        '
        'txtHoraI
        '
        Me.txtHoraI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraI.Location = New System.Drawing.Point(604, 32)
        Me.txtHoraI.Name = "txtHoraI"
        Me.txtHoraI.Size = New System.Drawing.Size(139, 20)
        Me.txtHoraI.TabIndex = 1
        '
        'txtCur
        '
        Me.txtCur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCur.Location = New System.Drawing.Point(207, 34)
        Me.txtCur.Name = "txtCur"
        Me.txtCur.Size = New System.Drawing.Size(273, 20)
        Me.txtCur.TabIndex = 1
        '
        'txtDia
        '
        Me.txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDia.Location = New System.Drawing.Point(67, 71)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(216, 20)
        Me.txtDia.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(964, 396)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'btnImprmir
        '
        Me.btnImprmir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprmir.Location = New System.Drawing.Point(482, 754)
        Me.btnImprmir.Name = "btnImprmir"
        Me.btnImprmir.Size = New System.Drawing.Size(102, 36)
        Me.btnImprmir.TabIndex = 64
        Me.btnImprmir.Text = "IMPRIMIR"
        Me.btnImprmir.UseVisualStyleBackColor = True
        '
        'DetalleContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 750)
        Me.Controls.Add(Me.btnImprmir)
        Me.Controls.Add(Me.btnPag2)
        Me.Controls.Add(Me.lblDomi)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.lblNCont)
        Me.Controls.Add(Me.lblNContT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "DetalleContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleContrato"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnPag2 As System.Windows.Forms.Button
    Friend WithEvents lblDomi As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents lblNCont As System.Windows.Forms.Label
    Friend WithEvents lblNContT As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuitC As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreR As System.Windows.Forms.TextBox
    Friend WithEvents txtDomi As System.Windows.Forms.TextBox
    Friend WithEvents txtComp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHorarioF As System.Windows.Forms.TextBox
    Friend WithEvents txtTiempo As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraI As System.Windows.Forms.TextBox
    Friend WithEvents txtCur As System.Windows.Forms.TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnImprmir As System.Windows.Forms.Button
End Class
