﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SnakeMan
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.BringToFront();


        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }
        private void Easy_Click(object sender, EventArgs e)
        {

        }

        private void Normal_Click(object sender, EventArgs e)
        {

        }


        private void Hard_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
