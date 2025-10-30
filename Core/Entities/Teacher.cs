using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class Teacher : Person
    {
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public List<SchoolSubject> TaughtSubjects { get; set; } = new List<SchoolSubject>();
    }
}
