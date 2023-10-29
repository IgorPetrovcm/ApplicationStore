using MDBC;
using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MCh;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace ApplicationStore_ApplicationForm
{
    public partial class ApplicationEditForm : Form
    {
        App app;
        string imagePath;
        bool iconEdit = false;
        List<Roles> roles = new List<Roles>();

        public ApplicationEditForm(App app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void ApplicationEditForm_Load(object sender, EventArgs e)
        {
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
                iconEdit = true;
                imagePath = dialog.FileName;

                byte[] new_iconBytes = File.ReadAllBytes(dialog.FileName);
                MemoryStream ms = new MemoryStream(new_iconBytes);

                icon_appBox.Image = Image.FromStream(ms);
            }
        }

        private void btnSaveNewApp_Click(object sender, EventArgs e)
        {
            LogicInterfaceControl.OutputEditImageApp(iconEdit, imagePath, app.Id);

            byte id_role = LogicInterfaceControl.OutputSelectedRoleIndex(roles, cmbRolesBox);

            EditAppToDB.ToDB(nameBox.Text, descriptionBox.Text, id_role, restrictionChkBox.Checked, app.Id);
        }

        private void btnDeleteApp_Click(object sender, EventArgs e)
        {
            MySqlCommand command = GetResultDB.GetDefaultRequest($"delete from application_test where app_id = {app.Id}");
            int rowDelete = command.ExecuteNonQuery();
            if (rowDelete > 0)
            {
                MessageBox.Show("Application delete!","Application edit");
            }
            else
            {
                MessageBox.Show("Delete error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
