using MSD;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using MDBC;

namespace ApplicationStore_AuthorizationForm
{
    public static class LogicControl
    {
        public static User ReaderDBRequest(string login, string password)
        {

            MySqlDataReader reader = GetResultDB.GetReader("select user_id,user_login,user_yearbirth,user_id_role from users " +
                $"where user_login = '{login}' and user_password = '{password}'");

            byte idUser = 0, idRoleUser = 0;
            string loginUser = null;
            int birthUser = 0;

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i) == "user_id")
                    {
                        idUser = Convert.ToByte(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_login")
                    {
                        loginUser = Convert.ToString(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_yearbirth")
                    {
                        birthUser = Convert.ToInt32(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_id_role")
                    {
                        idRoleUser = Convert.ToByte(reader.GetValue(i));
                    }
                }
            }

            User user = new User(idUser, loginUser, birthUser, idRoleUser);

            MessageBox.Show("Connection");
            return user;
        }
    }
}
