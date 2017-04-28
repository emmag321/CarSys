namespace software
{
    partial class frmMakeReservation
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grdCars = new System.Windows.Forms.DataGridView();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddresses = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.grpBookings = new System.Windows.Forms.GroupBox();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.txtRerID = new System.Windows.Forms.TextBox();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.lblBookingId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            this.grpCustDetails.SuspendLayout();
            this.grpBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(14, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // grdCars
            // 
            this.grdCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCars.Location = new System.Drawing.Point(14, 344);
            this.grdCars.Name = "grdCars";
            this.grdCars.ShowEditingIcon = false;
            this.grdCars.Size = new System.Drawing.Size(952, 323);
            this.grdCars.TabIndex = 49;
            this.grdCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCars_CellClick);
            // 
            // txtCarReg
            // 
            this.txtCarReg.Enabled = false;
            this.txtCarReg.Location = new System.Drawing.Point(610, 77);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(111, 22);
            this.txtCarReg.TabIndex = 53;
            this.txtCarReg.TextChanged += new System.EventHandler(this.txtCarReg_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(30, 83);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 16);
            this.lblSurname.TabIndex = 61;
            this.lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(30, 40);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(65, 16);
            this.lblForename.TabIndex = 62;
            this.lblForename.Text = "Forename";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 124);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(94, 16);
            this.lblPhoneNumber.TabIndex = 64;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(135, 34);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(291, 22);
            this.txtForename.TabIndex = 65;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(135, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(291, 22);
            this.txtSurname.TabIndex = 66;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(135, 118);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(291, 22);
            this.txtPhoneNumber.TabIndex = 67;
            // 
            // lblAddresses
            // 
            this.lblAddresses.AutoSize = true;
            this.lblAddresses.Location = new System.Drawing.Point(30, 159);
            this.lblAddresses.Name = "lblAddresses";
            this.lblAddresses.Size = new System.Drawing.Size(53, 16);
            this.lblAddresses.TabIndex = 68;
            this.lblAddresses.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 159);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 22);
            this.txtAddress.TabIndex = 69;
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.lblForename);
            this.grpCustDetails.Controls.Add(this.txtAddress);
            this.grpCustDetails.Controls.Add(this.lblSurname);
            this.grpCustDetails.Controls.Add(this.lblAddresses);
            this.grpCustDetails.Controls.Add(this.lblPhoneNumber);
            this.grpCustDetails.Controls.Add(this.txtPhoneNumber);
            this.grpCustDetails.Controls.Add(this.txtForename);
            this.grpCustDetails.Controls.Add(this.txtSurname);
            this.grpCustDetails.Location = new System.Drawing.Point(510, 112);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Size = new System.Drawing.Size(456, 216);
            this.grpCustDetails.TabIndex = 70;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Customer Details";
            // 
            // grpBookings
            // 
            this.grpBookings.Controls.Add(this.btnAvailable);
            this.grpBookings.Controls.Add(this.label1);
            this.grpBookings.Controls.Add(this.dtpArrival);
            this.grpBookings.Controls.Add(this.label2);
            this.grpBookings.Controls.Add(this.dtpReturn);
            this.grpBookings.Location = new System.Drawing.Point(14, 112);
            this.grpBookings.Name = "grpBookings";
            this.grpBookings.Size = new System.Drawing.Size(456, 216);
            this.grpBookings.TabIndex = 71;
            this.grpBookings.TabStop = false;
            this.grpBookings.Text = "Booking Details";
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(97, 143);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(268, 53);
            this.btnAvailable.TabIndex = 59;
            this.btnAvailable.Text = "Check Availability";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label1.Location = new System.Drawing.Point(103, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arrival Date:";
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.dtpArrival.Location = new System.Drawing.Point(107, 49);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(233, 22);
            this.dtpArrival.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label2.Location = new System.Drawing.Point(103, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Return Date:";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.dtpReturn.Location = new System.Drawing.Point(107, 105);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(233, 22);
            this.dtpReturn.TabIndex = 57;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.btnConfirmBooking.Location = new System.Drawing.Point(413, 691);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(152, 32);
            this.btnConfirmBooking.TabIndex = 60;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // txtRerID
            // 
            this.txtRerID.Location = new System.Drawing.Point(121, 75);
            this.txtRerID.Name = "txtRerID";
            this.txtRerID.Size = new System.Drawing.Size(77, 22);
            this.txtRerID.TabIndex = 72;
            this.txtRerID.TextChanged += new System.EventHandler(this.txtCarReg_TextChanged);
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Location = new System.Drawing.Point(507, 81);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(98, 16);
            this.lblCarReg.TabIndex = 52;
            this.lblCarReg.Text = "Car Registration";
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Location = new System.Drawing.Point(11, 75);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(74, 16);
            this.lblBookingId.TabIndex = 73;
            this.lblBookingId.Text = "Booking ID";
            // 
            // frmMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 761);
            this.Controls.Add(this.lblBookingId);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.txtRerID);
            this.Controls.Add(this.grpBookings);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.grdCars);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.Name = "frmMakeReservation";
            this.Text = "Make Reservation";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            this.grpBookings.ResumeLayout(false);
            this.grpBookings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdCars;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblAddresses;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.GroupBox grpBookings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.TextBox txtRerID;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.Button btnAvailable;
    }
}