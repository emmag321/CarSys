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
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }
    }
}
