using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestDatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "value1";
            string value2 = "value2";
            int value3 = 3;
            string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;User ID=StrongSystem;Password=StrongSolutions";
           // string connectionString = @"Data Source=24WN-SYSDESG1A\STRONGSOLUTIONS;Initial Catalog=HazardAssessmentDatabase;User ID=StrongSystem;Password=StrongSolutions";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            string query = "INSERT INTO Control (Con_Name,Con_Desc,Con_Cat_ID) VALUES(@value,@value2,@value3)";
            SqlCommand command = new SqlCommand(query, cnn);
            try
            {
                cnn.Open();
                try
                {
                    command.Parameters.AddWithValue("@value1", value);
                    command.Parameters.AddWithValue("@value2", value2);
                    command.Parameters.AddWithValue("@3", value3);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Inserted into table");
                }
                catch
                {
                    MessageBox.Show("not insert");
                }

             
            }
            catch
            {
                MessageBox.Show("not connected");
            }
            finally
            {

                cnn.Close();
            }
            cnn.Close();
        }
    }
}