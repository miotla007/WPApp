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
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
        App thisApp = Application.Current as App;
        public PanoramaPage1()
        {
            InitializeComponent();
            thisApp.storage.LoadScores();
            Level1.DataContext = thisApp.wynik;
            Level2.DataContext = thisApp.wynik2;
            
            
           // textBlock1.Text; += "%"; // = ((thisApp.k / 8 ) * 100).ToString() + "%";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.WynikP.CompareTo("100%") != 0) // 8 - ilość pytan w poziomie
            {
                MessageBox.Show("Aby rozpocząć level2 musisz ukonczyc level1");
            }
            else
            {
                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.RelativeOrAbsolute)); //zmienic na level2
            }
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }
        
    }
}