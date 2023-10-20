using MSD;
using System.Windows.Forms;

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
            User = user;   
            Image = image;
            Name = name;
            Description = description;
            IdRole = idRole;
            Restrictions = restrictions;
        }
    }
}
