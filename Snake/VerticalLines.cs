using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines
    {
        List<Point> Goriz;
        Random tr;

        public VerticalLines(int yDown, int yUp, int x, char point)
        {
            Goriz = new List<Point>();
            tr = new Random();
            yDown = tr.Next(5, 10);
            yUp = tr.Next(10,15);
            x = tr.Next(1, 10);
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x,y,point);
                Goriz.Add(p);
            }
        }

        public void stenaG()
        {
            foreach (Point i in Goriz)
            {
                i.Draw();
            }
        }
    }
}
