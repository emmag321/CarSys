namespace software
{
    partial class frmCancelBooking
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
            this.grdCancelBooking = new System.Windows.Forms.DataGridView();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.CancelReservation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // grdCancelBooking
            // 
            this.grdCancelBooking.AllowUserToAddRows = false;
            this.grdCancelBooking.AllowUserToDeleteRows = false;
            this.grdCancelBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCancelBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CancelReservation});
            this.grdCancelBooking.Location = new System.Drawing.Point(12, 54);
            this.grdCancelBooking.Name = "grdCancelBooking";
            this.grdCancelBooking.ReadOnly = true;
            this.grdCancelBooking.Size = new System.Drawing.Size(893, 484);
            this.grdCancelBooking.TabIndex = 39;
            this.grdCancelBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCancelBooking_CellContentClick);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.Location = new System.Drawing.Point(369, 572);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(154, 34);
            this.btnCancelBooking.TabIndex = 40;
            this.btnCancelBooking.Text = "Cancel Reservation";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
 
            // 
            // CancelReservation
            // 
            this.CancelReservation.HeaderText = "Cancel Reservation";
            this.CancelReservation.Name = "CancelReservation";
            this.CancelReservation.ReadOnly = true;
            this.CancelReservation.Text = "Cancel";
            this.CancelReservation.UseColumnTextForButtonValue = true;
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 669);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.grdCancelBooking);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Reservation";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdCancelBooking;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.DataGridViewButtonColumn CancelReservation;
    }
}