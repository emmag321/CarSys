namespace software
{
    partial class frmReturnCar
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
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.grdReturns = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdReturns)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.btnRemoveCar.Location = new System.Drawing.Point(300, 438);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(163, 23);
            this.btnRemoveCar.TabIndex = 44;
            this.btnRemoveCar.Text = "Confirm Return ";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            // 
            // grdReturns
            // 
            this.grdReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReturns.Location = new System.Drawing.Point(21, 51);
            this.grdReturns.Name = "grdReturns";
            this.grdReturns.Size = new System.Drawing.Size(755, 356);
            this.grdReturns.TabIndex = 45;
            this.grdReturns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReturns_CellContentClick);
            // 
            // frmReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 473);
            this.Controls.Add(this.grdReturns);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnBack);
            this.Name = "frmReturnCar";
            this.Text = "Return Car";
            ((System.ComponentModel.ISupportInitialize)(this.grdReturns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.DataGridView grdReturns;
    }
}