using DAL.AbstractRepositories;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DAL.ConcreteRepositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();

        }
        public async Task AddAsync(T entity)
        {
            if (entity != null)
            {
                await _entities.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddRangeAsync(IEnumerable<T> entity)
        {
            if (entity != null)
            {
                await _entities.AddRangeAsync(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            if (entity != null)
            {
                entity.DeletedDate = DateTime.Now;
                _entities.Update(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _entities.Where(x => !x.IsDeleted).ToListAsync();

            return entities;
        }

        public IQueryable<T> GetAllWithIncludes(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _entities;

            foreach (var item in includes)
            {
                query = query.Include(item);
            }

            return query;
        }
        public async Task UpdateViewCount(int menuId)
        {
            var menu = await _context.Menus.FindAsync(menuId);
            menu.ViewCount++;
            menu.ModifiedDate = DateTime.Now;
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _entities.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return result;

        }

        public async Task RemoveAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }
        
        //public IQueryable<T> GetAllWithIncludesThenIncludes(
        //   Expression<Func<T, object>>[] includes,
        //   params Expression<Func<object, object>>[] thenIncludes)
        //{
        //    IQueryable<T> query = _entities;

        //    if (includes != null)
        //    {
        //        foreach (var include in includes)
        //        {
        //            var includableQuery = query.Include(include);

        //            if (thenIncludes != null)
        //            {
        //                foreach (var thenInclude in thenIncludes)
        //                {
        //                    includableQuery = includableQuery.ThenInclude(thenInclude);
        //                }
        //            }

        //            query = (IQueryable<T>)includableQuery;
        //        }
        //    }

        //    return query;
        //}
        public async Task UpdateAsync(T entity)
        {
            if (entity != null)
            {
                entity.ModifiedDate = DateTime.Now;
                _entities.Update(entity);
                await _context.SaveChangesAsync();
            }

        }
    }
}
