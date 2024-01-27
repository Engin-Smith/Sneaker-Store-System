Imports System.Data.SqlClient
Imports System.IO

Public Class table_expense

    Private Sub table_expense_Load(sender As Object, e As EventArgs) Handles Me.Load
        expenserecord()
    End Sub
    Public Sub expenserecord()
        Dim i As Integer
        expensedatagridview.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_expenses ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            expensedatagridview.Rows.Add(i, dr.Item("ex_id").ToString, dr.Item("ex_date").ToString, dr.Item("ex_name").ToString, dr.Item("ex_type").ToString, dr.Item("ex_amount").ToString, dr.Item("ex_desc").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_adds_Click(sender As Object, e As EventArgs) Handles btn_adds.Click
        Dim add As New addnew_expenes
        add.ShowDialog()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        expenserecord()
    End Sub

    Private Sub expensedatagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles expensedatagridview.CellDoubleClick
        Dim form As New update_expense
        form.txt_exid.Text = expensedatagridview.CurrentRow.Cells(1).Value.ToString()
        form.txt_dp.Text = expensedatagridview.CurrentRow.Cells(2).Value.ToString()
        form.txt_exname.Text = expensedatagridview.CurrentRow.Cells(3).Value.ToString()
        form.cb_extype.Text = expensedatagridview.CurrentRow.Cells(4).Value.ToString()
        form.txt_exA.Text = expensedatagridview.CurrentRow.Cells(5).Value
        form.txt_desc.Text = expensedatagridview.CurrentRow.Cells(6).Value.ToString()
        form.ShowDialog()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim i As Integer
        expensedatagridview.Rows.Clear()
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_expenses  WHERE ex_name like '%" & txt_search.Text & "%' ", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                i += 1
                expensedatagridview.Rows.Add(i, dr.Item("ex_id").ToString, dr.Item("ex_date").ToString, dr.Item("ex_name").ToString, dr.Item("ex_type").ToString, dr.Item("ex_amount").ToString, dr.Item("ex_desc").ToString)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class