Public Class OpcCompanias

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuAdministracion.Show()
        Me.Hide()
    End Sub

    Private Sub btnPuntajeEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPuntajeEmpleados.Click
        PuntajeEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub btnCursosReal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursosReal.Click
        Cursos_Realizados.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir4.Click
        Rta = MsgBox("¿Desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub
End Class