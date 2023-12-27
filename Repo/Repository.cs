using DataBase;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repo
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
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

        public T GetEntity(int id, Expression<Func<T, object>> include)
        {
            var entity =  dbSet.Find(id);

            if (entity != null)
            _context.Entry(entity).Reference(include).Load();

            return entity;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<T> GetByCondition(Func<T, bool> predicate)
        {
            return dbSet.Where(predicate);
        }

        public T GetEntityByCondition(Func<T, bool> predicate, Expression<Func<T, object>> include)
        {
            var entity = dbSet.FirstOrDefault(predicate);
            if (entity != null)
                _context.Entry(entity).Reference(include).Load();

            return entity;
        }

        public void UpdateEntity(T entity)
        {
        }





    }
}
