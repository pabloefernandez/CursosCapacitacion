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

    End Sub
End Class