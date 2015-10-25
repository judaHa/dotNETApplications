using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows;
using System.Data;

namespace ApplicationGestionCommerciale.DAL
{
    class DAL_Fournisseur
    {
        public static void InsertFournisseur(Entity.Fournisseur ed)
        {

            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();
            string strSql = "INSERT into fournisseur VALUES(?idFournisseur,?ref_Fournisseur,?nom_Fournisseur,?prenom_Fournisseur,?adresse_Fournisseur, ?codePostal_Fournisseur, ?ville_Fournisseur,?pays_Fournisseur,?tel_Fournisseur,?telmobile_Fournisseur, ?email_Fournisseur, ?fax_Fournisseur, ?siteInternet_Fournisseur,?etat_Fournisseur,?nb_transactions_Fournisseur,?note_Fournisseur)";


            MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
            cmd.CommandText = strSql;

            //            p*
            MySqlParameter ccl = new MySqlParameter("idFournisseur", ed.idFournisseur);
            MySqlParameter refc = new MySqlParameter("ref_Fournisseur", ed.ref_Fournisseur);
            MySqlParameter nc = new MySqlParameter("nom_Fournisseur", ed.nom_Fournisseur);
            MySqlParameter pyc = new MySqlParameter("prenom_Fournisseur", ed.prenom_Fournisseur);
            MySqlParameter adc = new MySqlParameter("adresse_Fournisseur", ed.adresse_Fournisseur);
            MySqlParameter soc = new MySqlParameter("codePostal_Fournisseur", ed.codePostal_Fournisseur);
            MySqlParameter vc = new MySqlParameter("ville_Fournisseur", ed.ville_Fournisseur);
            MySqlParameter payc = new MySqlParameter("pays_Fournisseur", ed.pays_Fournisseur);
            MySqlParameter tfc = new MySqlParameter("tel_Fournisseur", ed.tel_Fournisseur);
            MySqlParameter tmobilec = new MySqlParameter("telmobile_Fournisseur", ed.telmobile_Fournisseur);
            MySqlParameter emc = new MySqlParameter("email_Fournisseur", ed.email_Fournisseur);
            MySqlParameter Fxc = new MySqlParameter("fax_Fournisseur", ed.fax_Fournisseur);
            MySqlParameter sic = new MySqlParameter("siteInternet_Fournisseur", ed.siteInternet_Fournisseur);
            MySqlParameter ec = new MySqlParameter("etat_Fournisseur", ed.etat_Fournisseur);
            MySqlParameter nbc = new MySqlParameter("nb_transactions_Fournisseur", ed.nb_transactions_Fournisseur);
            MySqlParameter notec = new MySqlParameter("note_Fournisseur", ed.note_Fournisseur);


            cmd.Parameters.Add(ccl);
            cmd.Parameters.Add(refc);
            cmd.Parameters.Add(nc);
            cmd.Parameters.Add(pyc);
            cmd.Parameters.Add(adc);
            cmd.Parameters.Add(soc);
            cmd.Parameters.Add(vc);
            cmd.Parameters.Add(payc);
            cmd.Parameters.Add(tfc);
            cmd.Parameters.Add(tmobilec);
            cmd.Parameters.Add(emc);
            cmd.Parameters.Add(Fxc);
            cmd.Parameters.Add(sic);
            cmd.Parameters.Add(ec);
            cmd.Parameters.Add(nbc);
            cmd.Parameters.Add(notec);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }



            _Cnn.Close();


        }

        public static DataView affichgrid(DataGridView dgv)
        {
            string ConnectionString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection _Conn = DAL.Connexion.connect();
            _Conn.Open();

            DataTable dt = new DataTable();

            string strSql = "SELECT * FROM fournisseur";

            MySqlCommand cmd = new MySqlCommand(strSql, _Conn);


            //OleDbDataAdapter joue le rôle de pont entre DataSet et une source de données pour la récupération et l'enregistrement de données.                
            MySqlDataAdapter da = new MySqlDataAdapter(strSql, ConnectionString);

            // un cache en mémoire des données récupérées d'une source de données,          
            DataSet ds = new DataSet();


            da.Fill(dt);
            da.Fill(ds, "fournisseur");


            dgv.DataSource = dt.DefaultView;

            return (ds.Tables["fournisseur"].DefaultView);
        }



        public static bool DeleteFournisseur(string id)
        {
            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();

            string strSql = "DELETE FROM fournisseur WHERE idFournisseur=?idFournisseur";
            MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
            cmd.CommandText = strSql;
            MySqlParameter pId = new MySqlParameter("idFournisseur", id);
            cmd.Parameters.Add(pId);
            try
            {
                cmd.ExecuteNonQuery();
                _Cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _Cnn.Close();
                return false;
            }

            return true;
        }

       /* public static void UpdateFournisseur(Entity.Fournisseur newd)
        {
            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();
            try
            {
                string strSql = "UPDATE fournisseur set  (ref_Fournisseur=?ref_Fournisseur,nom_Fournisseur=?nom_Fournisseur,prenom_Fournisseur=?prenom_Fournisseur,adresse_Fournisseur=?adresse_Fournisseur,codePostal_Fournisseur=?codePostal_Fournisseur, ville_Fournisseur=?ville_Fournisseur,pays_Fournisseur=?pays_Fournisseur,tel_Fournisseur= ?tel_Fournisseur,telmobile_Fournisseur= ?telmobile_Fournisseur, email_Fournisseur=?email_Fournisseur,fax_Fournisseur=?fax_Fournisseur,siteInternet_Fournisseur=?siteInternet_Fournisseur,etat_Fournisseur= ?etat_Fournisseur,note_Fournisseur=?note_Fournisseur)";
                MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
                cmd.CommandText = strSql;

                MySqlParameter newdrefc = new MySqlParameter("?ref_Fournisseur", newd.ref_Fournisseur);
                MySqlParameter newdnc = new MySqlParameter("?nom_Fournisseur", newd.nom_Fournisseur);
                MySqlParameter newdpyc = new MySqlParameter("?prenom_Fournisseur", newd.prenom_Fournisseur);
                MySqlParameter newdadc = new MySqlParameter("?adresse_Fournisseur", newd.adresse_Fournisseur);
                MySqlParameter newdtmc = new MySqlParameter("?codePostal_Fournisseur", newd.codePostal_Fournisseur);
                MySqlParameter newdvc = new MySqlParameter("?ville_Fournisseur", newd.ville_Fournisseur);
                MySqlParameter newdpayc = new MySqlParameter("?pays_Fournisseur", newd.pays_Fournisseur);
                MySqlParameter newdtfc = new MySqlParameter("?tel_Fournisseur", newd.tel_Fournisseur);
                MySqlParameter newdtmobilec = new MySqlParameter("?telmobile_Fournisseur", newd.telmobile_Fournisseur);
                MySqlParameter newdemc = new MySqlParameter("?email_Fournisseur", newd.email_Fournisseur);
                MySqlParameter newdFxc = new MySqlParameter("?fax_Fournisseur", newd.fax_Fournisseur);
                MySqlParameter newdsic = new MySqlParameter("?siteInternet_Fournisseur", newd.siteInternet_Fournisseur);
                MySqlParameter newdec = new MySqlParameter("?etat_Fournisseur", newd.etat_Fournisseur);
                MySqlParameter newdnotec = new MySqlParameter("?note_Fournisseur", newd.note_Fournisseur);

                cmd.Parameters.Add(newdrefc);
                cmd.Parameters.Add(newdnc);
                cmd.Parameters.Add(newdpyc);
                cmd.Parameters.Add(newdadc);
                cmd.Parameters.Add(newdvc);
                cmd.Parameters.Add(newdpayc);
                cmd.Parameters.Add(newdtfc);
                cmd.Parameters.Add(newdtmobilec);
                cmd.Parameters.Add(newdtmc);
                cmd.Parameters.Add(newdFxc);
                cmd.Parameters.Add(newdsic);
                cmd.Parameters.Add(newdemc);
                cmd.Parameters.Add(newdec);
                cmd.Parameters.Add(newdnotec);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch {
                    _Cnn.Close();
                    return false; 
                }

                _Cnn.Close();
                return true;

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                _Cnn.Close();
                return false;
            }
        }

    */


        public static void UpdateFournisseur(Entity.Fournisseur newd)
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();

            MySqlDataReader Reader;
            cmd.CommandText = "update fournisseur set ref_Fournisseur='" + newd.ref_Fournisseur + "' , nom_Fournisseur='" + newd.nom_Fournisseur + "', prenom_Fournisseur='" + newd.prenom_Fournisseur + "' , adresse_Fournisseur='" + newd.adresse_Fournisseur + "' , codePostal_Fournisseur= " + newd.codePostal_Fournisseur + ", ville_Fournisseur='" + newd.ville_Fournisseur + "' , pays_Fournisseur='" + newd.pays_Fournisseur + "' , tel_Fournisseur=" + newd.tel_Fournisseur + ", telmobile_Fournisseur=" + newd.telmobile_Fournisseur + ", email_Fournisseur='" + newd.email_Fournisseur + "' , siteInternet_Fournisseur='" + newd.siteInternet_Fournisseur + "' , fax_Fournisseur=" + newd.fax_Fournisseur + ", etat_Fournisseur='" + newd.etat_Fournisseur + "' , note_Fournisseur='" + newd.note_Fournisseur + "' where idFournisseur=" + newd.idFournisseur + ";";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }


        public static DataView rechercher(Entity.Fournisseur ed)
        {
            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();
            string strSql = "Select * from Fournisseur where idFournisseur=?idFournisseur OR codePostal_Fournisseur=?codePostal_Fournisseur OR ville_Fournisseur=?ville_Fournisseur OR pays_Fournisseur= ?pays_Fournisseur ";
            MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
            cmd.CommandText = strSql;
            cmd.Parameters.AddWithValue("?idFournisseur", ed.idFournisseur);
            cmd.Parameters.AddWithValue("?codePostal_Fournisseur", ed.codePostal_Fournisseur);
            cmd.Parameters.AddWithValue("?ville_Fournisseur", ed.ville_Fournisseur);
            cmd.Parameters.AddWithValue("?pays_Fournisseur", ed.pays_Fournisseur);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Fournisseur"); _Cnn.Close();
            return (ds.Tables["Fournisseur"].DefaultView);

        }
    }
}
