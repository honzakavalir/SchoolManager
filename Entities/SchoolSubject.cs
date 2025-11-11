using SchoolManager.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Entities
{
    /// <summary>
    /// Reprezentuje školní předmět, ze kterého mohou studenti získávat známky
    /// </summary>
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

        /// <summary>
        /// Primární klíč
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Název předmětu
        /// </summary>
        [Required]
        public required string Name { get; set; }

        /// <summary>
        /// Zkratka předmětu
        /// </summary>
        [Required]
        public required string Abbr { get; set; }

        /// <summary>
        /// Nepovinný popis
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Seznam známek patřících k tomuto předmětu
        /// </summary>
        public List<Grade> Grades { get; set; } = new List<Grade>();

        [NotMapped]
        public double GradeAverage => Grades.Select(g => g.Value).DefaultIfEmpty(0).Average();

        [NotMapped]
        public double GradeCount => Grades.Select(g => g.Value).Count();
    }
}
