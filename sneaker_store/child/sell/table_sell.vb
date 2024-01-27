Imports System.Data.SqlClient

Public Class table_sell
    'Dim con As SqlConnection = New SqlConnection(" Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123; ")

    Private Sub table_sell_Load(sender As Object, e As EventArgs) Handles Me.Load
        sellrecord()
    End Sub
    Public Sub sellrecord()
        Dim i As Integer
        selldatagridview.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_sales WHERE s_pname like '%" & txt_search.Text & "%'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            selldatagridview.Rows.Add(i, dr.Item("s_date").ToString, dr.Item("s_pname").ToString, dr.Item("s_sellp").ToString, dr.Item("s_qty").ToString, dr.Item("s_total").ToString, dr.Item("s_id").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub
    Private Sub txt_search_TextChanged_1(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        sellrecord()
    End Sub

    Private Sub selldatagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles selldatagridview.CellDoubleClick
        Dim Formcat As New sellupdate
        Formcat.txt_sid.Text = selldatagridview.CurrentRow.Cells(6).Value.ToString()
        Formcat.txt_pdate.Text = selldatagridview.CurrentRow.Cells(1).Value.ToString()
        Formcat.txt_sname.Text = selldatagridview.CurrentRow.Cells(2).Value.ToString()
        Formcat.txt_qty.Text = selldatagridview.CurrentRow.Cells(4).Value.ToString()
        Formcat.txt_total.Text = selldatagridview.CurrentRow.Cells(5).Value.ToString()
        Formcat.ShowDialog()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        sellrecord()
    End Sub
End Class