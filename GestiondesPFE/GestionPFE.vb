Imports GestiondesPFE
Imports System
Public Class GestionPFE


    Public Sub GestionEtudiant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try   'TODO : cette ligne de code charge les données dans la table 'BasegestionfeDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            'Me.basegestionfeDataSet.Etudiant.Fill(Me.BasegestionfeDataSet.Etudiant)
        Catch nullreferences As Exception
        End Try
    End Sub

    Private Sub EtudiantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtudiantToolStripMenuItem.Click

    End Sub

    Private Sub EditerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditerToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
      
        Dim ajoutetudiant As AjoutEtudiant = New AjoutEtudiant
        Dim frm As New AjoutEtudiant()
        frm.MdiParent = Me
        frm.Visible = True

        'ajoutetudiant.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim ajoutprojet As Form4 = New Form4
        Dim frm As New Form4()
        frm.MdiParent = Me
        frm.Visible = True
        ' ajoutprojet.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        'Dim ajoutencadreur As form = New AjoutEtudiant
        Dim frm As New AjoutEtudiant()
        frm.MdiParent = Me
        frm.Visible = True
        ' ajoutetudiant.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        'Dim modiftudiant As Form2 = New Form2
        Dim frm As New Form2()
        frm.MdiParent = Me
        frm.Visible = True
        ' modiftudiant.Show()


    End Sub

    Private Sub QuitterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ToutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToutToolStripMenuItem.Click
        ' Dim affetudiant As Liste_Etudiants = New Liste_Etudiants
        Dim frm As New Liste_Etudiants()
        frm.MdiParent = Me
        frm.Visible = True
        'affetudiant.Show()
    End Sub

    Private Sub ProjetsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjetsToolStripMenuItem.Click
        ' Dim affprojet As Liste_Projets = New Liste_Projets
        Dim frm As New Liste_Projets()
        frm.MdiParent = Me
        frm.Visible = True

        'affprojet.Show()
    End Sub

    Private Sub EncadreursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncadreursToolStripMenuItem.Click
        ' Dim affencad As Liste_Encadreurs = New Liste_Encadreurs
        Dim frm As New Liste_Encadreurs()
        frm.MdiParent = Me
        frm.Visible = True
        ' affencad.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        ' Dim affjury As Liste_Jury = New Liste_Jury
        Dim frm As New Liste_Jury()
        frm.MdiParent = Me
        frm.Visible = True
        ' affjury.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        ' Dim suppetudiant As Form3 = New Form3
        Dim frm As New Form3()
        frm.MdiParent = Me
        frm.Visible = True
        'suppetudiant.Show()
    End Sub
End Class