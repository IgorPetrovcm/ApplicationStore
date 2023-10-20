using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDBC;
using MSD;
using MySql.Data.MySqlClient;

namespace ApplicationStore.ApplicationForm
{
    public partial class ApplicationEditForm : Form
    {
        App app;
        public ApplicationEditForm(App app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void ApplicationEditForm_Load(object sender, EventArgs e)
        {
            using (MySqlDataReader reader = GetResultDB.GetReader($"select user_login from users where {app.UserId}"))
            {
                while (reader.Read())
                {
                    user_nameText.Text = reader.GetString(0);
                }

            }
        }
    }
}
