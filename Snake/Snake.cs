using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figura
    {
        public Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            stena = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point( tail );
                p.Move(i, direction);
                stena.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = stena.First();
            stena.Remove( tail );
            Point head = GetNextPoint();
            stena.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = stena.Last();
            Point nextpoint = new Point( head );
            nextpoint.Move(1, direction);
            return nextpoint;
        }

        public void Trans(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow) direction = Direction.RIGTH;
            else if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow) direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.point = head.point;
                stena.Add(food);
                return true;
            }
            else return false;
        }
    }
}
