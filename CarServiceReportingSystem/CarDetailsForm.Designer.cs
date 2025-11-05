namespace CarServiceReportingSystem
{
    partial class CarDetailsForm
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
            this.w = new System.Windows.Forms.Label();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCarDetailsTitle = new System.Windows.Forms.Label();
            this.clbServiceType = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w.Location = new System.Drawing.Point(104, 60);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(153, 25);
            this.w.TabIndex = 0;
            this.w.Text = "CAR NUMBER";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(399, 60);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(100, 22);
            this.txtCarNumber.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(104, 94);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(136, 25);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "CAR BRAND";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(399, 94);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(104, 134);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(139, 25);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "CAR MODEL";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(399, 134);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 5;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(104, 174);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(128, 25);
            this.lblFuelType.TabIndex = 6;
            this.lblFuelType.Text = "FUEL TYPE";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Items.AddRange(new object[] {
            "PETROL",
            "DIESEL",
            "CNG"});
            this.cmbFuelType.Location = new System.Drawing.Point(399, 174);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(121, 24);
            this.cmbFuelType.TabIndex = 7;
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometers.Location = new System.Drawing.Point(104, 217);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(236, 25);
            this.lblKilometers.TabIndex = 8;
            this.lblKilometers.Text = "KILOMETERS DRIVEN";
            // 
            // txtKilometers
            // 
            this.txtKilometers.Location = new System.Drawing.Point(399, 217);
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(100, 22);
            this.txtKilometers.TabIndex = 9;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(104, 255);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(168, 25);
            this.lblServiceType.TabIndex = 10;
            this.lblServiceType.Text = "SERVICE TYPE";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(221, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE AND CONTINUE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveAndNext_Click);
            // 
            // lblCarDetailsTitle
            // 
            this.lblCarDetailsTitle.AutoSize = true;
            this.lblCarDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDetailsTitle.Location = new System.Drawing.Point(228, 9);
            this.lblCarDetailsTitle.Name = "lblCarDetailsTitle";
            this.lblCarDetailsTitle.Size = new System.Drawing.Size(243, 38);
            this.lblCarDetailsTitle.TabIndex = 15;
            this.lblCarDetailsTitle.Text = "CAR DETAILS";
            // 
            // clbServiceType
            // 
            this.clbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbServiceType.FormattingEnabled = true;
            this.clbServiceType.Items.AddRange(new object[] {
            "Oil Change",
            "General Service",
            "Brake Inspection",
            "AC Repair",
            "Wheel Alignment",
            "Battery Check",
            "Engine Diagnostics",
            "Coolant Flush",
            "Transmission Service",
            "Suspension Check",
            "Tire Rotation",
            "Air Filter Replacement",
            "Spark Plug Replacement",
            "Interior Cleaning",
            "Exterior Wash & Polish"});
            this.clbServiceType.Location = new System.Drawing.Point(399, 255);
            this.clbServiceType.Name = "clbServiceType";
            this.clbServiceType.Size = new System.Drawing.Size(300, 140);
            this.clbServiceType.TabIndex = 16;
            // 
            // CarDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clbServiceType);
            this.Controls.Add(this.lblCarDetailsTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.txtKilometers);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtCarNumber);
            this.Controls.Add(this.w);
            this.Name = "CarDetailsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label w;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCarDetailsTitle;
        private System.Windows.Forms.CheckedListBox clbServiceType;
    }
}

