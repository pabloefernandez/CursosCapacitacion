Imports System.Data.Odbc
Public Class E_Edicion
    'Dim rnd As New Random
    'Dim val As Integer = rnd.Next(0, dgvHorarios.Rows.Count)

    Private Sub E_Edicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnElegir.Enabled = False
        Sql = "select Horario_I as Inicio, Horario_F as Final, Dia from ediciones e, cursos c where c.idcurso=e.idcurso and curso='" & contratos.txtNombreC.Text & "'"
        Procedure()
        ds.Tables.Add("Horarios")
        adp = New OdbcDataAdapter(Sql, CNN)
        adp.Fill(ds.Tables("Horarios"))
        Me.dgvHorarios.DataSource = ds.Tables("Horarios")
    End Sub

    Private Sub dgvHorarios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHorarios.CellClick
        btnElegir.Enabled = True
    End Sub


    Private Sub btnElegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElegir.Click
        Dim Inicio As TimeSpan
        Dim Final As TimeSpan
        Dim Dia As String
        Inicio = dgvHorarios(0, dgvHorarios.CurrentRow.Index).Value
        Final = dgvHorarios(1, dgvHorarios.CurrentRow.Index).Value
        Dia = dgvHorarios(2, dgvHorarios.CurrentRow.Index).Value
        contratos.dgvHorarios.Rows.Add(Inicio, Final, Dia)
        contratos.dgvHorarios.Visible = True
        contratos.dgvHorarios.Enabled = False
        contratos.Show()
        Me.Hide()
    End Sub
End Class