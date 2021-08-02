Imports System.Data.Odbc
Module Module1
    Public CNN As OdbcConnection
    Public CMD As OdbcCommand
    Public RS As OdbcDataReader
    Public RS2 As OdbcDataReader
    Public Bandera As Boolean
    Public Sql As String
    Public Rta As Integer
    Public rta2 As String
    Public rta3 As String
    Public A_Capac As Boolean
    Public A_Edicion As Boolean
    Public DniC As Integer
    Public NCurso As String
    Public bandera1 As Integer
    Public cont_comp As Boolean
    Public Prerrequisitos As Boolean
    Public Prerrequisitos2 As Boolean
    Public y As Boolean = False
    Public r As Boolean = False
    Public comp As Integer
    Public i As Integer = 0 'contratos'
    Public idcontrato As Integer 'para pago contratos'
    Public primera As Boolean 'para pago contratos'
    Public segunda As Boolean 'para pago contratos'
    Public MAX As Integer 'ncontrato para detallecontrato (1 y 2)'
    Public dnieval As Integer 'para las evaluaciones'
    Public invoice As New Encabezado()
    'Para uso de Grillas'
    Public ds As New DataSet
    Public adp As Odbc.OdbcDataAdapter
    '-------------------'
    Public Function conexion()
        Try
            CNN = New OdbcConnection("DSN=capacitacion")
            CNN.Open()

        Catch ex As Exception

        End Try
        Return 0
    End Function

    Public Sub Procedure()
        CMD = New OdbcCommand(Sql, CNN)
        CMD.CommandType = CommandType.Text
        RS = CMD.ExecuteReader
        CMD.Dispose()
    End Sub
End Module
