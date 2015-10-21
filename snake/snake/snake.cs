﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake : figura
    {
        direction direction;

        public snake(Point tail, int length, direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p); 
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Drow();
        }

        public Point GetNextPoint() {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void Controlsnake(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
