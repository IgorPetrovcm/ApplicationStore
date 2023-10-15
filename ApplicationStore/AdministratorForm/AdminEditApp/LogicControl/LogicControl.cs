using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSD;
using ApplicationStore_AdministratorForm;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace ApplicationStore_AdministratorForm_Edit
{
    public class LogicControl
    {
        public static List<Control> PanelAddAppToDB()
        {
            string test;
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            string commandString = @"select * from application_test";

            if (CheckingAccessToDB.ConnectionCheckPing(out test) == true)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(commandString, connection);

                using (connection)
                {

                    try
                    {
                        connection.Open();

                        MySqlDataReader reader = command.ExecuteReader();

                        int i = 0;
                        Panel panel = new Panel();
                        List<Control> controls = new List<Control>();

                        while (reader.Read())
                        {
                            TextBox appName = PropertyStructure.GetNameAppBox(i, reader);

                            PictureBox appIcon = PropertyStructure.GetIconApp(i, reader);
                            i++;

                            controls.Add(appName);
                            controls.Add(appIcon);
                        }

                        connection.Close();
                        return controls;
                    }
                    catch
                    {
                        MessageBox.Show("Error access to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Total error. Missing database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
