using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationStore
{
    public static class LogicControlToAuthorization
    {
        public static User ReaderDBRequest(string login, string password)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

            string commandString = $"select user_id,user_login,user_yearbirth,user_id_role " +
                                   $"from users where user_login = '{login}' and user_password = '{password}'";

            bool[] resultOfCheck = new bool[3];

            for (int i = 0; i < resultOfCheck.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        resultOfCheck[i] = LogicOfCheckingAccessToDB.RequestUserInfo(login, password); break;
                    case 1:
                        resultOfCheck[i] = LogicOfCheckingAccessToDB.ConnectionCheckPing(); break;
                    case 2:
                        resultOfCheck[i] = LogicOfCheckingAccessToDB.CommandRequestCheck(commandString, connection); break;
                }
            }

            foreach (bool result in resultOfCheck)
            {
                if (result == false)
                {
                    MessageBox.Show("Database access error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            MySqlCommand command = new MySqlCommand(commandString, connection);
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();

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

            connection.Close();

            User user = new User(idUser, loginUser, birthUser, idRoleUser);

            MessageBox.Show("Connection");
            return user;
        }
    }
}
