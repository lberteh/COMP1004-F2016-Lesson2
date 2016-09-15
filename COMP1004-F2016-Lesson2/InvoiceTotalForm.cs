using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson2
{
    public partial class InvoiceTotalForm : Form
    {
        public InvoiceTotalForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTotal();

        }

        private void CalculateTotal()
        {
            // Local variables
            const double DiscountPercent = 0.1;
            double SubTotal;
            double DiscountAmount;
            double Total;

            try
            {
                // read values from the text boxes
                SubTotal = Convert.ToDouble(SubTotalTextBox.Text); // convert string values to doubles
                DiscountAmount = SubTotal * DiscountPercent;
                Total = SubTotal - DiscountAmount;

                DiscountAmountTextBox.Text = DiscountAmount.ToString("C2");
                TotalTextBox.Text = Total.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                ResetSubTotalTextBob();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InvoiceTotalForm_Load(object sender, EventArgs e)
        {
            ResetSubTotalTextBob();

        }

        private void ResetSubTotalTextBob()
        {
            SubTotalTextBox.Focus();
            SubTotalTextBox.Text = "0";
            SubTotalTextBox.SelectAll();
        }
    }
}
