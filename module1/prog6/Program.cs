using System;

namespace prog6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int.TryParse(Console.ReadLine(), out int n);
            int[][] mas = new int[n][];
            for (int i=0; i<n; i++)
            {
                mas[i] = new int[rnd.Next(5, 16)];
                for (int j = 0; j < mas[i].Length; j++) mas[i][j] = rnd.Next(-10, 11);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < mas[i].Length; j++) Console.Write(mas[i][j] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Array.Sort(mas[i]);
                Array.Reverse(mas[i]);
            }

            Array.Sort(mas);
            Array.Reverse(mas);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < mas[i].Length; j++) Console.Write(mas[i][j] + " ");
                Console.WriteLine();
            }

        }
        
    }
}
