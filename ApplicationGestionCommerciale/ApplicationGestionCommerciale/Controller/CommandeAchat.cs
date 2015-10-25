using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale
{
    public class CommandeAchat
    {

        public string  cma_statut, cma_adresse, cma_ville, cma_pays, cma_email, cma_sitew, cma_note, cma_date, cma_date_liv;
        public int cma_code, fr_code, cma_cp, cma_fixe, cma_mobile, cma_fax;

        public CommandeAchat(int v_code, int v_fr_code, string v_statut, string v_date, string v_date_liv, string v_adresse, string v_ville, int v_cp, string v_pays, int v_fixe, int v_mobile, int v_fax, string v_email, string v_sitew, string v_note)
        {
            cma_code = v_code;
            fr_code = v_fr_code;
            cma_statut = v_statut;
            cma_date = v_date;
            cma_date_liv = v_date_liv;
            cma_adresse = v_adresse;
            cma_ville = v_ville;
            cma_cp = v_cp;
            cma_pays = v_pays;
            cma_fixe = v_fixe;
            cma_mobile = v_mobile;
            cma_fax = v_fax;
            cma_email = v_email;
            cma_sitew = v_sitew;
            cma_note = v_note;
        }

        public CommandeAchat(int v_code)
        {
            cma_code = v_code;
        }

        public CommandeAchat()
        {

        }

        public void cma_ajouter()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "insert into CommandeAchat values(" + cma_code + "," + fr_code + ",'" + cma_statut + "', '" + cma_date + "', '" + cma_date_liv + "', '" + cma_adresse + "', '" + cma_ville + "', '" + cma_cp + "', '" + cma_pays + "', " + cma_fixe + "," + cma_mobile + "," + cma_fax + ", '" + cma_email + "', '" + cma_sitew + "', '" + cma_note + "');";
                connection.Open();
                Reader = command.ExecuteReader();
                connection.Close();
                connection = null;
            }
            catch (Exception )
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

        public void cma_modifier(int v_fr_code, string v_statut, string v_date, string v_date_liv, string v_adresse, string v_ville, int v_cp, string v_pays, int v_fixe, int v_mobile, int v_fax, string v_email, string v_sitew, string v_note)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "update CommandeAchat set cma_code=" + cma_code + ", fr_code =" + v_fr_code + ", cma_statut='" + v_statut + "', cma_date = '" + v_date + "', cma_date_liv ='" + v_date_liv + "', cma_adresse='" + v_adresse + "', cma_ville='" + v_ville + "', cma_cp=" + v_cp + ", cma_pays='" + v_pays + "', cma_fixe=" + v_fixe + ", cma_mobile=" + v_mobile + ",cma_fax=" + v_fax + " , cma_email='" + v_email + "', cma_sitew='" + v_sitew + "', cma_note='" + v_note + "' where cma_code='" + cma_code + "';";
                connection.Open();
                Reader = command.ExecuteReader();
                connection.Close();
                connection = null;
            }
            catch (MySqlException )
            {
                MessageBox.Show("Le code commande existe déjà .", "Erreur", MessageBoxButtons.OK);
            }
            catch (Exception )
            {
                MessageBox.Show("Impossible de se connecter à la base de données!", "Erreur", MessageBoxButtons.OK);
            }
        }

        public void cma_supprimer()
        {
            try
            {
                //LigneCommandeAchat lcma = new LigneCommandeAchat();
                //lcma.lcma_supprimer(cma_code);

                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "delete from CommandeAchat where cma_code=" + cma_code + ";";
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
