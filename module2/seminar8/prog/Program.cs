using System;
using System.Collections.Generic;

namespace prog
{
    abstract class Person
    {
        private string name;
        private string pocket;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Pocket
        {
            get
            {
                return pocket;
            }
            set
            {
                pocket = value;
            }
        }

        public Person(string name) => Name = name;

        public abstract void Receive(string present);

        public override string ToString() => $"{Name} получил подарок {Pocket}";
    }

    class SnowMaiden : Person
    {
        Random rnd = new();
        public SnowMaiden(string name) : base(name) { }

        public string[] CreatePresents(int amount)
        {
            string[] presents = new string[amount];
            for (int i = 0; i < amount; i++)
            {
                string leftright = ((char)rnd.Next('a', 'z' + 1)).ToString();
                string second = ((char)rnd.Next('a', 'z' + 1)).ToString();
                string mid = ((char)rnd.Next('a', 'z' + 1)).ToString();
                presents[i] = leftright + second + mid + second + leftright;
            }
            return presents;
        }

        public override void Receive(string present)
        {
            if (Pocket != null) throw new ArgumentException("Снегурочка хотела получить второй подарок");
            Pocket = present;
        }
    }

    class Santa : Person
    {
        Random rnd = new();
        private List<string> sack;

        public Santa(string name) : base(name) { }

        public void Request(SnowMaiden snowMaiden, int amount) => sack = new(snowMaiden.CreatePresents(amount));

        public void Give(Person person)
        {
            if (sack.Count == 0) throw new Exception("пусто");
            int index = rnd.Next(sack.Count);
            person.Receive(sack[index]);
            sack.RemoveAt(index);
        }

        public override void Receive(string present)
        {
            if (Pocket != null) throw new ArgumentException("Санта хотел получить второй подарок");
            Pocket = present;
        }
    }

    class Child : Person
    {
        private string secondPocket;

        public Child(string name) : base(name) { }

        public override void Receive(string present)
        {
            if (Pocket == null) Pocket = present;
            else if (secondPocket == null) secondPocket = present;
            else throw new ArgumentException($"{Name} хотел получить третий подарок");
        }

        public override string ToString()
        {
            if (secondPocket == null) return $"{Name} получил подарок {Pocket}";
            return $"{Name} получил подарок {secondPocket}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            Santa santa = new("Санта");
            SnowMaiden snowMaiden = new("Снегурочка");
            List<Person> people = new() { };
            people.Add(santa);
            people.Add(snowMaiden);
            people.Add(new Child("Ребёнок1"));
            people.Add(new Child("Ребёнок2"));
            people.Add(new Child("Ребёнок3"));
            people.Add(new Child("Ребёнок4"));
            people.Add(new Child("Ребёнок5"));
            people.Add(new Child("Ребёнок6"));
            people.Add(new Child("Ребёнок7"));
            people.Add(new Child("Ребёнок8"));
            people.Add(new Child("Ребёнок9"));
            people.Add(new Child("Ребёнок10"));
            santa.Request(snowMaiden, rnd.Next(1, 5));
            int i = 0;
            bool b = true;
            while (people.Count != 1)
            {
                try
                {

                    i = rnd.Next(people.Count);
                    santa.Give(people[i]);
                    Console.WriteLine(people[i]);
                    if (b) santa.Request(snowMaiden, rnd.Next(1, 5));

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    if (e.Message == "Снегурочка хотела получить второй подарок") b = false;
                    else if (e.Message == "Санта хотел получить второй подарок") return;
                    people.RemoveAt(i);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            Console.WriteLine("Остался только Санта!");
        }
    }
}