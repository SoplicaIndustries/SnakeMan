using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMan
{
    class Saves
    {
        private static int BS { get; set; }
        private static string FileName { get; set; } = "bs.txt";

        public static void SaveBestScore(int bestScore)
        {
            BS = bestScore;
            

            using (StreamWriter tw = new StreamWriter(FileName, false))
            {
                tw.WriteLine(BS.ToString());
            }
        }

        public static int ReadBestScore()
        {
            int bestScore = 0;
            using (StreamReader sr = new StreamReader(FileName))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Trim().Length == 0) continue;
                    bestScore += Convert.ToInt32(line);
                }
            }

            return bestScore;

        }
    }
}
