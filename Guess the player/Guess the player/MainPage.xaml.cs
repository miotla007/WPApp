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

namespace Guess_the_player
{
    public partial class MainPage : PhoneApplicationPage
    {
        App thisApp = Application.Current as App;
        //public int k = 0;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                while (NavigationService.RemoveBackEntry() != null)
                {
                    NavigationService.RemoveBackEntry();
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            thisApp.storage.ClearScores();
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}