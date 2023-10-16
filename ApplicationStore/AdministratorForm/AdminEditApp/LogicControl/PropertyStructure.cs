﻿using MySql.Data.MySqlClient;
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

namespace ApplicationStore_AdministratorForm_Edit
{
    public struct PropertyStructure 
    {
        public static TextBox GetNameAppBox(App app)
        {
            TextBox appName = new TextBox()
            {
                Text = app.Name,
                ReadOnly = true,
                Size = new Size(175, 0),
                Location = new Point(55, (app.Id - 1) * 60 + 10),
                BorderStyle = BorderStyle.None,
                BackColor = SystemColors.Menu,
                Font = new Font("Microsoft Sans Serif", 10),
            };
            return appName;
        }

        public static PictureBox GetIconApp(App app)
        {
            byte[] iconBytes = app.Image;
            MemoryStream ms = new MemoryStream(iconBytes);

            byte appIdTest = app.Id;
            PictureBox appIcon = new PictureBox()
            {
                Size = new Size(45, 45),                
                Location = new Point(5, (appIdTest - 1) * 60 + 10),                          

                Image = Image.FromStream(ms),
            };
            appIcon.DoubleClick += (sender, e) =>
            {
                ApplicationForm appForm = new ApplicationForm(app);
                appForm.ShowDialog();
            };
            return appIcon;
        }
    }
}