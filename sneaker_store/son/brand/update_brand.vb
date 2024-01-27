Imports System.Data.SqlClient

Public Class update_brand

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim cmd As SqlCommand = New SqlCommand("UPDATE tbl_brand SET b_name=@bname WHERE b_id=@bid ", con)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@bid", txt_bid.Text)
        cmd.Parameters.AddWithValue("@bname", txt_bname.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show(" Update Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_brand WHERE b_id=@bid", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@bid", txt_bid.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show(" Delete Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Public Sub cleartext()
        txt_bid.Text = ""
        txt_bname.Text = ""
    End Sub

    Private Sub update_brand_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class