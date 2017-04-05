using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace software
{
    public partial class CarClass : Form
    {
        private char carClass;
        private String description;
        private decimal rate;

        public CarClass()
        {
            carClass = ' ';
            description = " ";
            rate = 0;
        }

        public CarClass(char CarClass, String Description, decimal Rate)
        {
            carClass = CarClass;
            description = Description;
            rate = Rate;
        }

       

        private void btnSet_Click(object sender, EventArgs e)
        {
            //validate data

            //save car class data
            //Car myCar = new Car();
            //myCar.setClassCode(Convert.ToChar(txtClassCode));
            //myCar.setDescription(txtDescription.Text);
            //myCar.setRate(Convert.ToDecimal(txtRate.Text));

            //Insert Car class into Car Class table
            //myCar.regCar();

            Car myCar = new Car(Convert.ToChar(txtClassCode), txtDescription.Text, Convert.ToDecimal(txtRate.Text));

            //insert into car class table 
            myCar.AddCarClass();


            //display confirmation message
            MessageBox.Show("Car class" + txtClassCode.Text + "Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reset UI
            txtClassCode.Text = " ";
            txtDescription.Text = " ";
            txtRate.Text = " ";



        }

        

    }
}
