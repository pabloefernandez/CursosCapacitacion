Imports System.Data.Odbc
Public Class PuntajeEmpleados

    Private Sub PuntajeEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        Sql = "select Nombre, Apellido, PuntajeGral as Puntaje from personas p, empleadoscomp c where p.idpersona=c.idpersona"
        Procedure()
        ds.Tables.Add("Datos")
        adp = New OdbcDataAdapter(Sql, CNN)
        adp.Fill(ds.Tables("Datos"))
        Me.dgvDatos.DataSource = ds.Tables("Datos")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        OpcCompanias.Show()
        Me.Close()
    End Sub
End Class