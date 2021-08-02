Public Class A_Capacitadores
    Dim datevar As String

    Private Sub txtCNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCDni.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCNacionalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNacionalidad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSiguiente.Click
        A_Capac = True 'colocar en false al terminar la operacion con el alta de los capacitadores'
        If rdnFemenino.Checked = True Then
            datevar = MonthCalendar1.SelectionStart.Date
            Sql = "insert into personas values('','" & txtCNombre.Text & "', '" & txtCApellido.Text & "', '" & txtCDireccion.Text & "','" & txtCTelefono.Text & "', " & txtCDni.Text & " ,'" & datevar & "', '" & txtCNacionalidad.Text & "', 'F', '" & txtCEmail.Text & "')"
            Procedure()
            Sql = "select idpersona from personas where dni=" & txtCDni.Text & ""
            Procedure()
            RS.Read()
            Sql = "insert into capacitadores values('', " & RS(0) & ", null)"
            Procedure()
        End If
        If rdnMasculino.Checked = True Then
            datevar = MonthCalendar1.SelectionStart.Date
            Sql = "insert into personas values('','" & txtCNombre.Text & "', '" & txtCApellido.Text & "', '" & txtCDireccion.Text & "','" & txtCTelefono.Text & "', " & txtCDni.Text & " ,'" & datevar & "', '" & txtCNacionalidad.Text & "', 'M', '" & txtCEmail.Text & "')"
            Procedure()
            Sql = "select idpersona from personas where dni=" & txtCDni.Text & ""
            Procedure()
            RS.Read()
            Sql = "insert into capacitadores values('', " & RS(0) & ", null)"
            Procedure()
        End If
        'txtCNombre.Text = ""
        'txtCApellido.Text = ""
        'txtCDireccion.Text = ""
        'txtCTelefono.Text = ""
        'txtCDni.Text = ""
        'txtCNacionalidad.Text = ""
        'rdnFemenino.Checked = False
        'rdnMasculino.Checked = False
        'txtCEmail.Text = ""
        A_Titulos.Show()
        Me.Hide()
    End Sub
End Class