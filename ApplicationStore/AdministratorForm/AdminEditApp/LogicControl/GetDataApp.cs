using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSD;
using ApplicationStore_AdministratorForm;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ApplicationStore_AdministratorForm_Edit
{
    public static class GetDataApps
    {
        public static List<App> GetApp()
        {
            string connectionString = null;
            string commandString = "select * from application_test";
            if (CheckingAccessToDB.ConnectionCheckPing(out connectionString)==true)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(commandString,connection);

                connection.Open();

                try
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    List<App> apps = new List<App>();

                    while (reader.Read())
                    {
                        App app = new App();

                        app.Id = (byte) reader.GetValue(0);
                        app.Image = (byte[]) reader.GetValue(1);
                        app.Name = (string) reader.GetValue(2);
                        app.Description = (string) reader.GetValue(3);
                        app.RoleId = (byte) reader.GetValue(4);
                        app.UserId = (byte) reader.GetValue(5);
                        app.Restrictions = (bool) reader.GetValue(6);

                        apps.Add(app);
                    }
                    connection.Close();
                    return apps;
                }
                catch
                {
                    MessageBox.Show("Total error. Request failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }                 
            }
            else 
            { 
                return null; 
            }
        }
    }
}
