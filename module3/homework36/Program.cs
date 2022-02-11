using System;

namespace homework36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество окружностей: ");
            int n = int.Parse(Console.ReadLine());
            Circle[] arr = new Circle[n];
            double x, y, rad;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите данные для окружности (x, y, radius): ");
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                rad = double.Parse(Console.ReadLine());
                arr[i] = new Circle(x, y, rad);
            }
            Array.Sort(arr);

            Console.WriteLine("---------");
            Console.WriteLine("Отсортированные окружности 1 способом:");
            foreach (Circle c in arr)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("---------");
            Console.WriteLine("Отсортированные окружности 2 способом:");
            Array.Sort(arr, (value1, value2) => value1.CompareTo(value2));
            foreach (Circle c in arr)
            {
                Console.WriteLine(c);
            }
        }
    }
}
