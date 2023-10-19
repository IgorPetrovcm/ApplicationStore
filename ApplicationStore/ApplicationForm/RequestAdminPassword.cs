using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSD;
using MDBC;
using MySql.Data.MySqlClient;

namespace ApplicationStore_ApplicationForm
{
    public partial class RequestAdminPassword : Form
    {
        User user;
        public RequestAdminPassword(User user)
        {
            InitializeComponent();
            this.user = user;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlDataReader reader = GetResultDB.GetReader($"select user_password from users where user_id = {user.Id}"))
            {
                while (reader.Read())
                {
                    if (user_passwordBox.Text == (string)reader.GetValue(0))
                    {

                    }
                }
            }
        }
    }
}
