using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS_PBKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            double amount = 0;
            double exchangeRate = 0;

            // Parse the amount value from the TextBox
            if (!double.TryParse(input.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            // Get the exchange rate for the selected currency in both sides
            if (rate1.SelectedItem == null || rate2.SelectedItem == null)
            {
                MessageBox.Show("Please select a currency.");
                return;
            }

            // Find the exchangeRate amount
            if (rate1.SelectedItem.ToString() == "IDR")
            {
                if (rate2.SelectedItem.ToString() == "USD")
                {
                    exchangeRate = 0.000067;
                }
                else if (rate2.SelectedItem.ToString() == "EUR")
                {
                    exchangeRate = 0.000061;
                }
                else if (rate2.SelectedItem.ToString() == "JPY")
                {
                    exchangeRate = 0.0089;
                }
                else if (rate2.SelectedItem.ToString() == "CAD")
                {
                    exchangeRate = 0.00009;
                }
                else if (rate2.SelectedItem.ToString() == "CNY")
                {
                    exchangeRate = 0.00046;
                }
            }
            else if (rate1.SelectedItem.ToString() == "RM")
            {
                if (rate2.SelectedItem.ToString() == "USD")
                {
                    exchangeRate = 0.23;
                }
                else if (rate2.SelectedItem.ToString() == "EUR")
                {
                    exchangeRate = 0.21;
                }
                else if (rate2.SelectedItem.ToString() == "JPY")
                {
                    exchangeRate = 30.00;
                }
                else if (rate2.SelectedItem.ToString() == "CAD")
                {
                    exchangeRate = 0.31;
                }
                else if (rate2.SelectedItem.ToString() == "CNY")
                {
                    exchangeRate = 1.56;
                }
            }

            // Add more currencies and exchange rates as needed

            // Calculate the converted amount
            double convertedAmount = amount * exchangeRate;

            // Display the converted amount in a label
            output.Text = convertedAmount.ToString("0.00") + " " + rate2.SelectedItem.ToString();
        }

    }
}
