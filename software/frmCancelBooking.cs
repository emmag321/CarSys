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
    public partial class frmCancelBooking : Form
    {
        private frmMain parent;


        public frmCancelBooking(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            grdCancelBooking.DataSource = Car.getCars();
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

        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
