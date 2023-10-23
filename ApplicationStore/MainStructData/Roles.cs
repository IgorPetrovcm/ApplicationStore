using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MSD//Main Struct Data
{
    public class Roles
    {
        byte idRole;
        string nameRole;

        public byte IdRole { get { return idRole; } set { idRole = value; } }
        public string NameRole { get { return nameRole; } set { nameRole = value; } }

        public Roles(byte idRole,string nameRole)
        {
            IdRole = idRole;
            NameRole = nameRole;
        }
        public Roles()
        {

        }
    }
}
