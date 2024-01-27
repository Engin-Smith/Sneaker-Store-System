Imports System.Data.SqlClient
Imports Guna.UI2.WinForms.Suite
Imports System.IO

Public Class search_form

    Private Sub search_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        searchtable()
    End Sub
    Public Sub searchtable()
        Dim i As Integer
        searchDataGridView1.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            searchDataGridView1.Rows.Add(i, dr.Item("p_id").ToString, dr.Item("p_name").ToString, dr.Item("p_cat").ToString, dr.Item("p_brand").ToString, dr.Item("p_unit").ToString, dr.Item("p_buyp").ToString, dr.Item("p_sellp").ToString, dr.Item("pimage"))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim i As Integer
        searchDataGridView1.Rows.Clear()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product WHERE p_id like '%" & txt_search.Text & "%' OR p_name like '%" & txt_search.Text & "%'", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                i += 1
                searchDataGridView1.Rows.Add(i, dr.Item("p_id").ToString, dr.Item("p_name").ToString, dr.Item("p_cat").ToString, dr.Item("p_brand").ToString, dr.Item("p_unit").ToString, dr.Item("p_buyp").ToString, dr.Item("p_sellp").ToString, dr.Item("pimage"))
            End While
            dr.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        main.Show()
        Me.Close()
    End Sub



    Private Sub searchDataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataGridView1.CellContentClick
        'Dim form As New 
        txt_id.Text = searchDataGridView1.CurrentRow.Cells(1).Value.ToString()
        txt_name.Text = searchDataGridView1.CurrentRow.Cells(2).Value.ToString()
        txt_cat.Text = searchDataGridView1.CurrentRow.Cells(3).Value.ToString()
        txt_brand.Text = searchDataGridView1.CurrentRow.Cells(4).Value
        txt_unit.Text = searchDataGridView1.CurrentRow.Cells(5).Value.ToString()
        txt_buy.Text = searchDataGridView1.CurrentRow.Cells(6).Value.ToString()
        txt_sell.Text = searchDataGridView1.CurrentRow.Cells(7).Value.ToString()
        'code for image
        Dim data As Byte() = DirectCast(searchDataGridView1.CurrentRow.Cells(8).Value, Byte())
        Dim ms As New MemoryStream(data)
        PictureBox1.Image = Image.FromStream(ms)
        TransfarantPictureBox1.Image = Image.FromStream(ms)
        'Form.ShowDialog()
    End Sub
End Class