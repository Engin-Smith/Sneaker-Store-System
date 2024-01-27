Imports System.Data.SqlClient

Public Class IDGenerator
    Private Shared nextID As Integer

    Public Shared Function GenerateID(prefix As String) As String
        Dim id As String = prefix & nextID.ToString().PadLeft(4, "0")
        nextID += 1
        Return id
    End Function
End Class
