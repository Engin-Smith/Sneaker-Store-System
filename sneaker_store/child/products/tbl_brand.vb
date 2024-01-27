Imports System.Data.SqlClient

Public Class tbl_brand

    Private Sub btn_addb_Click(sender As Object, e As EventArgs) Handles btn_addb.Click
        Dim add As New addnew_brand
        add.ShowDialog()
    End Sub
    Public Sub brandrecord()
        Dim i As Integer
        BrandDataGridView.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_brand ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            BrandDataGridView.Rows.Add(i, dr.Item("b_id").ToString, dr.Item("b_name").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub tbl_brand_Load(sender As Object, e As EventArgs) Handles Me.Load
        brandrecord()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        brandrecord()
    End Sub

    Private Sub BrandDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BrandDataGridView.CellDoubleClick
        Dim Form As New update_brand
        Form.txt_bid.Text = BrandDataGridView.CurrentRow.Cells(1).Value.ToString()
        Form.txt_bname.Text = BrandDataGridView.CurrentRow.Cells(2).Value.ToString()
        Form.ShowDialog()
    End Sub
End Class