using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore
{
    public partial class EditApplicationForm : Form
    {
        User user;
        public EditApplicationForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EditApplicationForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string commandString = @"select * from application_test";
            MySqlCommand command = new MySqlCommand(commandString, connection);

            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                TextBox appName = new TextBox()
                {
                    Text = reader.GetValue(2).ToString(),
                    ReadOnly = true,
                    Size = new Size(175, 0),
                    Location = new Point(55, i * 60 + 10),
                    BorderStyle = BorderStyle.None,
                    BackColor = SystemColors.Menu,
                };

                PictureBox appIcon = new PictureBox()
                {
                    Size = new Size(45, 45),
                    Location = new Point(5, i * 60 + 10),
                };
                i++;
                byte[] imageBytes = (byte[])reader.GetValue(1);

                MemoryStream ms = new MemoryStream(imageBytes);
                appIcon.Image = Image.FromStream(ms);   

                panel1.Controls.Add(appIcon);
                panel1.Controls.Add(appName);
            }
            connection.Close();

        }
    }
}
