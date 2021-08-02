Imports System.Data.Odbc
Public Class Menu1
    Dim Rta As Integer
    Private Sub Menu1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Private Sub btnSalir1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir1.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursos.Click
        OpcCursos.Show()
        Me.Hide()
    End Sub

    Private Sub btnContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContratos.Click
        contratos.Show()
        Me.Hide()
    End Sub

    Private Sub btnABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnABM.Click
        ABM.Show()
        Me.Hide()
    End Sub

    Private Sub btnCapacitadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapacitadores.Click
        OpcCapacitadores.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpcCompanias.Show()
        Me.Hide()
    End Sub
End Class
