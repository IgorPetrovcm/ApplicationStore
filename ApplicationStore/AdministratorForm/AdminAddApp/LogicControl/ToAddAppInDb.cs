using ApplicationStore_AdministratorForm;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MDBC;


namespace ApplicationStore_AdministratorForm_Add
{
    public static class ToAddAppInDB
    {
        public static void AddApp(Data_AddAppInDB data)
        {
            string commandString = $"insert into application_test values (null,@image,'{data.Name}','{data.Description}',{data.IdRole},{data.User.Id},{data.Restrictions})";

            using (MySqlCommand command = GetResultDB.GetDefaultRequest(commandString))
            {
                command.Parameters.AddWithValue("@image", data.Image);

                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Image added to database successfully", "Image added", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Image added to database failed", "Image added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
    
}
