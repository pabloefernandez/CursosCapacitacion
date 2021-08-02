﻿Public Class Contratados

    Private Sub btnSalir3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir3.Click
        Rta = MsgBox("Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        OpcCursos.Show()
        Me.Close()
    End Sub

    Private Sub Contratados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select distinct curso from cursos c, contratos cr, ediciones e where c.idcurso=e.idcurso and e.idedicion=cr.idedicion;"
        Procedure()
        While RS.Read = True
            lstContratados.Items.Add(RS(0))
        End While
    End Sub
End Class