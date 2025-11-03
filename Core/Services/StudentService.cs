using Microsoft.EntityFrameworkCore;
using SchoolManager.Core.Db;
using SchoolManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Core.Services
{
    public class StudentService : BaseService<Student>
    {
        public StudentService(AppDbContext context) : base(context) {}
    }
}
