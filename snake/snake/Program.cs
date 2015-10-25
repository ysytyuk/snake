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

            verticalLine vl = new verticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p = new Point(4, 5, '*');
            figura fSnake = new snake(p, 4, direction.RIGHT);
            Draw(fSnake);
            snake snake = (snake)fSnake;

            horizontalLine hl = new horizontalLine(0, 5, 6, '&');

            List<figura> figures = new List<figura>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }

            Console.ReadLine();

        }

        static void Draw(figura figure)
            {
                figure.Draw();
            }

    }
}
