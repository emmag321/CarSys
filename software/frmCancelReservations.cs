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
    public partial class frmCancelReservations : Form
    {
        private frmMain parent;


        public frmCancelReservations(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            grdCancelBooking.DataSource = Reservations.getReservations();
            //grdCancelBooking.DataSource = Reservations.deleteReservation();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {

        }

        private void grdCancelBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (grdCancelBooking.Rows[e.RowIndex].Cells[7].Value.ToString() != "D")
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
            }

        }

        /*private void btnCancelBooking_Click(object sender, EventArgs e)
            {

            }*/
    }
}


