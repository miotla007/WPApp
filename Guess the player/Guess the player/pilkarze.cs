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
        private String[] pilkarz = new String[11];
        private String[] pilkarze_foto = new String[11];
        private int n;
        //App thisApp = Application.Current as App;
        public pilkarze()
        {
            pilkarz[1] = "Iker Casillas";
            pilkarze_foto[1] = "/Guess%20the%20player;component/Images/01_casillas.jpg";

            pilkarz[2] = "Alvaro Arbeloa";
            pilkarze_foto[2] = "/Guess%20the%20player;component/Images/17_arbeloa.jpg";

            pilkarz[3] = "Michael Essien";
            pilkarze_foto[3] = "/Guess%20the%20player;component/Images/15_Essien.jpg";

            pilkarz[4] = "Carles Puyol";
            pilkarze_foto[4] = "/Guess%20the%20player;component/Images/carles_puyol.jpg";

            pilkarz[5] = "Gianluigi Buffon";
            pilkarze_foto[5] = "/Guess%20the%20player;component/Images/Gianluigi-Buffon_a_opi-conf.jpg";

            pilkarz[6] = "Robert Lewandowski";
            pilkarze_foto[6] = "/Guess%20the%20player;component/Images/lewandowski.jpg";

            pilkarz[7] = "Robinho";
            pilkarze_foto[7] = "/Guess%20the%20player;component/Images/1275-2_robinho.jpg";

            pilkarz[8] = "Luka Modric";
            pilkarze_foto[8] = "/Guess%20the%20player;component/Images/16_modric.jpg";

            pilkarz[9] = "Wayne Rooney";
            pilkarze_foto[9] = "/Guess%20the%20player;component/Images/Wayne_Rooney.jpg";

            pilkarz[10] = "Lionel Messi";
            pilkarze_foto[10] = "/Guess%20the%20player;component/Images/Lionel_Messi.jpg";
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
