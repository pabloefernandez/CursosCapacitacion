Public Class Tipo_Pago

    Private Sub Tipo_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select descripcion from formaspago"
        Procedure()
        While RS.Read = True
            cboTipo.Items.Add(RS(0))
        End While
    End Sub

    Private Sub cboTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipo.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSiguienteT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguienteT.Click
        Rta = MsgBox("Esta seguro que quiere ingresar ese tipo de pago?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If Rta = 6 Then
            DetalleContrato.Show()
            Me.Hide()
        End If
    End Sub
End Class