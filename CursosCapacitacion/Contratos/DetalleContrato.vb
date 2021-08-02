Public Class DetalleContrato
    Dim pos As Integer
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintForm1.Print()
    End Sub
    Private Sub DetalleContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "SELECT MAX(IDCONTRATO)+1 FROM CONTRATOS "
        Procedure()
        RS.Read()
        MAX = RS(0)
        lblNCont.Text = MAX
        Sql = "SELECT CURDATE()"
        Procedure()
        RS.Read()
        lblFecha.Text = RS(0)
        txtNombreR.Text = contratos.txtRepres.Text & " " & contratos.txtApe.Text
        txtComp.Text = contratos.txtNombreComp.Text
        txtCuitC.Text = contratos.txtCuit.Text
        txtDomi.Text = contratos.txtDireccion.Text
        Sql = "SELECT CURSO FROM CURSOS WHERE CURSO='" & contratos.txtNombreC.Text & "'"
        Procedure()
        RS.Read()
        txtCur.Text = RS(0)
        txtHoraI.Text = contratos.txtInicio.Text
        txtHorarioF.Text = contratos.txtFinal.Text
        txtDia.Text = contratos.txtDia.Text
        Sql = "SELECT DURACIONCUR FROM CURSOS WHERE CURSO='" & contratos.txtNombreC.Text & "'"
        Procedure()
        RS.Read()
        txtTiempo.Text = RS(0)
        txtNombreR.Enabled = False
        txtComp.Enabled = False
        txtCuitC.Enabled = False
        txtDomi.Enabled = False
        txtCur.Enabled = False
        txtHoraI.Enabled = False
        txtHorarioF.Enabled = False
        txtDia.Enabled = False
        txtTiempo.Enabled = False
    End Sub

    Private Sub btnImpr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub btnPag2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPag2.Click
        DetalleContrato2.Show()
    End Sub

    Private Sub btnImprmir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprmir.Click
        PrintForm1.Print()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class