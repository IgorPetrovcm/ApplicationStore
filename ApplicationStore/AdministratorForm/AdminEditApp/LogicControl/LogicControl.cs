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
        public static List<Control> PanelAddAppName(User user,ref int i)
        {
            List<Control> controls = new List<Control>();
            List<App> apps = GetDataApps.GetAppTest(user);

            foreach (App app in apps)
            {
                controls.Add(PropertyStructure.GetNameAppBox(app,i));
                controls.Add(PropertyStructure.GetIconApp(user, app, i));
                i++;
            }
            
            return controls;
        }
    }
}
