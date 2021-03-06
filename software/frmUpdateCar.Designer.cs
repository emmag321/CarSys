﻿namespace software
{
    partial class frmUpdateCar
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
            this.lblReg = new System.Windows.Forms.Label();
            this.bntOK = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpCar = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboNumDoors = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtRegPlate = new System.Windows.Forms.TextBox();
            this.lblCarClasses = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblRegPlate = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblNumDoors = new System.Windows.Forms.Label();
            this.cboClasses = new System.Windows.Forms.ComboBox();
            this.cboFuelTypes = new System.Windows.Forms.ComboBox();
            this.grpCar.SuspendLayout();
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
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblReg.Location = new System.Drawing.Point(46, 84);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(206, 18);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "Please enter Cars Registration:";
            // 
            // bntOK
            // 
            this.bntOK.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.bntOK.Location = new System.Drawing.Point(391, 83);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(106, 23);
            this.bntOK.TabIndex = 40;
            this.bntOK.Text = "OK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(248, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpCar
            // 
            this.grpCar.Controls.Add(this.cboStatus);
            this.grpCar.Controls.Add(this.lblStatus);
            this.grpCar.Controls.Add(this.txtModel);
            this.grpCar.Controls.Add(this.cboMake);
            this.grpCar.Controls.Add(this.cboNumDoors);
            this.grpCar.Controls.Add(this.lblModel);
            this.grpCar.Controls.Add(this.lblMake);
            this.grpCar.Controls.Add(this.txtRegPlate);
            this.grpCar.Controls.Add(this.lblCarClasses);
            this.grpCar.Controls.Add(this.lblFuel);
            this.grpCar.Controls.Add(this.lblRegPlate);
            this.grpCar.Controls.Add(this.btnAddCar);
            this.grpCar.Controls.Add(this.lblNumDoors);
            this.grpCar.Controls.Add(this.cboClasses);
            this.grpCar.Controls.Add(this.cboFuelTypes);
            this.grpCar.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.grpCar.Location = new System.Drawing.Point(49, 146);
            this.grpCar.Name = "grpCar";
            this.grpCar.Size = new System.Drawing.Size(448, 346);
            this.grpCar.TabIndex = 39;
            this.grpCar.TabStop = false;
            this.grpCar.Text = "Update Car Details";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(170, 264);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(147, 26);
            this.cboStatus.TabIndex = 52;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(117, 267);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 18);
            this.lblStatus.TabIndex = 51;
            this.lblStatus.Text = "Status";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(170, 225);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(147, 22);
            this.txtModel.TabIndex = 50;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(170, 180);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(147, 26);
            this.cboMake.TabIndex = 49;
            // 
            // cboNumDoors
            // 
            this.cboNumDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumDoors.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumDoors.FormattingEnabled = true;
            this.cboNumDoors.Location = new System.Drawing.Point(170, 143);
            this.cboNumDoors.Name = "cboNumDoors";
            this.cboNumDoors.Size = new System.Drawing.Size(147, 26);
            this.cboNumDoors.TabIndex = 47;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(116, 225);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 18);
            this.lblModel.TabIndex = 46;
            this.lblModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(121, 180);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(43, 18);
            this.lblMake.TabIndex = 45;
            this.lblMake.Text = "Make";
            // 
            // txtRegPlate
            // 
            this.txtRegPlate.Location = new System.Drawing.Point(170, 34);
            this.txtRegPlate.Name = "txtRegPlate";
            this.txtRegPlate.Size = new System.Drawing.Size(147, 22);
            this.txtRegPlate.TabIndex = 44;
            this.txtRegPlate.TextChanged += new System.EventHandler(this.txtRegPlate_TextChanged);
            // 
            // lblCarClasses
            // 
            this.lblCarClasses.AutoSize = true;
            this.lblCarClasses.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarClasses.Location = new System.Drawing.Point(81, 75);
            this.lblCarClasses.Name = "lblCarClasses";
            this.lblCarClasses.Size = new System.Drawing.Size(68, 18);
            this.lblCarClasses.TabIndex = 43;
            this.lblCarClasses.Text = "Car Class";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(76, 110);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(73, 18);
            this.lblFuel.TabIndex = 42;
            this.lblFuel.Text = "Fuel Type";
            // 
            // lblRegPlate
            // 
            this.lblRegPlate.AutoSize = true;
            this.lblRegPlate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPlate.Location = new System.Drawing.Point(39, 36);
            this.lblRegPlate.Name = "lblRegPlate";
            this.lblRegPlate.Size = new System.Drawing.Size(125, 18);
            this.lblRegPlate.TabIndex = 41;
            this.lblRegPlate.Text = "Registration Plate";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(208, 305);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(109, 23);
            this.btnAddCar.TabIndex = 40;
            this.btnAddCar.Text = "Update";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lblNumDoors
            // 
            this.lblNumDoors.AutoSize = true;
            this.lblNumDoors.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoors.Location = new System.Drawing.Point(53, 143);
            this.lblNumDoors.Name = "lblNumDoors";
            this.lblNumDoors.Size = new System.Drawing.Size(116, 18);
            this.lblNumDoors.TabIndex = 39;
            this.lblNumDoors.Text = "Number of doors";
            // 
            // cboClasses
            // 
            this.cboClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasses.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(170, 72);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(147, 26);
            this.cboClasses.TabIndex = 38;
            // 
            // cboFuelTypes
            // 
            this.cboFuelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuelTypes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuelTypes.FormattingEnabled = true;
            this.cboFuelTypes.Location = new System.Drawing.Point(170, 107);
            this.cboFuelTypes.Name = "cboFuelTypes";
            this.cboFuelTypes.Size = new System.Drawing.Size(147, 26);
            this.cboFuelTypes.TabIndex = 37;
            // 
            // frmUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 559);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.grpCar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblReg);
            this.Name = "frmUpdateCar";
            this.Text = "Update Car";
            this.grpCar.ResumeLayout(false);
            this.grpCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpCar;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboNumDoors;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtRegPlate;
        private System.Windows.Forms.Label lblCarClasses;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblRegPlate;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label lblNumDoors;
        private System.Windows.Forms.ComboBox cboClasses;
        private System.Windows.Forms.ComboBox cboFuelTypes;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}