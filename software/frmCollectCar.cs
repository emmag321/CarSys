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
            //loads stuff into grd - cars that are available for collection 
            grdCollectCar.DataSource = Reservations.getAvailableReservations();
        }

        //navigation for back button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }
        
        //click in the grd to mark car as collected 
        private void grdCollectCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Reservations.carCollected(Int32.Parse(grdCollectCar.Rows[e.RowIndex].Cells[1].Value.ToString()));
                MessageBox.Show("Car Collected");
                grdCollectCar.DataSource = Reservations.getAvailableReservations();
            }
        }
    }
}
