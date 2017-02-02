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
       
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(5);
            numList.Add(14);
            numList.Add(5);

            int a = numList[0];
            int b = numList[1];
            int c = numList[3];
            int d = numList[2];

            foreach(int i in numList)
                {
               Console.WriteLine(i);
                }
            numList.RemoveAt(0);
            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
     Console.ReadLine();
        }
    }
}
