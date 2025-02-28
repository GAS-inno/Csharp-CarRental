using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_CarRental
{
    public partial class CarRegistration : Form
    {
        dbconnection dbconn = new dbconnection();
        public CarRegistration()
        {
            InitializeComponent();
        }


        private void LoadData()
        {

            DataTable data = dbconn.FetchCarData(); // Correct method name
            dataGridView1.DataSource = data; // Bind the DataTable to the DataGridView

            // Add event handler for row click
            dataGridView1.CellClick += dataGridView1_CellContentClick;
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

                txtCarnumber.Text = row.Cells["carNumber"].Value.ToString();
                txtCarDesc.Text = row.Cells["carDesc"].Value.ToString();
                txtEngine.Text = row.Cells["engine"].Value.ToString();
                txtRegYear.Text = row.Cells["regYear"].Value.ToString();
                txtModel.Text = row.Cells["model"].Value.ToString();
                txtColor.Text = row.Cells["color"].Value.ToString();
                txtSpec.Text = row.Cells["spec"].Value.ToString();
                cbType.Text = row.Cells["carType"].Value.ToString();
                //tx.Text = row.Cells["currentMile"].Value.ToString();
               // txtSSID.Text = row.Cells["SSID"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // declaration variable
            string carNumber = txtCarnumber.Text;
            string carDesc = txtCarDesc.Text;
            string engine = txtEngine.Text;
            string regYear = txtRegYear.Text;
            string model = txtModel.Text;
            string color = txtColor.Text;
            string spec = txtSpec.Text;
            string carType = cbType.Text;
            int currentMile = 0;//= cbType.Text;



            //check if the input is empty
            // if (!string.IsNullOrEmpty(input))
            if (!string.IsNullOrEmpty(carNumber) || !string.IsNullOrEmpty(carDesc) || !string.IsNullOrEmpty(engine) || !string.IsNullOrEmpty(regYear) ||
                !string.IsNullOrEmpty(model) || !string.IsNullOrEmpty(color) || !string.IsNullOrEmpty(spec) ||
                !string.IsNullOrEmpty(carType) //|| !string.IsNullOrEmpty(currentMile)
                )
            {
                //Non empty input
                dbconn.InsertCar(carNumber,carDesc,engine,regYear, model, color,spec,carType,currentMile);

                //refresh the gridview data table
                LoadData();
                //Cleartext();


            }
            else
            {
                //Handle here
                MessageBox.Show("Input is Empty", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
