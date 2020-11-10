using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figura
    {
        Direction direction;

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
    }
}
