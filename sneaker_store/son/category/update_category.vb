Imports Guna.UI2.WinForms.Suite
Imports System.Data.SqlClient
Imports System.IO

Public Class update_category

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim cmd As SqlCommand = New SqlCommand("UPDATE tbl_category SET cat_name=@catname WHERE cat_id=@catid ", con)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@catid", txt_cid.Text)
        cmd.Parameters.AddWithValue("@catname", txt_cname.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show(" Update Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_category WHERE cat_id=@catid", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@catid", txt_cid.Text)
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
        txt_cid.Text = ""
        txt_cname.Text = ""
    End Sub

    Private Sub update_category_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class