using MSD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ApplicationStore_AdministratorForm_Add
{
    public partial class AddApplicationForm : Form
    {
        string imageExtension;
        User user;
        List<Roles> roles;

        public AddApplicationForm(User user)
        {
            InitializeComponent();

            this.user = user;

            roles = LogicInterfaceControl.AddRole();

            foreach (Roles role in roles)
            {
                cmbRolesBox.Items.Add(role.NameRole);
            }
        }

        private void btnAddIcon_Click(object sender, EventArgs e)
        {
            iconBox1.Image = LogicInterfaceControl.AddIcon(out imageExtension);
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            Data_LogicDataApp data = new Data_LogicDataApp(iconBox1,imageExtension,roles,cmbRolesBox,user,nameBox.Text,descriptionBox.Text,checkRestrictionsOfAge);
            LogicInterfaceControl.LogicDataApp(data);

            this.Close();
        }

    }
}
