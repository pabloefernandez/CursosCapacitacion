Imports System.Data.Odbc
Public Class PuntajeEmpleados
    Dim compania As Integer
    Private Sub PuntajeEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnBuscar.Enabled = False
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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Sql = "select count(*) from companias where nombre='" & txtNombreC.Text & "'"
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            Sql = "select count(*) from empleadoscomp ec, companias c where c.idcomp=ec.idcomp and Nombre='" & txtNombreC.Text & "'"
            Procedure()
            RS.Read()
            If RS(0) >= 1 Then
                Sql = "select idcomp from companias where nombre='" & txtNombreC.Text & "'"
                Procedure()
                RS.Read()
                compania = RS(0)
                ds.Reset()
                Sql = "select Nombre, Apellido, PuntajeGral as Puntaje from personas p, empleadoscomp c where p.idpersona=c.idpersona and idcomp=" & compania & ""
                Procedure()
                ds.Tables.Add("Datos")
                adp = New OdbcDataAdapter(Sql, CNN)
                adp.Fill(ds.Tables("Datos"))
                Me.dgvDatos.DataSource = ds.Tables("Datos")
                txtNombreC.Text = ""
                btnBuscar.Enabled = False
            Else
                MsgBox("La compania ingresada no cuenta con empleados.")
                txtNombreC.Text = ""
                btnBuscar.Enabled = False
            End If
            
        Else
            MsgBox("La compania no existe. Ingrese el nombre nuevamente")
            txtNombreC.Text = ""
            btnBuscar.Enabled = False
        End If
    End Sub

    Private Sub txtNombreC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreC.TextChanged
        btnBuscar.Enabled = True
    End Sub
End Class