using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ApplicationStore_AdministratorForm_Add;
using MSD;

namespace MCh
{
    public static class ChecksData
    {
        public static bool ChecksData_App(Data_AddAppInDB data)
        {
            if (data.User == null)
            {
                MessageBox.Show("Total error.User missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Image == null)
            {
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Name == null)
            {
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Description == null)
            {
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.IdRole == 0)
            {
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ChecksDataLogic_App(Data_LogicDataApp data)
        {
            if (data.Icon == null)
            {
                MessageBox.Show("Icon not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Extension == null)
            {
                MessageBox.Show("Extension missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Roles == null)
            {
                MessageBox.Show("Total error. Roles missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Cmb_Roles.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Roles not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.User == null)
            {
                MessageBox.Show("Total error. User missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Name == null)
            {
                MessageBox.Show("Name not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Description == null)
            {
                MessageBox.Show("Description not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (data.Restrictions == null)
            {
                MessageBox.Show("Total error. Restrictions missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
