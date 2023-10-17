using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static MySqlDataReader GetReader(string comStr)
        {
            MySqlConnection con = BasicDBOperations.GetConnection();

            MySqlCommand com = BasicDBOperations.GetCommand(con, comStr);

            con.Open();
            MySqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                return reader;
            }
            else
            {
                MessageBox.Show("Error request", "Total error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
