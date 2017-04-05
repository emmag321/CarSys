namespace software
{
    partial class frmCollectCar
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
            this.btnCollectCar = new System.Windows.Forms.Button();
            this.cboCar = new System.Windows.Forms.ComboBox();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCollectCar
            // 
            this.btnCollectCar.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.btnCollectCar.Location = new System.Drawing.Point(119, 95);
            this.btnCollectCar.Name = "btnCollectCar";
            this.btnCollectCar.Size = new System.Drawing.Size(148, 22);
            this.btnCollectCar.TabIndex = 47;
            this.btnCollectCar.Text = "Confirm Cancellation";
            this.btnCollectCar.UseVisualStyleBackColor = true;
            // 
            // cboCar
            // 
            this.cboCar.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.cboCar.FormattingEnabled = true;
            this.cboCar.Location = new System.Drawing.Point(119, 44);
            this.cboCar.Name = "cboCar";
            this.cboCar.Size = new System.Drawing.Size(148, 23);
            this.cboCar.TabIndex = 46;
            this.cboCar.Text = "Please Select Registration ";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblCarReg.Location = new System.Drawing.Point(12, 47);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(101, 16);
            this.lblCarReg.TabIndex = 45;
            this.lblCarReg.Text = "Car Registration:";
            // 
            // frmCollectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 150);
            this.Controls.Add(this.btnCollectCar);
            this.Controls.Add(this.cboCar);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCollectCar";
            this.Text = "frmCollectCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCollectCar;
        private System.Windows.Forms.ComboBox cboCar;
        private System.Windows.Forms.Label lblCarReg;
    }
}