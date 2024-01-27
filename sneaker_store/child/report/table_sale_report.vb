Imports System.Data.SqlClient

Public Class table_sale_report

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_sales WHERE s_date like '%" & DateTimePicker1.Text & "%'", con)
        'cmd.Parameters.Add("date1", SqlDbType.DateTime).Value = DateTimePicker1.Value
        'cmd.Parameters.Add("date2", SqlDbType.DateTime).Value = DateTimePicker2.Value
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim cr_report As New reportsales
        cr_report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr_report
        CrystalReportViewer1.Zoom(90%)
        CrystalReportViewer1.Refresh()
    End Sub
End Class