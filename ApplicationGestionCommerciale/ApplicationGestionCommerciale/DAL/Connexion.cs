using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationGestionCommerciale.DAL
{
    class Connexion
    {
        public static MySqlConnection connect()
        {

            string connectionString = "SERVER=localhost;" + "DATABASE=gestioncommerciale;" +
                "UID=root;" + "PASSWORD=freedomity;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;

        }
    }
}
