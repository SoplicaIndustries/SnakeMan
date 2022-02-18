﻿using System;
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

        public int TailCounter { get; set; } = 0;   

        public Panel CurrentFruit { get; set; }

        public List<Panel> Tail;
        public Form1(string difficulty)
        {
            InitializeComponent();
            //tick settings
            if (difficulty == "easy")
            {
                ticker.Interval = 400;
            }
            else if (difficulty == "normal")
            {
                ticker.Interval = 100;
            }
            else if (difficulty == "hard")
            {
                ticker.Interval = 50;
            }
            ticker.Enabled = true;



            //start settings
            Direction = "up";
            button1.TabStop = false;
            Tail = new List<Panel>();

            //fisrt fruit generation
            CurrentFruit = FruitGenerator.FGen(snake,board, FruitCounter);



        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            
            if(controlls.BoardCollision(snake, board) || controlls.TailCollision(snake, board, Tail, Direction))
            {
                label2.Text = "you lost";
                Direction = "clear";
                controlls.Movement(snake, board, Direction);
                FruitCounter = 1;
                TailCounter = 0;
                for(int i = 0; i < Tail.Count; i++)
                {
                    board.Controls.Remove(Tail[i]);
                }
                Tail.Clear();
               
            }
            else
            {   if(controlls.FruitCollision(snake, board, CurrentFruit, Direction))
                {
                    //fruit handler
                    board.Controls.Remove(CurrentFruit);
                    CurrentFruit = FruitGenerator.FGen(snake, board, FruitCounter);
                    FruitCounter++;

                    //buff handler

                    FruitEvent.TailHandler(snake, board, TailCounter, Tail, Direction);
                    TailCounter++;
                }
                controlls.Movement(snake, board, Direction);
                for(int i = 0; i< Tail.Count; i++)
                {
                    controlls.TailMovement(Tail[i],snake,board, Direction, i);
                    
                }
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
            CurrentFruit = FruitGenerator.FGen(snake, board, FruitCounter);
            FruitCounter++;
            this.ActiveControl = null;
        }

        

        
    }

    
}
