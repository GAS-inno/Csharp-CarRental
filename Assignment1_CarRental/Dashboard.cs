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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustReg_Click(object sender, EventArgs e)
        {
            CustomerRegistration form = new CustomerRegistration();
            form.ShowDialog();
            form.Focus();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Booking form = new Booking();
            form.ShowDialog();
            form.Focus();
        }

        private void btnCarReg_Click(object sender, EventArgs e)
        {
            CarRegistration form = new CarRegistration();
            form.ShowDialog();
            form.Focus();
        }

        private void btnCarReturn_Click(object sender, EventArgs e)
        {
            Return form = new Return();
            form.ShowDialog();
            form.Focus();
        }
    }
}
