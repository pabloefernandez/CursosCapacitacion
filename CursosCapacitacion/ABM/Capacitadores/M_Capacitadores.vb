Public Class M_Capacitadores
    Dim idpersona As Integer
    Private Sub btnTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick.Click
        Sql = "select count(*) from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            btnTick.Enabled = False
            gbxDatos.Enabled = True
            Sql = "select * from personas where dni='" & txtDCapacitador.Text & "'"
            Procedure()
            RS.Read()
            txtDCapacitador.Enabled = False
            btnModificar.Enabled = True
            txtNombre.Text = RS(1)
            txtApellido.Text = RS(2)
            txtDireccion.Text = RS(3)
            txtTel.Text = RS(4)
            txtDni.Text = RS(5)
            txtFNacimiento.Text = RS(6)
            txtNacionalidad.Text = RS(7)
            txtSexo.Text = RS(8)
            txtEmail.Text = RS(9)
            txtDni.Enabled = False
            btnTick5.Enabled = False
            txtFNacimiento.Enabled = False
            btnTick6.Enabled = False
        Else
            MsgBox("El capacitador no existe. Ingreselo nuevamente.")
        End If
    End Sub

    Private Sub M_Capacitadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        gbxDatos.Enabled = False
        txtDCapacitador.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        MsgBox("El capacitador ha sido moficiado exitosamente. Usted sera devuelto al menu principal.")
        btnTick.Enabled = True
        'En blanco al salir'
        gbxDatos.Enabled = False
        txtDCapacitador.Enabled = True
        txtDCapacitador.Text = ""
        btnModificar.Enabled = False
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTel.Text = ""
        txtDni.Text = ""
        txtFNacimiento.Text = ""
        txtNacionalidad.Text = ""
        txtSexo.Text = ""
        txtEmail.Text = ""
        Menu1.Show()
        Me.Hide()
    End Sub

    Private Sub btnTick1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick1.Click
        Sql = "select idpersona from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        idpersona = RS(0)
        Sql = "update personas set Nombre='" & txtNombre.Text & "' where idpersona=" & idpersona & ""
        Procedure()
        btnTick1.Enabled = False
        txtNombre.Enabled = False
    End Sub

    Private Sub btnTick2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick2.Click
        Sql = "select idpersona from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        idpersona = RS(0)
        Sql = "update personas set Apellido='" & txtApellido.Text & "' where idpersona=" & idpersona & ""
        Procedure()
        btnTick2.Enabled = False
        txtApellido.Enabled = False
    End Sub

    Private Sub btnTick3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick3.Click
        Sql = "select idpersona from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        idpersona = RS(0)
        Sql = "update personas set Direccion='" & txtDireccion.Text & "' where idpersona=" & idpersona & ""
        Procedure()
        btnTick3.Enabled = False
        txtDireccion.Enabled = False
    End Sub

    Private Sub btnTick4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick4.Click
        Sql = "select idpersona from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        idpersona = RS(0)
        Sql = "update personas set Telefono='" & txtTel.Text & "' where idpersona=" & idpersona & ""
        Procedure()
        btnTick4.Enabled = False
        txtTel.Enabled = False
    End Sub

    Private Sub btnTick7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick7.Click
        Sql = "select idpersona from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        idpersona = RS(0)
        Sql = "update personas set Nacionalidad='" & txtNacionalidad.Text & "' where idpersona=" & idpersona & ""
        Procedure()
        btnTick7.Enabled = False
        txtNacionalidad.Enabled = False
    End Sub

    Private Sub btnTick8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick8.Click
        Sql = "select idpersona from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        idpersona = RS(0)
        Sql = "update personas set Sexo='" & txtSexo.Text & "' where idpersona=" & idpersona & ""
        Procedure()
        btnTick8.Enabled = False
        txtSexo.Enabled = False
    End Sub

    Private Sub btnTick9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick9.Click
        Sql = "select idpersona from personas where dni=" & txtDCapacitador.Text & ""
        Procedure()
        RS.Read()
        idpersona = RS(0)
        Sql = "update personas set Email='" & txtEmail.Text & "' where idpersona=" & idpersona & ""
        Procedure()
        btnTick9.Enabled = False
        txtEmail.Enabled = False
    End Sub
End Class