using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AbstractRepositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task RemoveAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAllWithIncludes(params Expression<Func<T, object>>[] includes);
        Task UpdateViewCount(int menuId);
        Task SaveChangesAsync();


    }
}
