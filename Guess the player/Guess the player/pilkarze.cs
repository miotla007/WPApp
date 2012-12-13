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
        private String[] pilkarz = new String[21];
        private String[] pilkarze_foto = new String[21];
        private int n;
        //App thisApp = Application.Current as App;
        public pilkarze()
        {
            pilkarz[1] = "Iker Casillas";
            pilkarze_foto[1] = "/Guess%20the%20player;component/Images/casillas.jpg";

            pilkarz[2] = "Alvaro Arbeloa";
            pilkarze_foto[2] = "/Guess%20the%20player;component/Images/arbeloa.jpg";

            pilkarz[3] = "Michael Essien";
            pilkarze_foto[3] = "/Guess%20the%20player;component/Images/essien.jpg";

            pilkarz[4] = "Carles Puyol";
            pilkarze_foto[4] = "/Guess%20the%20player;component/Images/carles_puyol.jpg";

            pilkarz[5] = "Gianluigi Buffon";
            pilkarze_foto[5] = "/Guess%20the%20player;component/Images/Gianluigi-Buffon_a_opi-conf.jpg";

            pilkarz[6] = "Robert Lewandowski";
            pilkarze_foto[6] = "/Guess%20the%20player;component/Images/lewandowski.jpg";

            pilkarz[7] = "Robinho";
            pilkarze_foto[7] = "/Guess%20the%20player;component/Images/1275-2_robinho.jpg";

            pilkarz[8] = "Luka Modric";
            pilkarze_foto[8] = "/Guess%20the%20player;component/Images/modric.jpg";

            pilkarz[9] = "Wayne Rooney";
            pilkarze_foto[9] = "/Guess%20the%20player;component/Images/Wayne_Rooney.jpg";

            pilkarz[10] = "Lionel Messi";
            pilkarze_foto[10] = "/Guess%20the%20player;component/Images/Lionel_Messi.jpg";

            pilkarz[11] = "Zlatan Ibrahimovic";
            pilkarze_foto[11] = "/Guess%20the%20player;component/Images/ibra.jpg";

            pilkarz[12] = "Alexandre Pato";
            pilkarze_foto[12] = "/Guess%20the%20player;component/Images/pato.jpg";

            pilkarz[13] = "Sergio Ramos";
            pilkarze_foto[13] = "/Guess%20the%20player;component/Images/ramos.jpg";

            pilkarz[14] = "Xabi Alonso";
            pilkarze_foto[14] = "/Guess%20the%20player;component/Images/alonso.jpg";

            pilkarz[15] = "Radamel Falcao";
            pilkarze_foto[15] = "/Guess%20the%20player;component/Images/falcao.jpg";

            pilkarz[16] = "Didier Drogba";
            pilkarze_foto[16] = "/Guess%20the%20player;component/Images/Drogba.jpg";

            pilkarz[17] = "Neymar";
            pilkarze_foto[17] = "/Guess%20the%20player;component/Images/neymar.jpg";

            pilkarz[18] = "Arjen Roben";
            pilkarze_foto[18] = "/Guess%20the%20player;component/Images/roben.jpg";

            pilkarz[19] = "Thierry Henry";
            pilkarze_foto[19] = "/Guess%20the%20player;component/Images/henry.jpg";

            pilkarz[20] = "Diego Forlan";
            pilkarze_foto[20] = "/Guess%20the%20player;component/Images/forlan.jpg";

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
