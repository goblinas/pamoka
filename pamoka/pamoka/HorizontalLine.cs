﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamoka
{
    class HorizontalLine : Figura
    {

        public HorizontalLine(int xLeft , int xRight , int y , char symb )
        {
            plist = new List<Point>();
            for (int x= xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,symb);
                plist.Add(p);
            }
        }
    }
}
