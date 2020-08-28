Partial Class reportDataSet
    Partial Class printticketDataTable

        Private Sub printticketDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BusnoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
