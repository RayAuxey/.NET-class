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

namespace Kopa_Pesa
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLoanStatus_Click(object sender, RoutedEventArgs e)
        {
            double loanAmount;
            int Duration;
            const double Rate = 0.12;
            loanAmount = double.Parse(txtLoanAmount.Text);
            Duration=int.Parse(txtDuration.Text);


            double Interest = loanAmount * Duration * 0.12;
            double LoanDue = Interest + loanAmount;
            double MonthlyPay= LoanDue/Duration; 
            MessageBox.Show("The interest is:"+Interest+"\n"+"The Loan Due is:"+LoanDue+"\n"+"Loan Payable per month:"+ MonthlyPay);
        }
    }
}