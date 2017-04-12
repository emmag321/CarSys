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
            grdCars.DataSource = Car.getAvailableCars();

            dtpArrival.MinDate = DateTime.Now;
            dtpReturn.MinDate = DateTime.Now;
        }   

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

         private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            txtRerID.Text = Reservations.nextReservationNo().ToString();
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
            //All fields have to be filled in 
            if (txtForename.Text == "" || txtSurname.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "" )
            {
                MessageBox.Show("All Fields must be filled");
                return;
            }

            
            // Check that return date is after arrivalDate
            if (dtpArrival.Value.AddDays(1) > dtpReturn.Value.AddSeconds(1))
            {
                MessageBox.Show("Return date must be after arrival date");
                return;
            }

            //  Check that car available on selected days
            if (!Reservations.isCarAvailable(txtCarReg.Text, dtpArrival.Value, dtpReturn.Value))
            {
                MessageBox.Show("Car is not available on the selected dates");
                return;
            }

            //save booking details in DB
            //Instantiate Car object
            Reservations myRes = new Reservations(Int32.Parse(txtRerID.Text.ToString()), txtForename.Text.ToUpper(), txtSurname.Text.ToUpper(), txtPhoneNumber.Text.ToUpper(), txtAddress.Text.ToUpper(), dtpArrival.Value, dtpReturn.Value, txtCarReg.Text, 'B');

            myRes.regRes();

            //Display Conf Message
            MessageBox.Show("Car is now booked", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtForename.Text = "";
            txtSurname.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }

        private void txtCarReg_TextChanged(object sender, EventArgs e)
        {
            txtRerID.ReadOnly = true;
        }

        private void grdCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void True(object sender, EventArgs e)
        {

        }

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }
    }
}
