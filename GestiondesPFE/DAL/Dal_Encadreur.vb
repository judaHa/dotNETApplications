'Imports System.Data.OleDb
'Namespace GestiondesPFE

'    Public Class Dal_Encadreur

'        Public Sub InsertJury(ByVal ed As Encadreur)

'            Dim _Cnn As OleDbConnection
'            '    _Cnn = Connexion.connect()
'            _Cnn.Open()
'            Dim strSql As String = "INSERT into Encadreur VALUES(?,?,?)"
'            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)


'            Dim v1 As OleDbParameter = New OleDbParameter("NCode", ed.code)
'            Dim v2 As OleDbParameter = New OleDbParameter("nom", ed.nom)
'            Dim v3 As OleDbParameter = New OleDbParameter("prenom", ed.prenom)



'            cmd.Parameters.Add(v1)
'            cmd.Parameters.Add(v2)
'            cmd.Parameters.Add(v3)


'            cmd.ExecuteNonQuery()
'            _Cnn.Close()
'        End Sub

'        Public Function DeleteJury(ByVal id As String) As Boolean

'            '    Dim _Cnn As OleDbConnection = DAL.connexion.connect()
'            _Cnn.Open()
'            Dim strSql As String = "DELETE FROM Encadreur WHERE Code=?"
'            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)
'            Dim pId As OleDbParameter = New OleDbParameter("Code", id)
'            cmd.Parameters.Add(pId)

'            Try
'                cmd.ExecuteNonQuery()
'                '_Cnn.Close()
'            Catch
'                '_Cnn.Close()
'                Return False
'            End Try

'            Return True
'        End Function

'        Public Function UpdateProjet(ByVal oldd As Encadreur, ByVal newd As Encadreur) As Boolean

'            ' Dim _Cnn As OleDbConnection = DAL.connexion.connect()
'            _Cnn.Open()

'            Try



'                Dim strSql As String = "UPDATE Encadreur set  (nom=?, prenom=?) WHERE (Code =?)"
'                ' Dim cmd As OleDbCommand = New OleDbCommand(strSql, '_Cnn)


'                'Dim pnom As OleDbParameter = New OleDbParameter("nom", oldd.Titre)
'                ' Dim pprenom As OleDbParameter = New OleDbParameter("prenom", oldd.Description)


'                Dim pnewnom As OleDbParameter = New OleDbParameter("newnom", newd.nom)
'                Dim pnewprenom As OleDbParameter = New OleDbParameter("newprenom", newd.prenom)



'                '  cmd.Parameters.Add(pnom)
'                'cmd.Parameters.Add(pprenom)

'                ' cmd.Parameters.Add(pnewnom)
'                '    cmd.Parameters.Add(pnewprenom)

'                Try

'                    ' cmd.ExecuteNonQuery()

'                Catch
'                    '  _Cnn.Close()
'                    Return False
'                End Try

'                '  _Cnn.Close()
'                Return True


'            Catch Exception As Exception
'                '  _Cnn.Close()
'                Return False
'            End Try

'        End Function
'    End Class
'End Namespace
