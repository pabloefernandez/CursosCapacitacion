Public Class M_Compania
    Dim idcomp As Integer
    Private Sub btnTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick.Click
        Sql = "select count(*) from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            btnTick.Enabled = False
            gbxDatos.Enabled = True
            Sql = "select * from companias where nombre='" & txtNCompania.Text & "'"
            Procedure()
            RS.Read()
            txtNCompania.Enabled = False
            btnModificar.Enabled = True
            txtNombre.Text = RS(1)
            txtDireccion.Text = RS(2)
            txtTel.Text = RS(3)
            txtCuit.Text = RS(4)
            txtRepres.Text = RS(5)
            txtApe.Text = RS(6)
            txtEmail.Text = RS(7)
            txtCuit.Enabled = False
            btnTick4.Enabled = False
        Else
            MsgBox("La compania no existe. Ingresela nuevamente.")
        End If
    End Sub

    Private Sub M_Compania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        gbxDatos.Enabled = False
        txtNCompania.Focus()
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        MsgBox("La compania ha sido modificada exitosamente. Usted sera devuelto al menu principal.")
        btnTick.Enabled = True
        'En blanco al salir'
        gbxDatos.Enabled = False
        txtNCompania.Enabled = True
        txtNCompania.Text = ""
        btnModificar.Enabled = False
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTel.Text = ""
        txtCuit.Text = ""
        txtRepres.Text = ""
        txtApe.Text = ""
        txtEmail.Text = ""
        MenuAdministracion.Show()
        Me.Close()
    End Sub

    Private Sub btnTick1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick1.Click
        Sql = "select idcomp from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Nombre='" & txtNombre.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        txtNCompania.Text = txtNombre.Text
        btnTick1.Enabled = False
        txtNombre.Enabled = False
    End Sub

    Private Sub btnTick2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick2.Click
        Sql = "select idcomp from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Direccion='" & txtDireccion.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick2.Enabled = False
        txtDireccion.Enabled = False
    End Sub

    Private Sub btnTick3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick3.Click
        Sql = "select idcomp from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Telefono='" & txtTel.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick3.Enabled = False
        txtTel.Enabled = False
    End Sub

    Private Sub btnTick4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick4.Click
        Sql = "select idcomp from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set CUIT=" & txtCuit.Text & " where idcomp=" & idcomp & ""
        Procedure()
        btnTick4.Enabled = False
        txtNCompania.Enabled = False
    End Sub

    Private Sub btnTick5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick5.Click
        Sql = "select idcomp from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Representante_N='" & txtRepres.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick5.Enabled = False
        txtRepres.Enabled = False
    End Sub

    Private Sub btnTick6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick6.Click
        Sql = "select idcomp from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Representante_Ap='" & txtApe.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick6.Enabled = False
        txtApe.Enabled = False
    End Sub

    Private Sub btnTick7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick7.Click
        Sql = "select idcomp from companias where nombre='" & txtNCompania.Text & "'"
        Procedure()
        RS.Read()
        idcomp = RS(0)
        Sql = "update companias set Email='" & txtEmail.Text & "' where idcomp=" & idcomp & ""
        Procedure()
        btnTick7.Enabled = False
        txtEmail.Enabled = False
    End Sub
End Class