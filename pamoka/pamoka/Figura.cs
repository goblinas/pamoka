using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamoka
{
    class Figura
    {
        protected List<Point> plist;

      public void Drow()
        {
            foreach (Point p in plist)
                p.Draw();
        }
    }
}
