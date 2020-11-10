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

            Point p1 = new Point(1,4,'*');
            Point p2 = new Point(5,8,'#');
            Point p3 = new Point(9, 10, '&');
            Point p4 = new Point(15, 18, '$');
            Point p5 = new Point(20, 24, '@');

            Console.ReadKey();

            List<Point> newList = new List<Point>();
            newList.Add(p3);
            newList.Add(p4);
            newList.Add(p5);

            foreach (Point i in newList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
