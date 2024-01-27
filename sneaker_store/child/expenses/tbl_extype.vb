Imports System.Data.SqlClient

Public Class tbl_extype

    Private Sub tbl_extype_Load(sender As Object, e As EventArgs) Handles Me.Load
        xtrecord()
    End Sub
    Public Sub xtrecord()
        Dim i As Integer
        extypedatagridview.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_extype WHERE ex_name like '%" & txt_search.Text & "%'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            extypedatagridview.Rows.Add(i, dr.Item("ex_name").ToString, dr.Item("ex_id").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        xtrecord()
    End Sub

    Private Sub btn_adds_Click(sender As Object, e As EventArgs) Handles btn_adds.Click
        Dim add As New addnew_extype
        add.ShowDialog()
    End Sub

    Private Sub extypedatagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles extypedatagridview.CellDoubleClick
        Dim form As New update_extype
        form.txt_xtid.Text = extypedatagridview.CurrentRow.Cells(2).Value.ToString()
        form.txt_xtname.Text = extypedatagridview.CurrentRow.Cells(1).Value.ToString()
        form.ShowDialog()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        xtrecord()
    End Sub
End Class