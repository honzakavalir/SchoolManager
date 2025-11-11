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
    /// Třída pro práci s entitami <see cref="Student"/>.
    /// </summary>
    /// <remarks>
    /// Dědí z <see cref="BaseService{T}"/>, takže poskytuje všechny základní CRUD operace pro studenty.
    /// </remarks>
    public class StudentService : BaseService<Student>
    {
        public StudentService(AppDbContext context) : base(context) {}
    }
}
