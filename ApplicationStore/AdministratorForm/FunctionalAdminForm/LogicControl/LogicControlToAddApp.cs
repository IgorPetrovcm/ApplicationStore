using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore
{
    public static class LogicControlToAddApp
    {
        public static void AddApp(User user,string appName,string appDesctiption,byte idRole,bool restrictions)
        {
            byte[] image = UnitLogic.SearchImage();

            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            string commandString = $"insert into application_test values " +
                                    $"(null,@image,'{appName}','{appDesctiption}',{idRole},{user.Id},{restrictions})";

            if (CheckingAccessToDB.ConnectionCheckPing() == true)
            {
                MySqlCommand command = new MySqlCommand(commandString, connection);

                command.Parameters.AddWithValue("@image", image);

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

    public class LogicObjectControl
    {

        public List<Roles> AddRoleAcess()
        {
            List<Roles> roles = new List<Roles>();

            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            string commandString = "select role_id,role_name from roles";
            if (CheckingAccessToDB.ConnectionCheckPing() == true)
            {
                MySqlCommand command = new MySqlCommand(commandString, connection);

                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        Roles role = new Roles(Convert.ToByte(reader.GetValue(0)), Convert.ToString(reader.GetValue(1)));
                        roles.Add(role);
                    }
                    return roles;
                }
                catch
                {
                    MessageBox.Show("Request error database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    connection.Close();
                }                
            }
            else return null;
        }
    }
    
}
