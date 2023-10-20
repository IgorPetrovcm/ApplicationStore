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
            AddApplicationForm addAppForm = new AddApplicationForm(user);
            addAppForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditApplicationForm editAppForm = new EditApplicationForm(user);
            editAppForm.ShowDialog();
        }
    }
}
