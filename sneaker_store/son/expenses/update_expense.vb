Imports System.Data.SqlClient

Public Class update_expense

    Private Sub update_expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_extype' table. You can move, or remove it, as needed.
        Me.Tbl_extypeTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_extype)

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim cmd As SqlCommand = New SqlCommand("UPDATE tbl_expenses SET ex_name=@exname,ex_type=@extype,ex_amount=@examount,ex_desc=@exdesc WHERE ex_id ", con)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@exid", txt_exid.Text)
        cmd.Parameters.AddWithValue("@exname", txt_exname.Text)
        cmd.Parameters.AddWithValue("@extype", cb_extype.Text)
        cmd.Parameters.AddWithValue("@examount", txt_exA.Text)
        cmd.Parameters.AddWithValue("@exdesc", txt_desc.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show(" Update Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_expenses WHERE ex_id=@id", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id", txt_exid.Text)
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