using MSD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCh//Main Checks
{
    public static class ChecksEntities
    {
        public static bool CheckUser(User user)
        {
            if (user.Id != 0)
            {
                if (user.Login != null)
                {
                    if (user.Yearbirth != 0)
                    {
                        if (user.IdRole != 0)
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }

        public static bool CheckRole(Roles role)
        {
            if (role.IdRole != 0)
            {
                if (role.NameRole != null)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

    }
}
