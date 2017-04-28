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
using System.Data.SqlClient;

namespace software
{
    public partial class frmSetClass : Form
    {
        private frmMain parent;
      
        public frmSetClass(frmMain parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        //main button - contains validations in if statements etc.
        private void btnSet_Click_1(object sender, EventArgs e)
        {
            double txtRateVal;
            
            //validate data
            
            if (Car_Class.isExistingClass(txtClassCode.Text))
            {
                MessageBox.Show("Already exists");
                txtClassCode.Focus();
                return;
            } else if (txtClassCode.Text.Length == 0 || txtDescription.Text.Length == 0 || txtRate.Text.Length == 0)
            {
                MessageBox.Show("All Fields must be filled");
                return;
            } else if (!double.TryParse(txtRate.Text, out txtRateVal))
            {
                MessageBox.Show("Rate must be a valid price (e.g. 19.99)");
                return;
            }

            //save car class details in DB
            //Instantiate Car object 

            Car_Class myCars = new Car_Class(Convert.ToChar(txtClassCode.Text.ToUpper()), txtDescription.Text, Convert.ToDouble(txtRate.Text));
            

            //Insert CarClasses into Stock Table
            myCars.regCarClass();

            //Display Conf Message
            MessageBox.Show("Car class " + txtClassCode.Text + " is now Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reset UI
            txtClassCode.Text = "";
            txtDescription.Text = " ";
            txtRate.Text = " ";

            txtClassCode.Focus();

        }

        //navigation for back button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void txtClassCode_TextChanged(object sender, EventArgs e)
        {
            //ensures only upper case ONLY appears in txt box
            txtClassCode.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            //ensures only upper case ONLY appears in txt box
            txtDescription.CharacterCasing = CharacterCasing.Upper;
        }
    }
}

