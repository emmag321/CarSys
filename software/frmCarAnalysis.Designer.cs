namespace software
{
    partial class frmCarAnalysis
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
            this.grdCarsByMake = new System.Windows.Forms.DataGridView();
            this.lblCarAnal = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCarPop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarsByMake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarPop)).BeginInit();
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
            // grdCarsByMake
            // 
            this.grdCarsByMake.AllowUserToAddRows = false;
            this.grdCarsByMake.AllowUserToDeleteRows = false;
            this.grdCarsByMake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarsByMake.Location = new System.Drawing.Point(27, 151);
            this.grdCarsByMake.Name = "grdCarsByMake";
            this.grdCarsByMake.ReadOnly = true;
            this.grdCarsByMake.Size = new System.Drawing.Size(406, 211);
            this.grdCarsByMake.TabIndex = 40;
            // 
            // lblCarAnal
            // 
            this.lblCarAnal.AutoSize = true;
            this.lblCarAnal.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.lblCarAnal.Location = new System.Drawing.Point(20, 85);
            this.lblCarAnal.Name = "lblCarAnal";
            this.lblCarAnal.Size = new System.Drawing.Size(287, 29);
            this.lblCarAnal.TabIndex = 41;
            this.lblCarAnal.Text = "Number of Car By Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.label1.Location = new System.Drawing.Point(31, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cars By Popularity";
            // 
            // grdCarPop
            // 
            this.grdCarPop.AllowUserToAddRows = false;
            this.grdCarPop.AllowUserToDeleteRows = false;
            this.grdCarPop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarPop.Location = new System.Drawing.Point(36, 433);
            this.grdCarPop.Name = "grdCarPop";
            this.grdCarPop.ReadOnly = true;
            this.grdCarPop.Size = new System.Drawing.Size(475, 252);
            this.grdCarPop.TabIndex = 42;
            // 
            // frmCarAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCarPop);
            this.Controls.Add(this.lblCarAnal);
            this.Controls.Add(this.grdCarsByMake);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.25F);
            this.Name = "frmCarAnalysis";
            this.Text = "Car Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.grdCarsByMake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarPop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdCarsByMake;
        private System.Windows.Forms.Label lblCarAnal;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCarPop;
    }
}