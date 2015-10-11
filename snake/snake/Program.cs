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

            horizontalLine upLine = new horizontalLine(0, 78, 0, '+');
            horizontalLine downLine = new horizontalLine(0, 78, 24, '+');
            verticalLine leftline = new verticalLine(0, 24, 0, '+');
            verticalLine rightline = new verticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftline.Draw();            
            rightline.Draw();

            Console.ReadLine();
        }

    }
}
