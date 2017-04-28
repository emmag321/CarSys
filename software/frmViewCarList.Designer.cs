namespace software
{
    partial class frmViewCarList
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
            this.grdRemovedars = new System.Windows.Forms.DataGridView();
            this.grdAvailableCars = new System.Windows.Forms.DataGridView();
            this.lblRemoveCarHeading = new System.Windows.Forms.Label();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemovedars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableCars)).BeginInit();
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdRemovedars
            // 
            this.grdRemovedars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRemovedars.Location = new System.Drawing.Point(69, 357);
            this.grdRemovedars.Name = "grdRemovedars";
            this.grdRemovedars.Size = new System.Drawing.Size(817, 189);
            this.grdRemovedars.TabIndex = 49;
            // 
            // grdAvailableCars
            // 
            this.grdAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAvailableCars.Location = new System.Drawing.Point(69, 86);
            this.grdAvailableCars.Name = "grdAvailableCars";
            this.grdAvailableCars.Size = new System.Drawing.Size(817, 189);
            this.grdAvailableCars.TabIndex = 50;
            // 
            // lblRemoveCarHeading
            // 
            this.lblRemoveCarHeading.AutoSize = true;
            this.lblRemoveCarHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveCarHeading.Location = new System.Drawing.Point(64, 311);
            this.lblRemoveCarHeading.Name = "lblRemoveCarHeading";
            this.lblRemoveCarHeading.Size = new System.Drawing.Size(173, 29);
            this.lblRemoveCarHeading.TabIndex = 51;
            this.lblRemoveCarHeading.Text = "Removed Cars";
            // 
            // lblAvailableCars
            // 
            this.lblAvailableCars.AutoSize = true;
            this.lblAvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCars.Location = new System.Drawing.Point(64, 38);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(167, 29);
            this.lblAvailableCars.TabIndex = 52;
            this.lblAvailableCars.Text = "Available Cars";
            // 
            // frmViewCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 618);
            this.Controls.Add(this.lblAvailableCars);
            this.Controls.Add(this.lblRemoveCarHeading);
            this.Controls.Add(this.grdAvailableCars);
            this.Controls.Add(this.grdRemovedars);
            this.Controls.Add(this.btnBack);
            this.Name = "frmViewCarList";
            this.Text = "View Car List";
            ((System.ComponentModel.ISupportInitialize)(this.grdRemovedars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdRemovedars;
        private System.Windows.Forms.DataGridView grdAvailableCars;
        private System.Windows.Forms.Label lblRemoveCarHeading;
        private System.Windows.Forms.Label lblAvailableCars;
    }
}