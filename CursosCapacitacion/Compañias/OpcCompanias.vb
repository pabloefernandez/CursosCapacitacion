Public Class OpcCompanias

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Menu1.Show()
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
End Class