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
    public partial class frmMain : Form
    {   
        //Makes this frm the home page
        public frmMain()
        {
            InitializeComponent();   
        }

        //navigation for frmSetClass
        private void btnSetCarClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetClass frmNext = new frmSetClass(this);
            frmNext.Show();
        }

        //navigation for frmAddCar
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCar frmNext = new frmAddCar(this);
            frmNext.Show();
        }

        //navigation for frmMakeReservation
        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeReservation frmNext = new frmMakeReservation(this);
            frmNext.Show();
        }

        //navigation for frmCancelReservations
        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelReservations frmNext = new frmCancelReservations(this);
            frmNext.Show();
        }

        //exit system button- basically stops system
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //navigation for frmRemoveCar
        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveCar frmNext = new frmRemoveCar(this);
            frmNext.Show();
        }

        //navigation for frmUpdateCar 
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCar frmNext = new frmUpdateCar(this);
            frmNext.Show();
        }

        //navigation for frmViewCarList
        private void btnViewCarList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewCarList frmNext = new frmViewCarList(this);
            frmNext.Show();
        }

        //navigation for frmCollectCar
        private void btnCollectCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCollectCar frmNext = new frmCollectCar(this);
            frmNext.Show();
        }

        //navigation for frmReturnCar
        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnCar frmNext = new frmReturnCar(this);
            frmNext.Show();
        }

        //navigation for frmReservationAnalysis
        private void btnResAnal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservationAnalysis frmNext = new frmReservationAnalysis(this);
            frmNext.Show();
        }

        //navigation for frmCarAnalysis  
        private void btnCarAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCarAnalysis frmNext = new frmCarAnalysis(this);
            frmNext.Show();
        }
    }
}
