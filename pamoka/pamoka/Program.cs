using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,10,'*');
            p1.Draw();

           Point p2 = new Point(20,20,'+');
            p2.Draw();

            HorizontalLine Line = new HorizontalLine(5,10,8,'+');
            Line.Drow();
            VerticalLine line = new VerticalLine(5, 10, 8, '+');
            line.Drow();

            Console.ReadLine();
        }
    }
}
