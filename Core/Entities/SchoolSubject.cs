using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class SchoolSubject
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Abbr { get; set; }
        public string? Description { get; set; }
    }
}
