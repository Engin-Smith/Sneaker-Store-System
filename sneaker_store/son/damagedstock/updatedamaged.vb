﻿Imports System.Data.SqlClient

Public Class updatedamaged
    Dim cmd As SqlCommand

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_damaged WHERE d_id = @id", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id", txt_did.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show(" Delete Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class