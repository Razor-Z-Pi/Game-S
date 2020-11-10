using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLines : Figura
    {
        public HorizontalLines(int xLeft, int xRigth, int y, char point)
        {
            stena = new List<Point>();
            for (int x = xLeft; x <= xRigth; x++)
            {
                Point p = new Point(x, y, point);
                stena.Add(p);
            }
        }
    }
}
