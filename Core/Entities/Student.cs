using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class Student : Person
    {
        public required SchoolClass SchoolClass { get; set; }
    }
}
