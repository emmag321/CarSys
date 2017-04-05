namespace software
{
    partial class frmUpdateCustomer
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
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.grpCar = new System.Windows.Forms.GroupBox();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.grpCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCustomers
            // 
            this.grdCustomers.AllowUserToAddRows = false;
            this.grdCustomers.AllowUserToDeleteRows = false;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(13, 13);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.ReadOnly = true;
            this.grdCustomers.Size = new System.Drawing.Size(626, 255);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellClick);
            // 
            // grpCar
            // 
            this.grpCar.Controls.Add(this.txtCustomerId);
            this.grpCar.Controls.Add(this.label1);
            this.grpCar.Controls.Add(this.txtAddress);
            this.grpCar.Controls.Add(this.lblAdress);
            this.grpCar.Controls.Add(this.txtPhoneNum);
            this.grpCar.Controls.Add(this.lblPhoneNum);
            this.grpCar.Controls.Add(this.txtSurname);
            this.grpCar.Controls.Add(this.lblSurname);
            this.grpCar.Controls.Add(this.txtForename);
            this.grpCar.Controls.Add(this.lblForename);
            this.grpCar.Controls.Add(this.btnUpdateCust);
            this.grpCar.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.grpCar.Location = new System.Drawing.Point(13, 287);
            this.grpCar.Name = "grpCar";
            this.grpCar.Size = new System.Drawing.Size(626, 317);
            this.grpCar.TabIndex = 40;
            this.grpCar.TabStop = false;
            this.grpCar.Text = "Update Customer Details";
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCust.Location = new System.Drawing.Point(208, 276);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateCust.TabIndex = 40;
            this.btnUpdateCust.Text = "Update";
            this.btnUpdateCust.UseVisualStyleBackColor = true;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(32, 79);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(65, 16);
            this.lblForename.TabIndex = 41;
            this.lblForename.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(103, 79);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 22);
            this.txtForename.TabIndex = 42;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(103, 111);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 44;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(32, 114);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 16);
            this.lblSurname.TabIndex = 43;
            this.lblSurname.Text = "Surname";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(132, 144);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNum.TabIndex = 46;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(32, 147);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(94, 16);
            this.lblPhoneNum.TabIndex = 45;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 48;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(32, 180);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(46, 16);
            this.lblAdress.TabIndex = 47;
            this.lblAdress.Text = "Adress";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Location = new System.Drawing.Point(117, 42);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerId.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Customer ID";
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 626);
            this.Controls.Add(this.grpCar);
            this.Controls.Add(this.grdCustomers);
            this.Name = "frmUpdateCustomer";
            this.Text = "Update Customer Details";
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.grpCar.ResumeLayout(false);
            this.grpCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.GroupBox grpCar;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
    }
}