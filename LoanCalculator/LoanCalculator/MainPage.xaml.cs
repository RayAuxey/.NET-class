using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace LoanCalculator
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void txtLoanAmt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoanAmt.Text))
            {
                MessageBox.Show("Please enter Amount!");
                txtLoanAmt.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtLoanDtn.Text))
            {
                 MessageBox.Show("Enter Duration!");
                  txtLoanAmt.Focus();
                 return;
            }
            else if (int.Parse(txtLoanDtn.Text) > 12 || int.Parse(txtLoanDtn.Text) < 1)
            {
                MessageBox.Show("Duration invalid");
                txtLoanDtn.Focus();
                return;
            }

            else
            {
                double loanAmount;
                int duration;
                double rate = 0.12;
                loanAmount = double.Parse(txtLoanAmt.Text);
                duration = int.Parse(txtLoanDtn.Text);

                double Interest = loanAmount * duration * rate;
                double loanDue = Interest + loanAmount;
                double monthlyPay = loanDue / duration;

                txbLoanInterest.Text = "The Interest is:"+Interest;
                txbMonthlyRepay.Text = "Monthly Pay is:"+monthlyPay;
                txbTotalLoan.Text = "Total Loan Due" + loanDue;
            }


        }

        private void txtLoanDtn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}