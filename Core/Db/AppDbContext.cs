using Microsoft.EntityFrameworkCore;
using SchoolManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public string DbFilePath { get; }

        public AppDbContext()
        {
            DbFilePath = Path.Combine(AppContext.BaseDirectory, "SchoolManager.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbFilePath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Grade>()
                .HasOne(grade => grade.Student)
                .WithMany(student => student.Grades)
                .HasForeignKey(grade => grade.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Grade>()
                .HasOne(grade => grade.Subject)
                .WithMany(student => student.Grades)
                .HasForeignKey(grade => grade.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>()
                .Navigation(student => student.Grades)
                .AutoInclude();

            modelBuilder.Entity<SchoolSubject>()
                .Navigation(subject => subject.Grades)
                .AutoInclude();
        }
    }
}
