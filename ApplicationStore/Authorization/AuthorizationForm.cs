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
    public partial class AuthorizationForm : Form
    {
        User user;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            user = LogicControlToAuthorization.ReaderDBRequest(loginTextBox.Text,passwordTextBox.Text);
        }
    }
}
