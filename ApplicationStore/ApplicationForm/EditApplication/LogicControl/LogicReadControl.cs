using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MDBC;
using System.Drawing;
using System.IO;
using MCh;
using MSD;
using System.Drawing.Imaging;

namespace ApplicationStore_ApplicationForm
{
    public static class LogicReadControl
    {
        public static ComboBox GetInterfaceControl(byte app_id)
        {
            ComboBox roles = GetRoles($"select * from roles");
            return roles;
        }        

        public static Image GetImage(string command)
        {
            Image image;
            byte[] imageBytes = null;
            MySqlDataReader reader = GetResultDB.GetReader(command);
            
            while (reader.Read())
            {
                imageBytes = (byte[])reader.GetValue(0);
            }
            
            MemoryStream ms = new MemoryStream(imageBytes);
            image = Image.FromStream(ms);
            return image;
        }

        public static List<Roles> GetItemsFromRoles(string command)
        {
            MySqlDataReader reader = GetResultDB.GetReader(command);
            List<Roles> roles = new List<Roles>();

            while (reader.Read())
            {
                Roles role = new Roles();
                role.IdRole = (byte)reader.GetValue(0);
                role.NameRole = (string)reader.GetValue(1);
                roles.Add(role);
            }
            return roles;
        }

        public static byte GetSelectedIndexFromRoles(string command)
        {
            MySqlDataReader reader = GetResultDB.GetReader(command);
            byte index = 0;

            while (reader.Read())
            {
                index = (byte)reader.GetValue(0);

            }
            return index;
        }

        public static void GetIcon(string command, out PictureBox icon)
        {
            icon = null;

            using (MySqlDataReader reader = GetResultDB.GetReader(command))
            {
                while (reader.Read())
                {
                    byte[] iconBytes = (byte[])reader.GetValue(0);
                    MemoryStream ms = new MemoryStream(iconBytes);

                    icon.Image = Image.FromStream(ms);
  /*                  icon.DoubleClick += (sender, e) =>
                    {
                        OpenFileDialog dialog = new OpenFileDialog
                        {
                            Filter = "image extension (*.jpg,*.jpeg,*.png)|*.jpg,*.jpeg,*.png"
                        };
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            byte[] new_iconBytes = File.ReadAllBytes(dialog.FileName);
                            ms = new MemoryStream(new_iconBytes);

                            icon.Image = Image.FromStream(ms);
                        }
                    };*/
                }
            }            
        }

        
        public static ComboBox GetRoles(string command)
        {
            ComboBox roles = new ComboBox();
            using (MySqlDataReader reader = GetResultDB.GetReader(command))
            {
                while (reader.Read())
                {
                    roles.Items.Add((string)reader.GetValue(1));
                    roles.SelectedIndex = 0;
                }
            }
            using (MySqlDataReader reader = GetResultDB.GetReader($"select * from roles"))
            {
                while (reader.Read())
                {
                    Roles role = new Roles((byte)reader.GetValue(0), (string)reader.GetValue(1));
                    if (ChecksEntities.CheckRole(role))
                    {
                        roles.Items.Add(role.NameRole);
                    }
                }
            }
            return roles;
        }



/*        public static Image AddIcon(out string imageExtension)
        {
            byte[] imageByte = LogicControl.SearchImage(out imageExtension);

            using (MemoryStream ms = new MemoryStream(imageByte))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }*/
 /*       public static byte[] GetImageBytes(PictureBox image, string imageExtension)
        {
            byte[] imageBytes;
            if ((imageExtension == ".jpg") || (imageExtension == ".jpeg"))
            {
                MemoryStream ms = new MemoryStream();
                image.Image.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();

                return imageBytes;
            }
            if (imageExtension == ".png")
            {
                MemoryStream ms = new MemoryStream();
                image.Image.Save(ms, ImageFormat.Png);
                imageBytes = ms.ToArray();

                return imageBytes;
            }
            else
            {
                MessageBox.Show("Error read extension image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }*/
 /*       public static byte[] SearchImage(out string imageExtension)
        {
            imageExtension = null;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                byte[] imageBytes = File.ReadAllBytes(dialog.FileName);
                imageExtension = Path.GetExtension(dialog.FileName);

                imageBytes = 

                return imageBytes;
            }
            else return null;
        }*/
    }
}
