Imports System.Data.SqlClient

Public Class table_damagedstock
    'Dim con As SqlConnection = New SqlConnection(" Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123; ")

    Private Sub btn_addm_Click(sender As Object, e As EventArgs) Handles btn_addm.Click
        Dim add As New addnew_damagedstock
        add.ShowDialog()
    End Sub
    Public Sub productrecord()
        Dim i As Integer
        damageddatagridview.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_damaged WHERE p_name like '%" & txt_search.Text & "%'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            damageddatagridview.Rows.Add(i, dr.Item("p_name").ToString, dr.Item("unit").ToString, dr.Item("sellp").ToString, dr.Item("d_id").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub table_damagedstock_Load(sender As Object, e As EventArgs) Handles Me.Load
        productrecord()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        productrecord()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        productrecord()
    End Sub

    Private Sub productdatagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles damageddatagridview.CellDoubleClick
        Dim Formcat As New updatedamaged
        Formcat.txt_did.Text = damageddatagridview.CurrentRow.Cells(4).Value.ToString()
        Formcat.txt_dname.Text = damageddatagridview.CurrentRow.Cells(1).Value.ToString()
        Formcat.ShowDialog()
    End Sub
End Class