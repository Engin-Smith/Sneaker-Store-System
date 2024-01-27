Public Class suppliers
    Private Sub suppliers_Load(sender As Object, e As EventArgs) Handles Me.Load
        With table_supplier
            .TopLevel = False
            Panel1.Controls.Add(table_supplier)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        main.Show()
        Me.Hide()
    End Sub
End Class