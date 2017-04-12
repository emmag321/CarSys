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
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnSetCarClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetClass frmNext = new frmSetClass(this);
            frmNext.Show();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCar frmNext = new frmAddCar(this);
            frmNext.Show();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeReservation frmNext = new frmMakeReservation(this);
            frmNext.Show();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelBooking frmNext = new frmCancelBooking(this);
            frmNext.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveCar frmNext = new frmRemoveCar(this);
            frmNext.Show();
        }


        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCar frmNext = new frmUpdateCar(this);
            frmNext.Show();
        }

        private void btnViewCarList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewCarList frmNext = new frmViewCarList(this);
            frmNext.Show();
        }

        private void btnCollectCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCollectCar frmNext = new frmCollectCar(this);
            frmNext.Show();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnCar frmNext = new frmReturnCar(this);
            frmNext.Show();
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
