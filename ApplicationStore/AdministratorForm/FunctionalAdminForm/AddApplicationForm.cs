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
        string imageExtension;
        User user;
        List<Roles> roles;
        LogicInterfaceControl logicInterfaceControl = new LogicInterfaceControl();

        public AddApplicationForm(User user)
        {
            InitializeComponent();
            this.user = user;

            roles = logicInterfaceControl.AddRole();
            
            foreach (Roles role in roles)
            {
                cmbRolesBox.Items.Add(role.NameRole);    
            }
        }

        private void btnAddIcon_Click(object sender, EventArgs e)
        {
            iconBox1.Image = logicInterfaceControl.AddIcon(out imageExtension);
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = UnitLogicInterfaceControl.GetImageBytes(iconBox1, imageExtension);
            IEnumerable<byte> idrole = from roleName in roles where roleName.NameRole == cmbRolesBox.SelectedItem.ToString() select roleName.IdRole;

            byte idRole = 0;
            foreach (byte id in idrole)
            {
                idRole = id;
            }
            ToAddAppInDB.AddApp(user, imageBytes, nameBox.Text, descriptionBox.Text, idRole, checkRestrictionsOfAge.Checked);
        }
    }
}
