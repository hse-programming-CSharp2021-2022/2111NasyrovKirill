using System;

namespace prog5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[100];
            Random rnd = new Random();
            int value = rnd.Next(1, 100);
            int valuebad = rnd.Next(1, 100);
            while (value == valuebad) valuebad = rnd.Next(1, 100);

            for (int i = 0; i < 100; i++) list[i] = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i == value)
                {
                    int index = rnd.Next(0, 99);
                    if (list[index] == 0) list[index] = i;
                    else
                    {
                        while (list[index] != 0) index = rnd.Next(0, 99);
                        list[index] = i;
                    }

                    index = rnd.Next(0, 99);
                    if (list[index] == 0) list[index] = i;
                    else
                    {
                        while (list[index] != 0) index = rnd.Next(0, 99);
                        list[index] = i;
                    }
                }
                else if (i != valuebad)
                {
                    int index = rnd.Next(0, 99);
                    if (list[index] == 0) list[index] = i;
                    else
                    {
                        while (list[index] != 0) index = rnd.Next(0, list.Length);
                        list[index] = i;
                    }
                }
            }
            for (int i = 0; i < 100; i++) Console.Write(list[i] + " ");

            int[] list2 = new int[100];
            for (int i = 0; i < 100; i++) list2[i] = 0;
            for (int i = 0; i < 100; i++)
            {
                list2[list[i] - 1] += 1;
            }
            for (int i = 0; i < 100; i++)
            {
                if (list2[i] == 2)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}