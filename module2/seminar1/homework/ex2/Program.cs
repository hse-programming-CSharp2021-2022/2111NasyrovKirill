using System;

namespace ex2
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point(double x, double y) { X = x; Y = y; }
            public Point() : this(0, 0) { } // конструктор умолчания
            public double Ro
            {
                get
                {
                    return X * X + Y * Y;
                }
            }

            public double Fi
            {
                get
                {
                    if (X > 0 & Y >= 0) return Math.Atan(Y / X);
                    else if (X > 0 & Y < 0) return Math.Atan(Y / X) + 2 * Math.PI;
                    else if (X < 0) return Math.Atan(Y / X) + Math.PI;
                    else if (X == 0 & Y > 0) return Math.Atan(Math.PI / 2);
                    else if (X == 0 & Y < 0) return Math.Atan(3 * Math.PI / 2);
                    else return 0;
                }
            }

            public string PointData
            {   // СВОЙСТВО 
                get
                {
                    string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                    return string.Format(maket, X, Y, Ro, Fi);
                }
            }

            public double Lenght
            {
                get
                {
                    return Math.Sqrt(X * X + Y * Y);
                }
            }
        }

        static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                double[] mas = new double[3];
                mas[0] = a.Lenght; mas[1] = b.Lenght; mas[2] = c.Lenght;
                Array.Sort(mas);

                if (mas[0] == a.Lenght & mas[1] == b.Lenght & mas[2] == c.Lenght)
                {
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(b.PointData);
                    Console.WriteLine(c.PointData);
                }

                if (mas[0] == a.Lenght & mas[1] == c.Lenght & mas[2] == b.Lenght)
                {
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(c.PointData);
                    Console.WriteLine(b.PointData);
                }

                if (mas[0] == b.Lenght & mas[1] == a.Lenght & mas[2] == c.Lenght)
                {
                    Console.WriteLine(b.PointData);
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(c.PointData);
                }

                if (mas[0] == b.Lenght & mas[1] == c.Lenght & mas[2] == a.Lenght)
                {
                    Console.WriteLine(b.PointData);
                    Console.WriteLine(c.PointData);
                    Console.WriteLine(a.PointData);
                }

                if (mas[0] == c.Lenght & mas[1] == a.Lenght & mas[2] == b.Lenght)
                {
                    Console.WriteLine(c.PointData);
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(b.PointData);
                }

                if (mas[0] == c.Lenght & mas[1] == b.Lenght & mas[2] == a.Lenght)
                {
                    Console.WriteLine(c.PointData);
                    Console.WriteLine(b.PointData);
                    Console.WriteLine(a.PointData);
                }
            } while (x != 0 | y != 0);
        }


    }
}

