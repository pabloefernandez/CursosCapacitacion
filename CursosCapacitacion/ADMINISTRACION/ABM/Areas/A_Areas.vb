Public Class A_Areas

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Sql = "select max(idarea)+1 from areas"
        Procedure()
        RS.Read()
        Sql = "insert into areas values(" & RS(0) & ", '" & txtNombre.Text & "', " & txtPuntaje.Text & ")"
        Procedure()
        MsgBox("Area ingresada correctamente. Sera devuelto al menu principal.")
        MenuAdministracion.Show()
        Me.Close()
    End Sub
End Class