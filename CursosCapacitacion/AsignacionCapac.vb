Public Class AsignacionCapac
    Dim P As Integer
    Private Sub lstCapac_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs)
        e.Cancel = True
        e.NewWidth = lstCapac.Columns(e.ColumnIndex).Width
    End Sub
    Private Sub AsignacionCapac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAsignar.Enabled = False
        Sql = "SELECT IDEDICION,NOMBRE,APELLIDO,TELEFONO,H.IDHORARIO FROM HCAPACITADORES H,EDICIONES E,capacitadores C,PERSONAS P where H.DIA=E.DIA AND H.IDCAPACITADOR=C.IDCAPACITADOR AND P.IDPERSONA=C.IDPERSONA AND INICIO<=HORARIO_I AND FINAL>=HORARIO_F AND E.IDHORARIO IS NULL AND H.IDCAPACITADOR IN (SELECT IDCAPACITADOR FROM TITULOS T,CURSOS C,TITULOS_CAPAC TC WHERE T.IDTITULO=TC.IDTITULO AND T.IDAREA=C.IDAREA AND IDCURSO IN (SELECT IDCURSO FROM EDICIONES WHERE IDHORARIO IS NULL))"
        Procedure()
        While RS.Read
            lstCapac.Items.Add(RS(0))
            lstCapac.Items(P).SubItems.Add(RS(1).ToString)
            lstCapac.Items(P).SubItems.Add(RS(2).ToString)
            lstCapac.Items(P).SubItems.Add(RS(3).ToString)
            lstCapac.Items(P).SubItems.Add(RS(4).ToString)
            P = P + 1
        End While
    End Sub
    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Sql = "UPDATE EDICIONES SET IDHORARIO=" & lstCapac.SelectedItems(0).SubItems(4).Text & " WHERE IDEDICION=" & lstCapac.FocusedItem.Text & ""
        Procedure()
        Rta = MsgBox("El capacitador fue asignado correctamente a la edicion." + vbCrLf + " Desea asignar otro capacitador?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            P = 0
            lstCapac.Items.Clear()
            Sql = "SELECT IDEDICION,NOMBRE,APELLIDO,TELEFONO,H.IDHORARIO FROM HCAPACITADORES H,EDICIONES E,capacitadores C,PERSONAS P where H.DIA=E.DIA AND H.IDCAPACITADOR=C.IDCAPACITADOR AND P.IDPERSONA=C.IDPERSONA AND INICIO<=HORARIO_I AND FINAL>=HORARIO_F AND E.IDHORARIO IS NULL AND H.IDCAPACITADOR IN (SELECT IDCAPACITADOR FROM TITULOS T,CURSOS C,TITULOS_CAPAC TC WHERE T.IDTITULO=TC.IDTITULO AND T.IDAREA=C.IDAREA AND IDCURSO IN (SELECT IDCURSO FROM EDICIONES WHERE IDHORARIO IS NULL))"
            Procedure()
            While RS.Read
                lstCapac.Items.Add(RS(0))
                lstCapac.Items(P).SubItems.Add(RS(1).ToString)
                lstCapac.Items(P).SubItems.Add(RS(2).ToString)
                lstCapac.Items(P).SubItems.Add(RS(3).ToString)
                lstCapac.Items(P).SubItems.Add(RS(4).ToString)
                P = P + 1
            End While
            btnAsignar.Enabled = False
        Else
            MenuAdministracion.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lstCapac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCapac.SelectedIndexChanged
        btnAsignar.Enabled = True
    End Sub
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuAdministracion.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Rta = MsgBox(" Desea salir del programa? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        End If
    End Sub
End Class