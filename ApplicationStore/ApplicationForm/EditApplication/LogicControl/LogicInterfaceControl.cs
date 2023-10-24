using MSD;
using System.Collections.Generic;
using System.Drawing;

namespace ApplicationStore_ApplicationForm
{
    static public class LogicInterfaceControl
    {
        public static void GetInterface(
            byte app_id,
            out List<Roles> roles,
            out byte index,
            out string user_name
            )
        {

            roles = new List<Roles>();
            roles = LogicReadControl.GetItemsFromRoles("select * from roles");

            index = 0;
            index = LogicReadControl.GetSelectedIndexFromRoles($"select app_role_id from application_test where app_id = {app_id}");

            byte user_id = LogicReadControl.GetIdUploadedUser($"select app_users_id from application_test where app_id = {app_id}");
            user_name = LogicReadControl.GetNameUploadedUser($"select user_login from users where user_id = {user_id}");

        }
    }
}
