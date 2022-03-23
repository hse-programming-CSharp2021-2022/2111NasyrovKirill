using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace homework_3_12
{
    
    public class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
    }
    
    public class Professor : Human
    {
        public Professor(string name) : base(name){}
    }
    
    public class Department
    {
        public string Name { get; set; }
        public List<Human> Humans { get; set; }

        public Department(List<Human> humans, string name)
        {
            Name = name;
            Humans = humans;
        }
    }
    
    public class University
    {
        public string Name { get; set; }
        public  List<Department> Departments { get; set; }

        public University(List<Department> departments, string name)
        {
            Name = name;
            Departments = departments;
        }
    }
    
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Human> people = new List<Human>()
            {
                new Human("Ivan"),
                new Human("Nikolay"),
                new Human("Dmitriy"),
                new Human("Katya"),
                new Human("Julia"),
                new Human("Oleg")
            };

            Department d1 = new Department(people, "d1");
            Department d2 = new Department(people, "d2");
            List<Department> list = new List<Department>() {d1, d2};
            
            University u1 = new University(list, "u1");
            University u2 = new University(list, "u2");
            List<University> list2 = new List<University>() {u1, u2};
            
            using (var fs = new FileStream("file.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, list2);
                Console.WriteLine("Объект сериализован");
            }
            
            using (var fs = new FileStream("file.json", FileMode.OpenOrCreate))
            {
                var obj = await JsonSerializer.DeserializeAsync<List<University>>(fs);
                Console.WriteLine("Объект десериализован");
            }
        }

        
    }
}
