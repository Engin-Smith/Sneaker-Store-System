Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.[Shared]
Imports Guna.UI2.WinForms.Suite
Imports Microsoft.VisualBasic.ApplicationServices

Public Class add_product

    Dim cmd As SqlCommand

    Public Sub autoID()

        'Dim myReader As SqlDataReader
        'con = New SqlConnection(" Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123; ")
        'con.Open()
        'Dim temp As String
        'Try
        '    Dim sql As String = "SELECT MAX(ISNULL(p_id,000)) 'p_id' FROM tbl_product "
        '    Dim comm As SqlCommand = New SqlCommand(sql, con)
        '    myReader = comm.ExecuteReader
        '    If myReader.HasRows Then
        '        While myReader.Read()
        '            Dim _Count As Integer
        '            If (IsDBNull(myReader.Item("p_id"))) Then
        '                _Count = 1
        '            Else
        '                _Count = myReader.Item("p_id")
        '            End If
        '            temp = _Count + 1
        '            Me.txt_id.Text = String.Concat(temp)

        '        End While
        '    End If
        '    myReader.Close()
        'Catch ex As Exception
        'End Try
        'con.Close()
        'Dim ConnectionSQLx2 As New SqlConnection
        'Dim commando As SqlCommand
        'ConnectionSQLx2.ConnectionString = "Data Source=DESKTOP-4E8EDUP\SQLEXPRESS;Initial Catalog=db_stock;User ID=sa;Password=123; "
        'If (ConnectionSQLx2.State = ConnectionState.Closed) Then ConnectionSQLx2.Open()


        'Try
        '    commando = New SqlCommand("SELECT MAX(p_id) FROM tbl_product", ConnectionSQLx2)
        '    Dim Dr As SqlDataReader = commando.ExecuteReader
        '    If Dr.Read = True Then

        '        Me.txt_id.Clear()

        '        Me.txt_id.Text = Dr.Item("p_id") + 1
        '    Else
        '        Me.txt_id.Text = "001"
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        con.Open()

        Dim ct As String = "select Max(p_id) as p_id from tbl_product"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        Dim rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("p_id").ToString() <> "" Then
            'txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
            txt_id.Text = Integer.Parse(rdr("p_id").ToString()) + 1
        Else
            txt_id.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub
    Sub textclear()
        txt_id.Text = ""
        cb_cat.Text = ""
        cb_brand.Text = ""
        txt_unit.Text = ""
        txt_bp.Text = ""
        txt_sp.Text = ""
    End Sub
    Private Sub btn_closeP_Click(sender As Object, e As EventArgs) Handles btn_closeP.Click
        Me.Close()
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If (isValid()) Then
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tbl_product (p_id, p_name , p_cat, p_brand, p_unit, p_buyp, p_sellp,pimage)" + "VALUES (@pid, @pname , @pcat, @pbrand, @punit,@pbuyp,@psellp,@pimage) ", con)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@pid", txt_id.Text)
            cmd.Parameters.AddWithValue("@pname", txt_pname.Text)
            cmd.Parameters.AddWithValue("@pcat", cb_cat.SelectedValue)
            cmd.Parameters.AddWithValue("@pbrand", cb_brand.SelectedValue)
            cmd.Parameters.AddWithValue("@punit", txt_unit.Text)
            cmd.Parameters.AddWithValue("@pbuyp", txt_bp.Text)
            cmd.Parameters.AddWithValue("@psellp", txt_sp.Text)
            'code for image
            Dim ms As New MemoryStream()
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim Data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@pimage", SqlDbType.Image)
            p.Value = Data
            cmd.Parameters.Add(p)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            textclear()
            MessageBox.Show(" New Rrcord is successfully saved in the database ", " CURD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        End If


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
        If txt_sp.Text = String.Empty Then
            MessageBox.Show("your Selling Price", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End If
        Return True
    End Function

    Private Sub add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_brand' table. You can move, or remove it, as needed.
        Me.Tbl_brandTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_brand)
        'TODO: This line of code loads data into the 'Db_sneakerDataSet.tbl_category' table. You can move, or remove it, as needed.
        Me.Tbl_categoryTableAdapter.Fill(Me.Db_sneakerDataSet.tbl_category)

        autoID()
        txt_bp.Text = "$"
        txt_sp.Text = "$"

        'loadCombobox()


    End Sub

    Public Sub loadCombobox()
        Try
            Dim cmd As New SqlCommand("select * from tbl_category, tbl_brand", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cb_cat.DataSource = table
            cb_brand.DataSource = table
            cb_cat.DisplayMember = "cat_name"
            cb_brand.DisplayMember = "b_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_brow_Click(sender As Object, e As EventArgs) Handles btn_brow.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Choose a Profile Photo"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                PictureBox1.ImageLocation = fdlg.FileName
            End If

        End If
    End Sub

    Private Sub txt_unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_unit.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
            MessageBox.Show("Sorry Number Only", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txt_bp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bp.KeyPress
        'Dim ch As Char = e.KeyChar
        'If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
        '    e.Handled = True
        '    MessageBox.Show("Sorry Number Only", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txt_sp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sp.KeyPress
        'Dim ch As Char = e.KeyChar
        'If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
        '    e.Handled = True
        '    MessageBox.Show("Sorry Number Only", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub


End Class