using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 4;
            p1.point = '*';

            p1.Draw();

            Point p2 = new Point();
            p2.x = 6;
            p2.y = 8;
            p2.point = '#';

            p2.Draw();

            Console.ReadKey();
        }
    }
}
