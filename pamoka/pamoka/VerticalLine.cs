using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamoka
{
    class VerticalLine : Figura
    {

        public VerticalLine(int yUP, int yDown, int x, char symb)
        {
            plist = new List<Point>();
            for (int y = yUP; y <= yDown; y++)
            {
                Point p = new Point(x,y, symb);
                plist.Add(p);
            }
        }

    }
}
