Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.EtudiantTableAdapter.Fill(Me.BasegestionfeDataSet.Etudiant)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c = New Connexion
        Dim _Cnn = c.connect()
        Dim supp = New GestiondesPFE.Dal_Etudiant
        If supp.DeleteEtudiant(TextBox1.Text) Then
            MsgBox("etudiant supprimé avec succes", vbOK)
        Else : MsgBox("erreur lors de la suppression")
        End If
    End Sub
End Class