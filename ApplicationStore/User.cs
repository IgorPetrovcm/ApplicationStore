using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationStore
{
    public class User
    {
        byte id;
        string login;
        int yearbirth;
        byte idRole;

        public byte Id { get { return id; } set { id = value; } }
        public string Login { get { return login; } set { login = value; } }
        public int Yearbirth { get { return yearbirth; } set { yearbirth = value; } }
        public byte IdRole { get { return idRole; } set { idRole = value; } }

        public User(byte id, string login, int yearbirth, byte idrole)
        {
            Id = id; Login = login; Yearbirth = yearbirth; IdRole = idrole;
        }
    }
}
