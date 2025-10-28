using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab2.Employe;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите задание для выполнения:");
                Console.WriteLine("1 - Задание 1.3 (Имена)");
                Console.WriteLine("2 - Задание 1.2 (Человек)");
                Console.WriteLine("3 - Задание 2.4 (Сотрудники и отделы)");
                Console.WriteLine("4 - Задание 3.4 (Сотрудники с списком отдела)");
                Console.WriteLine("5 - Задание 4.5 (Имена с разными конструкторами)");
                Console.WriteLine("6 - Задание 5.1 (Пистолет)");
                Console.WriteLine("0 - Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1_2();
                        break;
                    case "2":
                        Task1_3();
                        break;
                    case "3":
                        Task2_4();
                        break;
                    case "4":
                        Task3_4();
                        break;
                    case "5":
                        Task4_5();
                        break;
                    case "6":
                        Task5_1();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Task1_3()
        {
            var name1 = new Name("Клеопатра", null, null);
            Console.WriteLine(name1);

            var name2 = new Name("Александр", "Пушкин", "Сергеевич");
            Console.WriteLine(name2);

            var name3 = new Name("Владимир", "Маяковский", null);
            Console.WriteLine(name3);
        }

        static void Task1_2()
        {
            Person person1 = new Person("Клеопатра", 152);
            Person person2 = new Person("Пушкин", 167);
            Person person3 = new Person("Владимир", 189);

            person1.Print();
            person2.Print();
            person3.Print();
        }

        static void Task2_4()
        {
            Department itDepartment = new Department("IT");

            Employee petrov = new Employee("Петров", itDepartment);
            Employee kozlov = new Employee("Козлов", itDepartment);
            Employee sidorov = new Employee("Сидоров", itDepartment);

            itDepartment.Manager = kozlov;

            Console.WriteLine(petrov.ToString());
            Console.WriteLine(kozlov.ToString());
            Console.WriteLine(sidorov.ToString());
        }

        static void Task3_4()
        {
            Department itDepartment = new Department("IT");

            Employee petrov = new Employee("Петров", itDepartment);
            Employee kozlov = new Employee("Козлов", itDepartment);
            Employee sidorov = new Employee("Сидоров", itDepartment);

            itDepartment.Manager = kozlov;

            Console.WriteLine("Все сотрудники отдела IT:");
            foreach (var employee in itDepartment.Employees)
            {
                Console.WriteLine($"- {employee.Name}");
            }

            Console.WriteLine("\nИнформация о сотрудниках:");
            Console.WriteLine(petrov.ToString());
            Console.WriteLine(kozlov.ToString());
            Console.WriteLine(sidorov.ToString());
        }

        static void Task4_5()
        {
            Name name1 = new Name("Клеопатра");
            Console.WriteLine(name1);

            Name name2 = new Name("Александр", "Пушкин");
            Console.WriteLine(name2);

            Name name3 = new Name("Владимир", "Маяковский", null);
            Console.WriteLine(name3);

            Name name4 = new Name("Христофор", "Бонифатьевич");
            Console.WriteLine(name4);
        }

        static void Task5_1()
        {
            Pistol pistol = new Pistol(3);

            Console.WriteLine("Стреляем 5 раз из пистолета с 3 патронами:");
            for (int i = 0; i < 5; i++)
            {
                pistol.Shoot();
            }
        }
    }
}