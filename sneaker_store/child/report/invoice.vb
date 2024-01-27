Imports System.Data.SqlClient

Public Class invoice
    'Dim con As SqlConnection = New SqlConnection(" Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123; ")

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Me.Close()
    End Sub
    Dim txtno As sales_form
    Public Sub New(ByRef txtnosear As sales_form)

        ' This call is required by the designer.
        InitializeComponent()
        txtno = txtnosear
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_search.Text = txtno.txt_no.Text
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_sales WHERE no like '%" & txt_search.Text & "%'", con)
        'cmd.Parameters.Add("date1", SqlDbType.DateTime).Value = DateTimePicker1.Value
        'cmd.Parameters.Add("date2", SqlDbType.DateTime).Value = DateTimePicker2.Value
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim cr_report As New reportInvoice
        cr_report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr_report
        CrystalReportViewer1.Zoom(100%)
        CrystalReportViewer1.Refresh()
    End Sub
End Class