using System;

namespace prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            rev(n);
        }
        public static void rev(int a)
        {
            int f = 0;
            while(a>0)
            {
                int k = a % 10;
                if (k==0)
                {
                    if (f==1) Console.Write(k);
                }
                else
                {
                    f = 1;
                    Console.Write(k);
                }
                a = a / 10;
            }
            
        }
    }
}
