Imports System.Data.OleDb
Public Class Connexion

    Public Function connect() As OleDbConnection

        Dim cn As OleDbConnection = New OleDbConnection()
        Dim chemin As String = "C:\Users\DELL\Desktop\PROJET VB NET\GestiondesPFE\basegestionfe.accdb"
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & chemin
        cn.Open()
        Return cn
    End Function
End Class
