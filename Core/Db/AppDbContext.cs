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
            DbFilePath = Path.Combine(AppContext.BaseDirectory, "school.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbFilePath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasMany(teacher => teacher.TaughtSubjects)
                .WithMany();

            modelBuilder.Entity<SchoolClass>()
                .HasMany(schoolClass => schoolClass.Students)
                .WithOne(student => student.SchoolClass)
                .IsRequired();

            modelBuilder.Entity<SchoolClass>()
                .HasOne(schoolClass => schoolClass.Teacher)
                .WithMany()
                .IsRequired();
        }
    }
}
