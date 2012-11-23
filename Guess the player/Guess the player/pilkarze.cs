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

namespace Guess_the_player
{
    public class pilkarze
    {
        private String[] pilkarz = new String[9];
        private String[] pilkarze_foto = new String[9];
        private int n;
        //App thisApp = Application.Current as App;
        public pilkarze()
        {
            pilkarz[1] = "Iker Casillas";
            pilkarze_foto[1] = "/Guess%20the%20player;component/Images/01_casillas.jpg";

            pilkarz[2] = "Alvaro Arbeloa";
            pilkarze_foto[2] = "/Guess%20the%20player;component/Images/17_arbeloa.jpg";
        }

        public String getPilkarzName(int num)
        {
            return pilkarz[num];
        }

        public String getPilkarzFoto(int num)
        {
            return pilkarze_foto[num];
        }

        public int Num
        {
            set { this.n = value; }

            get { return n; }
        }
    }
}
