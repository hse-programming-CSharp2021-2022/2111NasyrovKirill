using System;

namespace prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int max = 0, min = 9;
            while (n>0)
            {
                int k = n % 10;
                if (min > k) min = k;
                if (max < k) max = k;
                n = n / 10;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
