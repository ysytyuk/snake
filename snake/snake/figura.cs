using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class figura
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }
        }

        internal bool IsHit(figura figura)
        {
            foreach (var p in pList)
            {
                if (figura.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
