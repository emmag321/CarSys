namespace software
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCarClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveCar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateCar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewCarList = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCollectCar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturnCar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageFin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResAnal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCarsToolStripMenuItem,
            this.manageReservationsToolStripMenuItem,
            this.btnManageFin,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageCarsToolStripMenuItem
            // 
            this.manageCarsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCarClassToolStripMenuItem,
            this.btnAddCar,
            this.btnRemoveCar,
            this.btnUpdateCar,
            this.btnViewCarList});
            this.manageCarsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCarsToolStripMenuItem.Name = "manageCarsToolStripMenuItem";
            this.manageCarsToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.manageCarsToolStripMenuItem.Text = "Manage Cars";
            // 
            // setCarClassToolStripMenuItem
            // 
            this.setCarClassToolStripMenuItem.Name = "setCarClassToolStripMenuItem";
            this.setCarClassToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.setCarClassToolStripMenuItem.Text = "Set Car Class";
            this.setCarClassToolStripMenuItem.Click += new System.EventHandler(this.btnSetCarClass_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(167, 22);
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(167, 22);
            this.btnRemoveCar.Text = "Remove Car";
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(167, 22);
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnViewCarList
            // 
            this.btnViewCarList.Name = "btnViewCarList";
            this.btnViewCarList.Size = new System.Drawing.Size(167, 22);
            this.btnViewCarList.Text = "View Car List";
            this.btnViewCarList.Click += new System.EventHandler(this.btnViewCarList_Click);
            // 
            // manageReservationsToolStripMenuItem
            // 
            this.manageReservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMakeBooking,
            this.btnCancelBooking,
            this.btnCollectCar,
            this.btnReturnCar});
            this.manageReservationsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageReservationsToolStripMenuItem.Name = "manageReservationsToolStripMenuItem";
            this.manageReservationsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manageReservationsToolStripMenuItem.Text = "Manage Reservations";
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(203, 22);
            this.btnMakeBooking.Text = "Make a Reservation";
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(203, 22);
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnCollectCar
            // 
            this.btnCollectCar.Name = "btnCollectCar";
            this.btnCollectCar.Size = new System.Drawing.Size(203, 22);
            this.btnCollectCar.Text = "Collect Car";
            this.btnCollectCar.Click += new System.EventHandler(this.btnCollectCar_Click);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(203, 22);
            this.btnReturnCar.Text = "Return Car";
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnManageFin
            // 
            this.btnManageFin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnResAnal,
            this.btnCarAnalysis});
            this.btnManageFin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageFin.Name = "btnManageFin";
            this.btnManageFin.Size = new System.Drawing.Size(131, 22);
            this.btnManageFin.Text = "Manage Analysis";
            // 
            // btnResAnal
            // 
            this.btnResAnal.Name = "btnResAnal";
            this.btnResAnal.Size = new System.Drawing.Size(212, 22);
            this.btnResAnal.Text = "Reservation Analysis";
            this.btnResAnal.Click += new System.EventHandler(this.btnResAnal_Click);
            // 
            // btnCarAnalysis
            // 
            this.btnCarAnalysis.Name = "btnCarAnalysis";
            this.btnCarAnalysis.Size = new System.Drawing.Size(212, 22);
            this.btnCarAnalysis.Text = "Car Analysis";
            this.btnCarAnalysis.Click += new System.EventHandler(this.btnCarAnalysis_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::software.Properties.Resources.tumblr_ofks3mjP6v1vhnuslo1_1280;
            this.pictureBox1.InitialImage = global::software.Properties.Resources.HJBZhw;
            this.pictureBox1.Location = new System.Drawing.Point(-53, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 538);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "CARSYS MAIN MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCarClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddCar;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveCar;
        private System.Windows.Forms.ToolStripMenuItem btnViewCarList;
        private System.Windows.Forms.ToolStripMenuItem manageReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem btnCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem btnCollectCar;
        private System.Windows.Forms.ToolStripMenuItem btnReturnCar;
        private System.Windows.Forms.ToolStripMenuItem btnManageFin;
        private System.Windows.Forms.ToolStripMenuItem btnResAnal;
        private System.Windows.Forms.ToolStripMenuItem btnCarAnalysis;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateCar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}