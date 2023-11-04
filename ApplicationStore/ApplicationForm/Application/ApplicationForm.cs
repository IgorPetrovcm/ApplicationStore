using ApplicationStore;
using MSD;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ApplicationStore_ApplicationForm_AdminPassword;
using ApplicationStore_AdministratorForm_Edit;

namespace ApplicationStore_ApplicationForm
{
    public partial class ApplicationForm : Form
    {
        App app;
        User user;
        public ApplicationForm(App app, User user)
        {
            InitializeComponent();

            this.app = app;
            this.user = user;
        }

        private void ApplicationForm_Load(object sender, System.EventArgs e)
        {
            if (user.IdRole == 1) button1.Dispose();

            Data_ControlsToForm data = new Data_ControlsToForm(icon_appBox, nameText, user_nameText, roleText, restrictionChkBox, textBox1);
            Data_ControlsToForm data_form = LogicControl.GetAppInfo(data,app);

            LogicControl.GetInterface(out icon_appBox, out user_nameText, out roleText, out restrictionChkBox, out textBox1,data_form,out nameText);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();

            RequestAdminPasswordForm requestAdmin_passwordForm = new RequestAdminPasswordForm(user, app);
            requestAdmin_passwordForm.Show();
            requestAdmin_passwordForm.TopMost = true;
        }
    }
}
