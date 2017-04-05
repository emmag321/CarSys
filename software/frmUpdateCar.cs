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
    public partial class frmUpdateCar : Form
    {
        private frmMain parent;
        //code for menu
        public frmUpdateCar(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
      
        //Returns to home
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }
       
       //Loads the CarClass of car into the update form incase needs changing 
        public void loadClasses()
        {
            DataTable dt = Car_Class.getCarClasses();

            foreach (DataRow row in dt.Rows)
            {
                cboClasses.Items.Add(row.ItemArray[0] + " - " + row.ItemArray[1]);

            }
        }
       
        //Button that brings all info from db - info on the car - so it can be changed
        private void bntOK_Click(object sender, EventArgs e)
        {
            //validate data
            //retrieve car details from DB
            Car myCar = new Car();
            myCar.getCarDetails(txtSearch.Text);

            if (myCar.getRegPlate().Equals(""))
            {
                MessageBox.Show("Car not Found");
                txtSearch.Focus();
                return;

            }

            //load data from object into form controls
            txtRegPlate.Text = myCar.getRegPlate();

            //get cars class info
            loadClasses();
            cboClasses.SelectedIndex = 0;

            while (!(myCar.getCarClass().Equals(Convert.ToChar(cboClasses.Text.Substring(0, 1)))))
            {
                cboClasses.SelectedIndex++;
            }

            //set fuel type
            loadFuelTypes(myCar.getFuelType());

            //Set Num Doors
            loadNumDoors(myCar.getNumDoors().ToString());
            /*
            while (!(myCar.getNumDoors().Equals(Convert.ToInt32(cboNumDoors.Text.Substring(0, 1)))))
            {
                cboNumDoors.SelectedIndex++;
            }*/

            //Set makes 
            loadMake(myCar.getMake());

            //Set model 
            //loadModel(myCar.getModel());

            grpCar.Visible = true;
        }


        //Puts fuel type into update form 
        public void loadFuelTypes(char fuelType)
        {
            cboFuelTypes.Items.Add("D - Diesel");
            cboFuelTypes.Items.Add("P - Petrol");

            cboFuelTypes.SelectedIndex = cboFuelTypes.FindString(fuelType.ToString());
        }


        //Puts Num Doors into Update form --Not working correctly 
        public void loadNumDoors(String numDoors)
        {

            cboNumDoors.Items.Add("3 Doors");
            cboNumDoors.Items.Add("5Doors");

            //set the combobox to required number of doors
            /*cboNumDoors.SelectedIndex = 0;
            while (cboNumDoors.Text.Substring(0, 1) != numDoors)
            {
                cboNumDoors.SelectedIndex++;
            }*/

            cboNumDoors.SelectedIndex = cboNumDoors.FindString(numDoors);
        }


        //Puts models into Update form 
        public void loadMake(String make)
        {

            cboMake.Items.Add("Audi");
            cboMake.Items.Add("BMW");
            cboMake.Items.Add("Mercedes");
            cboMake.Items.Add("Opel");
            cboMake.Items.Add("Renault");
            cboMake.Items.Add("Skoda");
            cboMake.Items.Add("Toyota");
            cboMake.Items.Add("Volkswagen");

            cboMake.SelectedIndex = cboMake.FindString(make);
        }

        /*public void loadModel(String model)
        {
            lblModel.Text = model;
        }*/

        
        private void grpCar_Enter(object sender, EventArgs e)
        {

        }

        private void txtRegPlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateCar_Load(object sender, EventArgs e)
        {

        }


        private void cboClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMake_Click(object sender, EventArgs e)
        {

        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            //All fields have to be filled in 
            if (txtRegPlate.Text == "" || cboClasses.Text == "" || cboFuelTypes.Text == "" || cboFuelTypes.Text == "" || cboMake.Text == "" || txtModel.Text == "")
            {
                MessageBox.Show("All Fields must be filled");
                return;

            }/*
            else if (Car.alreadyRegistered(txtRegPlate.Text))
            {
                MessageBox.Show("Already Exists Please Try Again");
                txtRegPlate.Focus();
                return;
            }*/
        }

        private void cboNumDoors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboFuelTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblReg_Click(object sender, EventArgs e)
        {

        }
    }

    
}

        
    

    
  

