using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repo
{
    public abstract class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly DbContext _context;
        private DbSet<T> dbSet { get; set; }

        public Repository(DbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public T GetEntity(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> include = null)
        {
            var entity = dbSet.FirstOrDefault(predicate);
            if (include != null)
                _context.Entry(entity).Reference(include).Load();
            return entity;
        }

        public T GetEntity(int id, Expression<Func<T, object>> include = null)
        {
            var entity = dbSet.FirstOrDefault(i => i.Id == id);
            if (include != null)
                _context.Entry(entity).Reference(include).Load();
            return entity;
        }

        public IQueryable<T> GetEntities(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public async Task<bool>  CreateEntity(T entity)
        {
            if (entity is IEntityState entityWithState)
                SetActiveState(entityWithState);

            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteEntity(T entity)
        {
            if (entity is IEntityState entityWithState)
                SetDeletedState(entityWithState);

            dbSet.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<T> CreateOrUpdate(T entity)
        {
            if (entity.Id != 0 && entity is IDateInfo dateInfoEntity)
                Update(dateInfoEntity);

            dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        private void SetActiveState(IEntityState entity)
        {
            entity.EntityState = Domain.BaseTypes.EntityState.Active;
        }

        private void SetDeletedState(IEntityState entity)
        {
            entity.EntityState = Domain.BaseTypes.EntityState.Deleted;
        }
        private void Update(IDateInfo entity)
        {
            entity.UpdateDate = DateTime.UtcNow;
        }

    }
}
