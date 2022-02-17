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
        
        public static void Movement(Panel snake, TableLayoutPanel board, string direction)
        {
            
            var currentPosition = board.GetCellPosition(snake);
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

       
    }
}
