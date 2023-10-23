using MDBC;
using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MCh;
using System.IO;
using System.Drawing;
using ApplicationStore_AdministratorForm_Add;

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

            icon_appBox.Image = LogicReadControl.GetImage($"select app_image from application_test where app_id = {app.Id}");

            List<Roles> roles = LogicReadControl.GetItemsFromRoles("select * from roles");
            foreach (Roles role in roles)
            {
                cmbRolesBox.Items.Add(role.NameRole);
            }

            byte index = LogicReadControl.GetSelectedIndexFromRoles($"select app_role_id from application_test where app_id = {app.Id}");
            cmbRolesBox.SelectedIndex = index-1;
            /*List<Roles> roles = new List<Roles>();

            using (MySqlDataReader reader = GetResultDB.GetReader($"select user_login from users where user_id = {app.UserId}"))
            {
                while (reader.Read())
                {
                    user_nameText.Text = reader.GetString(0);
                }
            }
            using (MySqlDataReader reader = GetResultDB.GetReader($"select role_name from roles where role_id = '{app.RoleId}'"))
            {
                while (reader.Read())
                {
                    cmbRolesBox.Items.Add((string)reader.GetValue(0));
                    cmbRolesBox.SelectedIndex = 0;
                }
            }
            using (MySqlDataReader reader = GetResultDB.GetReader($"select * from roles"))
            {
                while (reader.Read())
                {
                    Roles role = new Roles((byte)reader.GetValue(0), (string)reader.GetValue(1));
                    if (ChecksEntities.CheckRole(role))
                    {
                        cmbRolesBox.Items.Add(role.NameRole);
                    }
                }
            }

            using (MySqlDataReader reader = GetResultDB.GetReader($"select app_ageRestriction from application_test where app_id = {app.Id}"))
            {
                while (reader.Read())
                {
                    restrictionChkBox.Checked = (bool)reader.GetValue(0);
                }
            }

            using (MySqlDataReader reader = GetResultDB.GetReader($"select app_image from application_test where app_id = {app.Id}"))
            {
                while (reader.Read())
                {
                    byte[] imageBytes = (byte[])reader.GetValue(0);

                    MemoryStream ms = new MemoryStream(imageBytes);

                    icon_appBox.Image = Image.FromStream(ms);

*//*                    icon_appBox.DoubleClick += (sender, e) =>
                    {

                    };*//*
                }
            }
            using (MySqlDataReader reader = GetResultDB.GetReader($"select app_description from application_test where app_id = {app.Id}"))
            {
                while (reader.Read())
                {
                    descriptionBox.Text = (string)reader.GetValue(0);
                }
            }
            using (MySqlDataReader reader = GetResultDB.GetReader($"select app_name from application_test where app_id = {app.Id}"))
            {
                while (reader.Read())
                {
                    nameBox.Text = (string)reader.GetValue(0);
                }
            }*/
        }
    }
}
