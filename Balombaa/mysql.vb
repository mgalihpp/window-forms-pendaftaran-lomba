﻿Imports System.Data.Odbc
Module mysql
    Public Conn As New OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=lomba;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module