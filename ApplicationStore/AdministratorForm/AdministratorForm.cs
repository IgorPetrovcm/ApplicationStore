using ApplicationStore_AdministratorForm_Add;
using ApplicationStore_AdministratorForm_Edit;
using System;
using System.Windows.Forms;
using MSD;

namespace ApplicationStore_AdministratorForm
{
    public partial class AdministratorForm : Form
    {
        User user;
        public AdministratorForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            this.Close();
            AddApplicationForm addAppForm = new AddApplicationForm(user);
            addAppForm.Show();
            addAppForm.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            EditApplicationForm editAppForm = new EditApplicationForm(user);
            editAppForm.Show();
            editAppForm.TopMost = true;
        }
    }
}
