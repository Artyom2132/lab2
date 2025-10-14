using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Name
    {
        public string? FirstName { get; }
        public string? LastName { get; }
        public string? MidleName { get; }

        public Name(string? firstName, string? lastName, string? midleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MidleName = midleName;
        }

        public override string ToString()
        {
            var parts = new[] {LastName, FirstName, MidleName}
            .Where(part => !string.IsNullOrEmpty(part))
            .ToArray();
            return string.Join(" ", parts);   
        }

        public bool IsEmpty => string.IsNullOrWhiteSpace(FirstName) &&
            string.IsNullOrWhiteSpace(LastName) &&
            string.IsNullOrWhiteSpace(MidleName);
    }
}
