using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSD;
using System.Windows.Forms;

namespace ApplicationStore
{
    public struct Data_ControlsToForm
    {
        PictureBox image;
        Label user_name;
        Label role;
        CheckBox restrictions;
        TextBox description;

        public PictureBox Image { get { return image; }  set { image = value; } }
        public Label User_Name { get { return user_name; }  set { user_name = value; } }
        public Label Role { get { return role; } set { role = value; } }
        public CheckBox Restrictions { get { return restrictions; }  set { restrictions = value; } }
        public TextBox Description { get { return description; }  set { description = value; } }

        public Data_ControlsToForm(
            PictureBox image,
            Label user_name,
            Label role,
            CheckBox restrictions,
            TextBox description
            ) : this()
        {
            Image = image;
            User_Name = user_name;
            Role = role;
            Restrictions = restrictions;
            Description = description;
        }
    }
}
