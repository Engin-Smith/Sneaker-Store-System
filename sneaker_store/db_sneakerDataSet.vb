Partial Class db_sneakerDataSet
    Partial Public Class tbl_productDataTable
        Private Sub tbl_productDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.p_brandColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
