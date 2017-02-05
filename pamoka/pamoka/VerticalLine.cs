using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamoka
{
    class VerticalLine
    {
        List<Point> plist;
        public VerticalLine(int yUP, int yDown, int x, char symb)
        {
            plist = new List<Point>();
            for (int n = yUP; n <= yDown; n++)
            {
                Point p = new Point(x,n, symb);
                plist.Add(p);
            }
        }
        public void Drow()
        {
            foreach (Point p in plist)
                p.Draw();
        }
    }
}
