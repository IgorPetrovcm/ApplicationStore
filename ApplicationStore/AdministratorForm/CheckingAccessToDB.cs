using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ApplicationStore_AdministratorForm
{
    public static class CheckingAccessToDB
    {
        public static bool ConnectionCheckPing(out string connectionString)
        {
            connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Error access to database");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
