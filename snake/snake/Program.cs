using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            horizontalLine line = new horizontalLine(5, 10, 8, '+');
            line.Draw();

            verticalLine line2 = new verticalLine(7, 5, 10, '+');
            line2.Draw2();

            Console.ReadLine();
        }

    }
}
