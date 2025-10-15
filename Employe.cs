using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Employe
    {

// Класс отдела
    public class Department
        {
            public string Name { get; set; }
            public Employee Manager { get; set; }

            public Department() { }

            public Department(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }

    public class Employee
        {
            public string Name { get; set; }
            public Department Department { get; set; }

            public Employee() { }  
            public Employee(string name, Department department)
            {
                Name = name;
                Department = department;
            }

            public override string ToString()
            {
                // Если сотрудник является начальником отдела
                if (Department.Manager == this)
                {
                    return $"{Name} начальник отдела {Department.Name}";
                }
                else
                {
                    return $"{Name} работает в отделе {Department.Name}, начальник которого {Department.Manager?.Name ?? "не назначен"}";
                }
            }

           
        }

    }
}
