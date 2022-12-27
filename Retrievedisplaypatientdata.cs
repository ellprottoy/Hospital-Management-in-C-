using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up the connection string
            string connectionString = "Server=localhost;Database=PatientDB;Trusted_Connection=True;";

            // Create a connection object
            SqlConnection conn = new SqlConnection(connectionString);

            // Open the connection
            conn.Open();

            // Create a command object
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patient", conn);

            // Execute the command and retrieve the data
            SqlDataReader reader = cmd.ExecuteReader();

            // Loop through the data and add the patient names to the list box
            while (reader.Read())
            {
                listBox1.Items.Add(reader["Name"]);
            }

            // Close the connection
            conn.Close();
        }
    }
}
