using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDBC;
using MSD;
using System.Windows.Forms;

namespace ApplicationStore_ApplicationForm
{
    public static class EditAppToDB
    {
        public static void ToDB(string name_app, string description_app, byte id_role, bool restriction_app, byte id_app)
        {
            MySqlCommand command = GetResultDB.GetDefaultRequest($"update application_test " +
                                                                 $"set app_name = '{name_app}', " +
                                                                 $"app_description = '{description_app}', " +
                                                                 $"app_role_id = {id_role}, " +
                                                                 $"app_ageRestriction = {restriction_app} " +
                                                                 $"where app_id = {id_app}");

            int addRowToDb = command.ExecuteNonQuery();
            if (addRowToDb > 0)
            {
                MessageBox.Show("Successfully", "Save", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Total error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
