using System;

namespace prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("метод без out");
            Console.WriteLine(function(true, true));
            Console.WriteLine(function(true, false));
            Console.WriteLine(function(false, true));
            Console.WriteLine(function(false, false));
            Console.WriteLine();

            Console.WriteLine("метод c out");
            bool res;
            function(true, true, out res);
            Console.WriteLine(res);
            function(true, false, out res);
            Console.WriteLine(res);
            function(false, true, out res);
            Console.WriteLine(res);
            function(false, false, out res);
            Console.WriteLine(res);

        }

        public static bool function(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }

        public static void function(bool p, bool q, out bool res)
        {
            res = !(p & q) & !(p | !q);
        }
    }
}
