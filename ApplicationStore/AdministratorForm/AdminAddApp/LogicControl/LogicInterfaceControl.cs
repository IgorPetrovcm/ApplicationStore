using ApplicationStore_AdministratorForm;
using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MDBC;
using MCh;

namespace ApplicationStore_AdministratorForm_Add
{
    public static class LogicInterfaceControl
    {
        public static List<Roles> AddRole()
        {
            List<Roles> roles = new List<Roles>();

            MySqlDataReader reader = GetResultDB.GetReader("select role_id,role_name from roles");

            try
            {
                while (reader.Read())
                {
                    Roles role = new Roles((byte)reader.GetValue(0), (string)reader.GetValue(1));

                    if (ChecksEntities.CheckRole(role))
                    {
                        roles.Add(role);
                    }
                    else
                    {
                        MessageBox.Show("There are errors in the output of roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                return roles;
            }
            catch
            {
                MessageBox.Show("Request error database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Image AddIcon(out string imageExtension)
        {
            byte[] imageByte = LogicControl.SearchImage(out imageExtension);

            using (MemoryStream ms = new MemoryStream(imageByte))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public static void LogicDataApp(Data_LogicDataApp data)
        {
            byte[] imageBytes = LogicControl.GetImageBytes(data.Icon, data.Extension);
            IEnumerable<byte> idrole = from roleName 
                                       in data.Roles 
                                       where roleName.NameRole == 
                                       data.Cmb_Roles.SelectedItem.ToString() 
                                       select roleName.IdRole;

            byte idRole = 0;
            foreach (byte id in idrole)
            {
                idRole = id;
            }

            Data_AddAppInDB dataApp = new Data_AddAppInDB(data.User, imageBytes, data.Name, data.Description, idRole, data.Restrictions.Checked);

            if (ChecksData.ChecksData_App_Add(dataApp))
            {
                ToAddAppInDB.AddApp(dataApp);
            }            
        }
    }
}
