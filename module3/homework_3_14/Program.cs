using System;
using System.Linq;

namespace homework_3_14
{
    class Program
    {
        static void Main()
        {
            Random rnd = new();
            int.TryParse(Console.ReadLine(), out int n);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-1000, 1001);

            var z1 = from numb in arr
                where numb == (int)Math.Sqrt(numb) * (int)Math.Sqrt(numb)
                select numb;

            var z2 = from numb in arr
                where numb > 0 && numb.ToString().Length == 2
                select numb;

            var z3 = from numb in arr
                where numb % 2 == 0
                orderby numb descending
                select numb;

            var z4 = from numb in arr
                group numb by Math.Abs(numb).ToString().Length;

            foreach (int i in  arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********");
            
            foreach (int i in  z1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");

            foreach (int i in  z2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");

            foreach (int i in  z3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");

            foreach (var i in  z4)
            {
                Console.WriteLine(i.Key);
                foreach (int k in i)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}