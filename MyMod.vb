Imports System.Data.SQLite
Module MyMod
    Public mycommand As New System.Data.SQLite.SQLiteCommand
    Public myadapter As New System.Data.SQLite.SQLiteDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.SQLite.SQLiteDataReader
    Public SQL As String
    Public conn As New System.Data.SQLite.SQLiteConnection
    Public cn As New Connection

    'Tabel Fakultas
    '-------------------------------
    Public fakultas_baru As Boolean
    Public ofakultas As New Fakultas
    '--------------------------------

    Public Sub DBConnect()
        cn.DataSource = "C:\Users\UMC-LN-03\Documents\data freddy\coba.db"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub
End Module
