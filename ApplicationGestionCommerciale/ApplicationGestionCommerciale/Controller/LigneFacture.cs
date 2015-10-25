using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale
{
    class LigneFacture
    {

        int numero_ligneFacture;
        string Produit_codeProduit;
        int quantite;
        double montant_Produit;
        int Facture_numeroFacture;

        public LigneFacture(int numero_ligneFacture, string Produit_codeProduit, int quantite, double montant_Produit, int Facture_numeroFacture)
        {
            this.numero_ligneFacture = numero_ligneFacture;
            this.Produit_codeProduit = Produit_codeProduit;
            this.quantite = quantite;
            this.montant_Produit = montant_Produit;
            this.Facture_numeroFacture = Facture_numeroFacture;
        }

        public LigneFacture(int numero_ligneFacture)
        {
            this.numero_ligneFacture = numero_ligneFacture;
        }

        public void AjouterLigneFacture()
        {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "insert into LigneFacture values(" + numero_ligneFacture + ",'" + Produit_codeProduit + "'," + quantite + "," + montant_Produit.ToString().Replace(',', '.') + "," + Facture_numeroFacture + ");";
                connection.Open();
                Reader = cmd.ExecuteReader();

                connection.Close();
                connection = null;
        }

        public void ModifierLigneFacture(string Produit_codeProduit, int quantite, double montant_Produit, int Facture_numeroFacture)
        {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "update LigneFacture set Produit_codeProduit = '" + Produit_codeProduit + "' , quantite = " + quantite + ", montant_Produit = " + montant_Produit.ToString().Replace(',', '.') + ", Facture_numeroFacture = " + Facture_numeroFacture + " where numero_ligneFacture = " + this.numero_ligneFacture + ";";
                connection.Open();
                Reader = cmd.ExecuteReader();

                connection.Close();
                connection = null;
        }

        public void SupprimerLigneFacture()
        {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "delete from LigneFacture where numero_ligneFacture = " + numero_ligneFacture + ";";
                connection.Open();
                Reader = cmd.ExecuteReader();
                connection.Close();
                connection = null;
        }




    }
}
