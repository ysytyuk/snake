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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            List<char> charList = new List<char>();
            charList.Add('$');
            charList.Add('%');
            charList.Add('@');
            charList.Add('!');

            foreach (char p in charList)
            {
                Console.WriteLine(p);
            }

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Point p3 = new Point(6, 7, '%');
            Point p4 = new Point(7, 8, '$');
            Point p5 = new Point(8, 9, '@');
            Point p6 = new Point(9, 10, '&');

            List<Point> myList = new List<Point>();
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);

            Console.ReadLine();
        }

    }
}
