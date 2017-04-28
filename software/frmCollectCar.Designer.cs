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
            this.grdCollectCar = new System.Windows.Forms.DataGridView();
            this.btnColCollect = new System.Windows.Forms.DataGridViewButtonColumn();
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
            // grdCollectCar
            // 
            this.grdCollectCar.AllowUserToAddRows = false;
            this.grdCollectCar.AllowUserToDeleteRows = false;
            this.grdCollectCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCollectCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnColCollect});
            this.grdCollectCar.Location = new System.Drawing.Point(12, 41);
            this.grdCollectCar.Name = "grdCollectCar";
            this.grdCollectCar.ReadOnly = true;
            this.grdCollectCar.Size = new System.Drawing.Size(847, 308);
            this.grdCollectCar.TabIndex = 48;
            this.grdCollectCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCollectCar_CellContentClick);
            // 
            // btnColCollect
            // 
            this.btnColCollect.HeaderText = "Select Car";
            this.btnColCollect.Name = "btnColCollect";
            this.btnColCollect.ReadOnly = true;
            this.btnColCollect.Text = "Collect";
            this.btnColCollect.UseColumnTextForButtonValue = true;
            // 
            // frmCollectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(895, 401);
            this.Controls.Add(this.grdCollectCar);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCollectCar";
            this.Text = "Collect Car";
            ((System.ComponentModel.ISupportInitialize)(this.grdCollectCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdCollectCar;
        private System.Windows.Forms.DataGridViewButtonColumn btnColCollect;
    }
}