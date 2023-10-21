using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore_ApplicationForm

{
    public struct Data_ControlRead
    {
        PictureBox icon;
        ComboBox roles;
        TextBox name;
        Label user_name;
        CheckBox restrictions;
        TextBox description;

        public PictureBox Icon { get { return icon; } set { icon = value; } }
        public ComboBox Roles { get { return roles; } set { roles = value; } }
        public TextBox Name { get { return name; } set { name = value; } }
        public Label User_Name { get { return user_name; } set { user_name = value; } } 
        public CheckBox Restrictions { get { return restrictions; } set { restrictions = value; } }
        public TextBox Description { get { return description; } set { description = value; } }

        public Data_ControlRead(
            PictureBox icon,
            ComboBox roles,
            TextBox name,
            Label user_name,
            CheckBox restrictions,
            TextBox description
            ) : this()
        {
            Icon = icon;
            Roles = roles;
            Name = name;
            User_Name = user_name;
            Restrictions = restrictions;    
            Description = description;
        }
    }
}
