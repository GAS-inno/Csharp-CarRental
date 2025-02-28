using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment1_CarRental
{
    internal class dbconnection
    {
        private string connectionString;

        public dbconnection()
        {
            // Connection string for LocalDB using Windows Authentication
            connectionString = @"Server=(localdb)\mylocaldb;Integrated Security=true;Database=carRental_DB; ";
        }

//----------------
//CUSTOMER REGISTRATION START
//----------------
        public void InsertCust(string firstname, string lastname, string custTitle, string custAddress, string postalCode, string custCity,
                                string custCountry, string custPhone, string custSSID)
        {
            // Validate if there's existing data
            bool exists = CheckExitingSSID(custSSID);
            if (exists)
            {
                MessageBox.Show("A customer with the same SSID already exists in the database.");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO dbo.Customer (firstName, lastName, title, address, postalcode, city, country, contactNo, SSID) " +
                        "VALUES (@firstName, @lastName, @title, @address, @postalcode, @city, @country, @contactNo, @SSID)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstname);
                        cmd.Parameters.AddWithValue("@lastName", lastname);
                        cmd.Parameters.AddWithValue("@title", custTitle);
                        cmd.Parameters.AddWithValue("@address", custAddress);
                        cmd.Parameters.AddWithValue("@postalcode", postalCode);
                        cmd.Parameters.AddWithValue("@city", custCity);
                        cmd.Parameters.AddWithValue("@country", custCountry);
                        cmd.Parameters.AddWithValue("@contactNo", custPhone);
                        cmd.Parameters.AddWithValue("@SSID", custSSID);

                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer inserted successfully!");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error inserting data: " + ex.Message);
                        }
                    }
                }
            }
        }

        // Check if SSID already exists in the database
        private bool CheckExitingSSID(string custSSID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM dbo.Customer WHERE SSID = @SSID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SSID", custSSID);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // If count > 0, SSID exists
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error checking SSID: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Fetch data from the Customer table
        public DataTable FetchCustomerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM dbo.Customer";
                    SqlDataAdapter sqlda = new SqlDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sqlda.Fill(dtbl);
                    return dtbl;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public void UpdatebyCustomerID(int customerID, string firstname, string lastname, string custTitle, string custAddress, string postalCode, string custCity,
                            string custCountry, string custPhone, string custSSID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL Update query to modify a customer by customerID
                string query = "UPDATE dbo.Customer " +
                               "SET firstName = @firstName, lastName = @lastName, title = @title, address = @address, postalcode = @postalcode, " +
                               "city = @city, country = @country, contactNo = @contactNo, SSID = @SSID " +
                               "WHERE customerID = @customerID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Set parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@firstName", firstname);
                    cmd.Parameters.AddWithValue("@lastName", lastname);
                    cmd.Parameters.AddWithValue("@title", custTitle);
                    cmd.Parameters.AddWithValue("@address", custAddress);
                    cmd.Parameters.AddWithValue("@postalcode", postalCode);
                    cmd.Parameters.AddWithValue("@city", custCity);
                    cmd.Parameters.AddWithValue("@country", custCountry);
                    cmd.Parameters.AddWithValue("@contactNo", custPhone);
                    cmd.Parameters.AddWithValue("@SSID", custSSID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the given customerID.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error updating data: " + ex.Message);
                    }
                }
            }
        }

         public void DeleteByCustomerId(int customerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to delete the book based on the ID
                string query = "DELETE FROM dbo.Customer WHERE customerID = @customerID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add the ID parameter to the query
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();  // Execute the query

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No Patient found with the specified ID.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error deleting patient: " + ex.Message);
                    }
                }
            }

        }
        //----------------
        //CUSTOMER REGISTRATION END
        //----------------

        //----------------
        //CAR REGISTRATION START
        //----------------

        public void InsertCar(string carNumber, string carDesc, string engine, string regYear, string model, string color,
                                        string spec, string carType, int currentMile)
        {
            // Validate if there's existing data
            bool exists = CheckExitingCarNumber(carNumber);
            if (exists)
            {
                MessageBox.Show("A customer with the same CarNumber already exists in the database.");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO dbo.Car (carNumber,carDesc,engine,regYear,model,color,spec,carType,currentMile) " +
                        "VALUES (@carNumber, @carDesc, @engine, @regYear, @model, @color, @spec, @carType, @currentMile)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@carNumber", carNumber);
                        cmd.Parameters.AddWithValue("@carDesc", carDesc);
                        cmd.Parameters.AddWithValue("@engine", engine);
                        cmd.Parameters.AddWithValue("@regYear", regYear);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@spec", spec);
                        cmd.Parameters.AddWithValue("@carType",carType);
                        cmd.Parameters.AddWithValue("@currentMile", currentMile);

                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer inserted successfully!");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error inserting data: " + ex.Message);
                        }
                    }
                }
            }
        }

        // Check if SSID already exists in the database
        private bool CheckExitingCarNumber(string carNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Explicit case-sensitive match of the column and table name
                string query = "SELECT COUNT(1) FROM dbo.Car WHERE carNumber = @carNumber";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@carNumber", carNumber);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // If count > 0, carNumber exists
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error checking carNumber: " + ex.Message);
                        return false;
                    }
                }
            }
        }


        // Fetch data from the Customer table
        public DataTable FetchCarData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM dbo.Car";
                    SqlDataAdapter sqlda = new SqlDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sqlda.Fill(dtbl);
                    return dtbl;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

    }//DB CLASS END
}
