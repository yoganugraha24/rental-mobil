Imports System.Data.Odbc
Module Module1
    Public Conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public Rd, Rd1, Rd2 As OdbcDataReader
    Public Cmd As OdbcCommand
    Public Cmd2 As OdbcCommand
    Public Cmd1 As OdbcCommand
    Public ds As DataSet
    Public LokasiData As String
    Sub Koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver};database=dbRental_Mobil;server=localhost;uid=root"
        Conn = New OdbcConnection(LokasiData)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module