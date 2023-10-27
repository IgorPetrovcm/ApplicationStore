using MSD;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using MDBC;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

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

        public static void OutputEditImageApp(bool iconEdit, string imagePath, App app)
        {
            if (iconEdit == true)
            {
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                MySqlCommand commandEditImage = GetResultDB.GetDefaultRequest($"update application_test " +
                                                                     $"set app_image = @image where app_id = {app.Id}");

                commandEditImage.Parameters.AddWithValue("@image", imageBytes);
                int add_toDbRow = commandEditImage.ExecuteNonQuery();
                if (add_toDbRow > 0)
                {
                    MessageBox.Show("Successfully add image", "Save image", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error add image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
            }
        }
        public static byte OutputSelectedRoleIndex(List<Roles> roles, ComboBox rolesBox)
        {
            byte roleId = 0;

            IEnumerable<byte> byteIndexes = from roleName in roles 
                                          where roleName.NameRole == rolesBox.SelectedItem.ToString() 
                                          select roleName.IdRole;

            foreach (byte id in byteIndexes)
            {
                roleId = id;
            }
            return roleId;
        }
    }
}
