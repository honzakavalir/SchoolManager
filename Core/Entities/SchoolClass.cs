using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

    }
}
