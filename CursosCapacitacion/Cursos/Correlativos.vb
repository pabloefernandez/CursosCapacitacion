Public Class Correlativos
    Dim i As Integer
    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click
        Rta = MsgBox("Esta seguro que desea salir del programa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        lstCorrelativos.Items.Clear()
        cboAreas.Text = ""
        Me.Close()
        OpcCursos.Show()
        Me.Hide()

    End Sub

    Private Sub cboAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreas.SelectedIndexChanged
        lstCorrelativos.Items.Clear()
        Sql = "select curso from cursos c, areas a where c.idarea=a.idarea and nombre= '" & cboAreas.SelectedItem & "'"
        Procedure()
        While RS.Read = True
            lstCorrelativos.Items.Add(RS(0))
        End While

    End Sub

    Private Sub Correlativos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select nombre from areas"
        Procedure()
        While RS.Read
            cboAreas.Items.Add(RS(0))
        End While
    End Sub
End Class