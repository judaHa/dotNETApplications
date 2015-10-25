Imports System
Imports System.Data.OleDb
Imports System.Collections.Generic

Public Class Encadreur

    Private _code As String
    Private _nom As String
    Private _prenom As String




    Public Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property


    Public Property nom() As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property prenom() As String
        Get
            Return _prenom
        End Get
        Set(ByVal value As String)
            _prenom = value
        End Set
    End Property


    Public Etudiant(code, nom, prenom)

End Class
