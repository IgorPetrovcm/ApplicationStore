using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using MDBC;
using ApplicationStore_AdministratorForm;
using MCh;
using ApplicationStore_AdministratorForm_Edit;

namespace ApplicationStore_AuthorizationForm
{
    public static class LogicControl
    {
        public static User GetUser(string login, string password)
        {
            User user = new User();

            MySqlDataReader reader = GetResultDB.GetReader("select user_id,user_login,user_yearbirth,user_id_role from users " +
                $"where user_login = '{login}' and user_password = '{password}'");

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i) == "user_id")
                    {
                        user.Id = Convert.ToByte(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_login")
                    {
                        user.Login = Convert.ToString(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_yearbirth")
                    {
                        user.Yearbirth = Convert.ToInt32(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_id_role")
                    {
                        user.IdRole = Convert.ToByte(reader.GetValue(i));
                    }
                }
            }
            if (ChecksEntities.CheckUser(user))
            {
                if (user.IdRole == 1)
                {
                    EditApplicationForm appsForm = new EditApplicationForm(user);
                    appsForm.ShowDialog();
                    return user;
                }
                AdministratorForm admin = new AdministratorForm(user);
                admin.ShowDialog();

                return user;
            }
            else
            {
                MessageBox.Show("Incorrect login or password", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
