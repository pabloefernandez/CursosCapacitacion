<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAAreas = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnACursos = New System.Windows.Forms.Button()
        Me.btnACapacitadores = New System.Windows.Forms.Button()
        Me.btnMCapacitadores = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAHCapacitadores = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAEdiciones = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnATitulos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCompMod = New System.Windows.Forms.Button()
        Me.btnCompAlt = New System.Windows.Forms.Button()
        Me.grpCompanias = New System.Windows.Forms.GroupBox()
        Me.btnSalir1 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnARequisitos = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpCompanias.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAAreas)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 49)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Areas"
        '
        'btnAAreas
        '
        Me.btnAAreas.Location = New System.Drawing.Point(7, 20)
        Me.btnAAreas.Name = "btnAAreas"
        Me.btnAAreas.Size = New System.Drawing.Size(278, 23)
        Me.btnAAreas.TabIndex = 0
        Me.btnAAreas.Text = "Altas"
        Me.btnAAreas.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnACursos)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(322, 59)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(292, 49)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cursos"
        '
        'btnACursos
        '
        Me.btnACursos.Location = New System.Drawing.Point(7, 20)
        Me.btnACursos.Name = "btnACursos"
        Me.btnACursos.Size = New System.Drawing.Size(279, 23)
        Me.btnACursos.TabIndex = 0
        Me.btnACursos.Text = "Altas"
        Me.btnACursos.UseVisualStyleBackColor = True
        '
        'btnACapacitadores
        '
        Me.btnACapacitadores.Location = New System.Drawing.Point(5, 21)
        Me.btnACapacitadores.Name = "btnACapacitadores"
        Me.btnACapacitadores.Size = New System.Drawing.Size(141, 23)
        Me.btnACapacitadores.TabIndex = 0
        Me.btnACapacitadores.Text = "Altas"
        Me.btnACapacitadores.UseVisualStyleBackColor = True
        '
        'btnMCapacitadores
        '
        Me.btnMCapacitadores.Location = New System.Drawing.Point(152, 21)
        Me.btnMCapacitadores.Name = "btnMCapacitadores"
        Me.btnMCapacitadores.Size = New System.Drawing.Size(134, 23)
        Me.btnMCapacitadores.TabIndex = 0
        Me.btnMCapacitadores.Text = "Modificaciones"
        Me.btnMCapacitadores.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnMCapacitadores)
        Me.GroupBox7.Controls.Add(Me.btnACapacitadores)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(322, 114)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(292, 49)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Capacitadores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAHCapacitadores)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(322, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 49)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario de los Capacitadores"
        '
        'btnAHCapacitadores
        '
        Me.btnAHCapacitadores.Location = New System.Drawing.Point(7, 20)
        Me.btnAHCapacitadores.Name = "btnAHCapacitadores"
        Me.btnAHCapacitadores.Size = New System.Drawing.Size(279, 23)
        Me.btnAHCapacitadores.TabIndex = 0
        Me.btnAHCapacitadores.Text = "Altas"
        Me.btnAHCapacitadores.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAEdiciones)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 49)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ediciones de los Cursos"
        '
        'btnAEdiciones
        '
        Me.btnAEdiciones.Location = New System.Drawing.Point(7, 20)
        Me.btnAEdiciones.Name = "btnAEdiciones"
        Me.btnAEdiciones.Size = New System.Drawing.Size(278, 23)
        Me.btnAEdiciones.TabIndex = 0
        Me.btnAEdiciones.Text = "Altas"
        Me.btnAEdiciones.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnATitulos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(292, 49)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Titulos"
        '
        'btnATitulos
        '
        Me.btnATitulos.Location = New System.Drawing.Point(7, 20)
        Me.btnATitulos.Name = "btnATitulos"
        Me.btnATitulos.Size = New System.Drawing.Size(279, 23)
        Me.btnATitulos.TabIndex = 0
        Me.btnATitulos.Text = "Altas"
        Me.btnATitulos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ABM Tablas"
        '
        'btnCompMod
        '
        Me.btnCompMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompMod.Location = New System.Drawing.Point(144, 16)
        Me.btnCompMod.Name = "btnCompMod"
        Me.btnCompMod.Size = New System.Drawing.Size(133, 23)
        Me.btnCompMod.TabIndex = 0
        Me.btnCompMod.Text = "Modificaciones"
        Me.btnCompMod.UseVisualStyleBackColor = True
        '
        'btnCompAlt
        '
        Me.btnCompAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompAlt.Location = New System.Drawing.Point(7, 16)
        Me.btnCompAlt.Name = "btnCompAlt"
        Me.btnCompAlt.Size = New System.Drawing.Size(131, 23)
        Me.btnCompAlt.TabIndex = 0
        Me.btnCompAlt.Text = "Altas"
        Me.btnCompAlt.UseVisualStyleBackColor = True
        '
        'grpCompanias
        '
        Me.grpCompanias.Controls.Add(Me.btnCompMod)
        Me.grpCompanias.Controls.Add(Me.btnCompAlt)
        Me.grpCompanias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCompanias.Location = New System.Drawing.Point(13, 224)
        Me.grpCompanias.Name = "grpCompanias"
        Me.grpCompanias.Size = New System.Drawing.Size(291, 45)
        Me.grpCompanias.TabIndex = 7
        Me.grpCompanias.TabStop = False
        Me.grpCompanias.Text = "Compañias"
        '
        'btnSalir1
        '
        Me.btnSalir1.Location = New System.Drawing.Point(520, 9)
        Me.btnSalir1.Name = "btnSalir1"
        Me.btnSalir1.Size = New System.Drawing.Size(98, 23)
        Me.btnSalir1.TabIndex = 16
        Me.btnSalir1.Text = "Salir"
        Me.btnSalir1.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 9)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(98, 23)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnARequisitos)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(323, 224)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(291, 45)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Requisitos"
        '
        'btnARequisitos
        '
        Me.btnARequisitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnARequisitos.Location = New System.Drawing.Point(7, 16)
        Me.btnARequisitos.Name = "btnARequisitos"
        Me.btnARequisitos.Size = New System.Drawing.Size(278, 23)
        Me.btnARequisitos.TabIndex = 0
        Me.btnARequisitos.Text = "Altas"
        Me.btnARequisitos.UseVisualStyleBackColor = True
        '
        'ABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 373)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir1)
        Me.Controls.Add(Me.grpCompanias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ABM"
        Me.Text = "ABM Tablas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.grpCompanias.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAAreas As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnACursos As System.Windows.Forms.Button
    Friend WithEvents btnACapacitadores As System.Windows.Forms.Button
    Friend WithEvents btnMCapacitadores As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAHCapacitadores As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAEdiciones As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnATitulos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCompMod As System.Windows.Forms.Button
    Friend WithEvents btnCompAlt As System.Windows.Forms.Button
    Friend WithEvents grpCompanias As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir1 As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnARequisitos As System.Windows.Forms.Button
End Class
