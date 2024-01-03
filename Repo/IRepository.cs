using Domain.Interfaces;
using System.Linq.Expressions;

namespace Repo
{
    public interface IRepository<T>
        where T : IEntity
    {
        public T GetEntity(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> include = null);
        public T GetEntity(int id, Expression<Func<T, object>> include = null);

        public IQueryable<T> GetEntities(Expression<Func<T, bool>> predicate);

        public Task<bool> CreateEntity(T entity);

        public Task<bool> DeleteEntity(T entity);

        public Task<T> CreateOrUpdate(T entity);
    }
}
