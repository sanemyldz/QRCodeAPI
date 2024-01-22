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
    }
}
