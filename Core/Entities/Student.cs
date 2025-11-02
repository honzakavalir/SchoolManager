using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, DateTime birthDate, SchoolClass schoolClass) : base(firstName, lastName, birthDate)
        {
            SchoolClass = schoolClass;
        }

        public required SchoolClass SchoolClass { get; set; }
    }
}
