Public Class DetalleContrato2
    Dim o As Integer
    Dim k As Integer
    Dim total As Integer
    Dim edi As Integer
    Dim fpago As Integer
    Dim ffinal As Date
    Private Sub DetalleContrato2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtC1.Enabled = False
        txtC2.Enabled = False
        txtFormaPago.Enabled = False
        txtPrecio.Enabled = False
        lstDatos.Enabled = False
        For Each item In EmpCont.lstDatos.Items
            lstDatos.Items.Add(item.text)
            lstDatos.Items(o).SubItems.Add(item.Subitems(1).text)
            lstDatos.Items(o).SubItems.Add(item.Subitems(2).text)
            o += 1
        Next item
        Sql = "select costocur from cursos where curso='" & contratos.txtNombreC.Text & "'"
        Procedure()
        RS.Read()
        total = RS(0) * i
        txtPrecio.Text = "$ " & total
        txtC1.Text = total / 2
        txtC2.Text = total / 2
        txtFormaPago.Text = Tipo_Pago.cboTipo.Text
    End Sub

    Private Sub btnImprmir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprmir.Click
        PrintForm1.Print()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Sql = "select idedicion from ediciones e, cursos c where c.idcurso=e.idcurso and curso='" & contratos.txtNombreC.Text & "' and horario_i='" & contratos.txtInicio.Text & "' and horario_f='" & contratos.txtFinal.Text & "' and dia='" & contratos.txtDia.Text & "'"
        Procedure()
        RS.Read()
        edi = RS(0)
        Sql = "select idfpago from formaspago where descripcion='" & Tipo_Pago.cboTipo.Text & "'"
        Procedure()
        RS.Read()
        fpago = RS(0)
        Sql = "select date_add(curdate(), interval " & DetalleContrato.txtTiempo.Text & " day)"
        Procedure()
        RS.Read()
        ffinal = RS(0)
        Sql = "insert into contratos values(" & MAX & ", " & comp & ", " & edi & ", " & fpago & ", curdate(), '" & Format(ffinal, "yyyy/MM/dd") & "', " & txtC1.Text & ", " & txtC2.Text & ")"
        Procedure()
        For Each Item In lstDatos.Items
            Sql = "select idempleado from empleadoscomp ec, personas p where p.idpersona=ec.idpersona and dni=" & Item.SubItems(2).Text & ""
            Procedure()
            RS.Read()
            Sql = "insert into empleadoscont values(" & RS(0) & ", " & MAX & ", null)"
            Procedure()
        Next Item
        MsgBox("El contrato ha sido finalizado con exito" + vbCrLf + "El numero de contrato para pagar las cuotas del mismo es [" & MAX & "]" + vbCrLf + "El usuario [companias] y la contraseña [1234comp] le servira para loguearse y poder pagar las cuotas.")
        MsgBox("Sera dirigido al menu principal.")
        contratos.Close()
        E_Edicion.Close()
        EmpCont.Close()
        DetalleContrato.Close()
        Tipo_Pago.Close()
        MenuAdministracion.Show()
        Me.Close()

    End Sub
End Class