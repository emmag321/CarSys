using System;

namespace software
{
    partial class frmAddCar
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
            this.cboClasses = new System.Windows.Forms.ComboBox();
            this.cboFuelTypes = new System.Windows.Forms.ComboBox();
            this.lblNumDoors = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblRegPlate = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblCarClasses = new System.Windows.Forms.Label();
            this.txtRegPlate = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblAddCarToSystem = new System.Windows.Forms.Label();
            this.cboNumDoors = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboClasses
            // 
            this.cboClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasses.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(190, 103);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(147, 26);
            this.cboClasses.TabIndex = 18;
            this.cboClasses.SelectedIndexChanged += new System.EventHandler(this.cboClasses_SelectedIndexChanged);
            // 
            // cboFuelTypes
            // 
            this.cboFuelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuelTypes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuelTypes.FormattingEnabled = true;
            this.cboFuelTypes.Location = new System.Drawing.Point(190, 138);
            this.cboFuelTypes.Name = "cboFuelTypes";
            this.cboFuelTypes.Size = new System.Drawing.Size(147, 26);
            this.cboFuelTypes.TabIndex = 16;
            this.cboFuelTypes.SelectedIndexChanged += new System.EventHandler(this.cboFuelTypes_SelectedIndexChanged);
            // 
            // lblNumDoors
            // 
            this.lblNumDoors.AutoSize = true;
            this.lblNumDoors.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoors.Location = new System.Drawing.Point(73, 174);
            this.lblNumDoors.Name = "lblNumDoors";
            this.lblNumDoors.Size = new System.Drawing.Size(116, 18);
            this.lblNumDoors.TabIndex = 20;
            this.lblNumDoors.Text = "Number of doors";
            this.lblNumDoors.Click += new System.EventHandler(this.lblNumDoors_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(228, 307);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 22;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lblRegPlate
            // 
            this.lblRegPlate.AutoSize = true;
            this.lblRegPlate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPlate.Location = new System.Drawing.Point(59, 67);
            this.lblRegPlate.Name = "lblRegPlate";
            this.lblRegPlate.Size = new System.Drawing.Size(125, 18);
            this.lblRegPlate.TabIndex = 23;
            this.lblRegPlate.Text = "Registration Plate";
            this.lblRegPlate.Click += new System.EventHandler(this.lblRegPlate_Click);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(96, 141);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(73, 18);
            this.lblFuel.TabIndex = 25;
            this.lblFuel.Text = "Fuel Type";
            this.lblFuel.Click += new System.EventHandler(this.lblFuel_Click);
            // 
            // lblCarClasses
            // 
            this.lblCarClasses.AutoSize = true;
            this.lblCarClasses.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarClasses.Location = new System.Drawing.Point(101, 106);
            this.lblCarClasses.Name = "lblCarClasses";
            this.lblCarClasses.Size = new System.Drawing.Size(68, 18);
            this.lblCarClasses.TabIndex = 26;
            this.lblCarClasses.Text = "Car Class";
            this.lblCarClasses.Click += new System.EventHandler(this.lblCarClasses_Click);
            // 
            // txtRegPlate
            // 
            this.txtRegPlate.Location = new System.Drawing.Point(190, 65);
            this.txtRegPlate.Name = "txtRegPlate";
            this.txtRegPlate.Size = new System.Drawing.Size(147, 20);
            this.txtRegPlate.TabIndex = 27;
            this.txtRegPlate.TextChanged += new System.EventHandler(this.txtRegPlate_TextChanged);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(126, 214);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(43, 18);
            this.lblMake.TabIndex = 29;
            this.lblMake.Text = "Make";
            this.lblMake.Click += new System.EventHandler(this.lblMake_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(121, 247);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 18);
            this.lblModel.TabIndex = 32;
            this.lblModel.Text = "Model";
            // 
            // lblAddCarToSystem
            // 
            this.lblAddCarToSystem.AutoSize = true;
            this.lblAddCarToSystem.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCarToSystem.Location = new System.Drawing.Point(167, 22);
            this.lblAddCarToSystem.Name = "lblAddCarToSystem";
            this.lblAddCarToSystem.Size = new System.Drawing.Size(170, 24);
            this.lblAddCarToSystem.TabIndex = 33;
            this.lblAddCarToSystem.Text = "Add Car To System";
            this.lblAddCarToSystem.Click += new System.EventHandler(this.lblAddCarToSystem_Click);
            // 
            // cboNumDoors
            // 
            this.cboNumDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumDoors.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumDoors.FormattingEnabled = true;
            this.cboNumDoors.Location = new System.Drawing.Point(190, 174);
            this.cboNumDoors.Name = "cboNumDoors";
            this.cboNumDoors.Size = new System.Drawing.Size(147, 26);
            this.cboNumDoors.TabIndex = 34;
            this.cboNumDoors.SelectedIndexChanged += new System.EventHandler(this.cboNumDoors_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(190, 214);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(147, 26);
            this.cboMake.TabIndex = 38;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(190, 248);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(147, 20);
            this.txtModel.TabIndex = 39;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // frmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 380);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cboMake);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboNumDoors);
            this.Controls.Add(this.lblAddCarToSystem);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtRegPlate);
            this.Controls.Add(this.lblCarClasses);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblRegPlate);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lblNumDoors);
            this.Controls.Add(this.cboClasses);
            this.Controls.Add(this.cboFuelTypes);
            this.Name = "frmAddCar";
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblAddCarToSystem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ComboBox cboClasses;
        private System.Windows.Forms.ComboBox cboFuelTypes;
        private System.Windows.Forms.Label lblNumDoors;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label lblRegPlate;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblCarClasses;
        private System.Windows.Forms.TextBox txtRegPlate;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblAddCarToSystem;
        private System.Windows.Forms.ComboBox cboNumDoors;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.TextBox txtModel;
    }
}