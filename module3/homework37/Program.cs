using System;

namespace homework37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количество человек: ");
            int n =int.Parse(Console.ReadLine());
            Person[] arr = new Person[n];
            for (int i = 0; i < n; i++) 
            {
                arr[i]=new Person(GetRandomName(), GetRandomName(), rand.Next(1, 100));
            }
            foreach (Person p in arr) Console.WriteLine(p);
            Console.WriteLine("----сортировка----");
            Array.Sort(arr);
            foreach (Person p in arr) Console.WriteLine(p);
        }

        public static string GetRandomName()
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Random rand = new Random();

            string word = "";
            for (int j = 1; j <= 5; j++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                word += letters[letter_num];
            }
            return word;
        }
    }


    public struct Person:IComparable<Person>
    {
        private string name;
        private string lastname;
        private int age;
        public Person(string name, string lastname, int age)
        {
            if (age < 0) throw new ArgumentOutOfRangeException("Отрицательный возраст");
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            return age.CompareTo(other.age);
        }
        public override string ToString()
        {
            return $"Имя - {name}, фамилия - {lastname}, возраст - {age}";
        }

        
    }
}
