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
    public class Produit
    {
        public string code_produit, libelle_produit, designation_produit, unite_produit;
        public string fabricant_produit, ref_fabricant_produit, poids_produit, volume_produit;
        public string Famille_idFamille, Categorie_idCategorie, produit_critique;
        public int stock_min_produit, stock_max_produit, stock_securite_produit, stock_disponible_produit;
        public string delai_approv_produit;
        public string magasin_produit, emplacement_produit, duree_conservation_produit;
        public double prix_moyen_produit, prix_vente_produit, TVA_produit, remise_produit;



        public Produit(string code_produit, string libelle_produit, string designation_produit, string unite_produit, string fabricant_produit, string ref_fabricant_produit, string poids_produit, string volume_produit, string Famille_idFamille, string Categorie_idCategorie, string produit_critique, int stock_min_produit, int stock_max_produit, int stock_securite_produit, int stock_disponible_produit, string delai_approv_produit, string magasin_produit, string emplacement_produit, string duree_conservation_produit, double prix_moyen_produit, double prix_vente_produit, double TVA_produit, double remise_produit)
        {

            this.code_produit = code_produit;
            this.libelle_produit = libelle_produit;
            this.designation_produit = designation_produit;
            this.unite_produit = unite_produit;
            this.fabricant_produit = fabricant_produit;
            this.ref_fabricant_produit = ref_fabricant_produit;
            this.poids_produit = poids_produit;
            this.volume_produit = volume_produit;
            this.Famille_idFamille = Famille_idFamille;
            this.Categorie_idCategorie = Categorie_idCategorie;
            this.produit_critique = produit_critique;
            this.stock_min_produit = stock_min_produit;
            this.stock_max_produit = stock_max_produit;
            this.stock_securite_produit = stock_securite_produit;
            this.stock_disponible_produit = stock_disponible_produit;
            this.delai_approv_produit = delai_approv_produit;
            this.magasin_produit = magasin_produit;
            this.emplacement_produit = emplacement_produit;
            this.duree_conservation_produit = duree_conservation_produit;
            this.prix_moyen_produit = prix_moyen_produit;
            this.prix_vente_produit = prix_vente_produit;
            this.TVA_produit = TVA_produit;
            this.remise_produit = remise_produit;
        }

        public Produit(String code_produit)
        {
            this.code_produit = code_produit;
        }

        public Produit()
        {

        }

        public void ajouterProduit()
        {
            try
            {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            cmd.CommandText = "insert into produit values('" + this.code_produit + "','" + this.libelle_produit + "','" + this.designation_produit + "','" + this.unite_produit + "','" + this.fabricant_produit + "','" + this.ref_fabricant_produit + "','" + this.poids_produit + "','" + this.volume_produit + "','" + this.Famille_idFamille + "','" + this.Categorie_idCategorie + "','" + this.produit_critique + "'," + this.stock_min_produit + "," + this.stock_max_produit + "," + this.stock_securite_produit + "," + this.stock_disponible_produit + ",'" + this.delai_approv_produit + "','" + this.magasin_produit + "','" + this.emplacement_produit + "','" + this.duree_conservation_produit + "'," + this.prix_moyen_produit.ToString().Replace(',', '.') + "," + this.prix_vente_produit.ToString().Replace(',', '.') + "," + this.TVA_produit.ToString().Replace(',', '.') + "," + this.remise_produit.ToString().Replace(',', '.') + ");";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
              }
              catch
             {
                  MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK);
             }

        }



        public void modifierProduit(string p_libelle_produit, string p_designation_produit, string p_unite_produit, string p_fabricant_produit, string p_ref_fabricant_produit, string p_poids_produit, string p_volume_produit, string p_famille_produit, string p_categorie_produit, string p_produit_critique, int p_stock_min_produit, int p_stock_max_produit, int p_stock_securite_produit, int p_stock_disponible_produit, string p_delai_approv_produit, string p_magasin_produit, string p_emplacement_produit, string p_duree_conservation_produit, double p_prix_moyen_produit, double p_prix_vente_produit, double p_TVA_produit, double p_remise_produit)
        {
            /*try
            {*/
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "update produit set libelle_produit='" + p_libelle_produit + "', designation_produit= '" + p_designation_produit + "' , unite_produit= '" + p_unite_produit + "' , fabricant_produit= '" + p_fabricant_produit + "' , ref_fabricant_produit='" + p_ref_fabricant_produit + "' , poids_produit='" + p_poids_produit + "' , volume_produit='" + p_volume_produit + "' , Famille_idFamille='" + p_famille_produit + "' , Categorie_idCategorie='" + p_categorie_produit + "' , produit_critique='" + p_produit_critique + "' , stock_min_produit= " + p_stock_min_produit + " , stock_max_produit=" + p_stock_max_produit + " , stock_securite_produit=" + p_stock_securite_produit + ", stock_disponible_produit=" + p_stock_disponible_produit + " , delai_approv_produit='" + p_delai_approv_produit + "' , magasin_produit='" + p_magasin_produit + "' , emplacement_produit='" + p_emplacement_produit + "' , duree_conservation='" + p_duree_conservation_produit + "' , prix_moyen_produit=" + p_prix_moyen_produit.ToString().Replace(',', '.') + " , prix_vente_produit= " + p_prix_vente_produit.ToString().Replace(',', '.') + " , TVA_produit= " + p_TVA_produit.ToString().Replace(',', '.') + " , remise_produit= " + p_remise_produit.ToString().Replace(',', '.') + " where code_produit = '" + this.code_produit + "' ;";
                connection.Open();
                Reader = cmd.ExecuteReader();
                connection.Close();
                connection = null;
           /* }
            catch
            {
                MessageBox.Show("Erreur!", "Erreur", MessageBoxButtons.OK);
            }*/

        }


        public void supprimerProduit()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand cmd = connection.CreateCommand();
                MySqlDataReader Reader;
                cmd.CommandText = "delete from produit where code_produit='" + this.code_produit + "';";
                connection.Open();
                Reader = cmd.ExecuteReader();
                connection.Close();
                connection = null;
            }
            catch
            {
                MessageBox.Show("Impossible de se connecter à la BD!", "Erreur", MessageBoxButtons.OK);
            }

        }

    }
}

