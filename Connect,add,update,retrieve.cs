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
            string connectionString = "Server=localhost;Database=MyDB;Trusted_Connection=True;";

            // Create a connection object
            SqlConnection conn = new SqlConnection(connectionString);

            // Open the connection
            conn.Open();

            // Create a command object
            SqlCommand cmd = new SqlCommand("SELECT * FROM MyTable", conn);

            // Execute the command and retrieve the data
            SqlDataReader reader = cmd.ExecuteReader();

            // Loop through the data and print the results
            while (reader.Read())
            {
                Console.WriteLine("Column1: " + reader["Column1"] + ", Column2: " + reader["Column2"]);
            }

            // Close the connection
            conn.Close();
        }
    }
}

//To execute an INSERT, UPDATE, or DELETE statement, use the ExecuteNonQuery method of the SqlCommand object

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
            string connectionString = "Server=localhost;Database=MyDB;Trusted_Connection=True;";

            // Create a connection object
            SqlConnection conn = new SqlConnection(connectionString);

            // Open the connection
            conn.Open();

            // Create a command object
            SqlCommand cmd = new SqlCommand("INSERT INTO MyTable (Column1, Column2) VALUES (@val1, @val2)", conn);
            cmd.Parameters.AddWithValue("@val1", "Value1");
            cmd.Parameters.AddWithValue("@val2", "Value2");

            // Execute the command
            int rowsAffected = cmd.ExecuteNonQuery();

            // Print the number of rows affected
            Console.WriteLine(rowsAffected + " rows were inserted.");

            // Close the connection
            conn.Close();
        }
    }
}
