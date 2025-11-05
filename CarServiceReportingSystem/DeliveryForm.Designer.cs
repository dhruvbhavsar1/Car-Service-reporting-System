namespace CarServiceReportingSystem
{
    partial class DeliveryForm
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
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.grpCarInfo = new System.Windows.Forms.GroupBox();
            this.cmbCarNumber = new System.Windows.Forms.ComboBox();
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.grpPricing = new System.Windows.Forms.GroupBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblDiscoutn = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.clbFinalServices = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtLaborCost = new System.Windows.Forms.TextBox();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.txtBaseCharge = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblLaborCost = new System.Windows.Forms.Label();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.lblBaseCharge = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveService = new System.Windows.Forms.Button();
            this.grpDates.SuspendLayout();
            this.grpCarInfo.SuspendLayout();
            this.grpPricing.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(221, 53);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDeliveryDate.TabIndex = 3;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDate.Location = new System.Drawing.Point(6, 18);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(170, 25);
            this.lblServiceDate.TabIndex = 4;
            this.lblServiceDate.Text = "SERVICE DATE";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(7, 53);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(180, 25);
            this.lblDeliveryDate.TabIndex = 5;
            this.lblDeliveryDate.Text = "DELIVERY DATE";
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(221, 18);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(200, 22);
            this.dtpServiceDate.TabIndex = 6;
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.lblDeliveryDate);
            this.grpDates.Controls.Add(this.dtpDeliveryDate);
            this.grpDates.Controls.Add(this.dtpServiceDate);
            this.grpDates.Controls.Add(this.lblServiceDate);
            this.grpDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDates.Location = new System.Drawing.Point(12, 78);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(450, 90);
            this.grpDates.TabIndex = 7;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "SERVICE SCHEDULING";
            // 
            // grpCarInfo
            // 
            this.grpCarInfo.Controls.Add(this.cmbCarNumber);
            this.grpCarInfo.Controls.Add(this.lblCarNumber);
            this.grpCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarInfo.Location = new System.Drawing.Point(12, 12);
            this.grpCarInfo.Name = "grpCarInfo";
            this.grpCarInfo.Size = new System.Drawing.Size(450, 60);
            this.grpCarInfo.TabIndex = 8;
            this.grpCarInfo.TabStop = false;
            this.grpCarInfo.Text = "CAR INFORMATION";
            // 
            // cmbCarNumber
            // 
            this.cmbCarNumber.FormattingEnabled = true;
            this.cmbCarNumber.Location = new System.Drawing.Point(182, 22);
            this.cmbCarNumber.Name = "cmbCarNumber";
            this.cmbCarNumber.Size = new System.Drawing.Size(121, 24);
            this.cmbCarNumber.TabIndex = 7;
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarNumber.Location = new System.Drawing.Point(6, 18);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(153, 25);
            this.lblCarNumber.TabIndex = 6;
            this.lblCarNumber.Text = "CAR NUMBER";
            // 
            // grpPricing
            // 
            this.grpPricing.Controls.Add(this.txtTax);
            this.grpPricing.Controls.Add(this.lblDiscoutn);
            this.grpPricing.Controls.Add(this.txtSubtotal);
            this.grpPricing.Controls.Add(this.lblSubtotal);
            this.grpPricing.Controls.Add(this.clbFinalServices);
            this.grpPricing.Controls.Add(this.label1);
            this.grpPricing.Controls.Add(this.txtDiscount);
            this.grpPricing.Controls.Add(this.txtLaborCost);
            this.grpPricing.Controls.Add(this.txtPartsCost);
            this.grpPricing.Controls.Add(this.txtBaseCharge);
            this.grpPricing.Controls.Add(this.txtTotalAmount);
            this.grpPricing.Controls.Add(this.btnCalculateTotal);
            this.grpPricing.Controls.Add(this.lblTotalAmount);
            this.grpPricing.Controls.Add(this.lblTax);
            this.grpPricing.Controls.Add(this.lblLaborCost);
            this.grpPricing.Controls.Add(this.lblPartsCost);
            this.grpPricing.Controls.Add(this.lblBaseCharge);
            this.grpPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPricing.Location = new System.Drawing.Point(12, 174);
            this.grpPricing.Name = "grpPricing";
            this.grpPricing.Size = new System.Drawing.Size(700, 265);
            this.grpPricing.TabIndex = 9;
            this.grpPricing.TabStop = false;
            this.grpPricing.Text = "PRICING AND CHARGES";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(209, 202);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 21;
            // 
            // lblDiscoutn
            // 
            this.lblDiscoutn.AutoSize = true;
            this.lblDiscoutn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscoutn.Location = new System.Drawing.Point(7, 160);
            this.lblDiscoutn.Name = "lblDiscoutn";
            this.lblDiscoutn.Size = new System.Drawing.Size(125, 25);
            this.lblDiscoutn.TabIndex = 20;
            this.lblDiscoutn.Text = "DISCOUNT";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(209, 123);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 19;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(7, 123);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(134, 25);
            this.lblSubtotal.TabIndex = 18;
            this.lblSubtotal.Text = "SUB TOTAL";
            // 
            // clbFinalServices
            // 
            this.clbFinalServices.FormattingEnabled = true;
            this.clbFinalServices.Items.AddRange(new object[] {
            "Oil Change - ₹500",
            "General Service - ₹700",
            "Brake Inspection - ₹300",
            "AC Repair - ₹1000",
            "Wheel Alignment - ₹400",
            "Battery Check - ₹250",
            "Engine Diagnostics - ₹800",
            "Coolant Flush - ₹600",
            "Transmission Service - ₹1200",
            "Suspension Check - ₹350",
            "Tire Rotation - ₹300",
            "Air Filter Replacement - ₹200",
            "Spark Plug Replacement - ₹450",
            "Interior Cleaning - ₹550",
            "Exterior Wash & Polish - ₹650"});
            this.clbFinalServices.Location = new System.Drawing.Point(348, 42);
            this.clbFinalServices.Name = "clbFinalServices";
            this.clbFinalServices.Size = new System.Drawing.Size(300, 140);
            this.clbFinalServices.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "SELECT PERFORMED SERVICES";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(209, 160);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 10;
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Location = new System.Drawing.Point(209, 88);
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.Size = new System.Drawing.Size(100, 22);
            this.txtLaborCost.TabIndex = 9;
            // 
            // txtPartsCost
            // 
            this.txtPartsCost.Location = new System.Drawing.Point(209, 52);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.Size = new System.Drawing.Size(100, 22);
            this.txtPartsCost.TabIndex = 8;
            // 
            // txtBaseCharge
            // 
            this.txtBaseCharge.Location = new System.Drawing.Point(209, 14);
            this.txtBaseCharge.Name = "txtBaseCharge";
            this.txtBaseCharge.Size = new System.Drawing.Size(100, 22);
            this.txtBaseCharge.TabIndex = 7;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(209, 237);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.AutoSize = true;
            this.btnCalculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.Location = new System.Drawing.Point(348, 214);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(192, 30);
            this.btnCalculateTotal.TabIndex = 5;
            this.btnCalculateTotal.Text = "CALCULATE TOTAL";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(7, 237);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(184, 25);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "TOTAL AMOUNT";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(7, 199);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(56, 25);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "TAX";
            // 
            // lblLaborCost
            // 
            this.lblLaborCost.AutoSize = true;
            this.lblLaborCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborCost.Location = new System.Drawing.Point(7, 88);
            this.lblLaborCost.Name = "lblLaborCost";
            this.lblLaborCost.Size = new System.Drawing.Size(152, 25);
            this.lblLaborCost.TabIndex = 2;
            this.lblLaborCost.Text = "LABOR COST";
            // 
            // lblPartsCost
            // 
            this.lblPartsCost.AutoSize = true;
            this.lblPartsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsCost.Location = new System.Drawing.Point(7, 52);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(152, 25);
            this.lblPartsCost.TabIndex = 1;
            this.lblPartsCost.Text = "PARTS COST";
            // 
            // lblBaseCharge
            // 
            this.lblBaseCharge.AutoSize = true;
            this.lblBaseCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseCharge.Location = new System.Drawing.Point(6, 18);
            this.lblBaseCharge.Name = "lblBaseCharge";
            this.lblBaseCharge.Size = new System.Drawing.Size(166, 25);
            this.lblBaseCharge.TabIndex = 0;
            this.lblBaseCharge.Text = "BASE CHARGE";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnBack);
            this.grpActions.Controls.Add(this.btnSaveService);
            this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.Location = new System.Drawing.Point(538, 12);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(250, 100);
            this.grpActions.TabIndex = 10;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "ACTIONS";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(6, 57);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(237, 30);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK TO CAR DETAILS";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveService
            // 
            this.btnSaveService.AutoSize = true;
            this.btnSaveService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveService.Location = new System.Drawing.Point(6, 21);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(237, 30);
            this.btnSaveService.TabIndex = 11;
            this.btnSaveService.Text = "GENERATE BILL";
            this.btnSaveService.UseVisualStyleBackColor = true;
            this.btnSaveService.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpPricing);
            this.Controls.Add(this.grpCarInfo);
            this.Controls.Add(this.grpDates);
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            this.grpCarInfo.ResumeLayout(false);
            this.grpCarInfo.PerformLayout();
            this.grpPricing.ResumeLayout(false);
            this.grpPricing.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.GroupBox grpDates;
        private System.Windows.Forms.GroupBox grpCarInfo;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.ComboBox cmbCarNumber;
        private System.Windows.Forms.GroupBox grpPricing;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.Label lblBaseCharge;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblLaborCost;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtLaborCost;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.TextBox txtBaseCharge;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbFinalServices;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblDiscoutn;
    }
}