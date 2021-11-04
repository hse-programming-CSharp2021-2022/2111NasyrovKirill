using System;
using System.Collections.Generic;

namespace ex3
{
    class Polygon
    {
        int number;
        double radius;
        public double Per
        {
            get
            {
                double R = radius / Math.Cos(Math.PI / number);
                double a = 2 * R * Math.Sin(Math.PI / number);
                return number * a;
            }
        }
        public double Sq
        {
            get
            {
                return 0.5 * Per * radius;
            }
        }
        public Polygon(int number = 0, double radius = 0)
        {
            this.number = number; this.radius = radius;
        }
        public string PoligonData()
        {
            return "Стороны = " + number + "\n" + "радиус  вписаной окружности= " + radius + "\n" + "периметр = " + Per + "\n" + "площадь = " + Sq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> list = new List<Polygon>();
            Console.WriteLine("Ввод количества сторон и радиуса фигуры");
            int.TryParse(Console.ReadLine(), out int num);
            int.TryParse(Console.ReadLine(), out int rad);
            Console.WriteLine();
            double max = 0;
            double min = 100000000;
            while (num != 0 | rad != 0)
            {
                Polygon a = new Polygon(num, rad);
                if (a.Sq > max) max = a.Sq;
                if (a.Sq < min) min = a.Sq;
                list.Add(a);
                Console.WriteLine("Ввод количества сторон и радиуса фигуры");
                int.TryParse(Console.ReadLine(), out num);
                int.TryParse(Console.ReadLine(), out rad);
                Console.WriteLine();
            }
            Polygon[] mas = list.ToArray();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Sq == max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mas[i].PoligonData());
                }
                else if (mas[i].Sq == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(mas[i].PoligonData());
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine(mas[i].PoligonData());
                }
            }




        }
    }
}