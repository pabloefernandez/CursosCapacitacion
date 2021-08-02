Imports System.Data.Odbc
Public Class E_Edicion
    Dim indice As Integer

    Private Sub E_Edicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnElegir.Enabled = False
        Sql = "select idedicion, Horario_I as Inicio, Horario_F as Final, Dia from ediciones e, cursos c where c.idcurso=e.idcurso and curso='" & contratos.txtNombreC.Text & "' and idedicion not in(select idedicion from contratos) and idhorario is not null"
        Procedure()
        While RS.Read
            lstDatos.Items.Add(RS(0))
            lstDatos.Items(indice).SubItems.Add(RS(1).ToString)
            lstDatos.Items(indice).SubItems.Add(RS(2).ToString)
            lstDatos.Items(indice).SubItems.Add(RS(3).ToString)
            indice = indice + 1
        End While
    End Sub

    Private Sub btnElegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElegir.Click
        Dim Inicio As String = lstDatos.SelectedItems(0).SubItems(1).Text
        Dim Final As String = lstDatos.SelectedItems(0).SubItems(2).Text
        Dim Dia As String = lstDatos.SelectedItems(0).SubItems(3).Text

        contratos.txtInicio.Text = Inicio
        contratos.txtFinal.Text = Final
        contratos.txtDia.Text = Dia

        contratos.Show()
        Me.Close()
    End Sub

    Private Sub lstDatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDatos.SelectedIndexChanged
        btnElegir.Enabled = True
    End Sub
End Class