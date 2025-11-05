using System;
using System.Windows.Forms;

namespace CarServiceReportingSystem
{
    public partial class DeliveryForm : Form
    {
        private string selectedCarNumber;

        public DeliveryForm(string carNumber)
        {
            InitializeComponent();
            selectedCarNumber = carNumber;
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            cmbCarNumber.Items.Clear();
            cmbCarNumber.Items.Add(selectedCarNumber);
            cmbCarNumber.SelectedIndex = 0;

            dtpServiceDate.Value = DateTime.Today;
            dtpDeliveryDate.Value = DateTime.Today.AddDays(1);

            txtDiscount.ReadOnly = true;
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal baseCharge = 0;

                foreach (var item in clbFinalServices.CheckedItems)
                {
                    string serviceEntry = item.ToString(); // e.g., "Oil Change - ₹500"
                    string[] parts = serviceEntry.Split('₹');
                    if (parts.Length == 2 && decimal.TryParse(parts[1].Trim(), out decimal price))
                    {
                        baseCharge += price;
                    }
                }

                txtBaseCharge.Text = baseCharge.ToString("0.00");

                decimal partsCost = string.IsNullOrWhiteSpace(txtPartsCost.Text) ? 0 : Convert.ToDecimal(txtPartsCost.Text);
                decimal laborCost = string.IsNullOrWhiteSpace(txtLaborCost.Text) ? 0 : Convert.ToDecimal(txtLaborCost.Text);

                decimal subtotal = baseCharge + partsCost + laborCost;

                // Determine discount percentage
                decimal discountPercent = 0;
                if (subtotal >= 15000) discountPercent = 20;
                else if (subtotal >= 10000) discountPercent = 18;
                else if (subtotal >= 7000) discountPercent = 15;
                else if (subtotal >= 5000) discountPercent = 12;
                else if (subtotal >= 3000) discountPercent = 10;
                else if (subtotal >= 1000) discountPercent = 5;

                decimal discountAmount = subtotal * discountPercent / 100;
                txtDiscount.Text = $"{discountPercent}% = ₹{discountAmount:0.00}";

                decimal taxableAmount = subtotal - discountAmount;
                decimal tax = taxableAmount * 0.18m;
                decimal total = taxableAmount + tax;

                txtSubtotal.Text = subtotal.ToString("0.00");
                txtTax.Text = tax.ToString("0.00");
                txtTotalAmount.Text = total.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for charges.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            BillForm bill = new BillForm();
            bill.SetBillData(
                carNumber: cmbCarNumber.Text,
                serviceDate: dtpServiceDate.Text,
                deliveryDate: dtpDeliveryDate.Text,
                performedServices: clbFinalServices.CheckedItems,
                baseCharge: txtBaseCharge.Text,
                partsCost: txtPartsCost.Text,
                laborCost: txtLaborCost.Text,
                subtotal: txtSubtotal.Text,
                discount: txtDiscount.Text,
                tax: txtTax.Text,
                totalAmount: txtTotalAmount.Text
            );
            bill.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CarDetailsForm carForm = new CarDetailsForm();
            carForm.Show();
            this.Hide();
        }
    }
}