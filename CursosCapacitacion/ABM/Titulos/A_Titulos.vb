Public Class A_Titulos
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim idtitulo As Integer
        Dim idcapacitador As Integer
        If A_Capac = True Then 'Si esta en el proceso del alta del capacitador'
            Sql = "select count(*) from titulos where descripcion='" & txtNtitulo.Text & "'"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Sql = "select idtitulo from titulos where descripcion='" & txtNtitulo.Text & "'"
                Procedure()
                RS.Read()
                idtitulo = RS(0)
                Sql = "select idcapacitador from personas p, capacitadores c where p.idpersona=c.idpersona and dni=" & A_Capacitadores.txtCDni.Text & ""
                Procedure()
                RS.Read()
                idcapacitador = RS(0)
                Sql = "insert into titulos_capac values(" & idtitulo & ", " & idcapacitador & ")"
                Procedure()
                Rta = MsgBox("Titulo ingresado correctamente. ¿Desea ingresar otro?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    txtNtitulo.Text = ""
                    cboAreas.Text = ""
                Else
                    H_Capacitadores.Show()
                    Me.Hide()
                End If
            Else
                Sql = "select idarea from areas where nombre='" & cboAreas.Text & "'"
                Procedure()
                RS.Read()
                Sql = "insert into titulos values('', '" & txtNtitulo.Text & "', '" & RS(0) & "')"
                Procedure()
                Sql = "select idtitulo from titulos where descripcion='" & txtNtitulo.Text & "'"
                Procedure()
                RS.Read()
                idtitulo = RS(0)
                Sql = "select idcapacitador from personas p, capacitadores c where p.idpersona=c.idpersona and dni=" & A_Capacitadores.txtCDni.Text & ""
                Procedure()
                RS.Read()
                idcapacitador = RS(0)
                Sql = "insert into titulos_capac values(" & idtitulo & ", " & idcapacitador & ")"
                Procedure()
                Rta = MsgBox("Titulo ingresado correctamente. ¿Desea ingresar otro?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    txtNtitulo.Text = ""
                    cboAreas.Text = ""
                Else
                    H_Capacitadores.Show()
                    Me.Hide()
                End If
            End If
        Else 'Si no esta en el proceso del alta del capacitador'
            Sql = "select count(*) from titulos where descripcion='" & txtNtitulo.Text & "'"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Sql = "select idtitulo from titulos where descripcion='" & txtNtitulo.Text & "'"
                Procedure()
                RS.Read()
                idtitulo = RS(0)
                Sql = "select idcapacitador from personas p, capacitadores c where dni=" & DniC & " and p.idpersona=c.idpersona"
                Procedure()
                RS.Read()
                idcapacitador = RS(0)
                Sql = "insert into titulos_capac values(" & idtitulo & ", " & idcapacitador & ")"
                Procedure()
                Rta = MsgBox("Titulo ingresado correctamente. ¿Desea ingresar otro?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    txtNtitulo.Text = ""
                    cboAreas.Text = ""
                Else
                    MsgBox("Usted sera devuelto al menu principal.")
                    txtNtitulo.Text = ""
                    cboAreas.Text = ""
                    Menu1.Show()
                    Me.Hide()
                End If
            Else
                Sql = "select idarea from areas where nombre='" & cboAreas.Text & "'"
                Procedure()
                RS.Read()
                Sql = "insert into titulos values('', '" & txtNtitulo.Text & "', " & RS(0) & ")"
                Procedure()
                Sql = "select idtitulo from titulos where descripcion='" & txtNtitulo.Text & "'"
                Procedure()
                RS.Read()
                idtitulo = RS(0)
                Sql = "select idcapacitador from personas p, capacitadores c where dni=" & DniC & " and p.idpersona=c.idpersona"
                Procedure()
                RS.Read()
                idcapacitador = RS(0)
                Sql = "insert into titulos_capac values(" & idtitulo & ", " & idcapacitador & ")"
                Procedure()
                Rta = MsgBox("Titulo ingresado correctamente. ¿Desea ingresar otro?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    txtNtitulo.Text = ""
                    cboAreas.Text = ""
                Else
                    Menu1.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub A_Titulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select nombre from areas"
        Procedure()
        While RS.Read
            cboAreas.Items.Add(RS(0))
        End While
    End Sub
End Class