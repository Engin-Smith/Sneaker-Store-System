Imports System.Data.SqlClient
Imports CrystalDecisions.Windows.Forms
Imports Guna.UI2.WinForms.Suite

Public Class table_stock_report

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product ", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim cr_report As New reportstock
        cr_report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr_report
        CrystalReportViewer1.Zoom(90%)
        CrystalReportViewer1.Refresh()
    End Sub
End Class