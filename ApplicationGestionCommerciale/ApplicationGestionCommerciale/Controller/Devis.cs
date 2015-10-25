using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ApplicationGestionCommerciale
{
    public class Devis
    {
        public string  dv_adresse, dv_ville, dv_pays, dv_email, dv_sitew, dv_note, dv_date, dv_statut;
        public int dv_code, cl_code, dv_cp, dv_fixe, dv_mobile, dv_fax;

        public Devis(int v_code, int v_cl_code, string v_statut, string v_date, string v_adresse, string v_ville, int v_cp, string v_pays, int v_fixe, int v_mobile, int v_fax, string v_email, string v_sitew, string v_note)
        {
            dv_code = v_code;
            cl_code = v_cl_code;
            dv_statut = v_statut;
            dv_date = v_date;
            dv_adresse = v_adresse;
            dv_ville = v_ville;
            dv_cp = v_cp;
            dv_pays = v_pays;
            dv_fixe = v_fixe;
            dv_fax = v_fax;
            dv_mobile = v_mobile;
            dv_email = v_email;
            dv_sitew = v_sitew;
            dv_note = v_note;
        }

        public Devis(int v_code)
        {
            dv_code = v_code;
        }

        public Devis()
        {

        }

        public void dv_ajouter()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "insert into Devis values(" + dv_code + " , " + cl_code + " , '" + dv_statut + "' , '" + dv_date + "' , '" + dv_adresse + "' , '" + dv_ville + "' , " + dv_cp + " , '" + dv_pays + "' , " + dv_fixe + ", " + dv_fax + " , " + dv_mobile + " , '" + dv_email + "' , '" + dv_sitew + "' , '" + dv_note + "');";
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

        public void dv_modifier(int v_cl_code, string v_date, string v_statut, string v_adresse, string v_ville, int v_cp, string v_pays, int v_fixe, int v_mobile, int v_fax, string v_email, string v_sitew, string v_note)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "update Devis set Client_codeClient=" + v_cl_code + ", dv_adresse='" + v_adresse + "', dv_ville='" + v_ville + "', dv_pays='" + v_pays + "', dv_email='" + v_email + "', dv_sitew='" + v_sitew + "', dv_note='" + v_note + "',dv_cp=" + v_cp + " , dv_fixe=" + v_fixe + ", dv_mobile=" + v_mobile + ", dv_fax=" + v_fax + " , dv_date='" + v_date + "' , dv_statut='" + v_statut + "' where dv_code=" + dv_code + ";";
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

        public void dv_supprimer()
        {
            try
            {
                //LigneDevis ld = new LigneDevis();
                //ld.ld_supprimer(dv_code);

                string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;

                command.CommandText = "delete from Devis where dv_code=" + dv_code + ";";
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

    }
}
