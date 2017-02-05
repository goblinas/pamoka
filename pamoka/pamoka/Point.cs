﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamoka
{
    class Point
    {
            public int x;
            public int y;
            public char symb;

        public Point()
        {
        }

        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }
        public void Move(int offset , Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.DOWN)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                x = x + offset;
            }

         }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
        public override string ToString()
        {
            return x + "," + y + "," + symb;
        }

    }
}
