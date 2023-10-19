using ApplicationStore;
using ApplicationStore_AdministratorForm_Add;
using MSD;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ApplicationStore_ApplicationForm
{
    public partial class ApplicationForm : Form
    {
        App app;
        public ApplicationForm(App app)
        {
            InitializeComponent();

            this.app = app;
        }

        private void ApplicationForm_Load(object sender, System.EventArgs e)
        {
            Data_ControlsToForm data = new Data_ControlsToForm(icon_appBox, user_nameText, roleText, restrictionChkBox, textBox1);
            Data_ControlsToForm data_form = LogicControl.GetAppInfo(app, data);

            icon_appBox = data_form.Image;
            user_nameText = data_form.User_Name;
            roleText = data_form.Role;
            restrictionChkBox = data_form.Restrictions;
            textBox1 = data_form.Description;


        }
}
}
