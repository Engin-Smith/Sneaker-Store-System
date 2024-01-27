Imports System.Data.SqlClient
Imports System.IO

Public Class table_category
    Dim cmd As SqlCommand

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Public Sub categoryrecord()
        Dim i As Integer
        CategoryDataGridView.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_category ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            CategoryDataGridView.Rows.Add(i, dr.Item("cat_id").ToString, dr.Item("cat_name").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_addC_Click(sender As Object, e As EventArgs) Handles btn_addC.Click
        Dim add As New add_cat
        add.ShowDialog()
    End Sub

    Private Sub table_category_Load(sender As Object, e As EventArgs) Handles Me.Load
        categoryrecord()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        categoryrecord()
    End Sub

    Private Sub CategoryDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellDoubleClick
        Dim Formcat As New update_category
        Formcat.txt_cid.Text = CategoryDataGridView.CurrentRow.Cells(1).Value.ToString()
        Formcat.txt_cname.Text = CategoryDataGridView.CurrentRow.Cells(2).Value.ToString()
        Formcat.ShowDialog()
    End Sub

    Private Sub CategoryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellContentClick

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class