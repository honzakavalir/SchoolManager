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
    public class GradeService : BaseService<Grade>
    {
        public GradeService(AppDbContext context) : base(context) {}

        public async Task<List<Grade>> FindByStudent(int studentId)
        {
            return await _dbSet
                .Where(grade => grade.StudentId == studentId)
                .Include(g => g.Subject)
                .OrderByDescending(grade => grade.Date)
                .ToListAsync();
        }
    }
}
