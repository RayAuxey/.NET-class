﻿#pragma checksum "C:\Users\STUDENT.Admin-PC.001\Desktop\WPA\Photo Selector1\Photo Selector1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "333469FA0180B02A958CB1AB339008CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Photo_Selector1 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.RadioButton rdoCamera;
        
        internal System.Windows.Controls.RadioButton rdoGallery;
        
        internal System.Windows.Controls.Image imgPhoto;
        
        internal System.Windows.Controls.Button btnCamera;
        
        internal System.Windows.Controls.Button btnGallery;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Photo%20Selector1;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.rdoCamera = ((System.Windows.Controls.RadioButton)(this.FindName("rdoCamera")));
            this.rdoGallery = ((System.Windows.Controls.RadioButton)(this.FindName("rdoGallery")));
            this.imgPhoto = ((System.Windows.Controls.Image)(this.FindName("imgPhoto")));
            this.btnCamera = ((System.Windows.Controls.Button)(this.FindName("btnCamera")));
            this.btnGallery = ((System.Windows.Controls.Button)(this.FindName("btnGallery")));
        }
    }
}

