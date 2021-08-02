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
            Sql = "select count(*) from ediciones e, cursos c where c.idcurso=e.idcurso and curso='" & txtNombreC.Text & "' and idhorario is not null"
            Procedure()
            RS.Read()
            If RS(0) >= 1 Then
                E_Edicion.Show()
                Me.Hide()
                txtNombreComp.Enabled = True
            Else
                MsgBox("El curso [" & txtNombreC.Text & "] no tiene ediciones con capacitadores asignados." + vbCrLf + "Solicitud de contrato rechazada." + vbCrLf + "Sera devuelto al menu principal ", MsgBoxStyle.Exclamation)
                cont_comp = False
                MenuAdministracion.Show()
                Me.Close()
            End If
        Else
            Rta = MsgBox("El curso [" & txtNombreC.Text & "] no existe." + vbCrLf + "Desea ingresar el curso nuevamente?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
            If Rta = 6 Then
                txtNombreC.Clear()
                txtNombreC.Focus()
            Else
                MsgBox("Solicitud de contrato rechazada." + vbCrLf + "Sera devuelto al menu principal ", MsgBoxStyle.Exclamation)
                MenuAdministracion.Show()
                Me.Close()
            End If

        End If
    End Sub

    Private Sub contratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombreComp.Enabled = False
        btnBuscar.Enabled = False
        txtEmp.Enabled = False
        btnComp.Enabled = False
        btnSiguiente.Enabled = False
        txtNombreC.Focus()
        txtNombreComp.Focus()
    End Sub

    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        Sql = "select count(*) from companias where nombre='" & txtNombreComp.Text & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            Sql = "select count(*) from prerreq,cursos where idcurso=idcur and curso='" & txtNombreC.Text & "' and obligatorio='Obligatorio'"
            Procedure()
            RS.Read()
            If RS(0) >= 1 Then
                'BUSCA SI LA COMPAÑIA DIO ALGUNA EDICION DEL CURSO REQUISITO
                Sql = "SELECT COUNT(*) FROM CONTRATOS C,COMPANIAS CO WHERE C.IDCOMP=CO.IDCOMP AND NOMBRE='" & txtNombreComp.Text & "' AND IDEDICION IN(SELECT IDEDICION FROM EDICIONES WHERE IDCURSO IN (SELECT idreq FROM EDICIONES E,CURSOS C,prerreq WHERE idcur=c.idcurso and E.IDCURSO=C.IDCURSO AND CURSO='" & txtNombreC.Text & "' and obligatorio=1))"
                Procedure()
                RS.Read()
                If RS(0) >= 1 Then
                    'CUMPLE REQ
                    txtEmp.Enabled = True
                    txtNombreComp.Enabled = False
                    y = True
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
                    txtNombreComp.Enabled = False
                    btnSiguiente.Enabled = True
                Else
                    'NO CUMPLE REQ
                    MsgBox("Solicitud de contrato rechazada." + vbCrLf + "El curso que quiere contratar tiene requisitos obligatorios", MsgBoxStyle.Exclamation)
                    Requisitos.Show()
                    Me.Close()
                End If
            Else
                txtEmp.Enabled = True
                txtNombreComp.Enabled = False
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
                txtNombreComp.Enabled = False
                btnSiguiente.Enabled = True
            End If
        Else
            Sql = "select count(*) from prerreq,cursos where idcurso=idcur and curso='" & txtNombreC.Text & "' and obligatorio=1"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Rta = MsgBox("Solicitud de contrato rechazada." + vbCrLf + "El curso que quiere contratar tiene requisitos obligatorios.¿Desea verlos? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    Requisitos.Show()
                    Me.Hide()
                Else
                    MsgBox("Solicitud de contrato rechazada." + vbCrLf + "Usted sera devuelto al menu principal", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
                    MenuAdministracion.Show()
                    Me.Close()
                End If
            End If
            Rta = MsgBox("La compañia no existe." + vbCrLf + "Desea registrarla?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel)
            If Rta = 6 Then
                A_Compania.Show()
                Me.Hide()
            ElseIf Rta = 7 Then
                MsgBox("Solicitud de contrato rechaza." + vbCrLf + "Sera devuelto al menu principal", MsgBoxStyle.Information)
                MenuAdministracion.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Rta = MsgBox("Esta seguro que quiere ingresar esos datos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Sql = "SELECT COUNT(*) FROM CURSOS WHERE cupo>=" & txtEmp.Text & " and curso='" & txtNombreC.Text & "'"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Sql = "select count(*) from cursos where " & txtEmp.Text & ">=6 and curso='" & txtNombreC.Text & "'"
                Procedure()
                RS.Read()
                If RS(0) = 1 Then
                    EmpCont.Show()
                    Me.Hide()
                Else
                    MsgBox("Solicitud de contrato rechazada." + vbCrLf + "La cantidad de empleados debe ser mayor a 6(seis)." + vbCrLf + "Sera devuelto al menu principal", MsgBoxStyle.Information)
                    MenuAdministracion.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Solicitud de contrato rechazada." + vbCrLf + "No hay cupo para esa cantidad de gente." + vbCrLf + "Sera devuelto al menu principal ", MsgBoxStyle.Information)
                MenuAdministracion.Show()
                Me.Close()
            End If
        Else
            txtEmp.Focus()
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