using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetByIdAsync(string Id);
        Task<T> GetByIdAsync(int Id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        Task<T> UpdateAsync(T entity);
        T Update(T entity);      
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate = null,
                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                    Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

        Task<List<T>> GetListAsync(Expression<Func<T, bool>> predicate = null,
                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                    Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }

};
