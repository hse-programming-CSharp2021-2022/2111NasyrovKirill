using System;
using System.Text;
using static System.Console;
namespace prog8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Let it be; All you need is love; Dizzy Miss Lizzy";
            string[] mas = str.Split(' ');
            StringBuilder[] strmas = new StringBuilder[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                strmas[i] = new StringBuilder();
                int j = 0;
                strmas[i].Append(char.ToUpper(mas[i][j]));
                while (!"AEIOUYaeiouy".Contains(mas[i][j]))
                {
                    strmas[i].Append(mas[i][j + 1]);
                    j++;
                }
                WriteLine(strmas[i]);
            }
        }
    }
}