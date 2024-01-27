Imports System.Data.OleDb
Imports System.Data.SqlClient
Module DBConnection
    'Public Function GetConnection() As SqlConnection
    '    Dim connectionString As String = "Data Source=DESKTOP-OI0S5QD\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123;" ' Replace with your actual connection string
    '    Return New SqlConnection(connectionString)
    'End Function
    'Friend conString As String
    'Public dr As OleDbDataReader

    'Sub Main()
    '    Dim sGlobalConnectionString As New OleDb.OleDbConnection
    '    Dim sDataserver As String
    '    Dim sDatabaseName As String
    '    Dim sDatabaseConnection As String

    '    sDataserver = "localhost"
    '    sDatabaseName = "employee"
    '    sDatabaseConnection = "Driver={MariaDB ODBC 3.1 Driver}; SERVER=" & sDataserver & "; UID=root;PWD=******; Database=" & sDatabaseName & "; PORT=3307; OPTION=3"
    '    sGlobalConnectionString = New OleDb.OleDbConnection(conString)
    'End Sub

    Dim connectionstring As String = "Server=DESKTOP-UOR27U4\SQLEXPRESS;Database=db_sneaker;UID=sa;PWD=123"
    Public con As New SqlConnection(connectionstring)
    Public cnn As New SqlCommand
End Module
