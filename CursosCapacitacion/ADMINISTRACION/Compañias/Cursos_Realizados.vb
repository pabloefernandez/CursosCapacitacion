Public Class Cursos_Realizados

    Private Sub btnSalir4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir4.Click
        Rta = MsgBox("¿Desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        lstCursos.Items.Clear()
        txtNComp.Text = ""
        btnLimpiar.Enabled = False
        btnTick.Enabled = False
        txtNComp.Enabled = True
        OpcCompanias.Show()
        Me.Close()
    End Sub

    Private Sub txtNComp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNComp.TextChanged
        btnTick.Enabled = True
        btnLimpiar.Enabled = True
    End Sub

    Private Sub btnTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick.Click
        Sql = "select count(*) from companias where nombre='" & txtNComp.Text & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            btnTick.Enabled = False
            txtNComp.Enabled = False
            Sql = "select distinct Curso from cursos c, contratos co, companias comp, ediciones e where e.idcurso=c.idcurso and comp.idcomp=co.idcomp and e.idedicion=co.idedicion and comp.nombre='" & txtNComp.Text & "'"
            Procedure()
            While RS.Read
                lstCursos.Items.Add(RS(0))
            End While

        Else
            MsgBox("No se encontro la compania. Ingrese el nombre nuevamente.")
            txtNComp.Text = ""
            btnTick.Enabled = False
            btnLimpiar.Enabled = False
            txtNComp.Focus()
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        lstCursos.Items.Clear()
        txtNComp.Text = ""
        btnLimpiar.Enabled = False
        btnTick.Enabled = False
        txtNComp.Enabled = True
    End Sub
End Class