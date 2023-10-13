using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore
{
    public partial class AddApplicationForm : Form
    {
        User user;
        List<Roles> roles;
        public AddApplicationForm(User user)
        {
            InitializeComponent();
            this.user = user;

            var logicObject = new LogicObjectControl();
            roles = logicObject.AddRoleAcess();
            
            foreach (Roles role in roles)
            {
                cmbRolesBox.Items.Add(role.NameRole);    
            }
        }

        private void btnAddIcon_Click(object sender, EventArgs e)
        {
            if ((nameBox.Text != null) && (cmbRolesBox.SelectedItem.ToString() != "") && (textBox1.Text != ""))
            {
                byte roleId = roles.Where(x => x.NameRole == cmbRolesBox.SelectedItem.ToString()).FirstOrDefault().IdRole;
                LogicControlToAddApp.AddApp(user, nameBox.Text, textBox1.Text,roleId,checkRestrictionsOfAge.Checked);
            }
        }
    }
}
