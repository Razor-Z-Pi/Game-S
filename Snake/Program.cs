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

            HorizontalLines stena = new HorizontalLines(5,10,8,'*');
            stena.Sten();
            VerticalLines stenaV = new VerticalLines(0,0,0,'*');
            stenaV.stenaG();

            Console.ReadKey();
        }
    }
}
