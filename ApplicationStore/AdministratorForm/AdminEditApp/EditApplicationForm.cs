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
            EventHandler ev = new EventHandler();
            int i = 1;
            List<Control> controlsNames = LogicControl.PanelAddAppName(ref i);

            foreach (Control control in controlsNames)
            {
                panel1.Controls.Add(control);                
            }

            i = 1;
            List<Control> controlsIcons = LogicControl.PanelAddAppIcon(ref i);

            foreach ( Control control in controlsIcons)
            {
                control.DoubleClick +=  =>
                {

                };
                panel1.Controls.Add(control);
            }
        }
    }
}
