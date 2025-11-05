namespace CarServiceReportingSystem
{
    partial class BillForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtbBillPreview = new System.Windows.Forms.RichTextBox();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnExportBill = new System.Windows.Forms.Button();
            this.btnCloseBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(200, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR SERVICE BILL";
            // 
            // rtbBillPreview
            // 
            this.rtbBillPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbBillPreview.Location = new System.Drawing.Point(50, 80);
            this.rtbBillPreview.Name = "rtbBillPreview";
            this.rtbBillPreview.Size = new System.Drawing.Size(700, 230);
            this.rtbBillPreview.TabIndex = 1;
            this.rtbBillPreview.ReadOnly = true;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrintBill.Location = new System.Drawing.Point(50, 340);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(180, 40);
            this.btnPrintBill.TabIndex = 2;
            this.btnPrintBill.Text = "PRINT BILL";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnExportBill
            // 
            this.btnExportBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnExportBill.Location = new System.Drawing.Point(270, 340);
            this.btnExportBill.Name = "btnExportBill";
            this.btnExportBill.Size = new System.Drawing.Size(260, 40);
            this.btnExportBill.TabIndex = 3;
            this.btnExportBill.Text = "EXPLORE TO FILE";
            this.btnExportBill.UseVisualStyleBackColor = true;
            this.btnExportBill.Click += new System.EventHandler(this.btnExportBill_Click);
            // 
            // btnCloseBill
            // 
            this.btnCloseBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCloseBill.Location = new System.Drawing.Point(570, 340);
            this.btnCloseBill.Name = "btnCloseBill";
            this.btnCloseBill.Size = new System.Drawing.Size(180, 40);
            this.btnCloseBill.TabIndex = 4;
            this.btnCloseBill.Text = "CLOSE";
            this.btnCloseBill.UseVisualStyleBackColor = true;
            this.btnCloseBill.Click += new System.EventHandler(this.btnCloseBill_Click);
            // 
            // BillForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.btnCloseBill);
            this.Controls.Add(this.btnExportBill);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.rtbBillPreview);
            this.Controls.Add(this.label1);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbBillPreview;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnExportBill;
        private System.Windows.Forms.Button btnCloseBill;
    }
}