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
       
        
        public static Panel FGen(Panel snake, TableLayoutPanel board, int counter)
        {
            int boardWidth = board.ColumnCount;
            int boardHeight = board.RowCount;

            var snakePos = board.GetCellPosition(snake);
            int snakeX = snakePos.Column;
            int snakeY = snakePos.Row;  

            Random randomPos = new Random();
            Random randomFruit = new Random();

            Panel Fruit;

            int xPos = randomPos.Next(0, boardWidth);
            int yPos = randomPos.Next(0, boardHeight);

            while (xPos == snakeX && yPos == snakeY)
            {
                xPos = randomPos.Next(0, boardWidth);
                yPos = randomPos.Next(0, boardHeight);
            }
            
            if ((counter % 10) == 0)
            {
                Fruit = Fruits_List.GetList()[randomFruit.Next(1, Fruits_List.GetList().Count())];
            }

            else
            {
                Fruit = Fruits_List.GetList()[0];
            }

            board.Controls.Add(Fruit, xPos, yPos);
            return Fruit;


        }
    }
}
