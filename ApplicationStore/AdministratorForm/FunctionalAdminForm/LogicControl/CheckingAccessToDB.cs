using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ApplicationStore
{
    public static class CheckingAccessToDB
    {
        public static bool ConnectionCheckPing()
        {
            MySqlConnection connection;
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
