using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSD;
using ApplicationStore_AdministratorForm;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace ApplicationStore_AdministratorForm_Edit
{
    public class LogicControl
    {
        public static List<Control> PanelAddAppToDB(User user)
        {
            List<Control> controls = new List<Control>();
            List<App> apps = GetDataApps.GetAppTest();

            int i = 1;
            foreach (App app in apps)
            {
                controls.Add(PropertyStructure.GetNameAppBox(app));
                controls.Add(PropertyStructure.GetIconApp(app,user));
            }
            
            return controls;
        }
    }
}
