'Imports System.Data.OleDb
'Namespace GestiondesPFE

'    Public Class Dal_Projet



'        Public Sub InsertEtudiant(ByVal ed As Entity.Projet)

'            Dim _Cnn As OleDbConnection
'            _Cnn = Dal.Connexion.connect()
'            _Cnn.Open()
'            Dim strSql As String = "INSERT into Projet VALUES(?,?,?,?,?)"
'            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)


'            Dim v1 As OleDbParameter = New OleDbParameter("NProjet", ed.NProje)
'            Dim v2 As OleDbParameter = New OleDbParameter("titre", ed.Titre)
'            Dim v3 As OleDbParameter = New OleDbParameter("Description", ed.Description)
'            Dim v4 As OleDbParameter = New OleDbParameter("DateDelai", ed.DateDelai)
'            Dim v5 As OleDbParameter = New OleDbParameter("Datesoutenance", ed.Datesoutenance)



'            cmd.Parameters.Add(v1)
'            cmd.Parameters.Add(v2)
'            cmd.Parameters.Add(v3)
'            cmd.Parameters.Add(v4)
'            cmd.Parameters.Add(v5)


'            cmd.ExecuteNonQuery()
'            _Cnn.Close()
'        End Sub

'        Public Function DeleteProjet(ByVal id As String) As Boolean

'            Dim _Cnn As OleDbConnection = DAL.connexion.connect()
'            _Cnn.Open()
'            Dim strSql As String = "DELETE FROM Projet WHERE NProje=?"
'            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)
'            Dim pId As OleDbParameter = New OleDbParameter("NProje", id)
'            cmd.Parameters.Add(pId)

'            Try
'                cmd.ExecuteNonQuery()
'                _Cnn.Close()
'            Catch
'                _Cnn.Close()
'                Return False
'            End Try

'            Return True
'        End Function

'        Public Function UpdateProjet(ByVal oldd As Entity.Projet, ByVal newd As Entity.Projet) As Boolean

'            Dim _Cnn As OleDbConnection = DAL.connexion.connect()
'            _Cnn.Open()

'            Try



'                Dim strSql As String = "UPDATE Projet set  (Titre=? ,Description=?, DateDelai=?, Datesoutenance=?) WHERE (NProj =? ,Titre=? ,Description=?, DateDelai=?, Datesoutenance=?)"
'                Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)


'                Dim ptitre As OleDbParameter = New OleDbParameter("Titre", oldd.Titre)
'                Dim pdesc As OleDbParameter = New OleDbParameter("Description", oldd.Description)
'                Dim pdat As OleDbParameter = New OleDbParameter("DateDelai", oldd.DateDelai)
'                Dim pdats As OleDbParameter = New OleDbParameter("Datesoutenance", oldd.Datesoutenance)



'                Dim pnewt As OleDbParameter = New OleDbParameter("newTitre", newd.Titre)
'                Dim pnewd As OleDbParameter = New OleDbParameter("newDescription", newd.Description)
'                Dim pnewdd As OleDbParameter = New OleDbParameter("newDateDelai", newd.DateDelai)
'                Dim pnewds As OleDbParameter = New OleDbParameter("newDatesoutenance", newd.Datesoutenance)



'                cmd.Parameters.Add(ptitre)
'                cmd.Parameters.Add(pdesc)
'                cmd.Parameters.Add(pdat)
'                cmd.Parameters.Add(pdats)


'                cmd.Parameters.Add(pnewp)
'                cmd.Parameters.Add(pnewt)
'                cmd.Parameters.Add(pnewd)
'                cmd.Parameters.Add(pnewdd)
'                cmd.Parameters.Add(pnewds)

'                Try

'                    cmd.ExecuteNonQuery()

'                Catch
'                    _Cnn.Close()
'                    Return False
'                End Try

'                _Cnn.Close()
'                Return True


'            Catch Exception As Exception
'                _Cnn.Close()
'                Return False
'            End Try

'        End Function

'        Public Function deleteProjet(ByVal ed As Entity.Projet) As Boolean

'            Dim _Cnn As OleDbConnection = DAL.connexion.connect()

'            _Cnn.Open()
'            Dim strSql As String = "DELETE FROM Projet WHERE  (Nproje =? , Titre=?, Description= ?, DateDepot=?, Datesoutenance=?"
'            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)
'            Dim pNproje As OleDbParameter = New OleDbParameter("Nproje", ed.Nproje)
'            Dim pTitre As OleDbParameter = New OleDbParameter("Titre", ed.Titre)
'            Dim pDescription As OleDbParameter = New OleDbParameter("Description", ed.Description)
'            Dim pDateDelai As OleDbParameter = New OleDbParameter("DateDepot", ed.DateDelain)
'            Dim pDatesoutenance As OleDbParameter = New OleDbParameter("Datesoutenance", ed.Datesoutenance)




'            cmd.Parameters.Add(pNproje)
'            cmd.Parameters.Add(pTitre)
'            cmd.Parameters.Add(pDescription)
'            cmd.Parameters.Add(pDateDelai)
'            cmd.Parameters.Add(pDatesoutenance)
'            Try

'                cmd.ExecuteNonQuery()


'            Catch
'                _Cnn.Close()
'                Return False
'            End Try

'            _Cnn.Close()
'            Return True


'        End Function

'    End Class
'End Namespace

