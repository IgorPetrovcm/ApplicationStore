using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

            MySqlConnection connection;
            string commandString = "insert into application_test values (null,'@image','@appname','@appdescription','@roleid','@userid','@restrictions')";

            if (CheckingAccessToDB.ConnectionCheckPing(out connection) == true)
            {
                MySqlCommand command = new MySqlCommand(commandString, connection);

                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@appname", appName);
                command.Parameters.AddWithValue("@appdescription", appDesctiption);
                command.Parameters.AddWithValue("@roleid", idRole);
                command.Parameters.AddWithValue("@userid", user.Id);
                command.Parameters.AddWithValue("@restrictions", restrictions);

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
                        MessageBox.Show("Image added to database failed", "Image added", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            else { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; };
        }
    }

    public class LogicObjectControl
    {
        public List<string> AddRoleAcess()
        {
            MySqlConnection connection;
            string commandString = "select * from roles";
            List<string> rolesAccessStrings = new List<string>();

            if (CheckingAccessToDB.ConnectionCheckPing(out connection) == true)
            {
                MySqlCommand command = new MySqlCommand(commandString, connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    rolesAccessStrings.Add(Convert.ToString(reader.GetValue(1)));
                }
                connection.Close();
                return rolesAccessStrings;
            }
            else return null;
        }
    }
    
}
