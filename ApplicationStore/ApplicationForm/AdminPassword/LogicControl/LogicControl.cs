using ApplicationStore_ApplicationForm;
using MDBC;
using MSD;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationStore_ApplicationForm_AdminPassword
{
    public static class LogicControl
    {
        public static void CheckPassword(User user,TextBox password, App app, RequestAdminPasswordForm form,Image imageIcon)
        {
            using (MySqlDataReader reader = GetResultDB.GetReader($"select user_password from users where user_id = {user.Id}"))
            {
                while (reader.Read())
                {
                    if (password.Text == (string)reader.GetValue(0))
                    {
                        ApplicationEditForm edit = new ApplicationEditForm(app,imageIcon);
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
