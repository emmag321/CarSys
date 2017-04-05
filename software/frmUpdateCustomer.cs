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
    public partial class frmUpdateCustomer : Form
    {
        frmMain parent;

        public frmUpdateCustomer(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            grdCustomers.DataSource = Customer.getCustomers();
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            if (txtForename.Text.Length > 0 && txtSurname.Text.Length > 0 && txtPhoneNum.Text.Length > 0 && txtAddress.Text.Length > 0)
            {
                Customer cust = new Customer(Int32.Parse(txtCustomerId.Text.ToString()), txtForename.Text.ToString(), txtSurname.Text.ToString(), txtPhoneNum.Text.ToString(), txtAddress.Text.ToString());
                cust.updateCustomer();

                txtCustomerId.Text = "";
                txtForename.Text = "";
                txtSurname.Text = "";
                txtPhoneNum.Text = "";
                txtAddress.Text = "";

                MessageBox.Show("Customer Updates");

                // Refresh Grid
                grdCustomers.DataSource = Customer.getCustomers();
            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
        }

        private void grdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int customerId = Int32.Parse(grdCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

            DataTable customer = Customer.getSingleCustomer(customerId);


            foreach  (DataRow row in customer.Rows)
            {
                txtCustomerId.Text = row["customer_id"].ToString();
                txtForename.Text = row["forename"].ToString();
                txtSurname.Text = row["surname"].ToString();
                txtPhoneNum.Text = row["phone_number"].ToString();
                txtAddress.Text = row["address"].ToString();
            }

            //e.RowIndex
            //e.ColumnIndex;
            
        }
    }
}
