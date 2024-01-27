Imports System.Data.SqlClient

Public Class table_purchase
    'Dim con As SqlConnection = New SqlConnection(" Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123; ")

    Private Sub btn_addP_Click(sender As Object, e As EventArgs) Handles btn_addP.Click
        Dim add As New addnew_purchase
        add.ShowDialog()
    End Sub

    Private Sub table_purchase_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
        productrecord()
    End Sub
    Public Sub productrecord()
        Dim i As Integer
        purchasedatagridview.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_purchase WHERE p_name like '%" & txt_search.Text & "%'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            purchasedatagridview.Rows.Add(i, dr.Item("p_date").ToString, dr.Item("p_name").ToString, dr.Item("p_cat").ToString, dr.Item("p_brand").ToString, dr.Item("p_sup").ToString, dr.Item("p_unit").ToString, dr.Item("p_buy").ToString, dr.Item("pur_id").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        productrecord()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        productrecord()
    End Sub

    Private Sub purchasedatagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles purchasedatagridview.CellDoubleClick
        Dim Formcat As New purchaseUpdate
        Formcat.txt_pid.Text = purchasedatagridview.CurrentRow.Cells(8).Value.ToString()
        Formcat.txt_pname.Text = purchasedatagridview.CurrentRow.Cells(2).Value.ToString()
        Formcat.ShowDialog()
    End Sub
End Class