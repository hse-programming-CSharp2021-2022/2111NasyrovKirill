using System;

namespace homework33
{
    class Dot
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Dot(double x, double y) => (X, Y) = (x, y);

        public delegate void CoordChanged(Dot point);
        public event CoordChanged OnCoordChanged;

        private Random rnd = new();
        public void DotFlow()
        {
            for (int i = 0; i < 10; i++)
            {
                X = 20*rnd.NextDouble()-10;
                Y = 20*rnd.NextDouble()-10;
                if (X < 0 & Y < 0) OnCoordChanged?.Invoke(new Dot(X, Y));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = double.Parse(Console.ReadLine());
            Dot D = new(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }

        static void PrintInfo(Dot A)
        {
            Console.WriteLine($"Координаты точки: ({A.X}, {A.Y})");
        }
    }
}