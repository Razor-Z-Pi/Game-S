using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLines
    {
        List<Point> stena;
        Random rz;

        public HorizontalLines(int xLeft, int xRigth, int y , char point)
        {
            rz = new Random();
            int i,s = 0;
            i = rz.Next(10, 20);
            while (i > s)
            { 
                stena = new List<Point>();
                xLeft = rz.Next(1,8);
                xRigth = rz.Next(8,11);
                y = rz.Next(1, 8);
                for (int x = xLeft; x <= xRigth; x++)
                {
                    Point p = new Point(x,y,point);
                    stena.Add(p);
                }
                s++;
            }
        }

        public void Sten()
        {
            foreach (Point i in stena)
            {
                i.Draw();
            }
        }
    }
}
