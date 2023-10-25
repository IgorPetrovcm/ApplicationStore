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

namespace ApplicationStore_ApplicationForm
{
    public partial class ApplicationEditForm : Form
    {
        App app;
        string imagePath;
        Image imageIcon;
        public ApplicationEditForm(App app, Image imageIcon)
        {
            InitializeComponent();
            this.app = app;
            this.imageIcon = imageIcon;
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
                imagePath = dialog.FileName;
                byte[] new_iconBytes = File.ReadAllBytes(dialog.FileName);
                MemoryStream ms = new MemoryStream(new_iconBytes);

                icon_appBox.Image = Image.FromStream(ms);
            }
        }

        private void btnSaveNewApp_Click(object sender, EventArgs e)
        {
            /*            MemoryStream ms = new MemoryStream();
                        icon_appBox.Image.Save(ms,ImageFormat.Png);
                        byte[] imageBytes = ms.ToArray();

                        MySqlCommand command = GetResultDB.GetDefaultRequest($"update application_test" +
                                                                             $"set app_image = @image," +
                                                                             $"app_name = '{nameBox.Text}'," +
                                                                             $"app_description = '{descriptionBox.Text}'," +
                                                                             $"app_role_id = {cmbRolesBox.SelectedIndex-1}," +
                                                                             $"app_restrictions = {restrictionChkBox.Checked}" +
                                                                             $"where app_id = {app.Id}");
                        command.Parameters.AddWithValue("@image", imageBytes);
                        int row_add = command.ExecuteNonQuery();*/
            if (icon_appBox.Image != imageIcon)
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

            MySqlCommand command = GetResultDB.GetDefaultRequest($"update application_test " +
                                                                 $"app_name = '{nameBox.Text}' " +
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
