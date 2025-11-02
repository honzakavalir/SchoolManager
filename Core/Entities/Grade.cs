using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Entities
{
    public class Grade
    {
        public Grade() {}

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

        public required int Value { get; set; }
        public required DateTime Date { get; set; }
        public string? Note { get; set; }
        public int StudentId { get; set; }
        public required Student Student { get; set; }
        public int SubjectId { get; set; }
        public required SchoolSubject Subject { get; set; }
    }
}
