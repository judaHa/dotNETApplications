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
    class Famille
    {
        string id_famille;
        public Famille(string id_famille)
        {
            this.id_famille = id_famille;
        }

        public void ajouterFamille()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            cmd.CommandText = "insert into famille values('" + this.id_famille + "');";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }


        /*public void modifierFamille()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            cmd.CommandText = "update famille set id_famille='" + this.id_famille + "';";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }*/

        public void supprimerFamille()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            cmd.CommandText = "delete from famille where id_famille='" + this.id_famille + "';";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }
       

    }
}
