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
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }

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

            // Ignorování vlastnosti FullName (je jen pro čtení, nezapisuje se do DB)
            modelBuilder.Entity<Person>()
                .Ignore(p => p.FullName);

            // Student - SchoolClass (1:N)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.SchoolClass)
                .WithMany(c => c.Students)
                .HasForeignKey("SchoolClassId")
                .OnDelete(DeleteBehavior.Cascade);

            // SchoolClass - Teacher (1:N)
            modelBuilder.Entity<SchoolClass>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.SchoolClasses)
                .HasForeignKey("TeacherId")
                .OnDelete(DeleteBehavior.Restrict);

            // Teacher - SchoolSubject (M:N)
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.TaughtSubjects)
                .WithMany(s => s.Teachers)
                .UsingEntity<Dictionary<string, object>>(
                    "TeacherSubject",
                    ts => ts.HasOne<SchoolSubject>()
                            .WithMany()
                            .HasForeignKey("SchoolSubjectId")
                            .OnDelete(DeleteBehavior.Cascade),
                    ts => ts.HasOne<Teacher>()
                            .WithMany()
                            .HasForeignKey("TeacherId")
                            .OnDelete(DeleteBehavior.Cascade),
                    ts =>
                    {
                        ts.HasKey("TeacherId", "SchoolSubjectId");
                        ts.ToTable("TeacherSubjects");
                    });
        }

    }
}
