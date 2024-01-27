Imports System.Data.SqlClient

Public Class addnew_extype
    Dim cmd As SqlCommand
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_extype (ex_id, ex_name )" + "VALUES (@xtid, @xtname ) ", con)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@xtid", txt_xtid.Text)
            cmd.Parameters.AddWithValue("@xtname", txt_xtname.Text)


            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If
    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If txt_xtname.Text = String.Empty Then
            MessageBox.Show("you name of the product", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Return True
    End Function

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub addnew_extype_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoId()
    End Sub
    Public Sub autoId()
        con.Open()

        Dim ct As String = "select Max(ex_id) as ex_id from tbl_extype"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("ex_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_xtid.Text = Integer.Parse(rdr("ex_id").ToString()) + 1
        Else
            txt_xtid.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub
End Class