Public Class expenses
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub expenses_Load(sender As Object, e As EventArgs) Handles Me.Load
        With tbl_extype
            .TopLevel = False
            Panel1.Controls.Add(tbl_extype)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub menu_extype_Click(sender As Object, e As EventArgs) Handles menu_extype.Click
        With tbl_extype
            .TopLevel = False
            Panel1.Controls.Add(tbl_extype)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub menu_brand_Click(sender As Object, e As EventArgs) Handles menu_brand.Click
        With table_expense
            .TopLevel = False
            Panel1.Controls.Add(table_expense)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class