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
using MDBC;
using MySql.Data.MySqlClient;
using ApplicationStore_ApplicationForm;

namespace ApplicationStore_ApplicationForm_AdminPassword
{
    public partial class RequestAdminPasswordForm : Form
    {
        User user;
        App app;
        Image imageIcon;
        public RequestAdminPasswordForm(User user, App app, Image imageIcon)
        {
            InitializeComponent();
            this.user = user;
            this.app = app;
            this.imageIcon = imageIcon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicControl.CheckPassword(user, user_passwordBox,app,this,imageIcon);
        }
    }
}
