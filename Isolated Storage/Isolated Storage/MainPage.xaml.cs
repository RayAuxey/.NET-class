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

namespace Isolated_Storage
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            using (employeeContext context = new
                employeeContext(employeeContext.dbconstring))
            {
                if (!context.DatabaseExists())
                {
                    context.CreateDatabase();
                }
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string ename, title, position, gender=" ";
            double salary;
            ename = txtEmpName.Text;
            title = txtTitle.Text;
            position = txtPosition.Text;
            salary = double.Parse(txtSalary.Text);
            if (rdoFemale.IsChecked ==true)
            {
                gender = "Female";
            }
            else if (rdoMale.IsChecked == true)
            {
                gender = "Male";
            }
            //create object of type employee
            employee em = new employee();
            em.addEmployee(ename, title, 
                position, gender, salary);
            MessageBox.Show("Records saved");

        }
    }
}