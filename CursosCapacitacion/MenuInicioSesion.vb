Imports System.Data.Odbc
Public Class MenuInicioSesion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Sql = "select count(*) from Usuarios where usuario='" & txtUsuario.Text & "' and contrasenia='" & txtContrasenia.Text & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            Sql = "select idusuario from usuarios where usuario='" & txtUsuario.Text & "' and contrasenia='" & txtContrasenia.Text & "'"
            Procedure()
            RS.Read()
            If RS(0) = 1 Then 'Administracion'
                MsgBox("Usted ha sido logueado en [Administracion].")
                MenuAdministracion.Show()
                Me.Hide()
            ElseIf RS(0) = 2 Then 'Finanzas'
                MsgBox("Usted ha sido logueado en [Finanzas].")
                MenuFinanzas.Show()
                Me.Hide()
            ElseIf RS(0) = 3 Then
                MsgBox("Usted ha sido logueado en [Compañias].")
                MenuComp.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Ingreso de datos incorrecto. Vuelva a intentarlo")
            txtUsuario.Text = ""
            txtContrasenia.Text = ""
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub MenuInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
        conexion()
        txtUsuario.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub
End Class