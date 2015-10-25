Public Class Liste_Projets

    Private Sub Liste_Projets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Projet'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ProjetTableAdapter.Fill(Me.BasegestionfeDataSet.Projet)
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Projet'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.ProjetTableAdapter.Fill(Me.BasegestionfeDataSet.Projet)

    End Sub
End Class