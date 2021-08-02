Imports System.Data.Odbc
Public Class CapacitadoresPagados
    Private Sub SueldosCapac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim indice As Integer
        Dim antepenultimo As Integer
        Dim ultimo As Integer
        Sql = "select date_add(last_day(curdate()), interval -2 day)"
        Procedure()
        RS.Read()
        antepenultimo = RS(0)
        Sql = "select last_day(curdate())"
        Procedure()
        RS.Read()
        ultimo = RS(0)
        ds.Reset()
        Sql = "select idPagoCa as id, Nombre, Apellido, DNI, Fecha_Pago, Paga from personas p, capacitadores c, ReciboSueldo pc where c.idpersona=p.idpersona and c.idcapacitador=pc.idcapacitador"
        Procedure()
        While RS.Read
            lstPagados.Items.Add(RS(0))
            lstPagados.Items(indice).SubItems.Add(RS(1))
            lstPagados.Items(indice).SubItems.Add(RS(2))
            lstPagados.Items(indice).SubItems.Add(RS(3))
            lstPagados.Items(indice).SubItems.Add(RS(4))
            lstPagados.Items(indice).SubItems.Add(RS(5))
            indice = indice + 1
        End While
        indice = 0
        Sql = "select idcapacitador, Nombre, Apellido, Dni from capacitadores c, personas p where c.idpersona=p.idpersona and idcapacitador not in(select idcapacitador from ReciboSueldo where Fecha_Pago between " & antepenultimo & " and " & ultimo & ")"
        Procedure()
        While RS.Read
            lstDatos.Items.Add(RS(0))
            lstDatos.Items(indice).SubItems.Add(RS(1))
            lstDatos.Items(indice).SubItems.Add(RS(2))
            lstDatos.Items(indice).SubItems.Add(RS(3))
            indice = indice + 1
        End While
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuFinanzas.Show()
        Me.Close()
    End Sub
End Class