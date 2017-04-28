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
    public partial class frmRemoveCar : Form
    {
        private frmMain parent;
        
        public frmRemoveCar(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;

            //loads getCars method into grdRemoveCars
            grdRemoveCar.DataSource = Car.getCars();
        }

        //grd contents here 
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.grdRemoveCar = new System.Windows.Forms.DataGridView();
            this.grdBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdRemoveCar
            // 
            this.grdRemoveCar.AllowUserToAddRows = false;
            this.grdRemoveCar.AllowUserToDeleteRows = false;
            this.grdRemoveCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRemoveCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdBtnDelete});
            this.grdRemoveCar.Location = new System.Drawing.Point(20, 50);
            this.grdRemoveCar.Name = "grdRemoveCar";
            this.grdRemoveCar.ReadOnly = true;
            this.grdRemoveCar.Size = new System.Drawing.Size(829, 292);
            this.grdRemoveCar.TabIndex = 42;
            this.grdRemoveCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRemoveCar_CellClick);
            // 
            // grdBtnDelete
            // 
            this.grdBtnDelete.HeaderText = "Remove";
            this.grdBtnDelete.Name = "grdBtnDelete";
            this.grdBtnDelete.ReadOnly = true;
            this.grdBtnDelete.Text = "Remove";
            this.grdBtnDelete.ToolTipText = "Delete Car";
            this.grdBtnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmRemoveCar
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 444);
            this.Controls.Add(this.grdRemoveCar);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRemoveCar";
            this.Text = "Remove Car";
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveCar)).EndInit();
            this.ResumeLayout(false);

        }
       
        //navigation for back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        //button which removes car
        private void grdRemoveCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (grdRemoveCar.Rows[e.RowIndex].Cells[7].Value.ToString() != "D")
                {
                    //message box to confirm removal of car 
                    DialogResult confirmResult = MessageBox.Show("Are you sure to remove this Car?", "Confirm Remove", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        Car.deleteCars(grdRemoveCar.Rows[e.RowIndex].Cells[1].Value.ToString());
                        grdRemoveCar.DataSource = Car.getCars();
                    }
                }
                else
                {
                    MessageBox.Show("Car has already been removed");
                }
            }
            
        }
    }
}
