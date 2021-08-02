Public Class OpcCursos

    Private Sub btnSalir4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir4.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnPlaneados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaneados.Click
        Planeados.Show()
        Me.Hide()
    End Sub

    Private Sub btnContratados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContratados.Click
        Contratados.Show()
        Me.Hide()
    End Sub

    Private Sub btnCorrelativos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrelativos.Click
        Correlativos.Show()
        Me.Hide()

    End Sub

    Private Sub btnRequisitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequisitos.Click
        Requisitos.Show()
        Me.Hide()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Menu1.Show()
        Me.Hide()
    End Sub

    Private Sub OpcCursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTrimestre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrimestre.Click
        Semestre.Show()
        Me.Hide()
    End Sub
End Class