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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCreateCarClass = new System.Windows.Forms.Label();
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(207, 134);
            this.txtDescription.MaxLength = 15;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(96, 19);
            this.txtDescription.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(164, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(128, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(132, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Class Code";
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
            this.lblCreateCarClass.Click += new System.EventHandler(this.lblCreateCarClass_Click);
            // 
            // frmSetClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 337);
            this.Controls.Add(this.lblCreateCarClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtClassCode);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSet);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "frmSetClass";
            this.Text = "Create Car Class";
            this.Load += new System.EventHandler(this.CarClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassCode;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCreateCarClass;
    }
}