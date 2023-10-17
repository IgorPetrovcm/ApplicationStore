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
        public static List<App> GetApp()
        {
            List<App> apps = new List<App>();

            using (MySqlDataReader reader = GetResultDB.GetReader("select * from application_test"))
            {
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
/*                    app.Id = reader.GetByte(0);
                    app.Image = (byte[])reader.GetValue(1);
                    app.Name = reader.GetString(2);
                    app.Description = reader.GetString(3);
                    app.RoleId = reader.GetByte(4);
                    app.UserId = reader.GetByte(5);
                    app.Restrictions = reader.GetBoolean(6);*/

                    apps.Add(app);
                }
                return apps;
            }        
        }
    }
}
