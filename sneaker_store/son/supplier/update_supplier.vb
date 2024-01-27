Imports System.Data.SqlClient

Public Class update_supplier

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim cmd As SqlCommand = New SqlCommand("UPDATE tbl_supplier SET s_name=@sname,s_phone=@sphone,s_address=@address WHERE s_id=@sid ", con)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@sid", txt_sid.Text)
        cmd.Parameters.AddWithValue("@sname", txt_sname.Text)
        cmd.Parameters.AddWithValue("@sphone", txt_phone.Text)
        cmd.Parameters.AddWithValue("@address", txt_address.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show(" Update Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_supplier WHERE s_id=@sid", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@sid", txt_sid.Text)
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