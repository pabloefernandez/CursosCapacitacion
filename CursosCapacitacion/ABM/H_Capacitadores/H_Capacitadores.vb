Public Class H_Capacitadores

    Private Sub btnSalir3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir3.Click
        MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If A_Capac = True Then
            Sql = "select idcapacitador from personas p, capacitadores c where p.idpersona=c.idpersona and dni=" & A_Capacitadores.txtCDni.Text & ""
            Procedure()
            RS.Read()
            Sql = "insert into hcapacitadores values('', " & RS(0) & ", '" & txtHorarioI.Text & ":" & txtHorarioI2.Text & "', '" & txtHorarioF.Text & ":" & txtHorarioF2.Text & "', '" & txtDia.Text & "', null)"
            Procedure()
            Rta = MsgBox("Horario ingresado correctamente. ¿Desea ingresar otro?", MsgBoxStyle.YesNo)
            If Rta = 6 Then
                txtHorarioI.Text = ""
                txtHorarioI2.Text = ""
                txtHorarioF.Text = ""
                txtHorarioF2.Text = ""
                txtDia.Text = ""
            Else
                MsgBox("Usted sera devuelto al menu principal.")
                A_Titulos.txtNtitulo.Text = ""
                A_Titulos.cboAreas.Text = ""
                txtHorarioI.Text = ""
                txtHorarioI2.Text = ""
                txtHorarioF.Text = ""
                txtHorarioF2.Text = ""
                txtDia.Text = ""
                A_Capac = False
                A_Capacitadores.txtCNombre.Text = ""
                A_Capacitadores.txtCApellido.Text = ""
                A_Capacitadores.txtCDireccion.Text = ""
                A_Capacitadores.txtCTelefono.Text = ""
                A_Capacitadores.txtCDni.Text = ""
                A_Capacitadores.txtCNacionalidad.Text = ""
                A_Capacitadores.rdnFemenino.Checked = False
                A_Capacitadores.rdnMasculino.Checked = False
                A_Capacitadores.txtCEmail.Text = ""
                Menu1.Show()
                Me.Hide()
            End If
        Else
            Sql = "select idcapacitador from personas p, capacitadores c where p.idpersona=c.idpersona and dni=" & DniC & ""
            Procedure()
            RS.Read()
            Sql = "insert into hcapacitadores values('', " & RS(0) & ", '" & txtHorarioI.Text & ":" & txtHorarioI2.Text & "', '" & txtHorarioF.Text & ":" & txtHorarioF2.Text & "', '" & txtDia.Text & "', null)"
            Procedure()
            Rta = MsgBox("Horario ingresado correctamente. ¿Desea ingresar otro?", MsgBoxStyle.YesNo)
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

    Private Sub H_Capacitadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class