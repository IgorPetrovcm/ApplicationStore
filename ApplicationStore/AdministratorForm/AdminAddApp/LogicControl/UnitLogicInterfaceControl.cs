﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ApplicationStore
{
    public static class UnitLogicInterfaceControl
    {
        public static byte[] SearchImage(out string imageExtension)
        {
            imageExtension = null;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png" ;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                byte[] imageBytes = File.ReadAllBytes(dialog.FileName);
                imageExtension = Path.GetExtension(dialog.FileName);

                return imageBytes;
            }
            else return null;
        } 

        public static byte[] GetImageBytes(PictureBox image,string imageExtension)
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
        }

    }
}