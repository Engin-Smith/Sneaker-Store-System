Public Class sales
    Private Sub menu_sale_Click(sender As Object, e As EventArgs) Handles menu_sale.Click
        With table_sell
            .TopLevel = False
            Panel1.Controls.Add(table_sell)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub sales_Load(sender As Object, e As EventArgs) Handles Me.Load
        With table_sell
            .TopLevel = False
            Panel1.Controls.Add(table_sell)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub menu_purchase_Click(sender As Object, e As EventArgs) Handles menu_purchase.Click
        With table_purchase
            .TopLevel = False
            Panel1.Controls.Add(table_purchase)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub menu_damagedstock_Click(sender As Object, e As EventArgs) Handles menu_damagedstock.Click
        With table_damagedstock
            .TopLevel = False
            Panel1.Controls.Add(table_damagedstock)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class