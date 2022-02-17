using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMan
{
    class controlls
    {
        public static int PreviousX { get; set; }
        public static int PreviousY { get; set; }

        public static int PreviousTailX { get; set; }
        public static int PreviousTailY { get; set; }

        public static void Movement(Panel snake, TableLayoutPanel board, string direction)
        {
            
            var currentPosition = board.GetCellPosition(snake);

            
                PreviousX = currentPosition.Column;
                PreviousY = currentPosition.Row;
            
            
               
            

            TableLayoutPanelCellPosition UpdateSnake;
            


            if (direction == "up")
            {
                UpdateSnake = new TableLayoutPanelCellPosition(currentPosition.Column, currentPosition.Row - 1);
                board.SetCellPosition(snake, UpdateSnake);

            }
            else if (direction == "down")
            {
                UpdateSnake = new TableLayoutPanelCellPosition(currentPosition.Column, currentPosition.Row + 1);
                board.SetCellPosition(snake, UpdateSnake);
            }
            else if (direction == "right")
            {
                UpdateSnake = new TableLayoutPanelCellPosition(currentPosition.Column + 1, currentPosition.Row);
                board.SetCellPosition(snake, UpdateSnake);
            }
            else if (direction == "left")
            {
                UpdateSnake = new TableLayoutPanelCellPosition(currentPosition.Column - 1, currentPosition.Row);
                board.SetCellPosition(snake, UpdateSnake);
            }
            else if(direction == "clear")
            {
                UpdateSnake = new TableLayoutPanelCellPosition(10, 10);
                board.SetCellPosition(snake, UpdateSnake);
            }
        }

        public static bool BoardCollision(Panel snake, TableLayoutPanel board)
        {
            var currentPosition = board.GetCellPosition(snake);

            var boardWidth = board.ColumnCount;
            var boardHeight = board.RowCount;

            if (Math.Abs(currentPosition.Column) > Math.Abs(boardWidth - 1) || Math.Abs(currentPosition.Row) > Math.Abs(boardHeight - 1) || currentPosition.Column < 0 || currentPosition.Row < 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool FruitCollision(Panel snake,TableLayoutPanel board, Panel fruit, string direction)
        {
            if (fruit != null)
            {
                var snakePos = board.GetCellPosition(snake);
                var fruitPos = board.GetCellPosition(fruit);

                if (snakePos.Column == (fruitPos.Column-1) && snakePos.Row == fruitPos.Row && direction =="right")
                {
                    return true;
                }
                else if (snakePos.Column == (fruitPos.Column + 1) && snakePos.Row == fruitPos.Row && direction == "left")
                {
                    return true;
                }

                else if (snakePos.Column == fruitPos.Column && snakePos.Row == (fruitPos.Row-1) && direction == "down")
                {
                    return true;
                }
                else if (snakePos.Column == fruitPos.Column && snakePos.Row == (fruitPos.Row + 1) && direction == "up")
                {
                    return true;
                }

                else return false;
            }
            return false;
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
            if (direction == "right")
            {
                tailX = snakePos.Column-1;
                tailY = snakePos.Row;
            }
            else if(direction == "left")
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

        public static void TailMovement(Panel tail,Panel snake, TableLayoutPanel board, string direction, int count)
        {
            var snakepos = board.GetCellPosition(snake);
            var tailpos = board.GetCellPosition(tail);

           

            TableLayoutPanelCellPosition UpdateTail;
            if (count == 0)
            {
                PreviousTailX = tailpos.Column;
                PreviousTailY = tailpos.Row;
                UpdateTail = new TableLayoutPanelCellPosition(PreviousX, PreviousY);
                board.SetCellPosition(tail, UpdateTail);
               
            }
            else
            {
                UpdateTail = new TableLayoutPanelCellPosition(PreviousTailX, PreviousTailY);
                board.SetCellPosition(tail, UpdateTail);
                PreviousTailX = tailpos.Column;
                PreviousTailY = tailpos.Row;
            }  
        }

        public static bool TailCollision(Panel snake,TableLayoutPanel board, List<Panel> tails, string direction)
        {
            if (tails != null)
            {
                foreach (var tail in tails) {
                    var snakePos = board.GetCellPosition(snake);
                    var tailPos = board.GetCellPosition(tail);

                    if (snakePos.Column == (tailPos.Column) && snakePos.Row == tailPos.Row && direction == "right")
                    {
                        return true;
                    }
                    else if (snakePos.Column == (tailPos.Column) && snakePos.Row == tailPos.Row && direction == "left")
                    {
                        return true;
                    }

                    else if (snakePos.Column == tailPos.Column && snakePos.Row == (tailPos.Row) && direction == "down")
                    {
                        return true;
                    }
                    else if (snakePos.Column == tailPos.Column && snakePos.Row == (tailPos.Row) && direction == "up")
                    {
                        return true;
                    }
                    
                }

                return false;

                
            }



            return false;
        }

       

       

       
    }
}
