Imports Microsoft.Reporting.WinForms
Public Class Imprimir
    Public Invoice As New List(Of Encabezado)()
    Private Sub Imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", Invoice))
        ReportViewer1.RefreshReport()
    End Sub
End Class