using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";

            Console.SetWindowSize(80, 25);

            HorizontalLines Left1 = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines Left2 = new HorizontalLines(0, 78, 24, '+');
            VerticalLines Up = new VerticalLines(0, 24, 0, '+');
            VerticalLines Up1 = new VerticalLines(0, 24, 78, '+');

            HorizontalLines sten1 = new HorizontalLines(15, 20, 18, '+');
            VerticalLines sten2 = new VerticalLines(6, 15, 20, '+');

            Left1.Sten();
            Left2.Sten();
            Up.Sten();
            Up1.Sten();
            sten1.Sten();
            sten2.Sten();

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p,4,Direction.RIGTH);
            snake.Sten();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadKey();
        }
    }
}
