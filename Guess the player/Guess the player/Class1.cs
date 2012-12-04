using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;



namespace Guess_the_player
{
    public class Score : INotifyPropertyChanged
    {
        App thisApp = Application.Current as App;

        private int[] questions = { 0,0,0,0,0,0,0,0,0,0,0 }; 
        private double score;
        public event PropertyChangedEventHandler PropertyChanged;

        public Score()
        {
            score = 0;
        }

        public void good_ansver(int n)
        {
            questions[n] = 1;
        }
        public void bad_ansver(int n)
        {
            questions[n] = 0;
        }
        public Boolean ansvered(int n)
        {
            if (questions[n] == 1) return true;
            else return false;
        }

        public String WynikP
        {
            get { return (this.score * 100 / 10).ToString() + "%"; } // 10 - ilość pytan w poziomie
        }

        public double Wynik
        {
            set { this.score = value; } // PropertyChanged(this, new PropertyChangedEventArgs("WynikP")); }
            get { return this.score; }
        }

        


    }
}
