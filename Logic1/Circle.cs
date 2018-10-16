using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    /*Создать объект класса Круг, используя классы Точка, Окружность. 
     * Методы: задание размеров, изменение радиуса, определение принадлежности 
     * точки данному кругу.*/
    public class Circle
    {
        public CircleContour Controur { get; private set; }
        public Point Center
        {
            get
            {
                return Controur.Center;
            }
        }

        public int Radius
        {
            get
            {
                return Controur.Radius;
            }
        }

        public Circle(Point center, int radius)
        {
            Controur = new CircleContour(center, radius);
        }

        public bool IsPointInCircle(Point p)
        {

            Point vector = new Point(p.X - Center.X, p.Y - Center.Y);
            double distance = vector.X * vector.X + vector.Y * vector.Y;
            return distance <= Controur.Radius * Controur.Radius;
        }

        public void ChangeSize(int x, int y, int newRadius)
        {
            Controur.Center = new Point(x, y);
            Controur.ChangeRadius(newRadius);
        }

        public void ChangeRadius(int radius)
        {
            Controur.ChangeRadius(radius);
        }

        public override string ToString()
        {
            return String.Format("Radius: {0}; Center: {1};", Controur.Radius, Center);
        }
    }
}
