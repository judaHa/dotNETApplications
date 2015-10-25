using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale
{
    class LigneCommandeAchat
    {
        int num_ligne_commande;
        int cma_code;
        string pr_code;
        int pr_quantite;
        double pr_montant;


        public LigneCommandeAchat(int v_num_ligne_commande, int v_cma_code, string v_pr_code, int v_pr_quantite, double v_pr_montant)
        {
            num_ligne_commande = v_num_ligne_commande;
            cma_code = v_cma_code;
            pr_code = v_pr_code;
            pr_quantite = v_pr_quantite;
            pr_montant = v_pr_montant;
        }

        public LigneCommandeAchat(int v_num_ligne_commande)
        {
            num_ligne_commande = v_num_ligne_commande;
        }

        public LigneCommandeAchat()
        {

        }

        public void lcma_ajouter()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "insert into LigneCommandeAchat values(" + num_ligne_commande + ", " + cma_code + ", '" + pr_code + "', " + pr_quantite + ", " + pr_montant.ToString().Replace(',', '.') + ");";
                connection.Open();
                Reader = command.ExecuteReader();

                connection.Close();
                connection = null;
            }
            catch
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

        public void lcma_modifier(int v_cma_code, string v_pr_code, int v_pr_quantite, double v_pr_montant)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "update LigneCommandeAchat set cma_code=" + v_cma_code + ", pr_code = '" + v_pr_code + "', pr_quantite =" + v_pr_quantite + ", pr_montant=" + v_pr_montant.ToString().Replace(',', '.') + ";";
                connection.Open();
                Reader = command.ExecuteReader();

                connection.Close();
                connection = null;
            }
            catch
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

        public void lcma_supprimer()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "delete from LigneCommandeAchat where num_ligne_commande=" + num_ligne_commande + ";";
                connection.Open();
                Reader = command.ExecuteReader();

                connection.Close();
                connection = null;
            }
            catch
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

        public void lcma_supprimer(string v_cma_code)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "delete from LigneCommandeAchat where cma_code=" + v_cma_code + ";";
                connection.Open();
                Reader = command.ExecuteReader();

                connection.Close();
                connection = null;
            }
            catch
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

    }

}
