using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
        HorizontalLine upLine = new HorizontalLine(0, 78, 0 , '+');
        HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
        VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
        VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
        upLine.Drow();
        downLine.Drow();
        leftLine.Drow();
        rightLine.Drow();

            Point p = new Point(4, 8, '*');
            Snace snace = new Snace(p, 4, Direction.RIGHT);
            snace.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25,'$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
              if(snace.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snace.Move();
                }
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snace.HandleKey(key.Key);
                }

                Thread.Sleep(200);
                snace.Move();
            }
          //  Console.ReadLine();           
        }
    }
}
