using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace software
{
    public partial class frmAddCar : Form
    {
        //Makes the main menu its parent 
        private frmMain parent;
        

        public frmAddCar(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        //puts info into the drop down boxes
        private void AddCar_Load(object sender, EventArgs e)
        {
            //Drop down for Fuel
            cboFuelTypes.Items.Add("P - Petrol");
            cboFuelTypes.Items.Add("D - Diesel");
            //Drop down for doors
            cboNumDoors.Items.Add("3 Door");
            cboNumDoors.Items.Add("5 Door");
            //Drop down for Model
            cboMake.Items.Add("Audi");
            cboMake.Items.Add("BMW");
            cboMake.Items.Add("Mercedes");
            cboMake.Items.Add("Opel");
            cboMake.Items.Add("Renault");
            cboMake.Items.Add("Skoda");
            cboMake.Items.Add("Toyota");
            cboMake.Items.Add("Volkswagen");
            
            //puts car classes from DB into Drop down menu 
            DataTable dt = Car_Class.getCarClasses();

            foreach (DataRow row in dt.Rows)
            {
                cboClasses.Items.Add(row.ItemArray[0] + " - " + row.ItemArray[1]);

            }
         }
 
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            //validate registration plate
            if (!isValidReg(txtRegPlate.Text))
            {
                MessageBox.Show("Invalid Reg");
                txtRegPlate.Focus();
                return;
            }

            //All fields have to be filled in 
            if (cboNumDoors.Text == "" || cboFuelTypes.Text == "" || cboClasses.Text == "" || txtRegPlate.Text == ""  || cboMake.Text == "" || txtModel.Text == "")
            {
                MessageBox.Show("All Fields must be filled");
                return;

            }
            else if (Car.alreadyRegistered(txtRegPlate.Text))
            {
                MessageBox.Show("Already Exists Please Try Again");
                txtRegPlate.Focus();
                return;
            }
     
            //save car class details in DB
            //Instantiate Car object
            Car myCar = new Car((txtRegPlate.Text.ToUpper()), Convert.ToChar(cboClasses.Text.Substring(0, 1)), Convert.ToChar(cboFuelTypes.Text.Substring(0, 1)), Convert.ToInt32(cboNumDoors.Text.Substring(0, 1)), cboMake.Text, (txtModel.Text.ToUpper()), 'A');
            
            //Insert Car into CARS table
             myCar.regAddCar();

            //Display Conf Message
            MessageBox.Show("Car:  " + txtRegPlate.Text.ToUpper() + "\n Make:  "+ cboMake.Text.ToUpper() + "\n Is Now Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtRegPlate.Text = "";
            cboClasses.SelectedIndex = -1;
            cboFuelTypes.SelectedIndex = -1;
            cboNumDoors.SelectedIndex = -1;
            cboMake.SelectedIndex = -1;
            txtModel.Text = "";
            txtRegPlate.Focus(); 


        }

        //Code to make sure registration is correct format
        public Boolean isValidReg(String regNo)
        {
            // Define Regex for car reg with 3 digits-two letters-up to 5 digits
            if ((Regex.IsMatch(regNo, "^[0-9]{2}[12][-][A-Za-z]{1,2}[-][0-9]{1,5}$")))
            {
                return true;
            }
            // Define Regex for car reg with 2 digits-two letters-up to 5 digits
            else if (Regex.IsMatch(regNo, "^[0-9]{2}[-][A-Za-z]{1,2}[-][0-9]{1,5}$"))
            {
                return true;
            }
            else
                return false;
        }

        //navigation for back button 
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }
    }
}
