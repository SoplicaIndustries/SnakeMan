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
        public static void FruitEventHandler(Panel snake, TableLayoutPanel board, int tailCounter, List<Panel> Tail, string direction, string fruitName)
        {
            if(fruitName == "Apple")
            {
                TailHandler(snake, board, Form1.TailCounter, Tail, direction);
                Form1.TailCounter++;
            }
            if(fruitName == "Berry")
            {
                for (int i = 0; i < 2; i++)
                {
                    TailHandler(snake, board, Form1.TailCounter, Tail, direction);
                    Form1.TailCounter++;
                }
                

            }
            if(fruitName == "Banana")
            {
                for(int i = 1; i <= 2 ; i++)
                {
                    var tailNum = Tail.Count-1;
                    board.Controls.Remove(Tail[tailNum]);
                    Tail.RemoveAt(tailNum);
                    Form1.TailCounter--;
                    
                }
            }
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
                if (direction == "right")
                {
                    tailX = controlls.PreviousTailX - 1;
                    tailY = controlls.PreviousTailY;
                }
                else if (direction == "left")
                {
                    tailX = controlls.PreviousTailX + 1;
                    tailY = controlls.PreviousTailY;
                }
                else if (direction == "up")
                {
                    tailX = controlls.PreviousTailX;
                    tailY = controlls.PreviousTailY + 1;
                }
                else if (direction == "down")
                {
                    tailX = controlls.PreviousTailX;
                    tailY = controlls.PreviousTailY - 1;
                }

            }
            else
            {
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

            }
            


            //adding tail element
            Tail.Add(new Panel { Name = tailCounter.ToString(), BackColor = System.Drawing.Color.Black });
            board.Controls.Add(Tail[tailCounter], tailX, tailY);

        }
    }
}
