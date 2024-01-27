Imports System.Data.SqlClient

Public Class addnew_expenes
    Dim cmd As SqlCommand
    Private Sub addnew_expenes_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_extype' table. You can move, or remove it, as needed.
        Me.Tbl_extypeTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_extype)
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_extype' table. You can move, or remove it, as needed.
        Me.Tbl_extypeTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_extype)



        autoId()
        'loadCombobox()
    End Sub
    Public Sub loadCombobox()
        Try
            Dim cmd As New SqlCommand("select * from tbl_extype", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cb_extype.DataSource = table
            cb_extype.DisplayMember = "cat_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub autoId()
        con.Open()

        Dim ct As String = "select Max(ex_id) as ex_id from tbl_expenses"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("ex_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_exid.Text = Integer.Parse(rdr("ex_id").ToString()) + 1
        Else
            txt_exid.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_expenses (ex_id, ex_name, ex_type, ex_amount, ex_desc, ex_date )" + "VALUES (@exid, @exname,@extype,@examount,@exdesc,@exdate ) ", con)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@exid", txt_exid.Text)
            cmd.Parameters.AddWithValue("@exname", txt_exname.Text)
            cmd.Parameters.AddWithValue("@extype", cb_extype.SelectedValue)
            cmd.Parameters.AddWithValue("@examount", txt_exA.Text)
            cmd.Parameters.AddWithValue("@exdesc", txt_desc.Text)
            cmd.Parameters.AddWithValue("@exdate", txt_dp.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If
    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If txt_exname.Text = String.Empty Then
            MessageBox.Show("you name of the product", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Return True
    End Function

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub txt_exA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_exA.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
            MessageBox.Show("Sorry Prices Only", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class