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
        public AddApplicationForm(User user)
        {
            InitializeComponent();

            var logicObject = new LogicObjectControl();
            List<string> rolesStrings = logicObject.AddRoleAcess();
            
            foreach (string role in rolesStrings)
            {
                cmbRolesBox.Items.Add(role);    
            }
        }

        private void btnAddIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
