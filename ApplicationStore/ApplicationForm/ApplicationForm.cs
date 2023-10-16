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
using System.IO;
using MySql.Data.MySqlClient;

namespace ApplicationStore_ApplicationForm
{
    public partial class ApplicationForm : Form
    {
        App app;
        public ApplicationForm(App app)
        {
            InitializeComponent();

            this.app = app;

            MemoryStream ms = new MemoryStream(app.Image);
            icon_appBox.Image = Image.FromStream(ms);

            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=Igor@147258369Lok;database=sales");
            string commandString = $"select user_login from users where user_id = {app.UserId}";

            MySqlCommand command = new MySqlCommand(commandString, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                user_nameText.Text = reader.GetString(0);
            }
            connection.Close();

        }

    }
}
