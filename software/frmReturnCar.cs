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
    public partial class frmReturnCar : Form
    {
        private frmMain parent;
        public frmReturnCar(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            //loads collected reservations inot data grid 
            grdReturns.DataSource = Reservations.getCollectedReservations();
        }

        //navigation for back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        //returned car button
        private void grdReturns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                Reservations.carReturned(Int32.Parse(grdReturns.Rows[e.RowIndex].Cells[1].Value.ToString()), DateTime.Now);
                MessageBox.Show("Car Returned");

                grdReturns.DataSource = Reservations.getCollectedReservations();
            }
        }
    }
}
