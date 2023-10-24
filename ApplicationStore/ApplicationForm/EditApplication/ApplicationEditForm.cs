using MDBC;
using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MCh;
using System.IO;
using System.Drawing;

namespace ApplicationStore_ApplicationForm
{
    public partial class ApplicationEditForm : Form
    {
        App app;
        public ApplicationEditForm(App app)
        {
            InitializeComponent();
            this.app = app;

        }

        private void ApplicationEditForm_Load(object sender, EventArgs e)
        {
            List<Roles> roles = new List<Roles>();

            LogicInterfaceControl.GetInterface(app.Id, out icon_appBox.Image, out roles,)
        }

        private void icon_appBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "image extension (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                byte[] new_iconBytes = File.ReadAllBytes(dialog.FileName);
                MemoryStream ms = new MemoryStream(new_iconBytes);

                icon_appBox.Image = Image.FromStream(ms);
            }
        }
    }
}
