using System.Collections.Generic;
using Cinderella;
using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Something[] mas = new Something[int.Parse(Console.ReadLine())];
            List<Lentil> lentils = new();
            List<Ashes> ashes = new();
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                int n = rnd.Next(2);
                if (n == 0)
                {
                    mas[i] = new Lentil();
                    lentils.Add(mas[i] as Lentil);
                }
                else
                {
                    mas[i] = new Ashes();
                    ashes.Add(mas[i] as Ashes);
                }
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine("Lentils:");
            foreach (Lentil lentil in lentils)
                Console.WriteLine(lentil);

            Console.WriteLine("Ashes:");
            foreach (Ashes ash in ashes)
                Console.WriteLine(ash);
        }
    }
}