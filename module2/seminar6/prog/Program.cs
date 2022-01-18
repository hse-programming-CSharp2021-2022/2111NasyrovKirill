using System;
using System.Collections.Generic;
using System.IO;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = null;
                string[] b = a.Split(' ');
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string[] a = new string[2];
                string b = a[2];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string a = "Я мастер исключений после всех этих пиргрейдов";
                int b = int.Parse(a);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int n = 8;
                n = n/0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string a = @"C:\tyu";
                Directory.SetCurrentDirectory(a);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var list = new List<string>();
                Console.WriteLine(list[0]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string a = "fsdfbfvffgn";
                StreamReader reader = new StreamReader(a);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                object a = " ";
                int b = (int)a;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string a = null;
                string b = "Исключения меня убивают";
                int c = b.IndexOf(a);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                char[,] a = new char[3, 2];
                Array.Reverse(a);
            }
            catch (RankException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                throw new CoolException();
            }
            catch (CoolException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public class CoolException : Exception
        {
            public CoolException() : base("Вот и закончились хихи хаха") { }
        }
    }
}
