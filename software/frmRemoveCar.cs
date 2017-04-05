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
        }

        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.cboCar = new System.Windows.Forms.ComboBox();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.btnCon.Location = new System.Drawing.Point(147, 106);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(164, 23);
            this.btnCon.TabIndex = 41;
            this.btnCon.Text = "Confirm Removal of Car";
            this.btnCon.UseVisualStyleBackColor = true;
            // 
            // cboCar
            // 
            this.cboCar.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.cboCar.FormattingEnabled = true;
            this.cboCar.Location = new System.Drawing.Point(151, 67);
            this.cboCar.Name = "cboCar";
            this.cboCar.Size = new System.Drawing.Size(160, 23);
            this.cboCar.TabIndex = 40;
            this.cboCar.Text = "Please Select Registration ";
            this.cboCar.SelectedIndexChanged += new System.EventHandler(this.cboCar_SelectedIndexChanged);
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblCarReg.Location = new System.Drawing.Point(47, 69);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(98, 16);
            this.lblCarReg.TabIndex = 39;
            this.lblCarReg.Text = "Car Registration";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 292);
            this.dataGridView1.TabIndex = 42;
            // 
            // frmRemoveCar
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.cboCar);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRemoveCar";
            this.Text = "Remove Car";
            this.Load += new System.EventHandler(this.frmRemoveCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmRemoveCar_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            parent.Show();
            this.Dispose();
        }

        private void cboCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
