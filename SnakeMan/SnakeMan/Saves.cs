using Newtonsoft.Json;
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
        public static List<ScoreResult> resultsFromFile { get; set; }  
        private static int BS { get; set; }
        private static string FileName { get; set; } = "bs.json";

        public static void SaveBestScore(string difficulty, int score, DateTime currDate)
        {

                for (int i = 0; i < resultsFromFile.Count; i++)
                {
                    var result = resultsFromFile[i];
                    if (result.Difficulty.ToLowerInvariant() == difficulty.ToLowerInvariant())
                    {
                        resultsFromFile[i].Score = score;
                        resultsFromFile[i].ScoreDate = currDate;
                    }
                }

                

                string jsonData = JsonConvert.SerializeObject(resultsFromFile);

                File.WriteAllText(FileName, jsonData);
                
            
        }

        public static int ReadBestScore(string difficulty)
        {
            
            var fromJSON = File.ReadAllText(FileName);

            if (fromJSON.Count() == 0)
            {
                List<ScoreResult> empty = new List<ScoreResult>
                {
                    new ScoreResult{Difficulty = "Easy", Score = 0, ScoreDate = new DateTime() },
                     new ScoreResult{Difficulty = "Normal", Score = 0, ScoreDate = new DateTime() },
                      new ScoreResult{Difficulty = "Hard", Score = 0, ScoreDate = new DateTime() }
                };

                string emptyJSON = JsonConvert.SerializeObject(empty);
                File.WriteAllText(FileName, emptyJSON);
                ReadBestScore(difficulty);
                

                return 0;

            }
            else
            {

                var res = JsonConvert.DeserializeObject<List<ScoreResult>>(fromJSON);
                resultsFromFile = res;

                foreach (ScoreResult result in res)
                {
                    if(difficulty == null)
                    {
                        return 0;
                    }
                    else if(result.Difficulty.ToLowerInvariant() == difficulty.ToLowerInvariant())
                    {
                        return result.Score;
                    }
                }

            }
            return 0;
            

        }
    }

    class ScoreResult
    {
        public String Difficulty { get; set; }

        public int Score { get; set; }

        public DateTime ScoreDate { get; set; }
    }
}
