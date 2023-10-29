using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSD;
using ApplicationStore_ApplicationForm;
using System.Runtime.CompilerServices;

namespace ApplicationStore_AdministratorForm_Edit
{
    public struct PropertyStructure 
    {
        public static TextBox GetNameAppBox(App app,int i)
        {
            TextBox appName = new TextBox()
            {
                Text = app.Name,
                ReadOnly = true,
                Size = new Size(175, 0),
                Location = new Point(55, (i - 1) * 60 + 10),
                BorderStyle = BorderStyle.None,
                BackColor = SystemColors.Menu,
                Font = new Font("Microsoft Sans Serif", 10),
            };
            return appName;
        }

        public static PictureBox GetIconApp(App app,User user,int i)
        {
            byte[] iconBytes = app.Image;
            MemoryStream ms = new MemoryStream(iconBytes);

            PictureBox appIcon = new PictureBox()
            {
                Size = new Size(45, 45),                
                Location = new Point(5, (i - 1) * 60 + 10),                          

                Image = Image.FromStream(ms),
            };
            appIcon.DoubleClick += (sender, e) =>
            {
                ApplicationForm appForm = new ApplicationForm(app,user);
                appForm.ShowDialog();

            };
            return appIcon;
        }
    }
}
