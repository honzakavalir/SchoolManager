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
    /// Třída pro práci s entitami <see cref="SchoolSubject"/>.
    /// </summary>
    /// <remarks>
    /// Dědí z <see cref="BaseService{T}"/>, takže poskytuje základní CRUD operace
    /// a zároveň přidává metody specifické pro předměty.
    /// </remarks>
    public class SchoolSubjectService : BaseService<SchoolSubject>
    {
        public SchoolSubjectService(AppDbContext context) : base(context) {}

        /// <summary>
        /// Najde školní předmět podle jeho zkratky (Abbr).
        /// </summary>
        /// <param name="abbr">Zkratka školního předmětu.</param>
        /// <returns>Předmět s danou zkratkou nebo null, pokud neexistuje.</returns>
        public async Task<SchoolSubject?> FindByAbbr(string abbr)
        {
            return await _dbSet.Where(subject => subject.Abbr == abbr).FirstOrDefaultAsync();
        }
    }
}
