using System;

namespace homework35
{
    delegate double calculate(double n);
    internal class Program
    {
        static void Main(string[] args)
        {
            F f1=new F();
            f1.calc = (double x) => x * x - 4;
            F f2 = new F();
            f2.calc = (double x) => Math.Sin(x);
            G g = new(f1, f2);
            for (double i=0; i<=Math.PI; i+=Math.PI/16.0)
            {
                Console.WriteLine(g.GF(i));
            }
        }
    }

    interface IFunction
    {
        double Function(double x);
    }

    class F: IFunction
    {
        public calculate calc;
        public double Function(double x)
        {
            return calc(x);
        }
    }

    class G
    {
        public F f1, f2;
        public G(F f1, F f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }

        public double GF(double x0)
        {
            return f1.Function(f2.Function(x0));
        }
    }
}
