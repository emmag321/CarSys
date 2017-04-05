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
            this.button1 = new System.Windows.Forms.Button();
            this.cboCar = new System.Windows.Forms.ComboBox();
            this.lblCarReg = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.button1.Location = new System.Drawing.Point(123, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Confirm Cancellation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboCar
            // 
            this.cboCar.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.cboCar.FormattingEnabled = true;
            this.cboCar.Location = new System.Drawing.Point(123, 55);
            this.cboCar.Name = "cboCar";
            this.cboCar.Size = new System.Drawing.Size(166, 23);
            this.cboCar.TabIndex = 43;
            this.cboCar.Text = "Please Select Registration ";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblCarReg.Location = new System.Drawing.Point(16, 57);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(101, 16);
            this.lblCarReg.TabIndex = 42;
            this.lblCarReg.Text = "Car Registration:";
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 164);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboCar);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCancelBooking";
            this.Text = "CancelBooking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboCar;
        private System.Windows.Forms.Label lblCarReg;
    }
}