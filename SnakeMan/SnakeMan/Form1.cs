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
        public int FruitCounter { get; set; } = 1;

        public Panel CurrentFruit { get; set; }
        public Form1()
        {
            InitializeComponent();
            ticker.Enabled = true;
            ticker.Interval = 100;
            Direction = "up";
            button1.TabStop = false;
            CurrentFruit = FruitGenerator.FGen(board, FruitCounter);



        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            
            if(controlls.BoardCollision(snake, board))
            {
                label2.Text = "you lost";
                Direction = "clear";
                controlls.Movement(snake, board, Direction);
            }
            else
            {   if(controlls.FruitCollision(snake, board, CurrentFruit, Direction))
                {
                    board.Controls.Remove(CurrentFruit);
                    CurrentFruit = FruitGenerator.FGen(board, FruitCounter);
                    FruitCounter++;
                }
                controlls.Movement(snake, board, Direction);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                Direction = "down";
            }
            else if (e.KeyCode == Keys.W)
            {
                Direction = "up";
            }
            else if (e.KeyCode == Keys.D)
            {
                Direction = "right";
            }
            else if (e.KeyCode == Keys.A)
            {
                Direction = "left";
            }
        }

        private void snake_Paint(object sender, PaintEventArgs e)
        {
           
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            CurrentFruit = FruitGenerator.FGen(board, FruitCounter);
            FruitCounter++;
            this.ActiveControl = null;
        }
    }

    
}
