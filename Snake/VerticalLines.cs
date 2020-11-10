using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines : Figura
    {
        public VerticalLines(int yDown, int yUp, int x, char point)
        {
            stena = new List<Point>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x,y,point);
                stena.Add(p);
            }
        }

    }
}
