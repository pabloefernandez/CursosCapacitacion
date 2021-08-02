Public Class PagoCapacitadores
    Dim dni As Integer
    Dim saldo As Decimal
    Private Sub PagoCapacitadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dni = InputBox("Ingrese DNI del capacitador a pagar:")
        Sql = "select count(*) from capacitadores c, personas p where p.idpersona=c.idpersona and dni=" & dni & ""
        Procedure()
        RS.Read()
        If RS(0) = 1 Then
            Sql = "select * from personas where dni=" & dni & ""
            Procedure()
            RS.Read()
            lblN.Text = RS(1)
            lblAp.Text = RS(2)
            lblDirecc.Text = RS(3)
            lblTel.Text = RS(4)
            lblDni.Text = RS(5)
            lblFNac.Text = RS(6)
            lblNac.Text = RS(7)
            lblSexo.Text = RS(8)
            lblEmail.Text = RS(9)
            Sql = "select sum(Costo+Puntaje) from(select sum(Costo+Cursos) Costo from(select sum(Costo) Costo from(select idedicion, Costo*0.10 Costo from(select idedicion, costocur*cant Costo from(select e.idedicion, count(*) cant, costocur from aprobemp ae, contratos c, ediciones e, cursos cur where ae.idcontrato=c.idcontrato and c.idedicion=e.idedicion and cur.idcurso=e.idcurso and FechaInicio>=curdate() and FechaFin<=curdate() group by ae.idcontrato)a)b)c,(select idedicion, sum(costocur) Cursos from cursos c, capacitadores cap, ediciones e, personas p where c.idcurso=e.idcurso and cap.idcapacitador=e.idcapacitador and p.idpersona=cap.idpersona and dni=" & dni & " group by idedicion)d where c.idedicion=d.idedicion)e,(select idedicion, sum(costocur) Cursos from cursos c, capacitadores cap, ediciones e, personas p where c.idcurso=e.idcurso and cap.idcapacitador=e.idcapacitador and p.idpersona=cap.idpersona and dni=" & dni & ")f)g,(select c.idcapacitador, sum(a.puntaje) Puntaje from capacitadores c, areas a, titulos t, titulos_capac tc, personas p where t.idtitulo=tc.idtitulo and t.idarea=a.idarea and c.idcapacitador=tc.idcapacitador and c.idpersona=p.idpersona and dni=" & dni & ")h"
            Procedure()
            RS.Read()
            saldo = RS(0)
            lblSaldo.Text = "$ " & saldo
        End If
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Sql = "select idcapacitador from capacitadores c, personas p where p.idpersona=c.idpersona and dni=" & dni & ""
        Procedure()
        RS.Read()
        Sql = "insert into ReciboSueldo values('', " & RS(0) & ", curdate(), '" & saldo & "')"
        Procedure()
        MsgBox("Se le ha pagado al capacitador. Usted sera devuelto al menu principal")
        MenuFinanzas.Show()
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintForm1.Print()
    End Sub
End Class