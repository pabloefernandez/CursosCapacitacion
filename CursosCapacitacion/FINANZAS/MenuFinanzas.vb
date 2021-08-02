Public Class MenuFinanzas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        MsgBox("Usted sera devuelto al menu de logueo.")
        MenuInicioSesion.txtUsuario.Text = ""
        MenuInicioSesion.txtContrasenia.Text = ""
        MenuInicioSesion.txtUsuario.Focus()
        MenuInicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub MenuFinanzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim antepenultimo As String
        Dim penultimo As String
        Dim ultimo As String
        Dim fecha As String
        Sql = "select date_add(last_day(curdate()), interval -2 day)"
        Procedure()
        RS.Read()
        antepenultimo = RS(0)
        Sql = "select date_add(last_day(curdate()), interval -1 day)"
        Procedure()
        RS.Read()
        penultimo = RS(0)
        Sql = "select last_day(curdate())"
        Procedure()
        RS.Read()
        ultimo = RS(0)
        Sql = "select curdate()"
        Procedure()
        RS.Read()
        fecha = RS(0)
        If fecha = antepenultimo Then
            MsgBox("Quedan dos dias para terminar el mes, PAGUE A LOS CAPACITADORES.")
        End If
        If fecha = penultimo Then
            MsgBox("Queda un dia para terminar el mes, PAGUE A LOS CAPACITADORES.")
        End If
        If fecha = ultimo Then
            MsgBox("Ultimo para terminar el mes, PAGUE A LOS CAPACITADORES.")
        End If
    End Sub

    Private Sub btnPagoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagoC.Click
        
    End Sub

    Private Sub btnCapacPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapacPag.Click
        CapacitadoresPagados.Show()
        Me.Hide()
    End Sub
End Class