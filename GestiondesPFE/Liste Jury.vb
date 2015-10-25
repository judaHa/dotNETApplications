Public Class Liste_Jury

    Private Sub Liste_Jury_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Jury'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.JuryTableAdapter.Fill(Me.BasegestionfeDataSet.Jury)
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Jury'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.JuryTableAdapter.Fill(Me.BasegestionfeDataSet.Jury)

    End Sub
End Class