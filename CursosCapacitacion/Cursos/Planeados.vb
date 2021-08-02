Public Class Planeados

    Private Sub btnSalir3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir3.Click
        Rta = MsgBox("Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        OpcCursos.Show()
        Me.Hide()

    End Sub

    Private Sub Planeados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select distinct Curso from cursos c, ediciones e where c.idcurso=e.idcurso and idedicion not in(select idedicion from contratos)"
        Procedure()
        While RS.Read = True
            lstEspera.Items.Add(RS(0))
        End While
    End Sub
End Class