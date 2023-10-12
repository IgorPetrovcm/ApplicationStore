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
    }
}
