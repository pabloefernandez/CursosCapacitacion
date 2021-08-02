Public Class contratos

    Dim datetimevar As String
    Dim id As Integer
    Dim maxid As Integer
    Dim curso As Integer
    Dim idcomp As Integer
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        cont_comp = True
        Sql = "select count(*) from cursos where curso='" & txtNombreC.Text & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            lblCursoE.Visible = True
            txtNombreC.Enabled = False
            btnBuscar.Enabled = False
            btnComp.Enabled = True
            Sql = "select count(*) from ediciones e, cursos c where c.idcurso=e.idcurso and curso='" & txtNombreC.Text & "' and idcapacitador is not null"
            Procedure()
            RS.Read()
            If RS(0) >= 1 Then
                E_Edicion.Show()
                Me.Hide()
                txtNombreComp.Enabled = True
            Else
                Rta = MsgBox("El curso [" & txtNombreC.Text & "] no tiene capacitadores asignados . ¿Desea ingresar a la lista de espera?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    Sql = "select curdate(), curtime()"
                    Procedure()
                    RS.Read()
                    datetimevar = Format(RS(0), "dd/MM/yyyy") & " " & RS(1).ToString
                    rta2 = InputBox("Ingrese nombre de la compañia")
                    Sql = "insert into listaespera values ('','" & rta2 & "','" & txtNombreC.Text & "', '" & datetimevar & "',null)"
                    Procedure()
                    MsgBox("La compania [" & txtNombreComp.Text & "] ha sido agregada CORRECTAMENTE a la lista de espera.")
                    MsgBox("Usted sera devuelto al menu principal.")
                    cont_comp = False
                    Menu1.Show()
                    Me.Close()
                Else
                    MsgBox("Usted sera devuelto al menu principal.")
                    cont_comp = False
                    'txtNombreComp.Enabled = False
                    'btnComp.Enabled = False
                    Menu1.Show()
                    Me.Close()
                End If
            End If
        Else
            Rta = 0
            Rta = MsgBox("El curso [" & txtNombreC.Text & "] no existe. ¿Desea ingresar a la lista de espera?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
            If Rta = 6 Then
                Sql = "select curdate(), curtime()"
                Procedure()
                RS.Read()
                datetimevar = Format(RS(0), "dd/MM/yyyy") & " " & RS(1).ToString
                rta2 = InputBox("Ingrese nombre de la compañia")
                'Sql = "select count(*) from companias where nombre='" & rta2 & "'"
                'Procedure()
                'RS.Read()
                'If RS(0) = 1 Then
                Sql = "insert into listaespera values ('','" & rta2 & "','" & txtNombreC.Text & "', '" & datetimevar & "',null)"
                Procedure()
                Rta = MsgBox("La compania [" & txtNombreComp.Text & "] ha sido agregada CORRECTAMENTE a la lista de espera.")
                Menu1.Show()
                Me.Close()
            Else
                Menu1.Show()
                Me.Hide()
            End If
        End If


    End Sub

    Private Sub contratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombreComp.Focus()
        txtNombreComp.Enabled = False
        txtEmp.Enabled = False
        txtNombreC.Focus()
        btnComp.Enabled = False
        btnSiguiente.Enabled = False
    End Sub

    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        Sql = "select count(*) from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            Sql = "select count(*) from prerreq,cursos where idcurso=idcur and curso='" & txtNombreC.Text & "' and obligatorio=1"
            Procedure()
            RS.Read()
            MsgBox(Sql)
            If RS(0) >= 1 Then
                Sql = "SELECT COUNT(*) FROM CONTRATOS C,COMPANIAS CO WHERE C.IDCOMP=CO.IDCOMP AND NOMBRE='" & txtNombreComp.Text & "' AND IDEDICION IN(SELECT IDEDICION FROM EDICIONES WHERE IDCURSO IN (SELECT idreq FROM EDICIONES E,CURSOS C,prerreq WHERE idcur=c.idcurso and E.IDCURSO=C.IDCURSO AND CURSO='" & txtNombreC.Text & "' and obligatorio=1))"
                Procedure()
                RS.Read()
                If RS(0) >= 1 Then
                    txtEmp.Text = True
                    txtNombreComp.Text = False
                    y = True
                    MsgBox("PETE ")
                Else
                    MsgBox("Solicitud de contrato rechaza.El curso que quiere contratar tiene requisitos obligatorios")
                    Requisitos.Show()
                End If
            Else
                MsgBox("PETE2")
                txtEmp.Enabled = True
                txtNombreComp.Text = False
                Sql = "select*from companias where nombre='" & txtNombreComp.Text & "'"
                Procedure()
                RS.Read()
                gbxDatos.Visible = True
                txtNCompania.Text = RS(1)
                txtDireccion.Text = RS(2)
                txtTel.Text = RS(3)
                txtCuit.Text = RS(4)
                txtRepres.Text = RS(5)
                txtApe.Text = RS(6)
                txtEmail.Text = RS(7)
                btnComp.Enabled = False
            End If
          
        Else
            Sql = "select count(*) from prerreq,cursos where idcurso=idcur and curso='" & txtNombreC.Text & "' and obligatorio=1"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Rta = MsgBox("Solicitud de contrato rechazada..El curso que quiere contratar tiene requisitos obligatorios.¿Desea verlos? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    Requisitos.Show()
                    Me.Hide()
                Else
                    MsgBox("Solicitud de contrato rechazada.Usted sera devuelto al menu principal")
                    Menu1.Show()
                    Me.Hide()
                End If
            End If
            MsgBox("La compañia no existe. Ingresela en la siguiente pantalla.", MsgBoxStyle.Information)
            A_Compania.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Sql = "select count(*) from cursos where " & txtEmp.Text & ">=6 and cupo>=" & txtEmp.Text & " and curso='" & txtNombreC.Text & "'"
        Procedure()
        RS.Read()
        If txtEmp.Text <> "" And RS(0) = 1 Then
            EmpCont.Show()
            Me.Hide()
        Else
            MsgBox("Agregar descripcion xd ")
        End If
    End Sub

    Private Sub btnTick1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick1.Click
        Sql = "select idcomp from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Nombre='" & txtNCompania.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        txtNCompania.Text = txtNombreComp.Text
        btnTick1.Enabled = False
        txtNCompania.Enabled = False
    End Sub

    Private Sub btnTick2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick2.Click
        Sql = "select idcomp from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Direccion='" & txtDireccion.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick2.Enabled = False
        txtDireccion.Enabled = False
    End Sub

    Private Sub btnTick3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick3.Click
        Sql = "select idcomp from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Telefono='" & txtTel.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick3.Enabled = False
        txtTel.Enabled = False
    End Sub

    Private Sub btnTick4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick4.Click
        Sql = "select idcomp from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set CUIT=" & txtCuit.Text & " where idcomp=" & idcomp & ""
        Procedure()
        btnTick4.Enabled = False
        txtNCompania.Enabled = False
    End Sub

    Private Sub btnTick5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick5.Click
        Sql = "select idcomp from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Representante_N='" & txtRepres.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick5.Enabled = False
        txtRepres.Enabled = False
    End Sub

    Private Sub btnTick6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick6.Click
        Sql = "select idcomp from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Representante_Ap='" & txtApe.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick6.Enabled = False
        txtApe.Enabled = False
    End Sub

    Private Sub btnTick7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick7.Click
        Sql = "select idcomp from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Email='" & txtEmail.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick7.Enabled = False
        txtEmail.Enabled = False
    End Sub

    Private Sub txtNombreC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreC.TextChanged
        btnBuscar.Enabled = True
    End Sub

    Private Sub txtNombreComp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreComp.TextChanged
        btnComp.Enabled = True
    End Sub
End Class