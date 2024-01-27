Imports System.Data.SqlClient

Public Class table_supplier

    Public Sub supplierrecord()
        Dim i As Integer
        supplierdatagridview.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_supplier WHERE s_id like '%" & txt_search.Text & "%' OR s_name like '%" & txt_search.Text & "%' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            supplierdatagridview.Rows.Add(i, dr.Item("s_id").ToString, dr.Item("s_name").ToString, dr.Item("s_phone").ToString, dr.Item("s_address").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub table_supplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        supplierrecord()
    End Sub

    Private Sub btn_adds_Click(sender As Object, e As EventArgs) Handles btn_adds.Click
        Dim add As New addnew_supplier
        add.ShowDialog()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        supplierrecord()
    End Sub

    Private Sub supplierdatagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplierdatagridview.CellDoubleClick
        Dim Form As New update_supplier
        Form.txt_sid.Text = supplierdatagridview.CurrentRow.Cells(1).Value.ToString()
        Form.txt_sname.Text = supplierdatagridview.CurrentRow.Cells(2).Value.ToString()
        Form.txt_phone.Text = supplierdatagridview.CurrentRow.Cells(3).Value.ToString()
        Form.txt_address.Text = supplierdatagridview.CurrentRow.Cells(4).Value.ToString()
        Form.ShowDialog()
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub supplierdatagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplierdatagridview.CellContentClick

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        supplierrecord()
    End Sub
End Class