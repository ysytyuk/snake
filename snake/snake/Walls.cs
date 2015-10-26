using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<figura> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<figura>();
            horizontalLine upLine = new horizontalLine(0, mapWidth - 2, 0, '+');
            horizontalLine downLine = new horizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            verticalLine leftLine = new verticalLine(0, mapHeight - 1, 0, '+');
            verticalLine rightLine = new verticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(figura figura)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figura))
                {
                    return true;
                }
            }

            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
