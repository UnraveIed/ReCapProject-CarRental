using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null 
                ? await _context.Set<TEntity>().CountAsync()
                : await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _context.Set<TEntity>().Remove(entity);
            });
        }

        public async Task<TEntity> GetAsync(IList<Expression<Func<TEntity, bool>>> predicates, IList<Expression<Func<TEntity, object>>> includes = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicates != null && predicates.Any())
            {
                foreach (var predicate in predicates)
                {
                    query = query.Where(predicate);
                }
            }
            if (includes != null && includes.Any())
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.AsNoTracking().SingleOrDefaultAsync();
        }
        

        public async Task<IList<TEntity>> GetAllAsync(IList<Expression<Func<TEntity, bool>>> predicates = null, IList<Expression<Func<TEntity, object>>> includes = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicates != null && predicates.Any())
            {
                foreach (var predicate in predicates)
                {
                    query = query.Where(predicate);
                }
            }
            if (includes != null && includes.Any())
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public IQueryable<TEntity> GetAsQueryable()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _context.Set<TEntity>().Update(entity);
            });
            return entity;
        }
    }
}
