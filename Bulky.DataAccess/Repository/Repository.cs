using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        internal DbSet<T> dbset;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbset = _db.Set<T>();
            //_db.Categories = dbset
        }
        public void Add(T entity)
        {
            // Implementation for adding an entity to the database
            dbset.Add(entity);
            //_db.SaveChanges(); // Save changes to the database
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            // Implementation for retrieving an entity based on a filter
            IQueryable<T> query = dbset;
            query = query.Where(filter);
            return query.FirstOrDefault(); // Return the first matching entity or null if none found
        }

        public IEnumerable<T> GetAll()
        {
            // Implementation for retrieving all entities, optionally filtered
            IQueryable<T> query = dbset;
            return query.ToList(); // Return all entities as a list
        }

        public void Remove(T entity)
        {
            // Implementation for removing an entity from the database
            dbset.Remove(entity);
            //_db.SaveChanges(); // Save changes to the database
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            // Implementation for removing a range of entities from the database
            dbset.RemoveRange(entity);
        }
    }
}
