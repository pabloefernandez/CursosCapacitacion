Public Class DetallePContrato
    Dim diferencia As Integer
    Dim interes As Decimal
    Dim hoy As Date
    Dim inicio As Date
    Dim final As Date
    Dim pos As Integer
    'Dim posSub As Integer
    Dim tipocuota As String
    Dim suma As Decimal
    Dim Total As Decimal
    Dim Saldo As Decimal
    Dim fin As Date
    Private Sub DetallePContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Sql = "select * from companias where idcomp in(select idcomp from contratos where idcontrato=" & idcontrato & ")"
        Procedure()
        RS.Read()
        lblNombre.Text = RS(1)
        lblDirecc.Text = RS(2)
        lblTel.Text = RS(3)
        lblCuit.Text = RS(4)
        lblRepresN.Text = RS(5)
        lblRepresAp.Text = RS(6)
        lblEmail.Text = RS(7)
        lblNContrato.Text = idcontrato
        Sql = "select date(curdate())"
        Procedure()
        RS.Read()
        lblFechaPago.Text = RS(0)
        Sql = "select Curso from Cursos c, Ediciones e, Contratos co where c.idcurso=e.idcurso and e.idedicion=co.idedicion and idcontrato=" & idcontrato & ""
        Procedure()
        RS.Read()
        lblRazon.Text = RS(0)
        Sql = "select curdate()"
        Procedure()
        RS.Read()
        hoy = RS(0)

        If primera = True Then 'pago inicial'
            Sql = "select FechaInicio from contratos where idcontrato=" & idcontrato & ""
            Procedure()
            RS.Read()
            inicio = RS(0)
            Sql = "select datediff('" & Format(hoy, "yyyy/MM/dd") & "', '" & Format(inicio, "yyyy/MM/dd") & "')"
            Procedure()
            RS.Read()
            diferencia = RS(0)
            Sql = "select count(*) from intereses where CantDias=" & diferencia & ""
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Sql = "select Interes from intereses where CantDias=" & diferencia & ""
                Procedure()
                RS.Read()
                interes = RS(0)
                Sql = "select costoinicial from contratos where idcontrato=" & idcontrato & ""
                Procedure()
                RS.Read()
                Saldo = RS(0)
                lblSaldo.Text = "$ " & RS(0)
                suma = RS(0) * interes
                lblAdicional.Text = "$ " & suma
                Total = RS(0) + suma
                lblTotal.Text = "$ " & Total
            Else 'si NO encuentra intereses en la tabla'
                If diferencia = 0 Then
                    Sql = "select CostoInicial from contratos where idcontrato=" & idcontrato & ""
                    Procedure()
                    RS.Read()
                    Saldo = RS(0)
                    lblSaldo.Text = "$ " & RS(0)
                    lblAdicional.Text = "$ 0"
                    Total = RS(0)
                    lblTotal.Text = "$ " & RS(0)
                ElseIf diferencia > 10 Then
                    Sql = "select CostoInicial from contratos where idcontrato=" & idcontrato & ""
                    Procedure()
                    RS.Read()
                    Saldo = RS(0)
                    lblSaldo.Text = "$ " & RS(0)
                    lblAdicional.Text = "$ 30000"
                    Total = RS(0) + 30000
                    lblTotal.Text = "$ " & Total
                End If
            End If
        ElseIf segunda = True Then 'pago final'
            Sql = "select FechaFin from contratos where idcontrato=" & idcontrato & ""
            Procedure()
            RS.Read()
            fin = RS(0)
            Sql = "select datediff('" & Format(hoy, "yyyy/MM/dd") & "', '" & Format(fin, "yyyy/MM/dd") & "')"
            Procedure()
            RS.Read()
            diferencia = RS(0)
            Sql = "select count(*) from intereses where CantDias=" & diferencia & ""
            Procedure()
            RS.Read()
            If RS(0) = 1 Then
                Sql = "select Interes from intereses where CantDias=" & diferencia & ""
                Procedure()
                RS.Read()
                interes = RS(0)
                Sql = "select costototal from contratos where idcontrato=" & idcontrato & ""
                Procedure()
                RS.Read()
                Saldo = RS(0)
                lblSaldo.Text = "$ " & RS(0)
                suma = RS(0) * interes
                lblAdicional.Text = "$ " & suma
                Total = RS(0) + suma
                lblTotal.Text = "$ " & Total
            Else 'si NO encuentra intereses en la tabla'
                If diferencia = 0 Then
                    Sql = "select CostoTotal from contratos where idcontrato=" & idcontrato & ""
                    Procedure()
                    RS.Read()
                    Saldo = RS(0)
                    lblSaldo.Text = "$ " & RS(0)
                    lblAdicional.Text = "$ 0"
                    Total = RS(0)
                    lblTotal.Text = "$ " & RS(0)
                ElseIf diferencia > 10 Then
                    Sql = "select CostoTotal from contratos where idcontrato=" & idcontrato & ""
                    Procedure()
                    RS.Read()
                    Saldo = RS(0)
                    lblSaldo.Text = "$ " & RS(0)
                    lblAdicional.Text = "$ 30000"
                    Total = RS(0) + 30000
                    lblTotal.Text = "$ " & Total
                End If
            End If
        End If

    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        If primera = True Then 'es inicial'
            Sql = "insert into reciboscomp values('', " & idcontrato & ", curdate(), 'i')"
            Procedure()
            Sql = "select idReciboPC from reciboscomp where idcontrato=" & idcontrato & " and Cuota='i'"
            Procedure()
            RS.Read()
            If diferencia >= 1 And diferencia <= 10 Then
                Sql = "insert into detallepcontrato values(''," & RS(0) & ", " & Saldo & ", " & suma & ", " & Total & ", 'i')"
                Procedure()
            ElseIf diferencia = 0 Then
                Sql = "insert into detallepcontrato values(''," & RS(0) & ", " & Saldo & ", 0, " & Total & ", 'i')"
                Procedure()
            ElseIf diferencia > 10 Then
                Sql = "insert into detallepcontrato values(''," & RS(0) & ", " & Saldo & ", 30000, " & Total & ", 'i')"
                Procedure()
            End If
            Me.Hide()
            MsgBox("La cuota inicial para el contrato N=" & idcontrato & " ha sido pagada. Sera devuelto al menu principal!")
            primera = False
            MenuComp.Show()
            Me.Close()
        ElseIf segunda = True Then 'es final'
            Sql = "insert into reciboscomp values('', " & idcontrato & ", curdate(), 'f')"
            Procedure()
            Sql = "select idReciboPC from reciboscomp where idcontrato=" & idcontrato & " and Cuota='f'"
            Procedure()
            RS.Read()
            If diferencia >= 1 And diferencia <= 10 Then
                Sql = "insert into detallepcontrato values(''," & RS(0) & ", " & Saldo & ", " & suma & ", " & Total & ", 'f')"
                Procedure()
            ElseIf diferencia = 0 Then
                Sql = "insert into detallepcontrato values(''," & RS(0) & ", " & Saldo & ", 0, " & Total & ", 'f')"
                Procedure()
            ElseIf diferencia > 10 Then
                Sql = "insert into detallepcontrato values(''," & RS(0) & ", " & Saldo & ", 30000, " & Total & ", 'f')"
                Procedure()
            End If
            Me.Hide()
            MsgBox("El contrato N=" & idcontrato & " ha sido pagado por completo. Sera devuelto al menu principal!")
            segunda = False
            MenuComp.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintForm1.Print()
    End Sub
End Class