using System;

namespace seminar_2_classwork_1
{
    class Program
    {


        class MyComplex
        {
            double re, im;
            MyComplex(double xre, double xim)
            { 
                re = xre; 
                im = xim; 
            }
            // Неправильная реализация:        
            //public static MyComplex operator ++(MyComplex mc)        
            //{ mc.re++; mc.im++; return mc; }
            public static MyComplex operator --(MyComplex mc)
            { 
                return new MyComplex(mc.re - 1, mc.im - 1); 
            }

            public static MyComplex operator +(MyComplex a, MyComplex b)
            {
                return new MyComplex(a.re + b.re, a.im + b.im);
            }

            public static MyComplex operator *(MyComplex a, MyComplex b)
            {
                return new MyComplex(a.re * b.re- a.im * b.im, a.im * b.re + a.re*b.im);
            }

            public static MyComplex operator /(MyComplex a, MyComplex b)
            {
                return new MyComplex( (a.re * b.re + a.im * b.im)/(b.re * b.re + b.im * b.im) , (a.im * b.re - a.re * b.im)/(b.re * b.re + b.im * b.im) );
            }

            public static MyComplex operator -(MyComplex a, MyComplex b)
            {
                return new MyComplex(a.re - b.re, a.im - b.im);
            }
            public double Mod() 
            { 
                return Math.Abs(re * re + im * im); 
            }
            static public bool operator true(MyComplex f)
            {
                if (f.Mod() > 1.0) return true;
                return false;
            }
            static public bool operator false(MyComplex f)
            {
                if (f.Mod() <= 1.0) return true;
                return false;
            }
            static void Display(MyComplex cs)
            {
                Console.WriteLine("real=" + cs.re + ", image=" + cs.im);
            }

            public override string ToString()
            {
                return re + " " + im;
            }

            static void Main()
            {
                MyComplex c1 = new MyComplex(4, 3.3);
                Console.WriteLine("Модуль исходного комплексного числа = " +  c1.Mod());
                while (c1)
                {
                    Console.Write("c1 => ");
                    Display(c1);
                    c1--;
                }
                Console.WriteLine("Модуль полученного числа = " + c1.Mod());

                MyComplex a = new MyComplex(3, 6);
                MyComplex b = new MyComplex(1, 3);
                Console.WriteLine(a + b);
            }


        }

    }
}
