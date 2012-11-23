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
using System.Windows.Media.Imaging;

namespace Guess_the_player
{
    public partial class Page2 : PhoneApplicationPage
    {
        App thisApp = Application.Current as App;
        int n;
        public Page2()
        {
            InitializeComponent();
            n = thisApp.baza.Num;
            image1.Source = new BitmapImage(new Uri(thisApp.baza.getPilkarzFoto(n), UriKind.Relative));
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.ToLower().CompareTo(thisApp.baza.getPilkarzName(n).ToLower()) == 0)
            {
                MessageBox.Show("Good answer!");
                thisApp.wynik.Wynik++;
                thisApp.wynik.good_ansver(n);
                thisApp.storage.SaveScores();
                thisApp.storage.SaveAnsvers();
                //MessageBox.Show(thisApp.baza.getPilkarzName(n));
                button1.IsEnabled = false;
                
                
            }
            else
            {
                MessageBox.Show("Wrong answer");
            }
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.RelativeOrAbsolute));
        }
 
    }
}