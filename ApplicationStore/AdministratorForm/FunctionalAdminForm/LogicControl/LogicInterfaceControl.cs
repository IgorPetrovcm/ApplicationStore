using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore
{
    public class LogicInterfaceControl
    {

        public List<Roles> AddRole()
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

        public Image AddIcon(out string imageExtension)
        {
            byte[] imageByte = UnitLogicInterfaceControl.SearchImage(out imageExtension);
            MemoryStream ms = new MemoryStream(imageByte);

            Image image = Image.FromStream(ms);
            return image;
        }

        public void LogicDataApp(Data_LogicDataApp data)
        {
            byte[] imageBytes = UnitLogicInterfaceControl.GetImageBytes(data.Icon, data.Extension);
            IEnumerable<byte> idrole = from roleName in data.Roles where roleName.NameRole == data.Cmb_Roles.SelectedItem.ToString() select roleName.IdRole;

            byte idRole = 0;
            foreach (byte id in idrole)
            {
                idRole = id;
            }

            Data_AddAppInDB dataApp = new Data_AddAppInDB(data.User, imageBytes, data.Name, data.Description, idRole, data.Restrictions.Checked);
            ToAddAppInDB.AddApp(dataApp);            
        }
    }
}
