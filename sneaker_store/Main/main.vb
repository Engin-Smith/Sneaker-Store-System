Imports System.Data.SqlClient
Imports Guna.UI2.WinForms.Suite
Imports System.IO

Public Class main

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub m_addproduct_Click(sender As Object, e As EventArgs)
        'With new_products
        '    .TopLevel = False
        '    Panel3.Controls.Add(new_products)
        '    .BringToFront()
        '    .Show()
        'End With
        products.Show()
        Me.Hide()
    End Sub

    Private Sub m_product_Click(sender As Object, e As EventArgs) Handles m_product.Click
        products.Show()
        Me.Hide()
    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        suppliers.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub btn_lounch_Click(sender As Object, e As EventArgs) Handles btn_lounch.Click
        sales_form.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        expenses.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        search_form.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        reporting_form.Show()
        Me.Hide()
    End Sub

    Private Sub btn_addp_Click(sender As Object, e As EventArgs) Handles btn_addp.Click
        Dim add As New add_product
        add.ShowDialog()
    End Sub

    Private Sub btn_adds_Click(sender As Object, e As EventArgs) Handles btn_adds.Click
        Dim add As New addnew_supplier
        add.ShowDialog()
    End Sub

    Private Sub btn_adde_Click(sender As Object, e As EventArgs) Handles btn_adde.Click
        Dim add As New add_cat
        add.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim add As New addnew_brand
        add.ShowDialog()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        totalproduct()
        totalbrand()
        totalsale()

    End Sub
    Sub totalproduct()
        Using cmd As New SqlCommand("SELECT COUNT(*) FROM tbl_product", con)
            con.Open()
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            lb_p.Text = String.Format("{0}", count)
            con.Close()
        End Using
    End Sub
    Sub totalbrand()
        Using cmd As New SqlCommand("SELECT COUNT(*) FROM tbl_brand", con)
            con.Open()
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            lb_brand.Text = String.Format("{0}", count)
            con.Close()
        End Using
    End Sub
    Sub totalsale()
        Using cmd As New SqlCommand("SELECT COUNT(*) FROM tbl_sales", con)
            con.Open()
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            lb_sale.Text = String.Format("{0}", count)
            con.Close()
        End Using
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        totalproduct()
        totalbrand()
        totalsale()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        totalproduct()
        totalbrand()
        totalsale()
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        totalproduct()
        totalbrand()
        totalsale()
    End Sub
End Class