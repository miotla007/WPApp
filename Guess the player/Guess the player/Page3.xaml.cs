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
    public partial class Page3 : PhoneApplicationPage
    {
        App thisApp = Application.Current as App;
        public Page3()
        {
            InitializeComponent();
            thisApp.storage.LoadAnsvers();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(11))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 11;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(12))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 12;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(13))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 13;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(14))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 14;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(15))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 15;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(16))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 16;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(17))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 17;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(18))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 18;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(19))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 19;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (thisApp.wynik.ansvered(20))
            {
                MessageBox.Show("juz rozwiazanie");
            }
            else
            {
                thisApp.baza.Num = 20;
                NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}