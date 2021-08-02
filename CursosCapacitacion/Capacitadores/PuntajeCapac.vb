Imports System.Data.Odbc
Public Class PuntajeCapac

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        OpcCapacitadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir4.Click
        Rta = MsgBox("¿Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub PuntajeCapac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Reset()
        Sql = "select Nombre, Apellido, PuntajeCap as Puntaje from personas p, capacitadores c where p.idpersona=c.idpersona"
        Procedure()
        ds.Tables.Add("Datos")
        adp = New OdbcDataAdapter(Sql, CNN)
        adp.Fill(ds.Tables("Datos"))
        Me.dgvDatos.DataSource = ds.Tables("Datos")
    End Sub
End Class