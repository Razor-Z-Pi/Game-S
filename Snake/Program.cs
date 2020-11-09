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

            int x1 = 1, x2 = 3, y1 = 6, y2 = 9;
            char point1 = '*', point2 = '#';

            Cor(x1,y1,point1);
            Cor(x2,y2,point2);

            Console.ReadKey();
        }

        static void Cor(int x, int y, char point)
        {
            Console.SetCursorPosition( x, y );
            Console.WriteLine(point);
        }
    }
}
