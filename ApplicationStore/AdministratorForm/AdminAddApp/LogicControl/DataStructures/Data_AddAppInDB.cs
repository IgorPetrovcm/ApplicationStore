using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSD;

namespace ApplicationStore_AdministratorForm_Add
{
    public struct Data_AddAppInDB
    {
        User user;
        byte[] image_bytes;
        string app_name;
        string app_description;
        byte id_role;
        bool restrictions;

        public User User { get { return user; } set { user = value; } }
        public byte[] Image { get { return image_bytes; } set { image_bytes = value; } }
        public string Name { get { return app_name; } set { app_name = value; } }
        public string Description { get { return app_description; } set { app_description = value; } }
        public byte IdRole { get { return id_role; } set { id_role = value; } }
        public bool Restrictions { get { return restrictions; } set { restrictions = value; } }

        public Data_AddAppInDB(
            User user,
            byte[] image,
            string name,
            string description,
            byte idRole,
            bool restrictions 
            ) : this()
        {
            if (user == null) { 
                MessageBox.Show("Total error.User missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (image == null) { 
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (name == null) { 
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (description == null) { 
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (idRole == 0) { 
                MessageBox.Show("Icon missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }

            User = user;   
            Image = image;
            Name = name;
            Description = description;
            IdRole = idRole;
            Restrictions = restrictions;
        }
    }
}
