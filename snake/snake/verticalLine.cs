using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class verticalLine
    {
        List<Point> pList;

        public verticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw2()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }
        }
    }
}
