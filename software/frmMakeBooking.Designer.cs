namespace software
{
    partial class frmMakeBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.dtpReutrn = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.grdCars = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(68, 502);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 28);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReturnDate);
            this.groupBox1.Controls.Add(this.lblArrival);
            this.groupBox1.Controls.Add(this.dtpReutrn);
            this.groupBox1.Controls.Add(this.dtpArrival);
            this.groupBox1.Location = new System.Drawing.Point(29, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 117);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblReturnDate.Location = new System.Drawing.Point(11, 66);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(80, 16);
            this.lblReturnDate.TabIndex = 7;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblArrival.Location = new System.Drawing.Point(15, 12);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(80, 16);
            this.lblArrival.TabIndex = 6;
            this.lblArrival.Text = "Arrival Date:";
            // 
            // dtpReutrn
            // 
            this.dtpReutrn.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.dtpReutrn.Location = new System.Drawing.Point(14, 82);
            this.dtpReutrn.Name = "dtpReutrn";
            this.dtpReutrn.Size = new System.Drawing.Size(200, 22);
            this.dtpReutrn.TabIndex = 5;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.dtpArrival.Location = new System.Drawing.Point(14, 31);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(200, 22);
            this.dtpArrival.TabIndex = 4;
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(29, 52);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(338, 168);
            this.grdCustomers.TabIndex = 48;
            this.grdCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellClick);
            // 
            // grdCars
            // 
            this.grdCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCars.Location = new System.Drawing.Point(420, 52);
            this.grdCars.Name = "grdCars";
            this.grdCars.Size = new System.Drawing.Size(354, 168);
            this.grdCars.TabIndex = 49;
            this.grdCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCars_CellClick);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(29, 265);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 50;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(117, 262);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 20);
            this.txtCustomerName.TabIndex = 51;
            // 
            // txtCarReg
            // 
            this.txtCarReg.Enabled = false;
            this.txtCarReg.Location = new System.Drawing.Point(505, 262);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(250, 20);
            this.txtCarReg.TabIndex = 53;
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Location = new System.Drawing.Point(417, 265);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(82, 13);
            this.lblCarReg.TabIndex = 52;
            this.lblCarReg.Text = "Car Registration";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Location = new System.Drawing.Point(117, 299);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(250, 20);
            this.txtCustomerId.TabIndex = 55;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(29, 302);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerId.TabIndex = 54;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 588);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.grdCars);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmMakeBooking";
            this.Text = "MakeBooking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.DateTimePicker dtpReutrn;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.DataGridView grdCars;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
    }
}