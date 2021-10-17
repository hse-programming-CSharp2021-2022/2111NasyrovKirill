using System;

namespace prog7
{
    class Program
    {
        public static void sum(int n, out double sum)
        {
            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (i + 0.3) / (3 * Math.Pow(i, 2) + 5);
                Console.WriteLine($"{i}: {sum}");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            sum(n, out double s);
        }
    }
}