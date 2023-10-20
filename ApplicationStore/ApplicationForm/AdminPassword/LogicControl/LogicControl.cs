using ApplicationStore.ApplicationForm;
using MDBC;
using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore_ApplicationForm_AdminPassword
{
    public static class LogicControl
    {
        public static void CheckPassword(User user,TextBox password, App app, RequestAdminPasswordForm form)
        {
            using (MySqlDataReader reader = GetResultDB.GetReader($"select user_password from users where user_id = {user.Id}"))
            {
                while (reader.Read())
                {
                    if (password.Text == (string)reader.GetValue(0))
                    {
                        ApplicationEditForm edit = new ApplicationEditForm(app);
                        edit.Show();

                        form.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        password.Text = "";
                    }
                }
            }
        }
    }
}
