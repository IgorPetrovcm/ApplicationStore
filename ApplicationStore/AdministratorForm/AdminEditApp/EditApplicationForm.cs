using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MSD;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ApplicationStore_AdministratorForm_Edit
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
            int i = 1;
            List<Control> controlsNames = LogicControl.PanelAddAppName(user,ref i);
            textBox1.Text = Convert.ToString(user.IdRole);

            foreach (Control control in controlsNames)
            {
                panel1.Controls.Add(control);                
            }

        }
    }
}
