using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software
{
    public partial class frmMakeBooking : Form
    {

        private frmMain parent;
        public frmMakeBooking(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            grdCustomers.DataSource = Customer.getCustomers();
            grdCars.DataSource = Car.getCars();
        }      

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaymentM_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPayment_Click(object sender, EventArgs e)
        {

        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {

        }

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void grdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int customerId = Int32.Parse(grdCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

            DataTable customer = Customer.getSingleCustomer(customerId);

            // Loops over each row of the retrieved customers
            foreach (DataRow row in customer.Rows)
            {
                txtCustomerName.Text = row["forename"].ToString() + " " + row["surname"].ToString();
                txtCustomerId.Text = row["customer_id"].ToString();
            }
        }

        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String regPlate = grdCars.Rows[e.RowIndex].Cells[0].Value.ToString();

            //DataTable customer = Customer.getSingleCustomer(customerId);
            DataTable car = Car.getSingleCar(regPlate);

            foreach (DataRow row in car.Rows)
            {
                txtCarReg.Text = row["RegPlate"].ToString();
            }
        }
    }
}
