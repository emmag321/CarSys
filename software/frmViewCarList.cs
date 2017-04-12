﻿using System;
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


        public frmViewCarList(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            //retrieves info from DB
            //grdViewCarList.DataSource = Car.getCars();
            grdAvailableCars.DataSource = Car.getAvailableCars();
            grdRemovedars.DataSource = Car.getRemovedCars();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void grdViewCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblReg_Click(object sender, EventArgs e)
        {

        }

        private void frmViewCarList_Load(object sender, EventArgs e)
        {


       }

        private void grdRemovedars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdAvailableCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAvailableCars_Click(object sender, EventArgs e)
        {

        }

        private void lblRemoveCarHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
