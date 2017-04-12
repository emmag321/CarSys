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
    public partial class frmMakeReservation : Form
    {

        private frmMain parent;
        public frmMakeReservation(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            //Puts data fro dB into grids
            grdCars.DataSource = Car.getCars();
            
        }      

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

         private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            txtRerID.Text = Reservations.nextReservationNo().ToString("00000");
        }
        
        //This puts the registration plate into the txt box - cannot be edit in txt box though
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

        private void grdCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpCustDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblAddresses_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpBookings_Enter(object sender, EventArgs e)
        {

        }

        private void grpCustDetails_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
          /*  private int reservation_id;
        private string forename;
        private string surname;
        private string phoneNumber;
        private string address;
        private DateTime arrivalDate;
        private DateTime returnDate;
        private int customer_id;
        private string regPlate;
        private Char status;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private char v5;
        */



        
       // Reservations res = new Reservations(txtRerID, txtForename,txtSurname, txtPhoneNumber,  txtAddress,  dtpArrival,  dtpReturn,  /*txtCustomerID,*/  txtCarReg /*, txtStatus*/);
            //res.setArrivalDate(dtpArrival.Value);
            //res.setReturnDate(dtpReturn.Value);


            //All fields have to be filled in 
            if (txtForename.Text == "" || txtSurname.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "" )
            {
                MessageBox.Show("All Fields must be filled");
                return;

            }
            //save booking details in DB
            //Instantiate Car object
            Reservations myRes = new Reservations((txtForename.Text.ToUpper()), (txtSurname.Text.ToUpper()), (txtPhoneNumber.Text.ToUpper()), (txtAddress.Text.ToUpper()), 'R');


            //Insert Car into CARS table
            myRes.regRes();

            //Display Conf Message
            MessageBox.Show("Customer " + txtForename.Text + txtSurname.Text + " is now Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Car:  " + txtRegPlate.Text.ToUpper() + "\n Make:  " + cboMake.Text.ToUpper() + "\n Is Now Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtForename.Text = "";
            txtSurname.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";

            
        }

        private void txtCarReg_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
