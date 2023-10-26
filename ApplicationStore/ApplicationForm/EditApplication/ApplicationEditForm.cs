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

            if (iconEdit == true)
            {
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                MySqlCommand commandEditImage = GetResultDB.GetDefaultRequest($"update application_test " +
                                                                          $"set app_image = @image where app_id = {app.Id}");
                commandEditImage.Parameters.AddWithValue("@image", imageBytes);
                int addImage = commandEditImage.ExecuteNonQuery();
                if (addImage > 0)
                {
                    MessageBox.Show("Successfully add image", "Save image", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error add image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            byte idRole = 0;
            IEnumerable<byte> roles_id = from roleName in roles where roleName.NameRole == cmbRolesBox.SelectedItem.ToString() select roleName.IdRole;
            foreach (byte id in roles_id)
            {
                idRole = id;
            }

            MySqlCommand command = GetResultDB.GetDefaultRequest($"update application_test " +
                                                                 $"set app_name = '{nameBox.Text}', " +
                                                                 $"app_description = '{descriptionBox.Text}', " +
                                                                 $"app_role_id = {idRole}, " +
                                                                 $"app_ageRestriction = {restrictionChkBox.Checked} " +
                                                                 $"where app_id = {app.Id}");
            int add = command.ExecuteNonQuery();
            if (add > 0)
            {
                MessageBox.Show("Successfully","Save",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Total error","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
