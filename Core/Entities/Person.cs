using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public abstract class Person
    {
        protected Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName => $"{FirstName} ${LastName}";

        
    }
}
