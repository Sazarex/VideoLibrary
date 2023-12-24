using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public abstract class Repository<T> : IRepository<T> where T : class, IEntity
    {

        private readonly DbContext _context;
        private DbSet<T> dbSet { get; set; }







        public Repository(DbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public void CreateEntity(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            T entity = dbSet.Find(id);
            if (entity != null)
                dbSet.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public T GetEntity(int id)
        {
            return dbSet.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<T> GetByCondition(Func<T,bool> predicate)
        {
            return dbSet.Where(predicate);
        }

        public void UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }






    }
}
