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
            this.btnCon = new System.Windows.Forms.Button();
            this.grdViewCarList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblReg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCarList)).BeginInit();
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
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.btnCon.Location = new System.Drawing.Point(380, 55);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(163, 23);
            this.btnCon.TabIndex = 47;
            this.btnCon.Text = "VIEW CAR LIST";
            this.btnCon.UseVisualStyleBackColor = true;
            // 
            // grdViewCarList
            // 
            this.grdViewCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewCarList.Location = new System.Drawing.Point(12, 102);
            this.grdViewCarList.Name = "grdViewCarList";
            this.grdViewCarList.Size = new System.Drawing.Size(531, 275);
            this.grdViewCarList.TabIndex = 48;
            this.grdViewCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewCarList_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(224, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 20);
            this.txtSearch.TabIndex = 50;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblReg.Location = new System.Drawing.Point(12, 60);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(206, 18);
            this.lblReg.TabIndex = 49;
            this.lblReg.Text = "Please enter Cars Registration:";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // frmViewCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 417);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.grdViewCarList);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.btnBack);
            this.Name = "frmViewCarList";
            this.Text = "ViewCarList";
            this.Load += new System.EventHandler(this.frmViewCarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.DataGridView grdViewCarList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblReg;
    }
}