using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Employe
    {
        public class Department
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private Employee manager;
            public Employee Manager
            {
                get { return manager; }
                set { manager = value; }
            }

            private List<Employee> employees = new List<Employee>();
            public IReadOnlyList<Employee> Employees => employees.AsReadOnly();

            public Department()
            {
                Name = string.Empty;
                Manager = null;
            }

            public Department(string name)
            {
                Name = name;
                Manager = null;
            }

            public void AddEmployee(Employee employee)
            {
                if (!employees.Contains(employee))
                {
                    employees.Add(employee);
                }
            }

            public void RemoveEmployee(Employee employee)
            {
                employees.Remove(employee);
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public class Employee
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private Department department;
            public Department Department
            {
                get { return department; }
                set
                {
                    if (department != value)
                    {
                        department?.RemoveEmployee(this);
                        department = value;
                        department?.AddEmployee(this);
                    }
                }
            }

            public Employee()
            {
                Name = string.Empty;
                Department = null;
            }

            public Employee(string name, Department department)
            {
                Name = name;
                Department = department;
                department.AddEmployee(this);
            }

            public override string ToString()
            {
                if (Department?.Manager == this)
                {
                    return $"{Name} начальник отдела {Department.Name}";
                }
                else
                {
                    return $"{Name} работает в отделе {Department?.Name ?? "не определен"}, начальник которого {Department?.Manager?.Name ?? "не назначен"}";
                }
            }
        }
    }
}