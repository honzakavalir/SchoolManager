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
    /// Reprezentuje studenta školy
    /// </summary>
    public class Student : IEntity
    {
        public Student() {}

        [SetsRequiredMembers]
        public Student(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        /// <summary>
        /// Primární klíč
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Jméno studenta
        /// </summary>
        [Required]
        public required string FirstName { get; set; }

        /// <summary>
        /// Příjmení studenta
        /// </summary>
        [Required]
        public required string LastName { get; set; }

        /// <summary>
        /// Datum narození
        /// </summary>
        [Required]
        public required DateTime BirthDate { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [NotMapped]
        public double GradeAverage => Math.Round(Grades.Select(g => g.Value).DefaultIfEmpty(0).Average(), 2);

        [NotMapped]
        public double GradeCount => Grades.Select(g => g.Value).Count();

        [NotMapped]
        public Grade? LastGrade => Grades.OrderByDescending(g => g.Date).FirstOrDefault();

        [NotMapped]
        public DateTime? LastGradeDate => LastGrade?.Date;

        [NotMapped]
        public int? LastGradeValue => LastGrade?.Value;

        /// <summary>
        /// Seznam známek studenta
        /// </summary>
        public List<Grade> Grades { get; set; } = new List<Grade>();

    }
}
