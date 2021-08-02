Public Class A_Cursos

    Private Sub btnICurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnICurso.Click
        A_Edicion = True
        Sql = "select idarea from areas where nombre='" & cboAreas.Text & "'"
        Procedure()
        RS.Read()
        If chkGerencial.Checked = True Then
            Sql = "insert into cursos values('', '" & txtNombre.Text & "', " & txtNivel.Text & ", " & txtDuracion.Text & ", " & txtPuntaje.Text & ", " & txtCosto.Text & ", " & txtCupo.Text & ", " & RS(0) & ", 1)"
            Procedure()
        Else
            Sql = "insert into cursos values('', '" & txtNombre.Text & "', " & txtNivel.Text & ", " & txtDuracion.Text & ", " & txtPuntaje.Text & ", " & txtCosto.Text & ", " & txtCupo.Text & ", " & RS(0) & ", 0)"
            Procedure()
        End If
        A_Ediciones.Show()
        Me.Hide()
    End Sub

    Private Sub A_Cursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select nombre from areas"
        Procedure()
        While RS.Read
            cboAreas.Items.Add(RS(0))
        End While
    End Sub
End Class