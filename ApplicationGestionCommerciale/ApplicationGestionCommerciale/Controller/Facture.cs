using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient.Properties;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ApplicationGestionCommerciale
{
    public class Facture
    {
        public int numero_Facture;
        public string date_Facture;
        public double montantHT_Facture, montantTTC_Facture, timbre_Facture, remise_Facture;
        public string statut_Facture;
        public int Client_codeClient;

        public Facture(int numero_Facture, string date_Facture, double timbre_Facture, double remise_Facture, double montantHT_Facture, double montantTTC_Facture, string statut_Facture, int Client_codeClient)
        {
            this.numero_Facture = numero_Facture;
            this.date_Facture = date_Facture;
            this.montantHT_Facture = montantHT_Facture;
            this.montantTTC_Facture = montantTTC_Facture;
            this.statut_Facture = statut_Facture; 
            this.timbre_Facture = timbre_Facture;
            this.remise_Facture = remise_Facture;
            this.Client_codeClient = Client_codeClient;
        }
        public Facture(int numero_Facture)
        {
            this.numero_Facture = numero_Facture;
        }
        public Facture()
        {

        }

        public void creerFacture()
        {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "insert into facture values(" + this.numero_Facture + ",'" + this.date_Facture + "'," + this.timbre_Facture.ToString().Replace(',', '.') + "," + this.remise_Facture.ToString().Replace(',', '.') + "," + this.montantHT_Facture.ToString().Replace(',', '.') + "," + this.montantTTC_Facture.ToString().Replace(',', '.') + ",'" + this.statut_Facture + "'," + this.Client_codeClient + ");";
                connection.Open();
                Reader = cmd.ExecuteReader();
                connection.Close();
                connection = null;
        }


        public void modifierFacture(string p_date_facture, double p_timbre_facture, double p_remise_facture, double p_montantHT_facture, double p_montantTTC_facture, String p_statut_facture, int p_Client_codeClient)
        {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "update facture set date_Facture='" + p_date_facture + "', montantHT_Facture= " + p_montantHT_facture.ToString().Replace(',', '.') + ", montantTTC_Facture=" + p_montantTTC_facture.ToString().Replace(',', '.') + ", statut_Facture='" + p_statut_facture + "' , timbre_Facture=" + p_timbre_facture.ToString().Replace(',', '.') + ", remise_Facture= " + p_remise_facture.ToString().Replace(',', '.') + ", Client_codeClient=" + p_Client_codeClient + " where numero_Facture=" + this.numero_Facture + ";";
                connection.Open();
                Reader = cmd.ExecuteReader();
                connection.Close();
                connection = null;
        }


        public void supprimerFacture()
        {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "delete from facture where numero_Facture=" + this.numero_Facture + ";";
                connection.Open();
                Reader = cmd.ExecuteReader();
                connection.Close();
                connection = null;
        }


    }
}
