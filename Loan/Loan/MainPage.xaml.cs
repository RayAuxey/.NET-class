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

namespace Loan
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            txbMonthlyRepay.Text = "";
            txbtotal.Text = "";
            txbinterest.Text = "";
            //basic validations
            if (string.IsNullOrEmpty(txtLoanAmount.Text))
            {
                MessageBox.Show("Please enter loan amount");
                txtLoanAmount.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDuration.Text))
            {
                MessageBox.Show("Enter duration amount");
                txtDuration.Focus();
                return;
            }
            else if (int.Parse(txtDuration.Text) < 1
                || int.Parse(txtDuration.Text) > 12)
            {
                MessageBox.Show("Laon duration must be between 1 and 12");
                txtDuration.SelectAll();
                return;
            }
            else
            {
                //compute loan for customer
                const double RATE = 0.12;
                double interest, loanamount, monthlyrepay;
                int duration;
                duration = Convert.ToInt32(txtDuration.Text);
                loanamount = Convert.ToDouble(txtLoanAmount.Text);
                interest = loanamount * RATE * duration;
                double toalloan = loanamount + interest;
                monthlyrepay = toalloan / duration;
                //display output on textblocks
                txbinterest.Text = "Loan interest\t" + interest;
                txbtotal.Text = "Total loan\t:" + toalloan;
                txbMonthlyRepay.Text = "Your monthly amount is\t" + monthlyrepay;
            }
        }
 

       private void txtDuration_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}