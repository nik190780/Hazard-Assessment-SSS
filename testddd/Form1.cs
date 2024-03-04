using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testddd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The connection string using the IP Address. this needs to use the VPN from the lab to work
            string connectionString = @"Data Source=172.22.2.115,1433;Initial Catalog=HazardAssessmentDatabase;User ID=StrongSystem;Password=StrongSolutions";
            SqlConnection cnn;
            //makes the connection
            cnn = new SqlConnection(connectionString);
            
            SqlCommand command = new SqlCommand();
            try
            {
                cnn.Open();
                try
                {
                    
                    command = new SqlCommand("insert into dbo.Control(Con_Name,Con_Desc,Con_Cat_ID)values('" + textBox1.Text + "','" + textBox2.Text + "','" + Int32.Parse(textBox3.Text) + "')", cnn); //this can just be a variable with the command innit
                    command.ExecuteNonQuery(); //executes the command
                    MessageBox.Show("Inserted into table");
                    cnn.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
