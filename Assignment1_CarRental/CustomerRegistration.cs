using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment1_CarRental
{
    public partial class CustomerRegistration : Form
    {
        dbconnection dbconn = new dbconnection();
        public CustomerRegistration()
        {
            InitializeComponent();
            LoadData();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // declaration variable
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string custTitle = cbTitle.Text;
            string custAddress = txtAddress.Text;
            string postalCode = txtPostalcode.Text;
            string custCity = txtCity.Text;
            string custCountry = txtCountry.Text;
            string custPhone = txtPhone.Text;
            string custSSID = txtSSID.Text;


            //check if the input is empty
            // if (!string.IsNullOrEmpty(input))
            if (!string.IsNullOrEmpty(firstname) || !string.IsNullOrEmpty(lastname) || !string.IsNullOrEmpty(custTitle) || !string.IsNullOrEmpty(custAddress) ||
                !string.IsNullOrEmpty(postalCode) || !string.IsNullOrEmpty(custCity) || !string.IsNullOrEmpty(custCountry) ||
                !string.IsNullOrEmpty(custPhone) || !string.IsNullOrEmpty(custSSID)
                )
            {
                //Non empty input
                dbconn.InsertCust(firstname, lastname, custTitle, custAddress, postalCode, custCity, custCountry, custPhone, custSSID);

                //refresh the gridview data table
                LoadData();
                Cleartext();


            }
            else
            {
                //Handle here
                MessageBox.Show("Input is Empty", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadData()
        {

            DataTable data = dbconn.FetchCustomerData(); // Correct method name
            dataGridView1.DataSource = data; // Bind the DataTable to the DataGridView

            // Add event handler for row click
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }


        private void Form_Car_Load(object sender, EventArgs e)
        {

            LoadData();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is valid (not on the column headers)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //Assigning the values to the text fields

                // Verify Column Name in DataGrideView
                /*   foreach (DataGridViewColumn column in dataGridView1.Columns)
                   {
                       Console.WriteLine(column.Name);
                       MessageBox.Show(column.Name);// Prints all column names in the console
                   } */

                lbCustomerID.Text = row.Cells["customerID"].Value.ToString();
                txtFirstname.Text = row.Cells["firstName"].Value.ToString();
                txtLastname.Text = row.Cells["lastName"].Value.ToString();
                cbTitle.Text = row.Cells["title"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtPostalcode.Text = row.Cells["postalcode"].Value.ToString();
                txtCity.Text = row.Cells["city"].Value.ToString();
                txtCountry.Text = row.Cells["country"].Value.ToString();
                txtPhone.Text = row.Cells["ContactNo"].Value.ToString();
                txtSSID.Text = row.Cells["SSID"].Value.ToString();
            }

        }

        private void Cleartext()
        {

            txtFirstname.Clear();
            txtLastname.Clear();
            cbTitle.Text = string.Empty;
            txtAddress.Clear();
            txtPostalcode.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPhone.Clear();
            txtSSID.Clear();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Cleartext();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection dbconn = new dbconnection();
                // Retrieve the data from the text boxes
                string firstname = txtFirstname.Text;
                string lastname = txtLastname.Text;
                string custTitle = cbTitle.Text;
                string custAddress = txtAddress.Text;
                string postalCode = txtPostalcode.Text;
                string custCity = txtCity.Text;
                string custCountry = txtCountry.Text;
                string custPhone = txtPhone.Text;
                string custSSID = txtSSID.Text;
                int customerID = Convert.ToInt32(lbCustomerID.Text);

                dbconn.UpdatebyCustomerID(customerID, firstname, lastname, custTitle, custAddress, postalCode, custCity,
                    custCountry, custPhone, custSSID);


                LoadData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // check row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                // Verify Column Name in DataGrideView
                /*   foreach (DataGridViewColumn column in dataGridView1.Columns)
                   {
                     Console.WriteLine(column.Name);
                     MessageBox.Show(column.Name);// Prints all column names in the console
                  }
                   */

                // Assuming 'ID' is the first column in your DataGridView
                int rowId = Convert.ToInt32(selectedRow.Cells["customerID"].Value);


                // Confirm deletion with the user
                DialogResult result = MessageBox.Show($"Comfirm to delete the Customer with ID {rowId}?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Call the delete method in the dbconnection class
                    dbconn.DeleteByCustomerId(rowId);

                    // Reload the data after deletion
                    LoadData();
                    // Cleartext();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    //----------------
    //CUSTOMER REGISTRATION END
    //----------------
}
