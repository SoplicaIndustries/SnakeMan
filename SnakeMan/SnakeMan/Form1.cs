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
    

    public partial class Form1 : Form
    {
        public string Direction { get; set; }
        public Form1()
        {
            InitializeComponent();
            ticker.Enabled = true;
            ticker.Interval = 100;
            Direction = "up";
           

        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            
            if(controlls.Collision(snake, board))
            {
                label2.Text = "you lost";
                Direction = "clear";
                controlls.Movement(snake, board, Direction);
            }
            else
            {
                controlls.Movement(snake, board, Direction);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                Direction = "down";
            }
            else if (e.KeyCode == Keys.Up)
            {
                Direction = "up";
            }
            else if (e.KeyCode == Keys.Right)
            {
                Direction = "right";
            }
            else if (e.KeyCode == Keys.Left)
            {
                Direction = "left";
            }
        }

        private void snake_Paint(object sender, PaintEventArgs e)
        {
           
        }

       
    }

    
}
