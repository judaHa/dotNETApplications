using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows;

namespace ApplicationGestionCommerciale.DAL
{
    class DAL_Client
    {


        public static void InsertClient(Entity.Client ed)
        {

            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();
            string strSql = "INSERT into client  VALUES(?code_Client,?ref_Client,?nom_Client,?prenom_Client,?adresse_Client,?codepostal_Client,?ville_Client,?pays_Client,?telFixe_Client,?telMobile_Client,?email_Client,?site_Client,?fax_Client,?societe_Client,?etat_Client,?nbTransactions_Client,?notes_Client)";


            MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);

            cmd.CommandText = strSql;

            //            p*
            MySqlParameter ccl = new MySqlParameter("code_Client", ed.code_Client);
            MySqlParameter refc = new MySqlParameter("ref_Client", ed.ref_Client);
            MySqlParameter nc = new MySqlParameter("nom_Client", ed.nom_Client);
            MySqlParameter pyc = new MySqlParameter("prenom_Client", ed.prenom_Client);
            MySqlParameter adc = new MySqlParameter("adresse_Client", ed.adresse_Client);
            MySqlParameter cpc = new MySqlParameter("codepostal_Client", ed.codepostal_Client);
            MySqlParameter vc = new MySqlParameter("ville_Client", ed.ville_Client);
            MySqlParameter payc = new MySqlParameter("pays_Client", ed.pays_Client);
            MySqlParameter tfc = new MySqlParameter("telFixe_Client", ed.telFixe_Client);
            MySqlParameter tmc = new MySqlParameter("telMobile_Client", ed.telMobile_Client);
            MySqlParameter emc = new MySqlParameter("email_Client", ed.email_Client);
            MySqlParameter sic = new MySqlParameter("site_Client", ed.site_Client);
            MySqlParameter Fxc = new MySqlParameter("fax_Client", ed.fax_Client);
            MySqlParameter soc = new MySqlParameter("societe_Client", ed.societe_Client);
            MySqlParameter ec = new MySqlParameter("etat_Client", ed.etat_Client);
            MySqlParameter nbc = new MySqlParameter("nbTransactions_Client", ed.nbTransactions_Client);
            MySqlParameter notec = new MySqlParameter("notes_Client", ed.notes_Client);


            cmd.Parameters.Add(ccl);
            cmd.Parameters.Add(refc);
            cmd.Parameters.Add(nc);
            cmd.Parameters.Add(pyc);
            cmd.Parameters.Add(adc);
            cmd.Parameters.Add(cpc);
            cmd.Parameters.Add(vc);
            cmd.Parameters.Add(payc);
            cmd.Parameters.Add(tfc);
            cmd.Parameters.Add(tmc);
            cmd.Parameters.Add(Fxc);
            cmd.Parameters.Add(sic);
            cmd.Parameters.Add(emc);
            cmd.Parameters.Add(soc);
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

        public static bool DeleteClient(int id)
        {
            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();



            string strSql = "DELETE FROM client WHERE code_Client=?code_Client";
            MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
            cmd.CommandText = strSql;
            MySqlParameter pId = new MySqlParameter("code_Client", id);
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

       /* public static void UpdateClient(Entity.Client newd)
        {
            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();
         //   try
          //  {
            string strSql = "UPDATE client set  (ref_Client=?ref_Client,nom_Client=?nom_Client,prenom_Client=?prenom_Client,adresse_Client=?adresse_Client,codepostal_Client=?codepostal_Client, ville_Client=?ville_Client, pays_Client=?pays_Client, telFixe_Client=?telFixe_Client, telMobile_Client=?telMobile_Client, email_Client=?email_Client,site_Client=?site_Client, fax_Client=?fax_Client, societe_Client=?societe_Client, etat_Client=?etat_Client, notes_Client=?notes_Client) WHERE (code_Client =?code_Client)";
                MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
                cmd.CommandText = strSql;

                MySqlParameter newdcc = new MySqlParameter("?code_Client", newd.code_Client);
                MySqlParameter newdrefc = new MySqlParameter("?ref_Client", newd.ref_Client);
                MySqlParameter newdnc = new MySqlParameter("?nom_Client", newd.nom_Client);
                MySqlParameter newdpyc = new MySqlParameter("?prenom_Client", newd.prenom_Client);
                MySqlParameter newdadc = new MySqlParameter("?adresse_Client", newd.adresse_Client);
                MySqlParameter newdcpc = new MySqlParameter("?codepostal_Client", newd.codepostal_Client);
                MySqlParameter newdvc = new MySqlParameter("?ville_Client", newd.ville_Client);
                MySqlParameter newdpayc = new MySqlParameter("?pays_Client", newd.pays_Client);
                MySqlParameter newdtfc = new MySqlParameter("?telFixe_Client", newd.telFixe_Client);
                MySqlParameter newdtmc = new MySqlParameter("?telMobile_Client", newd.telMobile_Client);
                MySqlParameter newdemc = new MySqlParameter("?email_Client", newd.email_Client);
                MySqlParameter newdsic = new MySqlParameter("?site_Client", newd.site_Client);
                MySqlParameter newdFxc = new MySqlParameter("?fax_Client", newd.fax_Client);
                MySqlParameter newdsoc = new MySqlParameter("?societe_Client", newd.societe_Client);
                MySqlParameter newdec = new MySqlParameter("?etat_Client", newd.etat_Client);
                MySqlParameter newdnotec = new MySqlParameter("?notes_Client", newd.notes_Client);

                
                cmd.Parameters.Add(newdrefc);
                cmd.Parameters.Add(newdnc);
                cmd.Parameters.Add(newdpyc);
                cmd.Parameters.Add(newdadc);
                cmd.Parameters.Add(newdcpc);
                cmd.Parameters.Add(newdvc);
                cmd.Parameters.Add(newdpayc);
                cmd.Parameters.Add(newdtfc);
                cmd.Parameters.Add(newdtmc);
                cmd.Parameters.Add(newdemc);
                cmd.Parameters.Add(newdsic);
                cmd.Parameters.Add(newdFxc);
                cmd.Parameters.Add(newdsoc);
                cmd.Parameters.Add(newdec);
                cmd.Parameters.Add(newdnotec);
                cmd.Parameters.Add(newdcc);

                cmd.ExecuteNonQuery();
              
                _Cnn.Close();
               // return true;

            //}
         //   catch (Exception)
           // {
                
            //    return false;
           // }

        }
        */

        public static void UpdateClient(Entity.Client newd)
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();

            MySqlDataReader Reader;
            cmd.CommandText = "update client set code_Client=" + newd.code_Client + ", ref_Client= '" + newd.ref_Client + "' , nom_Client='" + newd.nom_Client + "', prenom_Client='" + newd.prenom_Client + "' , adresse_Client='" + newd.adresse_Client + "' , codepostal_Client= " + newd.codepostal_Client + ", ville_Client='" + newd.ville_Client + "' , pays_Client='" + newd.pays_Client + "' , telFixe_Client=" + newd.telFixe_Client + ", telMobile_Client=" + newd.telMobile_Client + ", email_Client='" + newd.email_Client + "' , site_Client='" + newd.site_Client + "' , fax_Client='" + newd.fax_Client + "', societe_Client='" + newd.societe_Client + "' , etat_Client='" + newd.etat_Client + "' , notes_Client='" + newd.notes_Client +     "' where code_Client=" + newd.code_Client + ";";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }

        public static DataView affichgrid(DataGridView dgv)
        {
            string ConnectionString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection _Conn = DAL.Connexion.connect();
            _Conn.Open();

            DataTable dt = new DataTable();

            string strSql = "SELECT * FROM client";

            MySqlCommand cmd = new MySqlCommand(strSql, _Conn);


            //OleDbDataAdapter joue le rôle de pont entre DataSet et une source de données pour la récupération et l'enregistrement de données.                
            MySqlDataAdapter da = new MySqlDataAdapter(strSql, ConnectionString);

            // un cache en mémoire des données récupérées d'une source de données,          
            DataSet ds = new DataSet();


            da.Fill(dt);
            da.Fill(ds, "client");


            dgv.DataSource = dt.DefaultView;

            return (ds.Tables["client"].DefaultView);
        }




        public static DataView rechercher(Entity.Client ed)
        {
            MySqlConnection _Cnn = DAL.Connexion.connect();
            _Cnn.Open();
            string strSql = "Select * from client where code_Client=?code_Client OR societe_Client=?societe_Client OR ville_Client=?ville_Client OR pays_Client= ?pays_Client ";
            MySqlCommand cmd = new MySqlCommand(strSql, _Cnn);
            cmd.CommandText = strSql;
            cmd.Parameters.AddWithValue("?code_Client", ed.code_Client);
            cmd.Parameters.AddWithValue("?societe_Client", ed.societe_Client);
            cmd.Parameters.AddWithValue("?ville_Client", ed.ville_Client);
            cmd.Parameters.AddWithValue("?pays_Client", ed.pays_Client);
            // MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "client"); _Cnn.Close();
            return (ds.Tables["client"].DefaultView);
            //  DataTable dt = new DataTable();
            //  dt.Load(reader);

            // return dt;
        }




    }
}
