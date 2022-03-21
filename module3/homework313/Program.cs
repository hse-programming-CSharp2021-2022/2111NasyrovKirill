using System;
using System.Collections;

namespace homework313
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fi = new();
            TriangleNums tr = new();
            int m = 10;
            int[] arr = new int[m];
            int i = 0;
            foreach (int numb in fi.NameEnumerator(m))
            {
                arr[i] = numb;
                Console.WriteLine(numb);
                i++;
            }

            Console.WriteLine("*******");

            i = 0;
            foreach (int numb in tr.NameUnumerator(m))
            {
                arr[i] += numb;
                Console.WriteLine(numb);
                i++;
            }
            Console.WriteLine("*******");
            foreach (int n in  arr)
            {
                Console.WriteLine(n);
            }
        }

        class TriangleNums
        {
            public IEnumerable NameUnumerator(int max)
            {
                for (int i = 0; i < max; i++)
                {
                    yield return (int)(i / 2.0 * (i * (i + 1)));
                }
                
            }
        }

        class Fibonacci
        {
            private int f0 = 1;
            private int f1 = 0;
            public IEnumerable NameEnumerator(int max)
            {
                for (int i = 0; i < max; i++)
                {
                    int t = f0 + f1;
                    f0 = f1;
                    f1 = t;
                    yield return t;
                }
            }
        }
    }
}