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
            this.grdCollectCar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCollectCar)).BeginInit();
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
            this.btnCollectCar.Location = new System.Drawing.Point(364, 595);
            this.btnCollectCar.Name = "btnCollectCar";
            this.btnCollectCar.Size = new System.Drawing.Size(148, 22);
            this.btnCollectCar.TabIndex = 47;
            this.btnCollectCar.Text = "Confirm Collection";
            this.btnCollectCar.UseVisualStyleBackColor = true;
            this.btnCollectCar.Click += new System.EventHandler(this.btnCollectCar_Click);
            // 
            // grdCollectCar
            // 
            this.grdCollectCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCollectCar.Location = new System.Drawing.Point(12, 41);
            this.grdCollectCar.Name = "grdCollectCar";
            this.grdCollectCar.Size = new System.Drawing.Size(847, 308);
            this.grdCollectCar.TabIndex = 48;
            this.grdCollectCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCollectCar_CellContentClick);
            // 
            // frmCollectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(895, 640);
            this.Controls.Add(this.grdCollectCar);
            this.Controls.Add(this.btnCollectCar);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCollectCar";
            this.Text = "Collect Car";
            this.Load += new System.EventHandler(this.frmCollectCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCollectCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCollectCar;
        private System.Windows.Forms.DataGridView grdCollectCar;
    }
}