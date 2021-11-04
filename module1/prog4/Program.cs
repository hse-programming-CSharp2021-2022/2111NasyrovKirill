using System;

namespace prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int cnt1 = 0, cnt2 = 0;
            int k = 1;
            while(n>0)
            {
                int f = n % 10;
                if (k==1)
                {
                    cnt1 += f;
                    k = 2;
                }
                else if (k == 2)
                {
                    cnt2 += f;
                    k = 1;
                }
                n = n / 10;
            }
            Console.WriteLine("Сумма на четных местах - " + cnt2);
            Console.WriteLine("Сумма на нечетных местах - " + cnt1);
        }
    }
}
