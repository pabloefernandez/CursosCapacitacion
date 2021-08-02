Public Class MenuCapacitadores

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        MsgBox("Usted sera devuelto al menu de logueo.")
        MenuInicioSesion.txtUsuario.Text = ""
        MenuInicioSesion.txtContrasenia.Text = ""
        MenuInicioSesion.txtUsuario.Focus()
        MenuInicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnEvaluaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluaciones.Click
        Me.Hide()
        dnieval = InputBox("Ingrese su DNI: ")
        Sql = "select count(*) from ediciones e, capacitadores c, personas p where c.idcapacitador=e.idcapacitador and p.idpersona=c.idpersona and dni=" & dnieval & " and idedicion in(select idedicion from contratos where curdate() between FechaInicio and FechaFin)"
        'faltan validar cosas en la consulta'
        Procedure()
        RS.Read()
        If RS(0) >= 1 Then
            Sql = "select count(*) from ediciones e, capacitadores c, personas p, cursos cur, contratos cont where cur.idcurso=e.idcurso and c.idcapacitador=e.idcapacitador and p.idpersona=c.idpersona and cont.idedicion=e.idedicion and dni=" & dnieval & " and e.idedicion in(select idedicion from contratos where curdate() between FechaInicio and FechaFin) and cont.idcontrato not in(select idcontrato from ConstCargaEval)"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Evaluaciones.Show()
            Else
                MsgBox("Usted no tiene cursos pendientes para cargar evaluaciones. Sera devuelto al menu principal.")
                Me.Show()
            End If
        Else
            MsgBox("Usted no dicta ningun curso en este momento. Sera dirigido al menu principal")
            Me.Show()
        End If
    End Sub

    Private Sub MenuCapacitadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class