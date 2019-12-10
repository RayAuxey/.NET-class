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

namespace Benpaul
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnFullNames_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            { 
                MessageBox.Show("Please Enter the Firstname!");
                txtFirstName.Focus();
                return; //Exit the entire procedure
            
            }
            else if (string.IsNullOrEmpty(txtMiddleName.Text))
            {
                MessageBox.Show("Please Enter the MiddleName!");
                txtMiddleName.Focus();
                return; //Exit the entire procedure
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please Enter the LastName!");
                txtLastName.Focus();
               // return; //Exit the entire procedure
            }
            else
            {
                string Fname, Mname, Lname, Fullname;
                Fname = txtFirstName.Text;
                Mname = txtMiddleName.Text;
                Lname = txtLastName.Text;


                Fullname = Fname + "\t" + Mname + "\t" + Lname;
                MessageBox.Show("The Fullname is:\n" + Fullname);
            }
        }
    }
}