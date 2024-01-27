Public Class products
    Public Shared Property selectedrow As Object

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub menu_cat_Click_1(sender As Object, e As EventArgs) Handles menu_cat.Click
        With table_category
            .TopLevel = False
            Panel1.Controls.Add(table_category)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub menu_prod_Click(sender As Object, e As EventArgs) Handles menu_prod.Click
        With table_product
            .TopLevel = False
            Panel1.Controls.Add(table_product)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_addP_Click_1(sender As Object, e As EventArgs)
        add_product.Show()
    End Sub
    Private Sub products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With table_product
            .TopLevel = False
            Panel1.Controls.Add(table_product)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub productdatagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub menu_brand_Click(sender As Object, e As EventArgs) Handles menu_brand.Click
        With tbl_brand
            .TopLevel = False
            Panel1.Controls.Add(tbl_brand)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class