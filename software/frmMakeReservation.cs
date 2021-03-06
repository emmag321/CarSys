﻿using System;
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
           // grdCars.DataSource = Car.getAvailableCars();
            dtpArrival.MinDate = DateTime.Now;
            dtpReturn.MinDate = DateTime.Now;
        }   

        //navigation for back button
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        //reservation id loads it
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
           
            // Check that return date is after arrivalDate
            if (dtpArrival.Value.AddDays(1) > dtpReturn.Value.AddSeconds(1))
            {
                MessageBox.Show("Return date must be after arrival date");
                return;
            }
        }

        //button to submit reservation - has all validation etc.
        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            double txtPhoneNumberVal;

            //All fields have to be filled in 
            if (txtForename.Text == "" || txtSurname.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "" || txtCarReg.Text == "")
            {
                MessageBox.Show("All Fields must be filled inorder to complete booking!");
                return;
            }


            // Check that return date is after arrivalDate
            if (dtpArrival.Value.AddDays(1) > dtpReturn.Value.AddSeconds(1))
            {
                MessageBox.Show("Return date must be after arrival date");
                return;
            }

            //Makes sure phone number is a number 
            else if (!double.TryParse(txtPhoneNumber.Text, out txtPhoneNumberVal))
            {
                MessageBox.Show("Phone Number must be DIGITS!!!");
                return;
            }

            if (txtPhoneNumber.Text.Length > 10)
            {
                MessageBox.Show("Phone Number can only be 10 digits long!!!");
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
            txtCarReg.Text = "";
           // txtRerID.Text = "";
            dtpReturn.Text = "";
            dtpArrival.Text = "";

            //nxt res_ID 
            txtRerID.Text = Reservations.nextReservationNo().ToString();
        }

        //making ID uneditable here
        private void txtCarReg_TextChanged(object sender, EventArgs e)
        {
            txtRerID.ReadOnly = true;
        }
        
        //loads avail cars into datagrid
        private void btnAvailable_Click(object sender, EventArgs e)
        {
            grdCars.DataSource = Reservations.availableCars(dtpArrival.Value, dtpReturn.Value);

        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            //ensures only upper case appears in txt box
            txtForename.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            //ensures only upper case appears in txt box
            txtSurname.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            //ensures only upper case appears in txt box
            txtAddress.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
