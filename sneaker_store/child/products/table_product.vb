Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class table_product

    Private Sub btn_addP_Click(sender As Object, e As EventArgs) Handles btn_addP.Click
        add_product.Show()
    End Sub

    Private Sub table_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        productrecord()
        Me.productdatagridview.Refresh()

    End Sub
    'Public Sub productrecor()
    '    Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product ", con)
    '    Dim dt As DataTable = New DataTable()
    '    con.Open()
    '    Dim sdr As SqlDataReader = cmd.ExecuteReader()
    '    dt.Load(sdr)
    '    con.Close()
    '    productdatagridview.DataSource = dt
    'End Sub
    Public Sub productrecord()
        Dim i As Integer
        productdatagridview.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            productdatagridview.Rows.Add(i, dr.Item("p_id").ToString, dr.Item("p_name").ToString, dr.Item("p_cat").ToString, dr.Item("p_brand").ToString, dr.Item("p_unit").ToString, dr.Item("p_buyp").ToString, dr.Item("p_sellp").ToString, dr.Item("pimage"))
        End While
        dr.Close()
        con.Close()
    End Sub
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        productrecord()
    End Sub
    Private Sub productdatagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles productdatagridview.CellDoubleClick
        Dim form As New update_product
        form.txt_id.Text = productdatagridview.CurrentRow.Cells(1).Value.ToString()
        form.txt_pname.Text = productdatagridview.CurrentRow.Cells(2).Value.ToString()
        form.txt_cat.Text = productdatagridview.CurrentRow.Cells(3).Value.ToString()
        form.txt_brand.Text = productdatagridview.CurrentRow.Cells(4).Value
        form.txt_unit.Text = productdatagridview.CurrentRow.Cells(5).Value.ToString()
        form.txt_bp.Text = productdatagridview.CurrentRow.Cells(6).Value.ToString()
        form.txt_sp.Text = productdatagridview.CurrentRow.Cells(7).Value.ToString()
        'code for image
        Dim data As Byte() = DirectCast(productdatagridview.CurrentRow.Cells(8).Value, Byte())
        Dim ms As New MemoryStream(data)
        form.PictureBox1.Image = Image.FromStream(ms)
        form.ShowDialog()
    End Sub


    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim i As Integer
        productdatagridview.Rows.Clear()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product WHERE p_id like '%" & txt_search.Text & "%' OR p_name like '%" & txt_search.Text & "%'", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                i += 1
                productdatagridview.Rows.Add(i, dr.Item("p_id").ToString, dr.Item("p_name").ToString, dr.Item("p_cat").ToString, dr.Item("p_brand").ToString, dr.Item("p_unit").ToString, dr.Item("p_buyp").ToString, dr.Item("p_sellp").ToString, dr.Item("pimage"))
            End While
            dr.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class