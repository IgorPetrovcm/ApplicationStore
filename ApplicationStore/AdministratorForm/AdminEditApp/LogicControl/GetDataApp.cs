using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSD;
using ApplicationStore_AdministratorForm;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MDBC;

namespace ApplicationStore_AdministratorForm_Edit
{
    public static class GetDataApps
    {
        public static List<App> GetAppTest(User user)
        {
            MySqlDataReader reader;

            reader = GetResultDB.GetReader($"select * from application_test where app_role_id = 1");
            
            List<App> apps = new List<App>();

            while (reader.Read())
            {
                App app = new App();

                        app.Id = (byte) reader.GetValue(0);
                        app.Image = (byte[]) reader.GetValue(1);
                        app.Name = (string) reader.GetValue(2);
                        app.Description = (string) reader.GetValue(3);
                        app.RoleId = (byte) reader.GetValue(4);
                        app.UserId = (byte) reader.GetValue(5);
                        app.Restrictions = (bool) reader.GetValue(6);

                apps.Add(app);
            }
            if (user.IdRole == 2)
            {
                reader = GetResultDB.GetReader($"select * from application_test where app_role_id = {2}");
                while (reader.Read())
                {
                    App app = new App();

                    app.Id = (byte)reader.GetValue(0);
                    app.Image = (byte[])reader.GetValue(1);
                    app.Name = (string)reader.GetValue(2);
                    app.Description = (string)reader.GetValue(3);
                    app.RoleId = (byte)reader.GetValue(4);
                    app.UserId = (byte)reader.GetValue(5);
                    app.Restrictions = (bool)reader.GetValue(6);

                    apps.Add(app);
                }

            }

            return apps;

        }
    }
}
