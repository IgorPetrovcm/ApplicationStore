using MSD;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApplicationStore_AdministratorForm_Add
{
    public struct Data_LogicDataApp
    {
        PictureBox icon;
        string extension;
        List<Roles> roles;
        ComboBox cmb_roles;
        User user;
        string name;
        string description;
        CheckBox restrictions;

        public PictureBox Icon { get { return icon; } set { icon = value; } }
        public string Extension { get { return extension; } set { extension = value; } }
        public List<Roles> Roles { get { return roles; } set { roles = value; } }
        public ComboBox Cmb_Roles { get { return cmb_roles; } set { cmb_roles = value; } }
        public User User { get { return user; } set { user = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public CheckBox Restrictions { get { return restrictions; } set { restrictions = value; } }

        public Data_LogicDataApp(
            PictureBox icon,
            string extension,
            List<Roles> roles,
            ComboBox cmb_roles,
            User user,
            string name,
            string description,
            CheckBox restrictions
            ) : this()
        {
            if (icon == null) { 
                MessageBox.Show("Icon not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (extension == null) { 
                MessageBox.Show("Extension missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (roles == null) { 
                MessageBox.Show("Total error. Roles missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (cmb_roles.SelectedItem.ToString() == null) { 
                MessageBox.Show("Roles not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (user == null) { 
                MessageBox.Show("Total error. User missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (name == null) { 
                MessageBox.Show("Name not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (description == null) { 
                MessageBox.Show("Description not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (restrictions == null) { 
                MessageBox.Show("Total error. Restrictions missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }

            Icon = icon;
            Extension = extension;
            Roles = roles;
            Cmb_Roles = cmb_roles;
            User = user;
            Name = name;
            Description = description;
            Restrictions = restrictions;
        }
    }
}
