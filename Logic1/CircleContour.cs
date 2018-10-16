using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    public class CircleContour
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public CircleContour(Point center, int radius)
        {
            Radius = radius;
            Center = center;
        }
        public void ChangeRadius(int newRadius)
        {
            Radius = newRadius;
        }

        public override string ToString()
        {
            return String.Format("Radius: {0}; Center: {1};", Radius, Center);
        }
    }
}
