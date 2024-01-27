Imports System.Data.SqlClient

Public Class purchaseUpdate
    Dim cmd As SqlCommand

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_purchase WHERE pur_id=@pid", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@pid", txt_pid.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show(" Delete Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txt_pname_TextChanged(sender As Object, e As EventArgs) Handles txt_pname.TextChanged

    End Sub

    Private Sub txt_pid_TextChanged(sender As Object, e As EventArgs) Handles txt_pid.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel7.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class