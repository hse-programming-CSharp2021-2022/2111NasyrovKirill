using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework36
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point other)
        {
            double a = Math.Abs(this.X - other.X);
            double b = Math.Abs(this.Y - other.Y);
            return Math.Sqrt(a * a + b * b);
        }
    }
}
