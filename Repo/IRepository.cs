using Domain.Interfaces;

namespace Repo
{
    public interface IRepository<T>: IDisposable
        where T: IEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByCondition(Func<T, bool> predicate);
        T GetEntity(int id);
        void CreateEntity(T entity);
        void UpdateEntity(T entity);
        void Delete(int id);
        void Save();
    }
}
