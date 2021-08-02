Public Class Certificaciones
    Dim idcerti As Integer
    Dim idemp As Integer
    Private Sub btnEntregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntregar.Click
        Sql = "select count(*) from certificaciones"
        Procedure()
        RS.Read()
        If RS(0) = 0 Then
            Sql = "select idempleado from empleadoscomp ec, personas p where ec.idpersona=p.idpersona and dni=" & MCertificaciones.lstDatos.SelectedItems(0).SubItems(2).Text & ""
            Procedure()
            RS.Read()
            idemp = RS(0)
            Sql = "select idcurso from cursos where curso='" & lblCurso.Text & "'"
            Procedure()
            RS.Read()
            Sql = "insert into certificaciones values('', " & idemp & ", " & RS(0) & ", '" & lblFecha.Text & "')"
            Procedure()
            MCertificaciones.lstDatos.FocusedItem.Remove()
            MsgBox("Certificacion entregada")
            MCertificaciones.Show()
            Me.Close()
        Else
            Sql = "select max(idcertificacion)+1 from certificaciones"
            Procedure()
            RS.Read()
            idcerti = RS(0)
            Sql = "select idempleado from empleadoscomp ec, personas p where ec.idpersona=p.idpersona and dni=" & MCertificaciones.lstDatos.SelectedItems(0).SubItems(2).Text & ""
            Procedure()
            RS.Read()
            idemp = RS(0)
            Sql = "select idcurso from cursos where curso='" & lblCurso.Text & "'"
            Procedure()
            RS.Read()
            Sql = "insert into certificaciones values(" & idcerti & ", " & idemp & ", " & RS(0) & ", '" & lblFecha.Text & "')"
            Procedure()
            MCertificaciones.lstDatos.FocusedItem.Remove()
            MsgBox("Certificacion entregada")
            MCertificaciones.Show()
            Me.Close()
        End If
        
    End Sub

    Private Sub Certificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "select nombre, apellido from personas where dni=" & MCertificaciones.lstDatos.SelectedItems(0).SubItems(2).Text & ""
        Procedure()
        RS.Read()
        lblNombreApellido.Text = RS(0) & " " & RS(1)
        lblCurso.Text = MCertificaciones.lstDatos.SelectedItems(0).SubItems(3).Text
        Sql = "select curdate()"
        Procedure()
        RS.Read()
        lblFecha.Text = Format(RS(0), "dd/MM/yyyy")
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        InvoiceGenerate()
    End Sub
    Private Sub InvoiceGenerate()
        invoice.NombreApellido = lblNombreApellido.Text
        invoice.Curso = lblCurso.Text
        invoice.Fecha = lblFecha.Text
        Imprimir.Invoice.Add(invoice)
        Imprimir.Refresh()
        Imprimir.Show()
    End Sub
End Class