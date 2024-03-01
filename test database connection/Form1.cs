using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test_database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=master;Trusted_Connection=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            try
            {
                // connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=HazardAssessmentDatabase;User ID=SystemSolution;Password=StrongSolutions";
                cnn.Open();
                MessageBox.Show("connected");
            }
            catch
            {
                MessageBox.Show("not connected");
            }
            finally
            {

                cnn.Close();
            }
        }
    }
}