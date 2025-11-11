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
    /// Reprezentuje známku studenta v určitém předmětu
    /// </summary>
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

        /// <summary>
        /// Primární klíč
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Hodnota známky
        /// </summary>
        [Required]
        public required int Value { get; set; }

        /// <summary>
        /// Datum zapsání
        /// </summary>
        [Required]
        public required DateTime Date { get; set; }

        /// <summary>
        /// Nepovinná poznámka
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Cizí klíč – ID studenta, kterému známka patří
        /// </summary>
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        /// <summary>
        /// Navigační vlastnost na studenta
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Cizí klíč – ID předmětu, z něhož známka pochází
        /// </summary>
        [ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }

        /// <summary>
        /// Navigační vlastnost na předmět
        /// </summary>
        public SchoolSubject Subject { get; set; }

        [NotMapped]
        public string SubjectName => $"{Subject.Name}";
    }
}
