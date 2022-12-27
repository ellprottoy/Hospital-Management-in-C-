using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseExample
{
    class Program
    {
        static void Main(string[] args)
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

            // Loop through the data and print the results
            while (reader.Read())
            {
                Console.WriteLine("Patient Name: " + reader["Name"] + ", DOB: " + reader["DOB"] + ", Address: " + reader["Address"]);
            }

            // Close the connection
            conn.Close();
        }
    }
}
