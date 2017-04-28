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
    public partial class frmViewCarList : Form
    {
        private frmMain parent;

        //navigation 
        public frmViewCarList(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            //retrieves info from DB
            grdAvailableCars.DataSource = Car.getAvailableCars();
            grdRemovedars.DataSource = Car.getRemovedCars();
        }

        //bnavigation for back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }
    }
}
