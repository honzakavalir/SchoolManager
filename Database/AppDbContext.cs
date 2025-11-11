using Microsoft.EntityFrameworkCore;
using SchoolManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Database
{
    /// <summary>
    /// Hlavní databázový kontext aplikace — spravuje připojení k SQLite databázi
    /// a definuje entity (tabulky) pro studenty, předměty a známky.
    /// </summary>
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet<Grade> Grades { get; set; }

        /// <summary>
        /// Cesta k SQLite databázovému souboru.
        /// </summary>
        public string DbFilePath { get; }

        public AppDbContext()
        {
            // Databáze je uložená v adresáři aplikace (SchoolManager.db)
            DbFilePath = Path.Combine(AppContext.BaseDirectory, "SchoolManager.db");
        }

        /// <summary>
        /// Nastavení připojení k databázi – používá SQLite s určenou cestou k souboru.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbFilePath}");

        /// <summary>
        /// Definice relací mezi entitami a automatické načítání navigací.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relace: Student 1—N Grade
            // Jeden Student může mít více známek
            // Při smazání studenta se smažou i jeho známky
            modelBuilder.Entity<Grade>()
                .HasOne(grade => grade.Student)
                .WithMany(student => student.Grades)
                .HasForeignKey(grade => grade.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relace: SchoolSubject 1—N Grade
            // Jeden předmět může mít více známek
            // Při smazání předmětu se smažou i jeho známky
            modelBuilder.Entity<Grade>()
                .HasOne(grade => grade.Subject)
                .WithMany(student => student.Grades)
                .HasForeignKey(grade => grade.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Při načtení studenta se automaticky načtou jeho známky
            modelBuilder.Entity<Student>()
                .Navigation(student => student.Grades)
                .AutoInclude();

            // Při načtení předmětu se automaticky načtou jeho známky
            modelBuilder.Entity<SchoolSubject>()
                .Navigation(subject => subject.Grades)
                .AutoInclude();

            // Při načtení známky se automaticky načte její předmět
            modelBuilder.Entity<Grade>()
                .Navigation(grade => grade.Subject)
                .AutoInclude();
        }
    }
}
