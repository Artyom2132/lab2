using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Name
    {
        private string firstName;
        private string lastName;
        private string middleName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }


        public Name(string firstName)
        {
            FirstName = firstName;
            LastName = null;
            MiddleName = null;
        }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = null;
        }

        public Name(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        // Метод ToString() формирует строковое представление
        // Только непустые части имени объединяются через пробел
        public override string ToString()
        {
            var parts = new[] { LastName, FirstName, MiddleName }
                .Where(part => !string.IsNullOrEmpty(part))
                .ToArray();
            return string.Join(" ", parts);
        }

        // Свойство для проверки, пустое ли имя
        public bool IsEmpty => string.IsNullOrWhiteSpace(FirstName) &&
                              string.IsNullOrWhiteSpace(LastName) &&
                              string.IsNullOrWhiteSpace(MiddleName);
    }
}