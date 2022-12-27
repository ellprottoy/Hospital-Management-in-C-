using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StaffScheduler
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
            string connectionString = "Server=localhost;Database=StaffDB;Trusted_Connection=True;";

            // Create a connection object
            SqlConnection conn = new SqlConnection(connectionString);

            // Open the connection
            conn.Open();

            // Create a command object to retrieve the schedules for the current week
            DateTime startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            DateTime endDate = startDate.AddDays(7);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shift WHERE StartTime >= @startDate AND EndTime < @endDate", conn);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);

            // Execute the command and retrieve the data
            SqlDataReader reader = cmd.ExecuteReader();

            // Loop through the data and add the shift information to the calendar
            while (reader.Read())
            {
                DateTime startTime = (DateTime)reader["StartTime"];
                DateTime endTime = (DateTime)reader["EndTime"];
                string staffName = (string)reader["StaffName"];
                calendar1.AddBoldedDate(startTime);
                calendar1.AddBoldedDate(endTime);
                calendar1.AddAnnuallyBoldedDate(startTime);
                calendar1.AddAnnuallyBoldedDate(endTime);
                calendar1.UpdateBoldedDates();
                calendar1.SetAnnuallyBoldedDates(startTime, endTime);
                calendar1.UpdateBoldedDates();
                calendar1.SetCaption(startTime.ToString("MMMM"));
                calendar1.SetCalendarDimensions(1, 1);
            }

            // Close the connection
            conn.Close();
        }
    }
}
