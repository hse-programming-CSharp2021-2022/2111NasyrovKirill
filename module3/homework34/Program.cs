using System;

namespace homework34
{
    public abstract class Creature
    {
        public string Location;
    }
    public class RingIsFoundEventArgs : EventArgs 
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        // Будем передавать только строку
        public String Message { get; set; }
    }

    public class Wizard : Creature
    {
        public string Name { get; private set; }
        //2) событийный делегат
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        //3) событие "Кольцо найдено"
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public Wizard(string s) { Name = s; }
        public Wizard() { }
        // Когда волшебнику кажется, что кольцо найдено, он вызывает этот метод
        public void SomeThisIsChangedInTheAir() 
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }
    
    public class Hobbit : Creature 
    {
        public string Name { get; private set; }
        public Hobbit(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) 
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
            Location = e.Message;
        }
    }
    public class Human : Creature 
    {
        public string Name { get; private set; }
        public Human(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) 
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
            Location = e.Message;
        }
    }

    public class Elf : Creature 
    {
        public string Name { get; private set; }
        public Elf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) 	
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
            Location = e.Message;
        }
    }
    public class Dwarf : Creature 
    {
        public string Name { get; private set; }
        public Dwarf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) 
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
            Location = e.Message;
        }
    }
    class Program 
    {
        static void Main(string[] args) 
        {
            Hobbit hobit =new Hobbit("Фродо");
            Creature[] creatures = new Creature[9];
            creatures[0] = new Wizard("Гендальф");
            creatures[1] = new Hobbit("Фродо");
            creatures[2] = new Hobbit("Сэм");
            creatures[3] = new Hobbit("Пипин");
            creatures[4] = new Hobbit("Мэрри");
            creatures[5] = new Human("Боромир");
            creatures[6] = new Human("Арагорн");
            creatures[7] = new Dwarf("Гимли");
            creatures[8] = new Elf("Леголас");
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Hobbit) creatures[1]).RingIsFoundEventHandler;
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Hobbit) creatures[2]).RingIsFoundEventHandler;
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Hobbit) creatures[3]).RingIsFoundEventHandler;
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Hobbit) creatures[4]).RingIsFoundEventHandler;
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Human) creatures[5]).RingIsFoundEventHandler;
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Human) creatures[6]).RingIsFoundEventHandler;
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Dwarf) creatures[7]).RingIsFoundEventHandler;
            ((Wizard) creatures[0]).RaiseRingIsFoundEvent += ((Elf) creatures[8]).RingIsFoundEventHandler;
            // волшебник оповещает всех 
            ((Wizard) creatures[0]).SomeThisIsChangedInTheAir();
        }
    }
}