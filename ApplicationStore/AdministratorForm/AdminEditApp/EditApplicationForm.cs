using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MSD;
using System.Collections.Generic;

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
            List<Control> controls = LogicControl.PanelAddAppToDB(user);
            foreach (Control control in controls)
            {
                panel1.Controls.Add(control);
            }
        }
    }
}
