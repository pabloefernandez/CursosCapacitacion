<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleContrato2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleContrato2))
        Me.lstDatos = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dni = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtC2 = New System.Windows.Forms.TextBox()
        Me.txtC1 = New System.Windows.Forms.TextBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnImprmir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstDatos
        '
        Me.lstDatos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Apellido, Me.dni})
        Me.lstDatos.Location = New System.Drawing.Point(7, 53)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(686, 369)
        Me.lstDatos.TabIndex = 56
        Me.lstDatos.UseCompatibleStateImageBehavior = False
        Me.lstDatos.View = System.Windows.Forms.View.Details
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 197
        '
        'Apellido
        '
        Me.Apellido.Text = "Apellido"
        Me.Apellido.Width = 154
        '
        'dni
        '
        Me.dni.Text = "DNI"
        Me.dni.Width = 170
        '
        'txtFormaPago
        '
        Me.txtFormaPago.Location = New System.Drawing.Point(146, 150)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(147, 20)
        Me.txtFormaPago.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Forma de pago:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(82, 33)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(147, 20)
        Me.txtPrecio.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Costo:"
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.txtC2)
        Me.gbxDatos.Controls.Add(Me.txtC1)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtPrecio)
        Me.gbxDatos.Controls.Add(Me.txtFormaPago)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Location = New System.Drawing.Point(130, 443)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(449, 199)
        Me.gbxDatos.TabIndex = 61
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "PRESUPUESTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Cuota Nª1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Cuota Nª2:"
        '
        'txtC2
        '
        Me.txtC2.Location = New System.Drawing.Point(251, 98)
        Me.txtC2.Name = "txtC2"
        Me.txtC2.Size = New System.Drawing.Size(147, 20)
        Me.txtC2.TabIndex = 62
        '
        'txtC1
        '
        Me.txtC1.Location = New System.Drawing.Point(54, 101)
        Me.txtC1.Name = "txtC1"
        Me.txtC1.Size = New System.Drawing.Size(147, 20)
        Me.txtC1.TabIndex = 61
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(238, 668)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(215, 36)
        Me.btnPagar.TabIndex = 62
        Me.btnPagar.Text = "FINALIZAR CONTRATO"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnImprmir
        '
        Me.btnImprmir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprmir.Location = New System.Drawing.Point(591, 668)
        Me.btnImprmir.Name = "btnImprmir"
        Me.btnImprmir.Size = New System.Drawing.Size(102, 36)
        Me.btnImprmir.TabIndex = 63
        Me.btnImprmir.Text = "IMPRIMIR"
        Me.btnImprmir.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(407, 31)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "EMPLEADOS A CAPACITARSE"
        '
        'DetalleContrato2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 716)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnImprmir)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.lstDatos)
        Me.Controls.Add(Me.gbxDatos)
        Me.Name = "DetalleContrato2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleContrato2"
        Me.TopMost = True
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstDatos As System.Windows.Forms.ListView
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Apellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents dni As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtC1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnImprmir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
