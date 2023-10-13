using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ApplicationStore
{
    public static class UnitLogic
    {
        public static byte[] SearchImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png" ;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;

                byte[] imageBytes = File.ReadAllBytes(path);

                return imageBytes;
            }
            else return null;
        } 

    }
}
