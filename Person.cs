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
        public string name = "Undefined";
        public int height = 0;
        public void Print()
        {
            Console.WriteLine($"Человек с именем {name} и ростом {height}");
        }
    }
}
