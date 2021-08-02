Public Class A_Ediciones

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If A_Edicion = True Then
            Sql = "select idcurso from cursos where curso='" & A_Cursos.txtNombre.Text & "'"
            Procedure()
            RS.Read()
            Sql = "insert into ediciones values('', " & RS(0) & ", '" & nudHora1.Value & ":" & nudmm1.Value & "', '" & nudhora2.Value & ":" & nudmm2.Value & "', '" & cboDias.SelectedItem & "', null)"
            Procedure()
            Rta = MsgBox("Edicion ingresada correctamente. ¿Desea ingresar otra?", MsgBoxStyle.YesNoCancel)
            If Rta = 6 Then
                nudHora1.Value = 0
                nudhora2.Value = 0
                nudmm1.Value = 0
                nudmm2.Value = 0

            ElseIf Rta = 7 Then
                Rta = MsgBox("¿Desea ingresar pre-requisitos al curso?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    Prerrequisitos2 = True
                    Prerreq.Show()
                    Me.Hide()
                Else
                    nudHora1.Value = 0
                    nudhora2.Value = 0
                    nudmm1.Value = 0
                    nudmm2.Value = 0
                    A_Edicion = False
                    A_Cursos.txtNombre.Text = ""
                    A_Cursos.txtNivel.Text = ""
                    A_Cursos.txtDuracion.Text = ""
                    A_Cursos.txtPuntaje.Text = ""
                    A_Cursos.txtCosto.Text = ""
                    A_Cursos.txtCupo.Text = ""
                    A_Cursos.cboAreas.Text = ""
                    A_Cursos.chkGerencial.Checked = False
                    MenuAdministracion.Show()
                    Me.Hide()
                End If
            Else
                btnAsig.Enabled = True
                btnIngresar.Enabled = False
            End If
        Else
            Sql = "select idcurso from cursos where curso='" & NCurso & "'"
            Procedure()
            RS.Read()
            Sql = "insert into ediciones values('', " & RS(0) & ", '" & nudHora1.Value & ":" & nudmm1.Value & "', '" & nudhora2.Text & ":" & nudmm2.Value & "', '" & cboDias.SelectedItem & "', null)"
            Procedure()
            Rta = MsgBox("Edicion ingresada correctamente. ¿Desea ingresar otra?", MsgBoxStyle.YesNoCancel)
            If Rta = 6 Then
                nudHora1.Value = 0
                nudhora2.Value = 0
                nudmm1.Value = 0
                nudmm2.Value = 0
            ElseIf Rta = 7 Then
                MsgBox("Usted sera devuelto al menu principal.")
                nudHora1.Value = 0
                nudhora2.Value = 0
                nudmm1.Value = 0
                nudmm2.Value = 0
                MenuAdministracion.Show()
                Me.Hide()
            Else
                btnAsig.Enabled = True
                btnIngresar.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnAsig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsig.Click
        Rta = MsgBox("Esta seguro que quiere asignar capacitadores?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            AsignacionCapac.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub A_Ediciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAsig.Enabled = False
        btnIngresar.Enabled = False
    End Sub

    Private Sub cboDias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDias.SelectedIndexChanged
        btnIngresar.Enabled = True
    End Sub
End Class