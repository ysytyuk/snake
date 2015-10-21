using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 2, '*');

            p1.Drow();

            Point p2 = new Point(4, 5, '#');

            p2.Drow();

            horizontalLine upLine = new horizontalLine(0, 78, 0, '+');
            horizontalLine downLine = new horizontalLine(0, 78, 24, '+');
            verticalLine leftline = new verticalLine(0, 24, 0, '+');
            verticalLine rightline = new verticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftline.Draw();            
            rightline.Draw();

            Point p = new Point(4, 5, '*');
            snake snake = new snake( p, 4, direction.RIGHT );
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Controlsnake(key.Key);
                }
            }
        }

    }
}
