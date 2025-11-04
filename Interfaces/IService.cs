using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Interfaces
{
    public interface IService<T> where T : class, IEntity
    {
        Task<List<T>> FindAll();

        Task<T?> FindOne(int id);

        Task<T> Create(T entity);

        Task<T?> Update(int id, T entity);

        Task<bool> Delete(int id);
    }
}
