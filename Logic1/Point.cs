using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    public class Point
    {
        public Point( int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}
