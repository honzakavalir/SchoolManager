using SchoolManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class SchoolSubject : IEntity
    {
        public SchoolSubject() {}

        [SetsRequiredMembers]
        public SchoolSubject(string name, string abbr, string? description)
        {
            Name = name;
            Abbr = abbr;
            Description = description;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Abbr { get; set; }

        public string? Description { get; set; }

        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
