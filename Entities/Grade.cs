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
    public class Grade : IEntity
    {
        public Grade() {}

        [SetsRequiredMembers]
        public Grade(int value, DateTime date, string? note, Student student, SchoolSubject subject)
        {
            Value = value;
            Date = date;
            Note = note;
            StudentId = student.Id;
            Student = student;
            SubjectId = subject.Id;
            Subject = subject;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public required int Value { get; set; }

        [Required]
        public required DateTime Date { get; set; }
        public string? Note { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }
        public SchoolSubject Subject { get; set; }

        [NotMapped]
        public string SubjectName => $"{Subject.Name}";
    }
}
