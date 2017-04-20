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
    public partial class frmCollectCar : Form
    {
        private frmMain parent;
        public frmCollectCar(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            grdCollectCar.DataSource = Customer.getCustomers();


        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }



        private void frmCollectCar_Load(object sender, EventArgs e)
        {
            /*{
                if (e.ColumnIndex == 0)
                 {
                     if (grdCollectCar.Rows[e.RowIndex].Cells[7].Value.ToString() != "D")
                     {
                         DialogResult confirmResult = MessageBox.Show("Are you sure you want to cancel this Reservstion?", "Confirm Cancelation", MessageBoxButtons.YesNo);

                         if (confirmResult == DialogResult.Yes)
                         {
                             Reservations.cancelBooking(grdCancelBooking.Rows[e.RowIndex].Cells[1].Value.ToString());
                             grdCancelBooking.DataSource = Reservations.getReservations();
                         }
                     }
                     else
                     {
                         MessageBox.Show("Booking has been Cancelled!!");
                     }
                 }*/

        }


        private void grdCollectCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCollectCar_Click(object sender, EventArgs e)
        {

        }
    }
}
