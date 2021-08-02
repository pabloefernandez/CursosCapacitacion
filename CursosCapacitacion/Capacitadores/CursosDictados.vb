Public Class CursosDictados

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        lstCursos.Items.Clear()
        txtNomApe.Text = ""
        txtDni.Text = ""
        btnLimpiar.Enabled = False
        btnTick.Enabled = False
        txtDni.Enabled = True
        OpcCapacitadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir4.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub txtDni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDni.TextChanged
        btnTick.Enabled = True
        btnLimpiar.Enabled = True
    End Sub

    Private Sub btnTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick.Click
        Sql = "select count(*) from personas where dni=" & txtDni.Text & ""
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            btnTick.Enabled = False
            txtDni.Enabled = False
            Sql = "select Nombre, Apellido from personas where dni =" & txtDni.Text & ""
            Procedure()
            RS.Read()
            txtNomApe.Text = RS(0) & " " & RS(1)
            Sql = "select curso from cursos c, ediciones e, personas p, capacitadores cap where c.idcurso=e.idcurso and p.idpersona=cap.idpersona and dni= " & txtDni.Text & " and cap.idcapacitador=e.idcapacitador"
            Procedure()
            RS.Read()
            lstCursos.Items.Add(RS(0))
        Else
            MsgBox("No se encontro al capacitador. Ingrese el DNI nuevamente.")
            txtDni.Text = ""
            btnTick.Enabled = False
            btnLimpiar.Enabled = False
            txtDni.Focus()
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        lstCursos.Items.Clear()
        txtNomApe.Text = ""
        txtDni.Text = ""
        btnLimpiar.Enabled = False
        btnTick.Enabled = False
        txtDni.Enabled = True
    End Sub

    Private Sub CursosDictados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class