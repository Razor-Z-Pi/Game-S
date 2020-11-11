using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point 
    {
        public int x;
        public int y;
        public char point;

        public Point() 
        { 
        }

        public Point(int _x, int _y, char _point)
        {
            x = _x;
            y = _y;
            point = _point;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            point = p.point;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGTH)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition( x , y );
            Console.WriteLine(point);
        }

        public void Clear()
        {
            point = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + point;
        }
    }
}
