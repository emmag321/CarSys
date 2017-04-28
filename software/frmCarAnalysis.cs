﻿using Oracle.DataAccess.Client;
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
    public partial class frmCarAnalysis : Form
    {
        //Makes the main menu its parent 
        private frmMain parent;


        public frmCarAnalysis(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            //loads car makes from db - by make
            grdCarsByMake.DataSource = Car.carAnalysis();
            //loads method car pop from reservations to analysis cars by popularity 
            grdCarPop.DataSource = Car.carsByPopularity();
        }

        //navigation for back button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }
    }
}
