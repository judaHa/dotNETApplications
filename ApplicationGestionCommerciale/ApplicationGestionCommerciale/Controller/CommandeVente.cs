using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale
{
    public class CommandeVente
    {

        public string  cmv_statut, cmv_adresse, cmv_ville, cmv_pays, cmv_email, cmv_sitew, cmv_note, cmv_date, cmv_date_liv;
        public int cmv_code, cl_code, cmv_cp, cmv_fixe, cmv_mobile, cmv_fax;
        public double cmv_frais;

        public CommandeVente(int v_code, int v_cl_code, string v_statut, string v_date, string v_date_liv, string v_adresse, string v_ville, int v_cp, string v_pays, int v_fixe, int v_mobile, int v_fax, string v_email, string v_sitew, string v_note, double v_frais)
        {
            cmv_code = v_code;
            cl_code = v_cl_code;
            cmv_statut = v_statut;
            cmv_date = v_date;
            cmv_date_liv = v_date_liv;
            cmv_adresse = v_adresse;
            cmv_ville = v_ville;
            cmv_cp = v_cp;
            cmv_pays = v_pays;
            cmv_fixe = v_fixe;
            cmv_mobile = v_mobile;
            cmv_fax = v_fax;
            cmv_email = v_email;
            cmv_sitew = v_sitew;
            cmv_note = v_note;
            cmv_frais = v_frais; ;
        }

        public CommandeVente(int v_code)
        {
            cmv_code = v_code;
        }

        public CommandeVente()
        {

        }

        public void cmv_ajouter()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "insert into CommandeVente values(" + cmv_code + ", " + cl_code + ", '" + cmv_statut + "', '" + cmv_date + "', '" + cmv_date_liv + "', '" + cmv_adresse + "', '" + cmv_ville + "', " + cmv_cp + ", '" + cmv_pays + "', " + cmv_fixe + "," + cmv_mobile + "," + cmv_fax + ", '" + cmv_email + "', '" + cmv_sitew + "', '" + cmv_note + "'," + cmv_frais.ToString().Replace(',', '.') + ");";
                connection.Open();
                Reader = command.ExecuteReader();
                connection.Close();
                connection = null;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Le code commande existe déjà .", "Erreur", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

        public void cmv_modifier(int v_cl_code, string v_statut, string v_date, string v_date_liv, string v_adresse, string v_ville, int v_cp, string v_pays, int v_fixe, int v_mobile, int v_fax, string v_email, string v_sitew, string v_note, double v_frais)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "update CommandeVente set cl_code =" + v_cl_code + ", cmv_statut='" + v_statut + "', cmv_date = '" + v_date + "', cmv_date_liv ='" + v_date_liv + "', cmv_adresse='" + v_adresse + "', cmv_ville='" + v_ville + "', cmv_cp=" + v_cp + ", cmv_pays='" + v_pays + "', cmv_fixe=" + v_fixe + ", cmv_mobile=" + v_mobile + ",cmv_fax=" + v_fax + " , cmv_email='" + v_email + "', cmv_sitew='" + v_sitew + "', cmv_note='" + v_note + "', cmv_frais = " + v_frais.ToString().Replace(',', '.') + " where cmv_code=" + cmv_code + ";";
                connection.Open();
                Reader = command.ExecuteReader();
                connection.Close();
                connection = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

        public void cmv_supprimer()
        {
            try
            {
                //LigneCommandeVente lcmv = new LigneCommandeVente();
                //lcmv.lcma_supprimer(cmv_code);

                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "delete from CommandeVente where cmv_code=" + cmv_code + ";";
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
