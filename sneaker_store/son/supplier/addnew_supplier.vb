Imports System.Data.SqlClient

Public Class addnew_supplier
    Dim cmd As SqlCommand

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_supplier (s_id, s_name, s_phone, s_address )" + "VALUES (@sid, @sname, @sphone, @saddress ) ", con)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@sid", txt_sid.Text)
            cmd.Parameters.AddWithValue("@sname", txt_sname.Text)
            cmd.Parameters.AddWithValue("@sphone", txt_phone.Text)
            cmd.Parameters.AddWithValue("@saddress", txt_address.Text)


            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If
    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If txt_sname.Text = String.Empty Then
            MessageBox.Show("you name of the brand", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If txt_phone.Text = String.Empty Then
            MessageBox.Show("you name of the brand", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If txt_address.Text = String.Empty Then
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

        Dim ct As String = "select Max(s_id) as s_id from tbl_supplier"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("s_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_sid.Text = Integer.Parse(rdr("s_id").ToString()) + 1
        Else
            txt_sid.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub
    Private Sub addnew_supplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoId()
    End Sub
End Class