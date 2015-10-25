Public Class Liste_Encadreurs

    Private Sub Liste_Encadreurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Encadreur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EncadreurTableAdapter.Fill(Me.BasegestionfeDataSet.Encadreur)
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Encadreur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.EncadreurTableAdapter.Fill(Me.BasegestionfeDataSet.Encadreur)

    End Sub
End Class