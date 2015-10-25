Imports System
Imports System.Data.OleDb
Imports System.Collections.Generic

Public Class Etudiant

    Private _NCE As String
    Private _CIN As String
    Private _nom As String
    Private _prenom As String
    Private _email As String
    Private _tel As String
    Private _datedenaissance As String
    Private _filiere As String
    Private _stage As String




    Public Property NCE() As String
        Get
            Return _NCE
        End Get
        Set(ByVal value As String)
            _NCE = value
        End Set
    End Property

     
    Public Property CIN() As String
        Get
            Return _CIN
        End Get
        Set(ByVal value As String)
            _CIN = value
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

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property tel() As String
        Get
            Return _tel
        End Get
        Set(ByVal value As String)
            _tel = value
        End Set
    End Property

    Public Property datedenaissance() As String
        Get
            Return _datedenaissance
        End Get
        Set(ByVal value As String)
            _datedenaissance = value
        End Set
    End Property

    Public Property filiere() As String
        Get
            Return _filiere
        End Get
        Set(ByVal value As String)
            _filiere = value
        End Set
    End Property

    

    Public Property stage() As String
        Get
            Return _stage
        End Get
        Set(ByVal value As String)
            _stage = value
        End Set
    End Property

    Public Etudiant(NCE, CIN, nom, prenom, email, tel, datedenaissance, filiere, stage)

End Class
