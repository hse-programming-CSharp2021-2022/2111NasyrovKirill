using System;

namespace homework31_1
{
    class Program
    {
        delegate int Cast(double number);
        static void Main(string[] args)
        {
            Cast cast1, cast2;
            cast1 = delegate(double number)
            {
                return (int) number % 2 == 0 ? (int) number : (int) number + 1;
            };
            cast2 = (number) => ((int) number).ToString().Length;
            Console.WriteLine(cast1(23.3));
            Console.WriteLine(cast2(1323.3));
            Console.WriteLine(cast2(132343.3));
            Console.WriteLine(cast2(1324));
        }
    }
}
