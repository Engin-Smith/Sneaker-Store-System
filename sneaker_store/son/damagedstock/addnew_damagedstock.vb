Imports System.Data.SqlClient
Imports System.IO

Public Class addnew_damagedstock
    Dim cmd As SqlCommand

    Public Sub productrecord()
        Dim i As Integer
        ProductDataGridView1.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            ProductDataGridView1.Rows.Add(i, dr.Item("p_id").ToString, dr.Item("p_name").ToString, dr.Item("p_unit").ToString, dr.Item("p_sellp").ToString, dr.Item("pimage"))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub addnew_damagedstock_Load(sender As Object, e As EventArgs) Handles Me.Load
        'txt_search.Text = "Search Your Product"
        productrecord()
        autoId()
    End Sub
    Public Sub autoId()
        con.Open()

        Dim ct As String = "select Max(d_id) as d_id from tbl_damaged"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("d_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_did.Text = Integer.Parse(rdr("d_id").ToString()) + 1
        Else
            txt_did.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub ProductDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView1.CellContentClick
        Dim form As New Integer
        txt_id.Text = ProductDataGridView1.CurrentRow.Cells(1).Value.ToString()
        txt_pname.Text = ProductDataGridView1.CurrentRow.Cells(2).Value.ToString()
        txt_unit.Text = ProductDataGridView1.CurrentRow.Cells(3).Value.ToString()
        txt_sellp.Text = ProductDataGridView1.CurrentRow.Cells(4).Value.ToString()
        'code for image
        Dim data As Byte() = DirectCast(ProductDataGridView1.CurrentRow.Cells(5).Value, Byte())
        Dim ms As New MemoryStream(data)
        PictureBox1.Image = Image.FromStream(ms)
        'form.ShowDialog()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_damaged (d_id, p_id, p_name , unit, sellp)" + "VALUES (@did, @pid, @pname , @unit, @sellp) ", con)
            cmd.CommandType = CommandType.Text


            cmd.Parameters.AddWithValue("@pid", txt_id.Text)
            cmd.Parameters.AddWithValue("@pname", txt_pname.Text)
            cmd.Parameters.AddWithValue("@unit", txt_u.Text)
            cmd.Parameters.AddWithValue("@sellp", txt_sellp.Text)
            cmd.Parameters.AddWithValue("@did", txt_did.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If

    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If txt_pname.Text = String.Empty Then
            MessageBox.Show("you name of the product", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If txt_u.Text = String.Empty Then
            MessageBox.Show("your category", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If txt_sellp.Text = String.Empty Then
            MessageBox.Show("your Brand", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Return True
    End Function

End Class