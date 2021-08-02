Imports System.Data.Odbc
Public Class Requisitos
    Private Sub btnSalir3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir3.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        If Prerrequisitos = True And cont_comp = False Then
            Prerreq.Show()
            Me.Close()
        ElseIf Prerrequisitos2 = True And cont_comp = False Then
            Prerreq.Show()
            Me.Close()
        End If
        If cont_comp = False Then
            OpcCursos.Show()
            Me.Close()
        End If
        If cont_comp = True Then
            MenuAdministracion.Show()
            Me.Close()
            'Else
            'OpcCursos.Show()
            ' Me.Close()
        End If
    End Sub

    Private Sub Requisitos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select curso from cursos, prerreq where idcur=idcurso"
        Procedure()
        While RS.Read
            lstCurso.Items.Add(RS(0))
        End While
        Sql = "select curso from cursos, prerreq where idreq=idcurso"
        Procedure()
        While RS.Read
            lstRequisito.Items.Add(RS(0))
        End While
        Sql = "select obligatorio from prerreq"
        Procedure()
        While RS.Read
            lstObligatorio.Items.Add(RS(0))
        End While
    End Sub
End Class