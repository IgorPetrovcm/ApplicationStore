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
        public static Data_ControlsToForm GetAppInfo(App app,Data_ControlsToForm data, bool AuthenticationForEditing)
        {
            /*MySqlDataReader reader;
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

            return data;*/
            Data_ControlsToForm dataToForm;
            if (AuthenticationForEditing == true)
            {

            }
            else
            {
                dataToForm = LogicControl.GetControls_NonEdit(data, app);
                return dataToForm;
            }
        }

        public static Data_ControlsToForm GetControls_NonEdit(Data_ControlsToForm data,App app)
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
    }
}
