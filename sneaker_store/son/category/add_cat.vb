Imports System.Data.SqlClient

Public Class add_cat
    Dim cmd As SqlCommand

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_category (cat_id, cat_name )" + "VALUES (@catid, @catname ) ", con)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@catid", txt_cid.Text)
            cmd.Parameters.AddWithValue("@catname", txt_cname.Text)


            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If

    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If txt_cname.Text = String.Empty Then
            MessageBox.Show("you name of the product", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Return True
    End Function


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Public Sub autoId()
        con.Open()

        Dim ct As String = "select Max(cat_id) as cat_id from tbl_category"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("cat_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_cid.Text = Integer.Parse(rdr("cat_id").ToString()) + 1
        Else
            txt_cid.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub add_cat_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoId()

    End Sub
    Public Sub cleartext()
        txt_cid.Text = ""
        txt_cname.Text = ""
    End Sub
End Class