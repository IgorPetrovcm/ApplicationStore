using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore_AdministratorForm_Edit
{
    public struct PropertyStructure
    {
        public static TextBox GetNameAppBox(int i,MySqlDataReader reader)
        {
            TextBox appName = new TextBox()
            {
                Text = reader.GetValue(2).ToString(),
                ReadOnly = true,
                Size = new Size(175, 0),
                Location = new Point(55, i * 60 + 10),
                BorderStyle = BorderStyle.None,
                BackColor = SystemColors.Menu,
            };
            return appName;
        }

        public static PictureBox GetIconApp(int i, MySqlDataReader reader)
        {
            byte[] iconBytes = (byte[])reader.GetValue(1);
            MemoryStream ms = new MemoryStream(iconBytes);
            PictureBox appIcon = new PictureBox()
            {
                Size = new Size(45, 45),
                Location = new Point(5, i * 60 + 10),
                Image = Image.FromStream(ms),
            };
            return appIcon;
        }
    }
}
