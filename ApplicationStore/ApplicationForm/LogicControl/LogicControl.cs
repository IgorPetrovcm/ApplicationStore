using ApplicationStore;
using MDBC;
using MSD;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

namespace ApplicationStore_ApplicationForm
{
    public static class LogicControl
    {

        public static Data_ControlsToForm GetAppInfo(Data_ControlsToForm data,App app)
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
