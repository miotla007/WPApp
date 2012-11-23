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

using System.IO;
using System.IO.IsolatedStorage;

namespace Guess_the_player
{
    public class IS
    {
        App thisApp = Application.Current as App;

        public void SaveAnsvers()
        {
            String score = "";
            for (int i = 1; i < 9; i++)
            {
                if (thisApp.wynik.ansvered(i)) score += "1;"; else score += "0;";
            }
            saveScoreDataIS("ansvers.txt", score);
            
        }

        public void LoadAnsvers()
        {
            String score;
            loadScoreDataIS("ansvers.txt", out score);
            char[] separators = { ';' };
            String[] scores = score.Split(separators);

            if (scores.Length >= 8)
            {

                for (int i = 0; i < 8; i++)
                {
                    if (scores[i].CompareTo("1") == 0) thisApp.wynik.good_ansver(i + 1); else thisApp.wynik.bad_ansver(i + 1);
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                  thisApp.wynik.bad_ansver(i + 1);
                }
            }
        }


        public void SaveScores()
        {
            String score = thisApp.wynik.Wynik.ToString() + ";" + thisApp.wynik2.Wynik.ToString();
            saveScoreDataIS("scores.txt", score);
        }

        public void ClearScores()
        {
            saveScoreDataIS("scores.txt", "");
            saveScoreDataIS("ansvers.txt", "");
            LoadScores();
        }

        public void LoadScores()
        {
            String score;
            loadScoreDataIS("scores.txt", out score);
            char[] separators = { ';' };
            String[] scores = score.Split(separators);

            if (scores.Length >= 2)
            {
                thisApp.wynik.Wynik = Convert.ToDouble(scores[0]);
                thisApp.wynik2.Wynik = Convert.ToDouble(scores[1]);
            }
            else
            {
                thisApp.wynik.Wynik = 0;
                thisApp.wynik2.Wynik = 0;
            }
        }


        private void saveScoreDataIS(string filename, string text)
        {
            using (IsolatedStorageFile isf =
                          IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream rawStream =
                                 isf.CreateFile(filename))
                {
                    StreamWriter writer = new StreamWriter(rawStream);
                    writer.Write(text);
                    writer.Close();
                }
            }
        }

        private bool loadScoreDataIS(string filename, out string result)
        {
            result = "";
            using (IsolatedStorageFile isf =
                IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (isf.FileExists(filename))
                {
                    try
                    {
                        using (IsolatedStorageFileStream rawStream =
                            isf.OpenFile(filename, System.IO.FileMode.Open))
                        {
                            StreamReader reader = new StreamReader(rawStream);
                            result = reader.ReadToEnd();
                            reader.Close();
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
