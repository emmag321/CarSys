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

        }


        private void grdCollectCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCollectCar_Click(object sender, EventArgs e)
        {

        }
    }
}
