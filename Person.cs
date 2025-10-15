using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public Person()
        {
            Name = "Undefined";
            Height = 0;
        }
        public Person(string name, int height)
        {
            Name = name;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine($"Человек с именем {Name} и ростом {Height}");
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Рост: {Height}";
        }
    }
}
