using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationStore
{
    public static class LogicOfCheckingAccessToDB
    {
        public static bool RequestUserInfo(string login, string password)
        {
            if ((login.Contains("'") == true) || (password.Contains("'") == true))
            {
                return false;
            }
            else return true;
        }

        public static bool ConnectionCheckPing()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool CommandRequestCheck(string commandString, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(commandString, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows == true) { connection.Close(); return true; }
            else { connection.Close(); return false; }
        }
    }
}

