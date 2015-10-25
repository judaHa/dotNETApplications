Partial Class basegestionfeDataSet
    Partial Class EtudiantDataTable

        Private Sub EtudiantDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.filiereColumn.ColumnName) Then
                'Ajoutez le code utilisateur ici
            End If

        End Sub

    End Class

End Class
