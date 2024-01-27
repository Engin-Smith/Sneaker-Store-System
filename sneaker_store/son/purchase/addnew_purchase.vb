Imports Guna.UI2.WinForms.Suite
Imports System.Data.SqlClient
Imports System.IO

Public Class addnew_purchase
    Dim cmd As SqlCommand

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_purchase (pur_id, p_name , p_cat, p_brand,p_sup, p_unit, p_buy,p_date)" + "VALUES (@pid, @pname , @pcat, @pbrand, @psup, @punit, @pbuy, @pdate) ", con)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@pid", txt_id.Text)
            cmd.Parameters.AddWithValue("@pname", txt_pname.Text)
            cmd.Parameters.AddWithValue("@pcat", cb_cat.SelectedValue)
            cmd.Parameters.AddWithValue("@pbrand", cb_brand.SelectedValue)
            cmd.Parameters.AddWithValue("@psup", cb_supplier.SelectedValue)
            cmd.Parameters.AddWithValue("@punit", txt_unit.Text)
            cmd.Parameters.AddWithValue("@pbuy", txt_bp.Text)
            cmd.Parameters.AddWithValue("@pdate", datepicker.Text)



            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If
    End Sub
    Public Sub autoId()
        con.Open()

        Dim ct As String = "select Max(pur_id) as pur_id from tbl_purchase"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("pur_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_id.Text = Integer.Parse(rdr("pur_id").ToString()) + 1
        Else
            txt_id.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub
    Private Sub addnew_purchase_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_supplier' table. You can move, or remove it, as needed.
        Me.Tbl_supplierTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_supplier)
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_brand' table. You can move, or remove it, as needed.
        Me.Tbl_brandTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_brand)
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_category' table. You can move, or remove it, as needed.
        Me.Tbl_categoryTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_category)


        autoId()
        'loadCombobox()
    End Sub
    Public Sub loadCombobox()
        Try
            Dim cmd As New SqlCommand("select * from tbl_category, tbl_brand, tbl_supplier", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cb_cat.DataSource = table
            cb_brand.DataSource = table
            cb_supplier.DataSource = table
            cb_cat.DisplayMember = "cat_name"
            cb_brand.DisplayMember = "b_name"
            cb_supplier.DisplayMember = "s_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function isValid() As Boolean
        'Throw New NotImplementedException()
        If txt_pname.Text = String.Empty Then
            MessageBox.Show("you name of the product", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If cb_cat.Text = String.Empty Then
            MessageBox.Show("your category", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If cb_brand.Text = String.Empty Then
            MessageBox.Show("your Brand", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If txt_unit.Text = String.Empty Then
            MessageBox.Show("your Unit", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        If txt_bp.Text = String.Empty Then
            MessageBox.Show("your Product Price", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If

        Return True
    End Function

    Private Sub datepicker_ValueChanged(sender As Object, e As EventArgs) Handles datepicker.ValueChanged

    End Sub

    Private Sub txt_unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_unit.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
            MessageBox.Show("Sorry Number Only", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txt_bp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bp.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
            MessageBox.Show("Sorry Prices Only", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class