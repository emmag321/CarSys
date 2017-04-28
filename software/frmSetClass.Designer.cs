namespace software
{
    partial class frmSetClass
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
            this.txtClassCode = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblClassCode = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCreateCarClass = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClassCode
            // 
            this.txtClassCode.Location = new System.Drawing.Point(207, 107);
            this.txtClassCode.MaxLength = 1;
            this.txtClassCode.Name = "txtClassCode";
            this.txtClassCode.Size = new System.Drawing.Size(26, 19);
            this.txtClassCode.TabIndex = 10;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(207, 166);
            this.txtRate.MaxLength = 7;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(58, 19);
            this.txtRate.TabIndex = 12;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRate.Location = new System.Drawing.Point(164, 167);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(34, 16);
            this.lblRate.TabIndex = 17;
            this.lblRate.Text = "Rate";
            // 
            // lblClassCode
            // 
            this.lblClassCode.AutoSize = true;
            this.lblClassCode.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblClassCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClassCode.Location = new System.Drawing.Point(132, 109);
            this.lblClassCode.Name = "lblClassCode";
            this.lblClassCode.Size = new System.Drawing.Size(66, 16);
            this.lblClassCode.TabIndex = 15;
            this.lblClassCode.Text = "Class Code";
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.btnSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSet.Location = new System.Drawing.Point(146, 215);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(157, 32);
            this.btnSet.TabIndex = 13;
            this.btnSet.Text = "Create Car Class";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 25);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCreateCarClass
            // 
            this.lblCreateCarClass.AutoSize = true;
            this.lblCreateCarClass.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateCarClass.Location = new System.Drawing.Point(123, 52);
            this.lblCreateCarClass.Name = "lblCreateCarClass";
            this.lblCreateCarClass.Size = new System.Drawing.Size(204, 24);
            this.lblCreateCarClass.TabIndex = 19;
            this.lblCreateCarClass.Text = "Please Create Car Class";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(207, 134);
            this.txtDescription.MaxLength = 15;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(96, 19);
            this.txtDescription.TabIndex = 20;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(124, 136);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(73, 16);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Description";
            // 
            // frmSetClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 337);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCreateCarClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtClassCode);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblClassCode);
            this.Controls.Add(this.btnSet);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "frmSetClass";
            this.Text = "Create Car Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassCode;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblClassCode;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCreateCarClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}