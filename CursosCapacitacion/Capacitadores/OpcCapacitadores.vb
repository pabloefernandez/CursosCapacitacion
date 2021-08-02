Imports System.Data.Odbc
Public Class OpcCapacitadores

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Menu1.Show()
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

    Private Sub btnCursosDictados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursosDictados.Click
        CursosDictados.lstCursos.Enabled = False
        CursosDictados.btnTick.Enabled = False
        CursosDictados.btnLimpiar.Enabled = False
        CursosDictados.txtNomApe.Enabled = False
        CursosDictados.txtDni.Focus()
        CursosDictados.Show()
        Me.Hide()
    End Sub

    Private Sub btnPuntajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPuntajes.Click
        PuntajeCapac.Show()
        Me.Hide()
    End Sub
End Class