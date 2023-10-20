using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace MDBC
{
    public static class BasicDBOperations
    {
         
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch
            {
                con = null;
                MessageBox.Show("Total error. Access to database error");
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public static MySqlCommand GetCommand(MySqlConnection con, string comStr)
        {
            MySqlCommand com = new MySqlCommand(comStr,con);

            return com;            
        }

    }

    public static class GetResultDB
    {
        public static MySqlCommand GetDefaultRequest(string comStr)
        {
            MySqlConnection con = BasicDBOperations.GetConnection();
            MySqlCommand com = BasicDBOperations.GetCommand(con, comStr);

            con.Open();
            return com;
        }

        public static MySqlDataReader GetReader(string comStr)
        {
            MySqlConnection con = BasicDBOperations.GetConnection();

            MySqlCommand com = BasicDBOperations.GetCommand(con, comStr);

            con.Open();
            MySqlDataReader reader = com.ExecuteReader();

            return reader;

        }
    }
}
