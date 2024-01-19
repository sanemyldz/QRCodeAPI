using DAL.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        public readonly DEVELOP_MEYERContext _dataContext;
        public readonly DbSet<T> _dbSet;
        public GenericRepository(DEVELOP_MEYERContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = dataContext.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> GetByIdAsync(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }
        public async Task<List<T>> GetAllRelatedAsync(Expression<Func<T, object>> includeProperty)
        {
            var result = await _dbSet.Include(includeProperty).ToListAsync();
            return result;
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(string Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
            _dataContext.SaveChanges();
        }
        public void RemoveRange(IEnumerable<T> entity)
        {
            _dbSet.RemoveRange(entity);
            _dataContext.SaveChanges();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            //_dataContext.Entry(entity).State = EntityState.Detached;
            _dbSet.Update(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            _dataContext.SaveChanges();
            return entity;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>>? predicate = null,
         Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            IQueryable<T> query = _dbSet;

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null) query = orderBy(query);

            if (include != null) query = include(query);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                 ? await _dataContext.Set<T>().ToListAsync()
                 : await _dataContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
         Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _dbSet;

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null) query = orderBy(query);

            if (include != null) query = include(query);

            return await query.ToListAsync();
        }
    }
}
