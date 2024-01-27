Public Class reporting_form
    Private Sub menu_brand_Click(sender As Object, e As EventArgs) Handles menu_brand.Click
        With table_stock_report
            .TopLevel = False
            Panel1.Controls.Add(table_stock_report)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub menu_expense_Click(sender As Object, e As EventArgs) Handles menu_expense.Click
        With table_expense_report
            .TopLevel = False
            Panel1.Controls.Add(table_expense_report)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub menu_prod_Click(sender As Object, e As EventArgs) Handles menu_prod.Click
        With table_sale_report
            .TopLevel = False
            Panel1.Controls.Add(table_sale_report)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub reporting_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        With table_sale_report
            .TopLevel = False
            Panel1.Controls.Add(table_sale_report)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class