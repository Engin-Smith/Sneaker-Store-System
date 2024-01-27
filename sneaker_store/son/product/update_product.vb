Imports System.Data.SqlClient
Imports System.IO

Public Class update_product

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim cmd As SqlCommand = New SqlCommand("UPDATE tbl_product SET p_name=@pname , p_cat=@pcat, p_brand=@pbrand, p_unit=@punit, p_buyp=@pbuyp, p_sellp=@psellp,pimage=@pimage WHERE p_id=@pid ", con)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@pid", txt_id.Text)
        cmd.Parameters.AddWithValue("@pname", txt_pname.Text)
        cmd.Parameters.AddWithValue("@pcat", txt_cat.Text)
        cmd.Parameters.AddWithValue("@pbrand", txt_brand.Text)
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

        MessageBox.Show(" Update Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_closeP_Click(sender As Object, e As EventArgs) Handles btn_closeP.Click
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM tbl_product WHERE p_id=@pid", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@pid", txt_id.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show(" Delete Rrcord is successfully saved in the database ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
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
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub txt_sp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sp.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
End Class