using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSD;
using ApplicationStore_AdministratorForm;

namespace ApplicationStore_AuthorizationForm
{
    public partial class AuthorizationForm : Form
    {
        User user;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            user = LogicControl.ReaderDBRequest(loginTextBox.Text,passwordTextBox.Text);
            if (user != null )
            {
                AdministratorForm adminForm = new AdministratorForm(user);
                adminForm.ShowDialog();
            }
        }
    }
}
