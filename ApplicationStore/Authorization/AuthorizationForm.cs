using ApplicationStore_AdministratorForm;
using MSD;
using System;
using System.Windows.Forms;

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
            user = LogicControl.GetUser(loginTextBox.Text,passwordTextBox.Text);

        }
    }
}
