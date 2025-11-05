using System;
using System.Text;
using System.Windows.Forms;

namespace CarServiceReportingSystem
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        public void SetBillData(
            string carNumber,
            string serviceDate,
            string deliveryDate,
            CheckedListBox.CheckedItemCollection performedServices,
            string baseCharge,
            string partsCost,
            string laborCost,
            string subtotal,
            string discount,
            string tax,
            string totalAmount)
        {
            StringBuilder billText = new StringBuilder();

            billText.AppendLine("========== CAR SERVICE BILL ==========");
            billText.AppendLine($"Car Number       : {carNumber}");
            billText.AppendLine($"Service Date     : {serviceDate}");
            billText.AppendLine($"Delivery Date    : {deliveryDate}");
            billText.AppendLine();
            billText.AppendLine("Performed Services:");
            foreach (var item in performedServices)
            {
                billText.AppendLine($" - {item}");
            }
            billText.AppendLine();
            billText.AppendLine($"Base Charge      : ₹{baseCharge}");
            billText.AppendLine($"Parts Cost       : ₹{partsCost}");
            billText.AppendLine($"Labor Cost       : ₹{laborCost}");
            billText.AppendLine($"Subtotal         : ₹{subtotal}");
            billText.AppendLine($"Discount         : ₹{discount}");
            billText.AppendLine($"Tax (18%)        : ₹{tax}");
            billText.AppendLine($"Total Amount     : ₹{totalAmount}");
            billText.AppendLine("======================================");

            rtbBillPreview.Text = billText.ToString();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export functionality not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}