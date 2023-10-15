using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore_AdministratorForm
{
    public static class ToAddAppInDB
    {
        public static void AddApp(Data_AddAppInDB data)
        {            
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            string commandString = $"insert into application_test values " +
                                    $"(null,@image,'{data.Name}','{data.Description}',{data.IdRole},{data.User.Id},{data.Restrictions})";

            if (CheckingAccessToDB.ConnectionCheckPing() == true)
            {
                MySqlCommand command = new MySqlCommand(commandString, connection);

                command.Parameters.AddWithValue("@image", data.Image);

                try
                {
                    connection.Open();

                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Image added to database successfully", "Image added", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Image added to database failed", "Image added", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else 
            { 
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            };
        }
    }
    
}
