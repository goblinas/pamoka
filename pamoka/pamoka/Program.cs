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

            HorizontalLine line = new HorizontalLine(4, 8, 4, 'X');
            line.Drow();

            VerticaLine Line = new VerticaLine(5, 9, 5, 'X');
            Line.Drow();

            Console.ReadLine();
        }
    }
}
