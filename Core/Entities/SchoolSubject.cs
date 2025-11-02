using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class SchoolSubject
    {
        public SchoolSubject(string name, string abbr, string? description)
        {
            Name = name;
            Abbr = abbr;
            Description = description;
        }

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Abbr { get; set; }
        public string? Description { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
