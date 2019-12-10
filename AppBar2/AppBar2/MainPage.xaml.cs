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
using Microsoft.Phone.Shell;

namespace AppBar2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //Instantiate the application bar
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton newpage = new ApplicationBarIconButton();
            //set the iconuri
            newpage.IconUri=new Uri("/images/new.png", UriKind.Relative);
            //set button text
            newpage.Text = "New Page";
            //add button to application bar
            ApplicationBar.Buttons.Add(newpage);

            //add save button
            ApplicationBarIconButton save = new ApplicationBarIconButton();
            //set the iconuri
            save.IconUri=new Uri("/images/save.png", UriKind.Relative);
            //set button text
            save.Text = "save";
            //add button to application bar
            ApplicationBar.Buttons.Add(save);
            save.Click += new EventHandler(save_Click);

            //add delete button
           
            ApplicationBarIconButton delete = new ApplicationBarIconButton();
            delete.IconUri = new Uri("/images/delete.png", UriKind.Relative);
            //set button text
            delete.Text = "delete";
            //add button to application bar
            ApplicationBar.Buttons.Add(delete);

            //add cancel button
            ApplicationBarIconButton cancel = new ApplicationBarIconButton();
            //set the iconuri
            cancel.IconUri = new Uri("/images/cancel.png", UriKind.Relative);
            //set button text
            cancel.Text = "cancel";
            //add button to application bar
            ApplicationBar.Buttons.Add(cancel);

            //add 3 menu items on application bar
            ApplicationBarMenuItem share = new ApplicationBarMenuItem();
            share.Text = "Share";
            ApplicationBar.MenuItems.Add(share);
            share.Click += new EventHandler(share_Click);
            //menu item for our website
            ApplicationBarMenuItem Website = new ApplicationBarMenuItem();
            Website.Text = "Visit: www.horizonedge.tech";
            ApplicationBar.MenuItems.Add(Website);
            //menu item for contact
            ApplicationBarMenuItem Contact = new ApplicationBarMenuItem();
            Contact.Text = "Tell: 0712365478";
            ApplicationBar.MenuItems.Add(Contact);

        }

        void share_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Share");
        }

        void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record saved");
        }
    }
}