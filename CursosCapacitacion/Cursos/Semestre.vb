Public Class Semestre

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        OpcCursos.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir3.Click
        Rta = MsgBox("Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Application.ExitThread()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Trimestre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim anio As String
        Sql = "select year(curdate())"
        Procedure()
        RS.Read()
        anio = RS(0)
        lblT1.Text = "Desde 01/01/" & anio & " hasta 31/06/" & anio & ""
        lblT2.Text = "Desde 01/07/" & anio & " hasta 31/12/" & anio & ""
        Sql = "select curso from cursos c, ediciones e, contratos co where c.idcurso=e.idcurso and e.idedicion=co.idedicion and FechaInicio between '2019-01-01' and '2019-06-30'"
        Procedure()
        While RS.Read
            lstS1.Items.Add(RS(0))
        End While
        Sql = "select curso from cursos c, ediciones e, contratos co where c.idcurso=e.idcurso and e.idedicion=co.idedicion and FechaInicio between '2019-07-01' and '2019-12-30'"
        Procedure()
        While RS.Read
            lstS2.Items.Add(RS(0))
        End While
    End Sub
End Class