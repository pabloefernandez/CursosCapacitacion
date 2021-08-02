Public Class A_Ediciones

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If A_Edicion = True Then
            Sql = "select idcurso from cursos where curso='" & A_Cursos.txtNombre.Text & "'"
            Procedure()
            RS.Read()
            Sql = "insert into ediciones values('', " & RS(0) & ", '" & txtHorarioI.Text & ":" & txtHorarioI2.Text & "', '" & txtHorarioF.Text & ":" & txtHorarioF2.Text & "', '" & txtDia.Text & "', null)"
            Procedure()
            Rta = MsgBox("Edicion ingresada correctamente. ¿Desea ingresar otra?", MsgBoxStyle.YesNo)
            If Rta = 6 Then
                txtHorarioI.Text = ""
                txtHorarioI2.Text = ""
                txtHorarioF.Text = ""
                txtHorarioF2.Text = ""
                txtDia.Text = ""
            Else
                Rta = MsgBox("¿Desea ingresar pre-requisitos al curso?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    Prerrequisitos2 = True
                    Prerreq.Show()
                    Me.Hide()
                Else
                    txtHorarioI.Text = ""
                    txtHorarioI2.Text = ""
                    txtHorarioF.Text = ""
                    txtHorarioF2.Text = ""
                    txtDia.Text = ""
                    A_Edicion = False
                    A_Cursos.txtNombre.Text = ""
                    A_Cursos.txtNivel.Text = ""
                    A_Cursos.txtDuracion.Text = ""
                    A_Cursos.txtPuntaje.Text = ""
                    A_Cursos.txtCosto.Text = ""
                    A_Cursos.txtCupo.Text = ""
                    A_Cursos.cboAreas.Text = ""
                    A_Cursos.chkGerencial.Checked = False
                    Menu1.Show()
                    Me.Hide()
                End If
            End If
        Else
            Sql = "select idcurso from cursos where curso='" & NCurso & "'"
            Procedure()
            RS.Read()
            Sql = "insert into ediciones values('', " & RS(0) & ", '" & txtHorarioI.Text & ":" & txtHorarioI2.Text & "', '" & txtHorarioF.Text & ":" & txtHorarioF2.Text & "', '" & txtDia.Text & "', null)"
            Procedure()
            Rta = MsgBox("Edicion ingresada correctamente. ¿Desea ingresar otra?", MsgBoxStyle.YesNo)
            If Rta = 6 Then
                txtHorarioI.Text = ""
                txtHorarioI2.Text = ""
                txtHorarioF.Text = ""
                txtHorarioF2.Text = ""
                txtDia.Text = ""
            Else
                MsgBox("Usted sera devuelto al menu principal.")
                txtHorarioI.Text = ""
                txtHorarioI2.Text = ""
                txtHorarioF.Text = ""
                txtHorarioF2.Text = ""
                txtDia.Text = ""
                Menu1.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnSalir3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir3.Click
        MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class