Imports System.Data.SqlClient

Public Class table_expense_report
    'Dim con As SqlConnection = New SqlConnection(" Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123; ")

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_expenses WHERE ex_date like '%" & DateTimePicker1.Text & "%'", con)
        'cmd.Parameters.Add("date1", SqlDbType.DateTime).Value = DateTimePicker1.Value
        'cmd.Parameters.Add("date2", SqlDbType.DateTime).Value = DateTimePicker2.Value
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim cr_report As New reportexpense
        cr_report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr_report
        CrystalReportViewer1.Zoom(90%)
        CrystalReportViewer1.Refresh()
    End Sub
End Class