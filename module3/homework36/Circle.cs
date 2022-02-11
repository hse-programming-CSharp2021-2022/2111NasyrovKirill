using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework36
{
    internal class Circle:IComparable<Circle>
    {
        public Point center;
        double rad;
        double Rad 
        { 
            get
            {
                return rad;
            }
            set
            {
                rad = value;
            }
        }
        public Circle(double x, double y, double rad)
        {
            center = new Point(x, y);
            Rad = rad;
        }
        public override string ToString()
        {
            return $"Окружность с радиусом: {rad}; с центром в точке: ({center.X}, {center.Y})";
        }
        public int CompareTo(Circle other)
        {
            double a = this.Rad * this.center.Distance(new Point(0.0, 0.0));
            double b = other.Rad * other.center.Distance(new Point(0.0, 0.0));
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;
        }
    }
}
