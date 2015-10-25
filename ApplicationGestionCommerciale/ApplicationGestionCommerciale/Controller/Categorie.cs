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
    class Categorie
    {
        string id_categorie;

        public Categorie(string id_categorie)
        {
            this.id_categorie = id_categorie;
        }

        public void ajouterCategorie()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            cmd.CommandText = "insert into categorie values('" + this.id_categorie + "');";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }


      /*  public void modifierCategorie()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            cmd.CommandText = "update categorie set id_categorie='" + this.id_categorie + "';";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }*/


        public void supprimerCategorie()
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" + "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            cmd.CommandText = "delete from categorie where id_categorie='" + this.id_categorie + "';";
            connection.Open();
            Reader = cmd.ExecuteReader();
            connection.Close();
            connection = null;
        }

    }
}
