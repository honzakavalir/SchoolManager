using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class SchoolSubject
    {
        public SchoolSubject(string name, string abbr, Teacher teacher, string? description)
        {
            Name = name;
            Abbr = abbr;
            Teacher = teacher;
            Description = description;
        }

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Abbr { get; set; }
        public required Teacher Teacher { get; set; }
        public string? Description { get; set; }
    }
}
