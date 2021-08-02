Public Class MCertificaciones
    Dim indice As Integer
    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        MenuAdministracion.Show()
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

    Private Sub MCertificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select Nombre, Apellido, Dni, Curso from resultadoseval re, personas p, empleadoscomp ec, cursos c where re.idempleado not in(select idempleado from certificaciones) and re.estado='aprobado' and ec.idpersona=p.idpersona and ec.idempleado=re.idempleado and c.idcurso=re.idcurso"
        Procedure()
        While RS.Read
                lstDatos.Items.Add(RS(0))
                lstDatos.Items(indice).SubItems.Add(RS(1).ToString)
                lstDatos.Items(indice).SubItems.Add(RS(2).ToString)
                lstDatos.Items(indice).SubItems.Add(RS(3).ToString)
                indice = indice + 1
        End While
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Rta = MsgBox("Desea generar certificacion?" + MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        If Rta = 6 Then
            Certificaciones.Show()
            Me.Hide()
        End If
    End Sub
End Class