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
    public partial class Page1 : PhoneApplicationPage
    {
        App thisApp = Application.Current as App;
        public Page1()
        {
            InitializeComponent();
            thisApp.storage.LoadAnsvers();
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(1))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 1;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(2))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 2;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(3))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 3;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(4))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 4;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(5))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 5;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(6))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 6;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(7))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 7;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(8))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 8;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(9))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 9;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(10))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 10;
                NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}