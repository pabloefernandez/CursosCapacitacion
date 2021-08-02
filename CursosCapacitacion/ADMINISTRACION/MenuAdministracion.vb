Public Class MenuAdministracion

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

    Private Sub btnCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursos.Click
        OpcCursos.Show()
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

    Private Sub btnContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContratos.Click
        contratos.Show()
        Me.Hide()
    End Sub
    Private Sub btnABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnABM.Click
        ABM.Show()
        Me.Hide()
    End Sub

    Private Sub MenuAdministracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select count(*) from resultadoseval where idempleado not in(select idempleado from certificaciones) and estado='aprobado'"
        Procedure()
        RS.Read()
        If RS(0) >= 1 Then
            MsgBox("Hay " & RS(0) & " certificaciones para entregar. VAYA A")
        End If
    End Sub

    Private Sub btnCertificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCertificaciones.Click
        MCertificaciones.Show()
        Me.Hide()
    End Sub

    Private Sub btnAsigna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsigna.Click
        AsignacionCapac.Show()
        Me.Hide()
    End Sub
End Class