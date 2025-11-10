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
    public class SchoolSubjectService : BaseService<SchoolSubject>
    {
        public SchoolSubjectService(AppDbContext context) : base(context) {}
    }
}
