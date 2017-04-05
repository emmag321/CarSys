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
    public partial class frmRegCustomer : Form
    {
        frmMain parent;

        public frmRegCustomer(frmMain parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtForename.Text.Length > 0 && txtSurname.Text.Length > 0 && txtPhoneNum.Text.Length > 0  && txtAddress.Text.Length > 0)
            {
                Customer cust = new Customer(txtForename.Text.ToString(), txtSurname.Text.ToString(), txtPhoneNum.Text.ToString(), txtAddress.Text.ToString());
                cust.regCustomer();

                txtForename.Text = "";
                txtSurname.Text = "";
                txtPhoneNum.Text = "";
                txtAddress.Text = "";

                MessageBox.Show("Customer Registered");
            } else
            {
                MessageBox.Show("Please complete all fields");
            }
            
        }
    }
}
