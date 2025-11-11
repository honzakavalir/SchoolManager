using Microsoft.EntityFrameworkCore;
using SchoolManager.Database;
using SchoolManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Base
{
    /// <summary>
    /// Základní generická služba pro CRUD operace nad entitami
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseService<T> : IService<T> where T : class, IEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseService(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// Vrátí všechny entity daného typu
        /// </summary>
        public virtual async Task<List<T>> FindAll()
        {
            return await _dbSet.ToListAsync();
        }

        /// <summary>
        /// Najde entitu podle ID
        /// </summary>
        public virtual async Task<T?> FindOne(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(entity => entity.Id == id);
        }

        /// <summary>
        /// Vytvoří novou entitu
        /// </summary>
        public virtual async Task<T> Create(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Upraví entitu podle ID
        /// </summary>
        public virtual async Task<T?> Update(int id, T entity)
        {
            var entityToUpdate = await FindOne(id);
            if (entityToUpdate == null)
            {
                return null;
            }

            _context.Entry(entityToUpdate).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return entityToUpdate;
        }

        /// <summary>
        /// Smaže entitu podle ID
        /// </summary>
        public virtual async Task<bool> Delete(int id)
        {
            var entityToDelete = await FindOne(id);
            if (entityToDelete == null)
            {
                return false;
            }

            _dbSet.Remove(entityToDelete);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
