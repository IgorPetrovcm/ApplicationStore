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
            finally
            {
                connection.Close();
            }
        }

        public static bool CommandRequestcheck(MySqlConnection connection, string commandString, byte[] imageBytes,byte userId, byte roleId)
        {
            MySqlCommand command = new MySqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@image", imageBytes);
            command.Parameters.AddWithValue("@user_id", userId);
            command.Parameters.AddWithValue("@role_id", roleId);

            try
            {
                connection.Open();
                int countRows = command.ExecuteNonQuery();

                if (countRows != 0)
                {
                    return true;
                }
                else return false;
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
