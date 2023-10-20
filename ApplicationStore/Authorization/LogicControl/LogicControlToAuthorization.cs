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
            User user = new User();

            MySqlDataReader reader = GetResultDB.GetReader("select user_id,user_login,user_yearbirth,user_id_role from users " +
                $"where user_login = '{login}' and user_password = '{password}'");

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i) == "user_id")
                    {
                        user.Id = Convert.ToByte(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_login")
                    {
                        user.Login = Convert.ToString(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_yearbirth")
                    {
                        user.Yearbirth = Convert.ToInt32(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "user_id_role")
                    {
                        user.IdRole = Convert.ToByte(reader.GetValue(i));
                    }
                }
            }

            return user;
        }
    }
}
