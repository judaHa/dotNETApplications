Imports System.Data.OleDb
Imports System
Imports GestiondesPFE
Namespace GestiondesPFE

    Public Class Dal_Etudiant



        Public Function BindDataToEtudiant(ByVal x As String) As Etudiant


            Dim _Cnn As OleDbConnection
            Dim c = New Connexion
            _Cnn = c.connect()
            _Cnn.Open()


            Dim ed As Etudiant = New Etudiant()


            Dim strSql As String
            strSql = "SELECT * FROM Etudiant WHERE (NCE=?)"

            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(strSql, _Cnn)
            Dim pid As OleDbParameter
            pid = New OleDbParameter("NCE", x)
            cmd.Parameters.Add(pid)

            Try


                Dim rd As OleDbDataReader
                rd = cmd.ExecuteReader()

                While rd.Read

                    ed.NCE = rd(0).ToString()
                    ed.CIN = rd("CIN").ToString()
                    ed.nom = rd("Nom").ToString()
                    ed.prenom = rd("Prenom").ToString()
                    ed.email = rd("email").ToString()
                    ed.tel = rd("Tel").ToString()
                    ed.datedenaissance = rd("Date de naissance").ToString()
                    ed.filiere = rd("Filiere").ToString()
                    ed.stage = rd("Stage").ToString()


                End While
                rd.Close()

            Catch
                _Cnn.Close()
                Return ed
            End Try

            _Cnn.Close()

            Return ed

        End Function


        Public Sub InsertEtudiant(ByVal ed As Etudiant)

            Dim _Cnn As OleDbConnection
            Dim c = New Connexion
            _Cnn = c.connect()

            _Cnn.Open()
            '  " & _
            '  "@Column1, @Column2

            'values (@Cust"& _ 
            '      "omerID,@CustomerGUID,@RegisterDate,@Password,@SiteID,@LastName,@FirstName,@Email"& _ 
            '  ",@Notes,@BillingEqualsShipping,@BillingLastName)"


            Dim strSql As String = "INSERT into Etudiant VALUES('_NCE','_CIN','_nom','_prenom','_email','_tel','_Datedenaissance','_filiere','_stage')" ')"
            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)


            Dim pnce As OleDbParameter = New OleDbParameter("NCE", ed.nce)
            Dim pcin As OleDbParameter = New OleDbParameter("CIN", ed.cin)
            Dim pnom As OleDbParameter = New OleDbParameter("nom", ed.nom)
            Dim pprenom As OleDbParameter = New OleDbParameter("prenom", ed.prenom)
            Dim pemail As OleDbParameter = New OleDbParameter("email", ed.email)
            Dim ptel As OleDbParameter = New OleDbParameter("tel", ed.tel)
            Dim pdatedenaissance As OleDbParameter = New OleDbParameter("Datedenaissance", ed.datedenaissance)
            Dim pfiliere As OleDbParameter = New OleDbParameter("filiere", ed.filiere)
            Dim pstage As OleDbParameter = New OleDbParameter("stage", ed.stage)


            cmd.Parameters.Add(pnce)
            cmd.Parameters.Add(pcin)
            cmd.Parameters.Add(pnom)
            cmd.Parameters.Add(pprenom)
            cmd.Parameters.Add(pemail)
            cmd.Parameters.Add(ptel)
            cmd.Parameters.Add(pdatedenaissance)
            cmd.Parameters.Add(pfiliere)
            cmd.Parameters.Add(pstage)



            cmd.ExecuteNonQuery()
            _Cnn.Close()
        End Sub

        Public Function DeleteEtudiant(ByVal id As String) As Boolean

            Dim c = New Connexion
            Dim _Cnn As OleDbConnection = c.connect()
            _Cnn.Open()
            Dim strSql As String = "DELETE FROM Etudiant WHERE NCE=& me._NCE"
            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)
            Dim pId As OleDbParameter = New OleDbParameter("Identifiant", id)
            cmd.Parameters.Add(pId)

            Try
                cmd.ExecuteNonQuery()
                _Cnn.Close()
            Catch
                _Cnn.Close()
                Return False
            End Try

            Return True
        End Function

        Public Function UpdateDiplome(ByVal oldd As Etudiant, ByVal newd As Etudiant) As Boolean

            Dim c = New Connexion
            Dim _Cnn As OleDbConnection = c.connect()
            _Cnn.Open()

            Try



                Dim strSql As String = "UPDATE Etudiant set  (nom =? ,prenom=? ,email=?, tel=?) WHERE (NCE =?)"
                Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)

                Dim pnom As OleDbParameter = New OleDbParameter("nom", oldd.nom)
                Dim pprenom As OleDbParameter = New OleDbParameter("prenom", oldd.prenom)
                Dim pemail As OleDbParameter = New OleDbParameter("email", oldd.email)
                Dim ptel As OleDbParameter = New OleDbParameter("tel", oldd.tel)

                Dim pnewnom As OleDbParameter = New OleDbParameter("newnom", newd.nom)
                Dim pnewprenom As OleDbParameter = New OleDbParameter("newprenom", newd.prenom)
                Dim pnewemail As OleDbParameter = New OleDbParameter("newemail", newd.email)
                Dim pnewtel As OleDbParameter = New OleDbParameter("newtel", newd.tel)




                cmd.Parameters.Add(pnom)
                cmd.Parameters.Add(pprenom)
                cmd.Parameters.Add(pemail)
                cmd.Parameters.Add(pnewtel)


                Try

                    cmd.ExecuteNonQuery()

                Catch
                    _Cnn.Close()
                    Return False
                End Try

                _Cnn.Close()
                Return True


            Catch Exception As Exception
                _Cnn.Close()
                Return False
            End Try

        End Function

        Public Function delete(ByVal ed As Etudiant) As Boolean


            Dim c = New Connexion
            Dim _Cnn As OleDbConnection = c.connect()

            _Cnn.Open()
            Dim strSql As String = "DELETE FROM Etudiant WHERE  (NCE =? ) "
            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _Cnn)
            Dim pNCE As OleDbParameter = New OleDbParameter("NCE", ed.NCE)


            cmd.Parameters.Add(pNCE)
            Try

                cmd.ExecuteNonQuery()


            Catch
                _Cnn.Close()
                Return False
            End Try

            _Cnn.Close()
            Return True


        End Function

    End Class
End Namespace

