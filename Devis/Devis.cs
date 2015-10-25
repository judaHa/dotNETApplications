using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Devis
{
    class Devis
    {
        string dv_code, cl_code, dv_adresse, dv_ville, dv_pays, dv_email, dv_sitew, dv_note;
        int dv_cp , dv_fixe , dv_mobile , dv_fax ;
        DateTime dv_date;

        public Devis(string v_code, string v_cl_code, string v_adresse, string v_ville, string v_pays, string v_email, string v_sitew, string v_note, int v_cp, int v_fixe, int v_mobile, int v_fax, DateTime v_date)
        {
            dv_code = v_code ;
            cl_code = v_cl_code ;
            dv_adresse = v_adresse ;
            dv_ville = v_ville ;
            dv_pays = v_pays ;
            dv_email = v_email ;
            dv_sitew = v_sitew ;
            dv_note = v_note ;
            dv_cp = v_cp ;
            dv_fixe = v_fixe ;
            dv_mobile = v_mobile ;
            dv_fax = v_fax ;
            dv_date = v_date;
        }

        public Devis(string v_code)
        {
            dv_code = v_code;
        }

        public void dv_ajouter()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=mydb;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "insert into Devis values('" + dv_code + "','" + cl_code + "', '" + dv_adresse + "', '" + dv_ville + "', '" + dv_pays + "', '" + dv_email + "', '" + dv_sitew + "', '" + dv_note + "'," + dv_cp + " , " + dv_fixe + " , " + dv_mobile + " , " + dv_fax + " ,'" + dv_date + "');";
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

        public void dv_modifier(string v_code, string v_cl_code, string v_adresse, string v_ville, string v_pays, string v_email, string v_sitew, string v_note, int v_cp, int v_fixe, int v_mobile, int v_fax, DateTime v_date)
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=mydb;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "update Devis set dv_code='" + v_code + "', cl_code='" + v_cl_code + "', dv_adresse='" + v_adresse + "', dv_ville='" + v_ville + "', dv_pays='" + v_pays + "', dv_email='" + v_email + "', dv_sitew='" + v_sitew + "', dv_note='" + v_note + "',dv_cp=" + v_cp + " , dv_fixe=" + v_fixe + ", dv_mobile=" + v_mobile + ", dv_fax=" + v_fax + " , dv_date=" + v_date + "where dv_code='dv_code';";
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

        public void dv_supprimer()
        {
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=mydb;" + "UID=root;" + "PASSWORD=freedomity;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "delete from Devis where dv_code='" + dv_code + "';";
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
