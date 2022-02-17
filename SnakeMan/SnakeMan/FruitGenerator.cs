using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMan
{
    
    class FruitGenerator
    {
       
        
        public static void FGen(TableLayoutPanel board, int counter)
        {
            int boardWidth = board.ColumnCount;
            int boardHeight = board.RowCount;

            Random randomPos = new Random();
            Random randomFruit = new Random();

            Panel Fruit;

            int xPos = randomPos.Next(0,boardWidth);
            int yPos = randomPos.Next(0, boardHeight);

            if (counter % 10 == 0)
            {
                Fruit = Fruits_List.GetList()[randomFruit.Next(0, Fruits_List.GetList().Count())];
            }

            else
            {
                Fruit = Fruits_List.GetList()[randomFruit.Next(0, 0)];
            }

            board.Controls.Add(Fruit, xPos, yPos);


        }
    }
}
