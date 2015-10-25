Imports GestiondesPFE
Public Class AjoutEtudiant

    Private Sub AjoutEtudiant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Encadreur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EncadreurTableAdapter.Fill(Me.BasegestionfeDataSet.Encadreur)
        'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ' Me.EtudiantTableAdapter.Fill(Me.basegestionfe.Etudiant)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' If (TextBox2.Text.Equals"" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" And ComboBox1.SelectedItem = 0 And ComboBox2.SelectedItem = 0 And TextBox8.Text = "" And TextBox10.Text = "") Then
        'MsgBox("Veuillez fournir tous les champs!", vbOK, vbExclamation)
        ' Else
        Dim c = New Connexion
        Dim _Cnn = c.connect()
        Dim i = New GestiondesPFE.Dal_Etudiant
        Dim student = New Etudiant
        student.NCE = TextBox2.Text
        student.CIN = TextBox3.Text
        student.nom = TextBox4.Text
        student.prenom = TextBox5.Text
        student.email = TextBox6.Text
        student.tel = TextBox7.Text
        student.datedenaissance = TextBox8.Text
        student.filiere = ComboBox1.SelectedItem
        student.stage = TextBox10.Text
        i.InsertEtudiant(student)
        _Cnn.Close()
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ajoutprojet As Form4 = New Form4()
        ajoutprojet.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class