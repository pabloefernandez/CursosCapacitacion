Public Class MenuComp

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        MsgBox("Usted sera devuelto al menu de logueo.")
        MenuInicioSesion.txtUsuario.Text = ""
        MenuInicioSesion.txtContrasenia.Text = ""
        MenuInicioSesion.txtUsuario.Focus()
        MenuInicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnPagarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarC.Click
        Me.Hide()
        idcontrato = InputBox("Ingrese Nª de contrato para pagar cuotas:")
        Sql = "select count(*) from contratos where idcontrato=" & idcontrato & ""
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            Sql = "select count(*) from reciboscomp where idcontrato=" & idcontrato & ""
            Procedure()
            RS.Read()
            If RS(0) = 0 Then
                Rta = MsgBox("El contrato no cuenta con cuotas pagadas. ¿Desea pagar la primera?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    primera = True 'recordar ponerla en False al terminar de pagar el contrato' 
                    DetallePContrato.Show()
                Else
                    MsgBox("Sera dirigido al menu principal")
                    Me.Show()
                End If
            ElseIf RS(0) = 1 Then
                Rta = MsgBox("El contrato cuenta con la primer cuota paga. ¿Desea pagar la segunda?", MsgBoxStyle.YesNo)
                If Rta = 6 Then
                    segunda = True 'recordar ponerla en False al terminar de pagar el contrato'
                    DetallePContrato.Show()
                Else
                    MsgBox("Sera dirigido al menu principal.")
                    Me.Show()
                End If
            ElseIf RS(0) = 2 Then
                MsgBox("El contrato ingresado no cuenta con cuotas pendientes. Sera dirigido al menu principal.")
                Me.Show()
            End If
        Else
            MsgBox("El contrato no existe. Sera dirigido al menu principal.")
            Me.Show()
        End If
    End Sub
End Class