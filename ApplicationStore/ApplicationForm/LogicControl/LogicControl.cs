using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationStore;
using ApplicationStore_AdministratorForm;
using MSD;
using MDBC;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using ApplicationStore_AdministratorForm_Add;

namespace ApplicationStore_ApplicationForm
{
    public static class LogicControl
    {
        public static Data_ControlsToForm GetAppInfo(App app,Data_ControlsToForm data)
        {
            MySqlDataReader reader;
            using (reader = GetResultDB.GetReader($"select user_login from users where {app.UserId}"))
            {
                while (reader.Read())
                {
                    data.User_Name.Text = reader.GetString(0);
                }

            }

            using (reader = GetResultDB.GetReader($"select role_name from roles where role_id = {app.RoleId}"))
            {
                while (reader.Read())
                {
                    data.Role.Text = reader.GetString(0);
                }
            }

            using (MemoryStream ms = new MemoryStream(app.Image))
            {
                data.Image.Image = Image.FromStream(ms);
            }

            data.Description.Text = app.Description;
            data.Description.ReadOnly = true;

            data.Restrictions.Checked = app.Restrictions;
            data.Restrictions.Enabled = false;

            return data;
        }

/*        public static Data_ControlsToForm GetAppFunction(Data_ControlsToForm data)
        {
            data.User_Name.DoubleClick += (sender, e) =>
            {
                ChangeTextForm change = new ChangeTextForm();
                change.ShowDialog();
            };

            data.Role.DoubleClick += (sender, e) =>
            {
                LogicInterfaceControl logicInterfaceControl = new LogicInterfaceControl();

                ComboBox cmbRoles = new ComboBox();
                List<Roles> roles = logicInterfaceControl.AddRole();

                foreach (Roles role in roles)
                {
                    cmbRoles.Items.Add(role);
                }

                cmbRoles.Location = new Point(data.Role.Location.X + 20, data.Role.Location.Y);
            };
        }*/
    }
}
