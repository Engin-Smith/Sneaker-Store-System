Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms.Suite

Public Class sales_form
    Dim table As New DataTable("table")
    Dim cmd As New SqlCommand
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        'txt_search.Text = ""
        productrecord()
    End Sub

    Private Sub sales_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_search.Text = "Search Your Product"
        txt_search.Focus()
        productrecord()
        autoId()
        autoNO()

        'If cb_qty.Text = "" Or txt_sprice.Text = "" Then
        'Else
        '    Dim num13 As Double = txt_sprice.Text
        '    Dim num14 As Double = cb_qty.Text
        '    Dim ans As Double = num13 * num14
        '    txt_total.Text = ans
        'End If
        'If cb_qty.Text = "" Then
        '    txt_total.Text = ""
        '    txt_sprice.Text = ""
        'Else
        'End If


    End Sub
    Public Sub autoNO()
        con.Open()

        Dim ct As String = "select Max(no) as no from tbl_sales"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("no").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_no.Text = Integer.Parse(rdr("no").ToString()) + 1
        Else
            txt_no.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub
    Public Sub autoId()
        con.Open()

        Dim ct As String = "select Max(s_id) as s_id from tbl_sales"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("s_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_id.Text = Integer.Parse(rdr("s_id").ToString()) + 1
        Else
            txt_id.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    Public Sub updatestock()

    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        txt_search.Text = ""
    End Sub
    Public Sub productrecord()
        Dim i As Integer
        productDataGridView1.Rows.Clear()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(" SELECT*FROM tbl_product WHERE p_id like '%" & txt_search.Text & "%' OR p_name like '%" & txt_search.Text & "%' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            i += 1
            productDataGridView1.Rows.Add(dr.Item("p_name").ToString, dr.Item("p_unit").ToString, dr.Item("p_sellp").ToString, dr.Item("pimage"))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        main.Show()
        Me.Hide()
        basketDataGridView1.Rows.Clear()
        txt_no.Refresh()
        txt_displaytotal.Clear()
        cb_qty.SelectedIndex.ToString()
        txt_pname.Clear()
        txt_sprice.Clear()
        PictureBox1.Image = Nothing
        autoId()
        autoNO()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub productDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productDataGridView1.CellContentClick
        Dim form As New Integer
        txt_pname.Text = productDataGridView1.CurrentRow.Cells(0).Value.ToString()
        txt_sprice.Text = productDataGridView1.CurrentRow.Cells(2).Value.ToString()
        'code for image
        Dim data As Byte() = DirectCast(productDataGridView1.CurrentRow.Cells(3).Value, Byte())
        Dim ms As New MemoryStream(data)
        PictureBox1.Image = System.Drawing.Image.FromStream(ms)
        'form.ShowDialog()
    End Sub

    Private Sub btn_addbasket_Click(sender As Object, e As EventArgs) Handles btn_addbasket.Click
        updatestock()
        basketDataGridView1.Rows.Add(txt_pname.Text, cb_qty.Text, txt_sprice.Text, txt_total.Text)
        'Me.txt_displaytotal.Text = txt_total.Text
        'sum rows -----------------------
        Dim colsum As Decimal
        'For Each r As DataGridView In basketDataGridView1.Rows
        '    colsum += r.Cells(4).value

        'Next
        For i = 0 To basketDataGridView1.Rows.Count - 1
            colsum += basketDataGridView1.Rows(i).Cells(3).Value
        Next
        txt_displaytotal.Text = (FormatCurrency(colsum))

        'add to data bases
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_sales (s_id, s_date , s_pname, s_sellp, s_qty, s_total, no)" + "VALUES (@sid, @sdate , @sname,@sellp, @qty, @total,@no) ", con)
            cmd.CommandType = CommandType.Text


            cmd.Parameters.AddWithValue("@sid", txt_id.Text)
            cmd.Parameters.AddWithValue("@sdate", txt_date.Text)
            cmd.Parameters.AddWithValue("@sname", txt_pname.Text)
            cmd.Parameters.AddWithValue("@sellp", txt_sprice.Text)
            cmd.Parameters.AddWithValue("@qty", cb_qty.SelectedItem)
            cmd.Parameters.AddWithValue("@total", txt_total.Text)
            cmd.Parameters.AddWithValue("@no", txt_no.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            'MessageBox.Show(" Please Click OK ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        autoId()
        'If (isValid()) Then
        '    Dim cmd As SqlCommand = New SqlCommand("UPDATE tbl_supplier SET s_name=@sname WHERE s_id=@sid  ", con)
        '    cmd.CommandType = CommandType.Text


        '    cmd.Parameters.AddWithValue("@sid", txt_id.Text)
        '    cmd.Parameters.AddWithValue("@sdate", txt_date.Text)
        '    cmd.Parameters.AddWithValue("@sname", txt_pname.Text)
        '    cmd.Parameters.AddWithValue("@sellp", txt_sprice.Text)
        '    cmd.Parameters.AddWithValue("@qty", cb_qty.SelectedItem)
        '    cmd.Parameters.AddWithValue("@total", txt_total.Text)
        '    cmd.Parameters.AddWithValue("@no", txt_no.Text)
        '    con.Open()
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        'End If

    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If cb_qty.Text = String.Empty Then
            MessageBox.Show("you name of the product", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If

        Return True
    End Function


    Private Sub cb_qty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_qty.SelectedIndexChanged
        If cb_qty.Text = "" Or txt_sprice.Text = "" Then
        Else
            Dim num21 As Double = cb_qty.Text
            Dim num22 As Decimal = txt_sprice.Text
            Dim ans As Decimal = num21 * num22
            txt_total.Text = (FormatCurrency(ans))
            'TextBox3.Text = Format(Val(TextBox3.Text), "0.0000")
        End If
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        Me.txt_id.Refresh()
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        MessageBox.Show(" We'll print the recreipt to Customer ", " King Smith ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim form As New invoice(Me)
        form.ShowDialog()

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim form As New invoice(Me)
        form.ShowDialog()
    End Sub

    Private Sub btn_concel_Click(sender As Object, e As EventArgs) Handles btn_concel.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_sales WHERE s_id=@sid", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@sid", txt_no.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show(" Concel For Everything That's OK ", " Concaling", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.Close()
        basketDataGridView1.Rows.Clear()
        txt_no.Refresh()
        txt_displaytotal.Clear()
        cb_qty.SelectedIndex.ToString()
        txt_pname.Clear()
        txt_sprice.Clear()
        PictureBox1.Image = Nothing
        autoId()
        autoNO()

    End Sub

    Private Sub txt_displaytotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_displaytotal.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
End Class