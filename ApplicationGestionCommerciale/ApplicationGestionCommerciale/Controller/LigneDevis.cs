using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale
{
    class LigneDevis
    {
        int num_ligne_devis;
        int dv_code;
        string pr_code;
        int pr_quantite;
        double pr_montant;

        public LigneDevis(int v_num_ligne_devis, int v_dv_code, string v_pr_code, int v_pr_quantite, double v_pr_montant)
        {
            num_ligne_devis = v_num_ligne_devis;
            dv_code = v_dv_code;
            pr_code = v_pr_code;
            pr_quantite = v_pr_quantite;
            pr_montant = v_pr_montant;
        }

        public LigneDevis(int v_num_ligne_devis)
        {
            num_ligne_devis = v_num_ligne_devis;
        }

        public LigneDevis()
        {

        }

        public void ld_ajouter()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "insert into LigneDevis values(" + num_ligne_devis + " , " + dv_code + " , '" + pr_code + "' ," + pr_quantite + " , " + pr_montant.ToString().Replace(',', '.') + ");";
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

        public void ld_modifier(int v_dv_code, string v_pr_code, int v_pr_quantite, double v_pr_montant)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "update LigneDevis set dv_code = " + v_dv_code + " , pr_code = '" + v_pr_code + "' , pr_quantite = " + v_pr_quantite + " , pr_montant = " + v_pr_montant.ToString().Replace(',', '.') + " where num_ligne_devis = " + num_ligne_devis + ";";
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

        public void ld_supprimer()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "delete from LigneDevis where num_ligne_devis=" + num_ligne_devis + ";";
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

        public void ld_supprimer(string v_dv_code)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;

                command.CommandText = "delete from Devis where dv_code=" + v_dv_code + ";";
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
