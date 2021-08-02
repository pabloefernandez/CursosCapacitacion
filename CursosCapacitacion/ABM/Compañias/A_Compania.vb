Public Class A_Compania

    Private Sub btnCSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSiguiente.Click
        If cont_comp = True Then
            Sql = "insert into companias values ('','" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtTel.Text & "'," & txtCuit.Text & ",'" & txtRepres.Text & "','" & txtApe.Text & "','" & txtEmail.Text & "', null)"
            Procedure()
            MsgBox("La compañia ha sido registrada correctamente. Sera dirigido al formulario contratos.")
            contratos.Show()
            Me.Hide()
        Else
            Sql = "insert into companias values ('','" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtTel.Text & "'," & txtCuit.Text & ",'" & txtRepres.Text & "','" & txtApe.Text & "','" & txtEmail.Text & "', null)"
            Procedure()
            MsgBox("La compañia ha sido registrada correctamente. Sera dirigido al menu principal.")
            Menu1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCuit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuit.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRepres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepres.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub A_Compania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class