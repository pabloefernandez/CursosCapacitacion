Public Class Evaluaciones
    Dim indice As Integer
    Dim indice2 As Integer
    Dim contrato As Integer
    Dim curso As Integer
    Dim puntajecur As Integer
    Dim idcont As Integer
    Dim idemp As Integer
    Private Sub Evaluaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSeleccionar.Enabled = False
        btnAprobados.Enabled = False
        btnDesaprobados.Enabled = False
        lstAprobados.Enabled = False
        lstDesaprobados.Enabled = False
        Sql = "select e.idedicion, Curso, Horario_I, Horario_F, Dia, idcontrato from ediciones e, capacitadores c, personas p, cursos cur, contratos cont where cur.idcurso=e.idcurso and c.idcapacitador=e.idcapacitador and p.idpersona=c.idpersona and cont.idedicion=e.idedicion and dni=" & dnieval & " and e.idedicion in(select idedicion from contratos where curdate() between FechaInicio and FechaFin) and cont.idcontrato not in(select idcontrato from ConstCargaEval)"
        Procedure()
        While RS.Read
            lstCursos.Items.Add(RS(0))
            lstCursos.Items(indice).SubItems.Add(RS(1).ToString)
            lstCursos.Items(indice).SubItems.Add(RS(2).ToString)
            lstCursos.Items(indice).SubItems.Add(RS(3).ToString)
            lstCursos.Items(indice).SubItems.Add(RS(4).ToString)
            lstCursos.Items(indice).SubItems.Add(RS(5).ToString)
            indice = indice + 1
        End While
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        lstCursos.Enabled = False
        btnSeleccionar.Enabled = False
        Sql = "select idcurso from cursos where curso='" & lstCursos.SelectedItems(0).SubItems(1).Text & "'"
        Procedure()
        RS.Read()
        curso = RS(0)
        Sql = "select idcontrato from contratos where idcontrato=" & lstCursos.SelectedItems(0).SubItems(5).Text & ""
        Procedure()
        RS.Read()
        idcont = RS(0)
        Sql = "select Nombre, Apellido, Dni from personas p, empleadoscomp ecomp, empleadoscont econt where p.idpersona=ecomp.idpersona and ecomp.idempleado=econt.idempleado and idcontrato=" & RS(0) & ""
        Procedure()
        While RS.Read
            lstAprobados.Items.Add(RS(0))
            lstAprobados.Items(indice2).SubItems.Add(RS(1).ToString)
            lstAprobados.Items(indice2).SubItems.Add(RS(2).ToString)
            indice2 = indice2 + 1
        End While
        lstAprobados.Enabled = True
        lstDesaprobados.Enabled = True
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAprobados.SelectedIndexChanged
        btnAprobados.Enabled = False
        btnDesaprobados.Enabled = True
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDesaprobados.SelectedIndexChanged
        btnDesaprobados.Enabled = False
        btnAprobados.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Rta = MsgBox("¿Esta seguro que desea cargar los resultados?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            If lstAprobados.Items.Count <> 0 Then
                For Each Item In lstAprobados.Items
                    Sql = "select puntajecur from cursos where idcurso=" & curso & ""
                    Procedure()
                    RS.Read()
                    puntajecur = RS(0)
                    Sql = "select idempleado from empleadoscomp ec, personas p where p.idpersona=ec.idpersona and dni=" & Item.SubItems(2).Text & ""
                    Procedure()
                    RS.Read()
                    idemp = RS(0)
                    Sql = "insert into resultadoseval values(" & RS(0) & ", " & curso & ", 'aprobado')"
                    Procedure()
                    Sql = "update empleadoscomp set puntaje=puntaje+" & puntajecur & " where idempleado=" & idemp & ""
                    Procedure()
                Next Item
            End If
            If lstDesaprobados.Items.Count <> 0 Then
                For Each Item In lstDesaprobados.Items
                    Sql = "select puntajecur from cursos where idcurso=" & curso & ""
                    Procedure()
                    RS.Read()
                    puntajecur = RS(0)
                    Sql = "select idempleado from empleadoscomp ec, personas p where p.idpersona=ec.idpersona and dni=" & Item.SubItems(2).Text & ""
                    Procedure()
                    RS.Read()
                    idemp = RS(0)
                    Sql = "insert into resultadoseval values(" & RS(0) & ", " & curso & ", 'desaprobado')"
                    Procedure()
                    Sql = "update empleadoscomp set puntaje=puntaje+" & puntajecur & " where idempleado=" & idemp & ""
                    Procedure()
                Next Item
            End If
        Else

        End If
        Sql = "insert into constcargaeval values('', " & idcont & ", curdate())"
        Procedure()
        MsgBox("Los resultados de las evaluaciones han sido cargados." + vbCrLf + "Usted sera devuelto al menu principal.")
        MenuCapacitadores.Show()
        Me.Close()
    End Sub

    Private Sub lstCursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCursos.SelectedIndexChanged
        btnSeleccionar.Enabled = True
    End Sub

    Private Sub btnDesaprobados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesaprobados.Click
        For Each si As ListViewItem In lstAprobados.SelectedItems
            lstDesaprobados.Items.Add(DirectCast(si.Clone(), ListViewItem))
            si.Remove()
        Next
    End Sub

    Private Sub btnAprobados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobados.Click
        For Each si As ListViewItem In lstDesaprobados.SelectedItems
            lstAprobados.Items.Add(DirectCast(si.Clone(), ListViewItem))
            si.Remove()
        Next
    End Sub
End Class