Imports System.Data.SqlClient

Public Class addnew_brand
    Dim cmd As SqlCommand

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_brand (b_id, b_name )" + "VALUES (@bid, @bname ) ", con)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@bid", txt_bid.Text)
            cmd.Parameters.AddWithValue("@bname", txt_bname.Text)


            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If
    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If txt_bname.Text = String.Empty Then
            MessageBox.Show("you name of the brand", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Return True
    End Function

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Public Sub autoId()
        con.Open()

        Dim ct As String = "select Max(b_id) as b_id from tbl_brand"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("b_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_bid.Text = Integer.Parse(rdr("b_id").ToString()) + 1
        Else
            txt_bid.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub addnew_brand_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoId()

    End Sub
    Public Sub cleartext()
        txt_bid.Text = ""
        txt_bname.Text = ""
    End Sub
End Class