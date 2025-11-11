using Microsoft.EntityFrameworkCore;
using SchoolManager.Base;
using SchoolManager.Database;
using SchoolManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Services
{
    /// <summary>
    /// Třída pro práci s entitami <see cref="Grade"/>.
    /// </summary>
    /// <remarks>
    /// Dědí z <see cref="BaseService{T}"/>, takže poskytuje základní CRUD operace
    /// a zároveň přidává metody specifické pro známky.
    /// </remarks>
    public class GradeService : BaseService<Grade>
    {
        public GradeService(AppDbContext context) : base(context) {}

        /// <summary>
        /// Vrátí všechny známky daného studenta, seřazené od nejnovějších po nejstarší.
        /// </summary>
        /// <param name="studentId">ID studenta, jehož známky se mají načíst.</param>
        /// <returns>Seznam známek studenta.</returns>
        public async Task<List<Grade>> FindByStudent(int studentId)
        {
            return await _dbSet
                .Where(grade => grade.StudentId == studentId)
                .OrderByDescending(grade => grade.Date)
                .ToListAsync();
        }
    }
}
