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
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace Photo_Selector1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //hides the two buttons
            btnCamera.Visibility = Visibility.Collapsed;
            btnGallery.Visibility = Visibility.Collapsed;
        }

        CameraCaptureTask cct = new CameraCaptureTask();
        PhotoChooserTask pct = new PhotoChooserTask();

        private void rdoCamera_Checked(object sender, RoutedEventArgs e)
        {
            //enable the camera button
            btnCamera.Visibility = Visibility.Visible;
            btnGallery.Visibility = Visibility.Collapsed;
        }

        private void rdoGallery_Checked(object sender, RoutedEventArgs e)
        {
            //enable the camera button
            btnCamera.Visibility = Visibility.Collapsed;
            btnGallery.Visibility = Visibility.Visible;
        }

        private void btnCamera_Click(object sender, RoutedEventArgs e)
        {
            //launch the camera
            cct.Show();
            cct.Completed += new EventHandler<PhotoResult>(cct_Completed);
        }

        void cct_Completed(object sender, PhotoResult e)
        {
            BitmapImage img = new BitmapImage();
            //set the image sourse
            img.SetSource(e.ChosenPhoto);
            //display photo on image
            imgPhoto.Source = img;
        }

        private void btnGallery_Click(object sender, RoutedEventArgs e)
        {
            //launch photo chooser dialog
            pct.Show();
            pct.Completed += new EventHandler<PhotoResult>(pct_Completed);
        }

        void pct_Completed(object sender, PhotoResult e)
        {
            BitmapImage img = new BitmapImage();
            //set the image sourse
            img.SetSource(e.ChosenPhoto);
            //display photo on image
            imgPhoto.Source = img;
        }
               
    }
}