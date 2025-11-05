using System;
using System.Windows.Forms;

namespace CarServiceReportingSystem
{
    public partial class CarDetailsForm : Form
    {
        public CarDetailsForm()
        {
            InitializeComponent();
        }

        private void btnSaveAndNext_Click(object sender, EventArgs e)
        {
            string carNumber = txtCarNumber.Text.Trim();

            if (string.IsNullOrEmpty(carNumber))
            {
                MessageBox.Show("Please enter a car number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: Save car details to database or file here

            DeliveryForm deliveryForm = new DeliveryForm(carNumber); // ✅ Pass car number
            deliveryForm.Show();
            this.Hide();
        }
    }
}