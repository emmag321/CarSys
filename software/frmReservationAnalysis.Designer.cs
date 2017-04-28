namespace software
{
    partial class frmReservationAnalysis
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
            this.lblPleaseSelect = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblCarAnal = new System.Windows.Forms.Label();
            this.grdRes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 25);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPleaseSelect
            // 
            this.lblPleaseSelect.AutoSize = true;
            this.lblPleaseSelect.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.lblPleaseSelect.Location = new System.Drawing.Point(34, 95);
            this.lblPleaseSelect.Name = "lblPleaseSelect";
            this.lblPleaseSelect.Size = new System.Drawing.Size(172, 22);
            this.lblPleaseSelect.TabIndex = 47;
            this.lblPleaseSelect.Text = "Please Select a Year";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.cboYear.Location = new System.Drawing.Point(216, 91);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 26);
            this.cboYear.TabIndex = 46;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // lblCarAnal
            // 
            this.lblCarAnal.AutoSize = true;
            this.lblCarAnal.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.lblCarAnal.Location = new System.Drawing.Point(33, 170);
            this.lblCarAnal.Name = "lblCarAnal";
            this.lblCarAnal.Size = new System.Drawing.Size(154, 29);
            this.lblCarAnal.TabIndex = 45;
            this.lblCarAnal.Text = "Cars Rented ";
            // 
            // grdRes
            // 
            this.grdRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRes.Location = new System.Drawing.Point(38, 202);
            this.grdRes.Name = "grdRes";
            this.grdRes.Size = new System.Drawing.Size(299, 388);
            this.grdRes.TabIndex = 44;
            // 
            // frmReservationAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 678);
            this.Controls.Add(this.lblPleaseSelect);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.lblCarAnal);
            this.Controls.Add(this.grdRes);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.25F);
            this.Name = "frmReservationAnalysis";
            this.Text = "Reservation Analysis";
            this.Load += new System.EventHandler(this.frmReservationAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPleaseSelect;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblCarAnal;
        private System.Windows.Forms.DataGridView grdRes;
    }
}