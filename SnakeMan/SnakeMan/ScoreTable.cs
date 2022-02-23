using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMan
{
    public partial class ScoreTable : Form
    {
        public ScoreTable()
        {
            InitializeComponent();
            Saves.ReadBestScore(null);
            List<ScoreResult> scoreResults = new List<ScoreResult>();
            scoreResults = Saves.resultsFromFile;
            
            

            foreach(ScoreResult item in scoreResults)
            {
                ListViewItem lvItem = new ListViewItem(item.Difficulty);
                lvItem.SubItems.Add(item.Score.ToString());
                if(item.ScoreDate == new DateTime()) lvItem.SubItems.Add("NO DATE");
                lvItem.SubItems.Add(item.ScoreDate.ToString());
                lvScores.Items.Add(lvItem);
            }

        }

        private void lvScores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
