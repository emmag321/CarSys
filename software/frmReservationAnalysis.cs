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
    public partial class frmReservationAnalysis : Form
    {
        //Makes the main menu its parent 
        private frmMain parent;

        //Navigation
        public frmReservationAnalysis(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        //items for cbp box
        private void frmReservationAnalysis_Load(object sender, EventArgs e)
        {
            cboYear.Items.Add("2017");
           
        }

        //Navigation for back button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        //method for reservations analysis by year - tells the reservations per month and totoal reservations 
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            //get Data in grid
            try
            {
                //use getReservations() method to get the data
                DataSet myDS = new DataSet();

                //Load data into grid
                grdRes.DataSource = Reservations.getReservations(myDS, cboYear.SelectedItem.ToString()).Tables["Res"];
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        
       }
    }
}
