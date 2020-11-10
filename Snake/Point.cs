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

        public void Draw()
        {
            Console.SetCursorPosition( x , y );
            Console.WriteLine(point);
        }
    }
}
