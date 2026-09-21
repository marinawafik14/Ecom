using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecom.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        Task AddAsync(T entity);
        Task DeleteAsync (int id);
        Task UpdateAsync (T entity);
        Task<IReadOnlyList<T>> GetAllAsync ();
        Task<IReadOnlyList<T>> GetAllAsync(params Expression <Func<T, object>>[] includes);
        Task<T> GetByIdAsync(int id);

        Task<T> GetByIdAsync(int id, params Expression <Func<T, object>>[] includes);


    }
}
