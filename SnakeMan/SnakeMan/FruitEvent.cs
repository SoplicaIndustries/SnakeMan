using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMan
{
    internal class FruitEvent
    {
        public static void FruitEventHandler(Panel snake,TableLayoutPanel board, string direction, string fruitName)
        {

        }

        public static void TailHandler(Panel snake, TableLayoutPanel board, int tailCounter, List<Panel> Tail, string direction)
        {
            //Getting pos
            var snakePos = board.GetCellPosition(snake);
            var snakeX = snakePos.Column;
            var snakeY = snakePos.Row;

            //Setting pos
            int tailX = 0;
            int tailY = 0;

            if(Tail.Count > 0)
            {
                tailX = controlls.PreviousTailX;
                tailY = controlls.PreviousTailY;

            }
            if (direction == "right")
            {
                tailX = snakePos.Column - 1;
                tailY = snakePos.Row;
            }
            else if (direction == "left")
            {
                tailX = snakePos.Column + 1;
                tailY = snakePos.Row;
            }
            else if (direction == "up")
            {
                tailX = snakePos.Column;
                tailY = snakePos.Row + 1;
            }
            else if (direction == "down")
            {
                tailX = snakePos.Column;
                tailY = snakePos.Row - 1;
            }


            //adding tail element
            Tail.Add(new Panel { Name = tailCounter.ToString(), BackColor = System.Drawing.Color.Black });
            board.Controls.Add(Tail[tailCounter], tailX, tailY);

        }
    }
}
