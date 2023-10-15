using ApplicationStore_AdministratorForm;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ApplicationStore_AdministratorForm_Add
{
    public static class ToAddAppInDB
    {
        public static void AddApp(Data_AddAppInDB data)
        {
            string connectionString = null;

            string commandString = $"insert into application_test values " +
                                    $"(null,@image,'{data.Name}','{data.Description}',{data.IdRole},{data.User.Id},{data.Restrictions})";

            if (CheckingAccessToDB.ConnectionCheckPing(out connectionString) == true)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(commandString, connection);

                command.Parameters.AddWithValue("@image", data.Image);

                try
                {
                    connection.Open();

                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Image added to database successfully", "Image added", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Image added to database failed", "Image added", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else 
            { 
                return; 
            };
        }
    }
    
}
