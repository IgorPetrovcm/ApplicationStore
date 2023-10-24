using MDBC;
using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MCh;
using System.IO;
using System.Drawing;

namespace ApplicationStore_ApplicationForm
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
            List<Roles> roles = new List<Roles>();
            byte index;
            string user_name;


            LogicInterfaceControl.GetInterface(app.Id, out roles, out index, out user_name);
            foreach (Roles role in roles)
            {
                cmbRolesBox.Items.Add(role.NameRole);
            }
            cmbRolesBox.SelectedIndex = index-1;

            user_nameText.Text = user_name;

            MemoryStream ms = new MemoryStream(app.Image);
            icon_appBox.Image = Image.FromStream(ms);

            descriptionBox.Text = app.Description;
            nameBox.Text = app.Name;
            restrictionChkBox.Checked = app.Restrictions;

        }

        private void icon_appBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "image extension (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                byte[] new_iconBytes = File.ReadAllBytes(dialog.FileName);
                MemoryStream ms = new MemoryStream(new_iconBytes);

                icon_appBox.Image = Image.FromStream(ms);
            }
        }
    }
}
