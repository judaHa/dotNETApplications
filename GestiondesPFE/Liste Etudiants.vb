Public Class Liste_Etudiants

    Private Sub Liste_Etudiants_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EtudiantTableAdapter.Fill(Me.BasegestionfeDataSet.Etudiant)

    End Sub
End Class