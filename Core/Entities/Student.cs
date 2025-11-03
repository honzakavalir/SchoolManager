using SchoolManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
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

        [Key]
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required]
        public required DateTime BirthDate { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [NotMapped]
        public double GradeAverage => Grades.Select(g => g.Value).DefaultIfEmpty(0).Average();

        [NotMapped]
        public double GradeCount => Grades.Select(g => g.Value).Count();

        [NotMapped]
        public Grade? LastGrade => Grades.OrderByDescending(g => g.Date).FirstOrDefault();

        [NotMapped]
        public DateTime? LastGradeDate => LastGrade?.Date;

        [NotMapped]
        public int? LastGradeValue => LastGrade?.Value;


        public List<Grade> Grades { get; set; } = new List<Grade>();

    }
}
